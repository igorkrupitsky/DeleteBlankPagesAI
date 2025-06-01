Imports System.IO
Imports System.Net

Public Class frmMain

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim oAppRegistry As New AppSetting

		cbFileType.SelectedIndex = oAppRegistry.GetValueDef("FileType", "0")
		cbAction.SelectedIndex = oAppRegistry.GetValueDef("Action", "0")
		txtFrom.Text = oAppRegistry.GetValue("From")
		chkSubfolders.Checked = oAppRegistry.GetValue("Subfolders") = "1"
		chkResize.Checked = oAppRegistry.GetValue("Resize") = "1"
		txtApiKey.Text = oAppRegistry.GetValue("ApiKey")
		txtPrompt.Text = oAppRegistry.GetValueDef("Prompt", "What is it probability from 0 to 100 that this image is a blanked page. Do not provide any comments. ")
		txtTargetProbability.Text = oAppRegistry.GetValueDef("TargetProbability", "100")
		txtResizePx.Text = oAppRegistry.GetValueDef("ResizePx", "300")

	End Sub

	Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim oAppRegistry As New AppSetting

		oAppRegistry.SetValue("From", txtFrom.Text)
		oAppRegistry.SetValue("FileType", cbFileType.SelectedIndex)
		oAppRegistry.SetValue("Action", cbAction.SelectedIndex)
		oAppRegistry.SetValue("Subfolders", IIf(chkSubfolders.Checked, 1, 0))
		oAppRegistry.SetValue("Resize", IIf(chkResize.Checked, 1, 0))
		oAppRegistry.SetValue("ApiKey", txtApiKey.Text)
		oAppRegistry.SetValue("Prompt", txtPrompt.Text)
		oAppRegistry.SetValue("TargetProbability", txtTargetProbability.Text)
		oAppRegistry.SetValue("ResizePx", txtResizePx.Text)
		oAppRegistry.SaveData()
	End Sub


	Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

		Dim sFromPath As String = txtFrom.Text
		If Not System.IO.Directory.Exists(sFromPath) Then
			MsgBox("Folder does not exist")
			Exit Sub
		End If

		btnProcess.Enabled = False
		txtOutput.Text = ""
		txtOutput.Text += "Starting..." & vbCrLf
		ProccessFolder(sFromPath)
		txtOutput.Text += "Done!"
		btnProcess.Enabled = True

	End Sub

	Sub ProccessFolder(ByVal sFolderPath As String)

		Dim sFileType As String = cbFileType.SelectedItem
		Dim sAction As String = cbAction.SelectedItem
		Dim oFiles As String() = Directory.GetFiles(sFolderPath)
		ProgressBar1.Maximum = oFiles.Length

		For i As Integer = 0 To oFiles.Length - 1
			Dim sFromFilePath As String = oFiles(i)
			Dim oFileInfo As New FileInfo(sFromFilePath)
			Dim sExt As String = Path.GetExtension(sFromFilePath)
			If (sFileType = "All" And (sExt = ".jpg" Or sExt = ".jpeg" Or sExt = ".gif" Or sExt = ".bmp" Or sExt = ".tiff" Or sExt = ".tif" Or sExt = ".webp")) _
				OrElse sExt = sFileType Then

				'Try
				Dim dTime As DateTime = DateTime.Now
				Dim sQuestion As String = txtPrompt.Text
				Dim iTargetProbability As Integer = txtTargetProbability.Text
				Dim iActualProbability As Integer = 0

				Dim sRet As String = ""

				If chkResize.Checked Then
					Dim sResizeFilePath As String = ResizeImage(sFromFilePath)
					sRet = SendOpenAiMsg(sResizeFilePath, sQuestion)
					IO.File.Delete(sResizeFilePath)
				Else
					sRet = SendOpenAiMsg(sFromFilePath, sQuestion)
				End If

				Dim iSecondsToReadFile As Integer = (DateTime.Now).Subtract(dTime).TotalSeconds()

				If Integer.TryParse(sRet, iActualProbability) Then
					txtOutput.Text += sFromFilePath & vbTab & " has " & iActualProbability & "% probability of being a blank page. File was read in " & iSecondsToReadFile & " seconds." & vbCrLf
				Else
					txtOutput.Text += sFromFilePath & vbTab & " did not return a number but this text instead: " & sRet & ". File was read in " & iSecondsToReadFile & " seconds." & vbCrLf
				End If


				If iActualProbability >= iTargetProbability Then
					'Found white page

					Select Case sAction
						Case "Delete blank images"
							oFileInfo.Delete()

						Case "Add _deleted to the filename of a blank image"
							Dim sNewFileName As String = IO.Path.GetFileNameWithoutExtension(sFromFilePath) & "_deleted" & sExt
							Dim sNewFilePath As String = sFolderPath & "\" & sNewFileName

							If IO.File.Exists(sNewFilePath) Then
								txtOutput.Text += "File " & oFileInfo.Name & " cannot be renamed to " & sNewFileName & " because file with this name already exists." & vbCrLf
							Else
								oFileInfo.MoveTo(sNewFilePath)
							End If

						Case "Place blank images to to_be_deleted folder"
							Dim sTempFolderPath As String = sFolderPath & "\to_be_deleted"

							If IO.Directory.Exists(sTempFolderPath) = False Then
								IO.Directory.CreateDirectory(sTempFolderPath)
							End If

							If IO.File.Exists(sTempFolderPath & "\" & oFileInfo.Name) Then
								txtOutput.Text += "File " & oFileInfo.Name & " cannot be moved to " & sTempFolderPath & " because file with this name already exists there." & vbCrLf
							Else
								oFileInfo.MoveTo(sTempFolderPath & "\" & oFileInfo.Name)
							End If
					End Select

				End If
				'Catch ex As Exception
				'	txtOutput.Text += sFromFilePath & vbTab & ex.Message & vbCrLf
				'End Try
			End If

			ProgressBar1.Value = i
		Next

		ProgressBar1.Value = 0

		If chkSubfolders.Checked Then
			Dim oFolders As String() = Directory.GetDirectories(sFolderPath)
			For i As Integer = 0 To oFolders.Length - 1
				Dim sChildFolder As String = oFolders(i)
				Dim iPos As Integer = sChildFolder.LastIndexOf("\")
				Dim sFolderName As String = sChildFolder.Substring(iPos + 1)
				If sFolderName <> "to_be_deleted" Then
					ProccessFolder(sChildFolder)
				End If
			Next
		End If

	End Sub

	Function ResizeImage(ByVal sFilePath As String)

		Dim directory As String = Path.GetDirectoryName(sFilePath)
		Dim oGuid As Guid = Guid.NewGuid()
		Dim sGuid As String = Replace(Replace(oGuid.ToString(), "{", ""), "}", "")
		Dim sOutputPath As String = Path.Combine(directory, sGuid & ".png")
		Dim iWidth As Integer = txtResizePx.Text

		Return ResizeImage(sFilePath, sOutputPath, iWidth)
	End Function

	Function ResizeImage(ByVal inputPath As String,
						 ByVal outputPath As String,
						 ByVal newWidth As Integer) As String

		' Load the original image
		Using originalImage As Image = Image.FromFile(inputPath)

			Dim aspectRatio As Double = originalImage.Height / originalImage.Width
			Dim newHeight As Integer = CInt(newWidth * aspectRatio)

			' Create a new Bitmap with the desired dimensions
			Using resizedImage As New Bitmap(newWidth, newHeight)
				' Create Graphics object for the new image
				Using g As Graphics = Graphics.FromImage(resizedImage)
					' Set the resize quality modes
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
					g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

					' Draw the original image onto the new image
					g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
				End Using

				' Save the resized image
				resizedImage.Save(outputPath, Imaging.ImageFormat.Png)
			End Using
		End Using

		' Return the path of the resized image
		Return outputPath
	End Function

	Function SendOpenAiMsg(ByVal sFiePath As String, ByVal sQuestion As String) As String

		System.Net.ServicePointManager.SecurityProtocol =
		   System.Net.SecurityProtocolType.Ssl3 Or
		   System.Net.SecurityProtocolType.Tls12 Or
		   System.Net.SecurityProtocolType.Tls11 Or
		   System.Net.SecurityProtocolType.Tls

		Dim sModel As String = "gpt-4o-mini"
		Dim sUrl As String = "https://api.openai.com/v1/chat/completions"

		Dim request As HttpWebRequest = WebRequest.Create(sUrl)
		request.Method = "POST"
		request.ContentType = "application/json"
		request.Headers.Add("Authorization", "Bearer " & txtApiKey.Text)

		'https://platform.openai.com/docs/models
		'https://beta.openai.com/docs/api-reference/completions/create
		Dim image_data : image_data = GetFile64(sFiePath)

		Dim data As String = "{" &
		  " ""model"":""" & sModel & """," &
		  """messages"": [{""role"":""user"", ""content"": [" &
		  "{""type"": ""image_url"", ""image_url"": {""url"": ""data:image/jpeg;base64," & image_data & """}}," &
		  "{""type"": ""text"", ""text"": """ & PadQuotes(sQuestion) & """}]}]}"

		Using streamWriter As New StreamWriter(request.GetRequestStream())
			streamWriter.Write(data)
			streamWriter.Flush()
			streamWriter.Close()
		End Using

		Dim response As HttpWebResponse = request.GetResponse()
		Dim streamReader As New StreamReader(response.GetResponseStream())
		Dim sJson As String = streamReader.ReadToEnd()
		'Return sJson

		Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
		Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
		Dim sResponse As String = oJson("choices")(0)("message")("content")

		Return sResponse
	End Function

	Public Function GetFile64(imagePath As String) As String
		Dim fileBytes As Byte() = File.ReadAllBytes(imagePath)
		Return Convert.ToBase64String(fileBytes)
	End Function

	Private Function PadQuotes(ByVal s As String) As String

		If s.IndexOf("\") <> -1 Then
			s = Replace(s, "\", "\\")
		End If

		If s.IndexOf(vbCrLf) <> -1 Then
			s = Replace(s, vbCrLf, "\n")
		End If

		If s.IndexOf(vbCr) <> -1 Then
			s = Replace(s, vbCr, "\r")
		End If

		If s.IndexOf(vbLf) <> -1 Then
			s = Replace(s, vbLf, "\f")
		End If

		If s.IndexOf(vbTab) <> -1 Then
			s = Replace(s, vbTab, "\t")
		End If

		If s.IndexOf("""") = -1 Then
			Return s
		Else
			Return Replace(s, """", "\""")
		End If
	End Function

	Private Sub btnFromFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromFolder.Click
		fldFrom.ShowDialog()
		txtFrom.Text = fldFrom.SelectedPath
	End Sub


	Private Sub btnApiKeyShow_Click(sender As Object, e As EventArgs) Handles btnApiKeyShow.Click
		If txtApiKey.PasswordChar = "*" Then
			txtApiKey.PasswordChar = ""
		Else
			txtApiKey.PasswordChar = "*"
		End If
	End Sub

	Private Sub urlApiKey_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles urlApiKey.LinkClicked
		Process.Start(New ProcessStartInfo("https://platform.openai.com/api-keys"))
	End Sub
End Class

