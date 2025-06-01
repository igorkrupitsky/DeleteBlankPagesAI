<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFromFolder = New System.Windows.Forms.Button()
        Me.fldFrom = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFileType = New System.Windows.Forms.ComboBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAction = New System.Windows.Forms.ComboBox()
        Me.chkSubfolders = New System.Windows.Forms.CheckBox()
        Me.chkResize = New System.Windows.Forms.CheckBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.lblOpenAI = New System.Windows.Forms.Label()
        Me.btnApiKeyShow = New System.Windows.Forms.Button()
        Me.urlApiKey = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrompt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTargetProbability = New System.Windows.Forms.TextBox()
        Me.txtResizePx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFrom
        '
        Me.txtFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrom.Location = New System.Drawing.Point(156, 181)
        Me.txtFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(643, 26)
        Me.txtFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 185)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folder"
        '
        'btnFromFolder
        '
        Me.btnFromFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFromFolder.Location = New System.Drawing.Point(810, 178)
        Me.btnFromFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFromFolder.Name = "btnFromFolder"
        Me.btnFromFolder.Size = New System.Drawing.Size(44, 35)
        Me.btnFromFolder.TabIndex = 2
        Me.btnFromFolder.Text = "..."
        Me.btnFromFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 241)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "File Type"
        '
        'cbFileType
        '
        Me.cbFileType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileType.FormattingEnabled = True
        Me.cbFileType.Items.AddRange(New Object() {"All", ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".tif", ".webp"})
        Me.cbFileType.Location = New System.Drawing.Point(156, 228)
        Me.cbFileType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbFileType.Name = "cbFileType"
        Me.cbFileType.Size = New System.Drawing.Size(696, 28)
        Me.cbFileType.TabIndex = 12
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(22, 419)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(829, 296)
        Me.txtOutput.TabIndex = 15
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcess.Location = New System.Drawing.Point(150, 363)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(703, 35)
        Me.btnProcess.TabIndex = 14
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(22, 726)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(831, 26)
        Me.ProgressBar1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 291)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Action"
        '
        'cbAction
        '
        Me.cbAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAction.FormattingEnabled = True
        Me.cbAction.Items.AddRange(New Object() {"Add _deleted to the filename of a blank image", "Place blank images to to_be_deleted folder", "Delete blank images"})
        Me.cbAction.Location = New System.Drawing.Point(156, 279)
        Me.cbAction.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbAction.Name = "cbAction"
        Me.cbAction.Size = New System.Drawing.Size(696, 28)
        Me.cbAction.TabIndex = 18
        '
        'chkSubfolders
        '
        Me.chkSubfolders.AutoSize = True
        Me.chkSubfolders.Checked = True
        Me.chkSubfolders.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSubfolders.Location = New System.Drawing.Point(150, 329)
        Me.chkSubfolders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkSubfolders.Name = "chkSubfolders"
        Me.chkSubfolders.Size = New System.Drawing.Size(170, 24)
        Me.chkSubfolders.TabIndex = 21
        Me.chkSubfolders.Text = "Process subfolders"
        Me.chkSubfolders.UseVisualStyleBackColor = True
        '
        'chkResize
        '
        Me.chkResize.AutoSize = True
        Me.chkResize.Checked = True
        Me.chkResize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResize.Location = New System.Drawing.Point(341, 329)
        Me.chkResize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkResize.Name = "chkResize"
        Me.chkResize.Size = New System.Drawing.Size(216, 24)
        Me.chkResize.TabIndex = 34
        Me.chkResize.Text = "Resize (to decrease cost)"
        Me.chkResize.UseVisualStyleBackColor = True
        '
        'txtApiKey
        '
        Me.txtApiKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApiKey.Location = New System.Drawing.Point(156, 11)
        Me.txtApiKey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApiKey.Multiline = True
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(643, 32)
        Me.txtApiKey.TabIndex = 36
        '
        'lblOpenAI
        '
        Me.lblOpenAI.AutoSize = True
        Me.lblOpenAI.Location = New System.Drawing.Point(13, 14)
        Me.lblOpenAI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpenAI.Name = "lblOpenAI"
        Me.lblOpenAI.Size = New System.Drawing.Size(92, 20)
        Me.lblOpenAI.TabIndex = 35
        Me.lblOpenAI.Text = "OpenAI key"
        '
        'btnApiKeyShow
        '
        Me.btnApiKeyShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApiKeyShow.Location = New System.Drawing.Point(811, 11)
        Me.btnApiKeyShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApiKeyShow.Name = "btnApiKeyShow"
        Me.btnApiKeyShow.Size = New System.Drawing.Size(42, 35)
        Me.btnApiKeyShow.TabIndex = 50
        Me.btnApiKeyShow.Text = "*"
        Me.btnApiKeyShow.UseVisualStyleBackColor = True
        '
        'urlApiKey
        '
        Me.urlApiKey.AutoSize = True
        Me.urlApiKey.Location = New System.Drawing.Point(112, 14)
        Me.urlApiKey.Name = "urlApiKey"
        Me.urlApiKey.Size = New System.Drawing.Size(18, 20)
        Me.urlApiKey.TabIndex = 51
        Me.urlApiKey.TabStop = True
        Me.urlApiKey.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Prompt"
        '
        'txtPrompt
        '
        Me.txtPrompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrompt.Location = New System.Drawing.Point(156, 66)
        Me.txtPrompt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrompt.Multiline = True
        Me.txtPrompt.Name = "txtPrompt"
        Me.txtPrompt.Size = New System.Drawing.Size(695, 62)
        Me.txtPrompt.TabIndex = 53
        Me.txtPrompt.Text = "What is it probability from 0 to 100 that this image is a blanked page. Do not pr" &
    "ovide any comments. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Target Probability"
        '
        'txtTargetProbability
        '
        Me.txtTargetProbability.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTargetProbability.Location = New System.Drawing.Point(156, 140)
        Me.txtTargetProbability.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTargetProbability.Name = "txtTargetProbability"
        Me.txtTargetProbability.Size = New System.Drawing.Size(695, 26)
        Me.txtTargetProbability.TabIndex = 55
        Me.txtTargetProbability.Text = "100"
        '
        'txtResizePx
        '
        Me.txtResizePx.Location = New System.Drawing.Point(565, 327)
        Me.txtResizePx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtResizePx.Name = "txtResizePx"
        Me.txtResizePx.Size = New System.Drawing.Size(56, 26)
        Me.txtResizePx.TabIndex = 56
        Me.txtResizePx.Text = "300"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(629, 330)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "pixels"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 766)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtResizePx)
        Me.Controls.Add(Me.txtTargetProbability)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrompt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.urlApiKey)
        Me.Controls.Add(Me.btnApiKeyShow)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.lblOpenAI)
        Me.Controls.Add(Me.chkResize)
        Me.Controls.Add(Me.chkSubfolders)
        Me.Controls.Add(Me.cbAction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbFileType)
        Me.Controls.Add(Me.btnFromFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrom)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Delete Blank Images with AI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnFromFolder As System.Windows.Forms.Button
	Friend WithEvents fldFrom As System.Windows.Forms.FolderBrowserDialog
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents cbFileType As System.Windows.Forms.ComboBox
	Friend WithEvents txtOutput As System.Windows.Forms.TextBox
	Friend WithEvents btnProcess As System.Windows.Forms.Button
	Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents cbAction As System.Windows.Forms.ComboBox
	Friend WithEvents chkSubfolders As System.Windows.Forms.CheckBox
	Friend WithEvents chkResize As System.Windows.Forms.CheckBox
	Friend WithEvents txtApiKey As TextBox
	Friend WithEvents lblOpenAI As Label
    Friend WithEvents btnApiKeyShow As Button
    Friend WithEvents urlApiKey As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrompt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTargetProbability As TextBox
    Friend WithEvents txtResizePx As TextBox
    Friend WithEvents Label6 As Label
End Class
