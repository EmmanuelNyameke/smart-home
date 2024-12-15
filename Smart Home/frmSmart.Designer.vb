<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSmart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picSmartHome = New PictureBox()
        lblHeading = New Label()
        cboMonths = New ComboBox()
        btnDisplay = New Button()
        lblDisplaySavings = New Label()
        lblDisplayAverage = New Label()
        lblOverall = New Label()
        CType(picSmartHome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picSmartHome
        ' 
        picSmartHome.Image = My.Resources.Resources.smarthome
        picSmartHome.Location = New Point(1, 3)
        picSmartHome.Name = "picSmartHome"
        picSmartHome.Size = New Size(334, 249)
        picSmartHome.SizeMode = PictureBoxSizeMode.StretchImage
        picSmartHome.TabIndex = 0
        picSmartHome.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(350, 74)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(224, 62)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Smart Home" & vbCrLf & "Electric Savings"
        ' 
        ' cboMonths
        ' 
        cboMonths.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboMonths.FormattingEnabled = True
        cboMonths.Location = New Point(389, 164)
        cboMonths.Name = "cboMonths"
        cboMonths.Size = New Size(156, 32)
        cboMonths.TabIndex = 2
        cboMonths.Text = "Select Month:"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.CornflowerBlue
        btnDisplay.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.ForeColor = Color.White
        btnDisplay.Location = New Point(235, 317)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(190, 35)
        btnDisplay.TabIndex = 3
        btnDisplay.Text = "Display Statistics"
        btnDisplay.UseVisualStyleBackColor = False
        btnDisplay.Visible = False
        ' 
        ' lblDisplaySavings
        ' 
        lblDisplaySavings.AutoSize = True
        lblDisplaySavings.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblDisplaySavings.Location = New Point(1, 276)
        lblDisplaySavings.Name = "lblDisplaySavings"
        lblDisplaySavings.Size = New Size(83, 25)
        lblDisplaySavings.TabIndex = 4
        lblDisplaySavings.Text = "Label1"
        lblDisplaySavings.Visible = False
        ' 
        ' lblDisplayAverage
        ' 
        lblDisplayAverage.AutoSize = True
        lblDisplayAverage.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblDisplayAverage.Location = New Point(1, 353)
        lblDisplayAverage.Name = "lblDisplayAverage"
        lblDisplayAverage.Size = New Size(83, 25)
        lblDisplayAverage.TabIndex = 5
        lblDisplayAverage.Text = "Label1"
        lblDisplayAverage.Visible = False
        ' 
        ' lblOverall
        ' 
        lblOverall.AutoSize = True
        lblOverall.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        lblOverall.Location = New Point(1, 399)
        lblOverall.Name = "lblOverall"
        lblOverall.Size = New Size(83, 25)
        lblOverall.TabIndex = 6
        lblOverall.Text = "Label1"
        lblOverall.Visible = False
        ' 
        ' frmSmart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(601, 461)
        Controls.Add(lblOverall)
        Controls.Add(lblDisplayAverage)
        Controls.Add(lblDisplaySavings)
        Controls.Add(btnDisplay)
        Controls.Add(cboMonths)
        Controls.Add(lblHeading)
        Controls.Add(picSmartHome)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmSmart"
        Text = "Smart Home Application"
        CType(picSmartHome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picSmartHome As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblDisplaySavings As Label
    Friend WithEvents lblDisplayAverage As Label
    Friend WithEvents lblOverall As Label

End Class
