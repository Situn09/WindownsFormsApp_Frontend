<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStartStopWatch = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(122, 344)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(329, 32)
        Me.btnSubmit.TabIndex = 29
        Me.btnSubmit.Text = "SUBMIT (CTRL +S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnStartStopWatch
        '
        Me.btnStartStopWatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnStartStopWatch.Location = New System.Drawing.Point(122, 273)
        Me.btnStartStopWatch.Name = "btnStartStopWatch"
        Me.btnStartStopWatch.Size = New System.Drawing.Size(161, 53)
        Me.btnStartStopWatch.TabIndex = 21
        Me.btnStartStopWatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStartStopWatch.UseVisualStyleBackColor = False
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(245, 189)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PlaceholderText = "     +91xxxxxxxxxx"
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPhone.Size = New System.Drawing.Size(206, 27)
        Me.txtPhone.TabIndex = 25
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(245, 227)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.PlaceholderText = "     github link"
        Me.txtGithub.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtGithub.Size = New System.Drawing.Size(206, 27)
        Me.txtGithub.TabIndex = 24
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(245, 152)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = "      char@gmail.com"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtEmail.Size = New System.Drawing.Size(206, 27)
        Me.txtEmail.TabIndex = 23
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(245, 113)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = "      name"
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtName.Size = New System.Drawing.Size(206, 27)
        Me.txtName.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Phone No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(122, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 40)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Github Link For Task 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(122, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Chiranjiv, Slidely Task 2 - Create Submission"
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(289, 286)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.PlaceholderText = "00:00:00:00"
        Me.txtTimer.Size = New System.Drawing.Size(162, 27)
        Me.txtTimer.TabIndex = 30
        Me.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 450)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStartStopWatch)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStartStopWatch As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents Timer1 As Timer
End Class
