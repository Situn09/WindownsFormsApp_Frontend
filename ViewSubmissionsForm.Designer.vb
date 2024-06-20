<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.TextBox()
        Me.lblGithub = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.TextBox()
        Me.lblTimer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(96, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chiranjiv, Slidely Task 2 - View Submission Form"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Phone No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(120, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Github Link For Task 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(243, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.ReadOnly = True
        Me.lblName.Size = New System.Drawing.Size(206, 27)
        Me.lblName.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(243, 155)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.ReadOnly = True
        Me.lblEmail.Size = New System.Drawing.Size(206, 27)
        Me.lblEmail.TabIndex = 10
        '
        'lblGithub
        '
        Me.lblGithub.Location = New System.Drawing.Point(243, 238)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.ReadOnly = True
        Me.lblGithub.Size = New System.Drawing.Size(206, 27)
        Me.lblGithub.TabIndex = 11
        Me.lblGithub.TabStop = False
        '
        'lblPhone
        '
        Me.lblPhone.Location = New System.Drawing.Point(243, 192)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.ReadOnly = True
        Me.lblPhone.Size = New System.Drawing.Size(206, 27)
        Me.lblPhone.TabIndex = 12
        '
        'lblTimer
        '
        Me.lblTimer.Location = New System.Drawing.Point(243, 284)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.ReadOnly = True
        Me.lblTimer.Size = New System.Drawing.Size(206, 27)
        Me.lblTimer.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(120, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 50)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "StopWatch Time"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnPrevious.Location = New System.Drawing.Point(96, 328)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(178, 32)
        Me.btnPrevious.TabIndex = 15
        Me.btnPrevious.Text = "PREVIOUS (CLTR + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(280, 328)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(187, 32)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(280, 366)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(187, 32)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "DELETE (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LightGreen
        Me.btnEdit.Location = New System.Drawing.Point(96, 366)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(178, 32)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "EDIT (CLTR + E)"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(566, 450)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents lblGithub As TextBox
    Friend WithEvents lblPhone As TextBox
    Friend WithEvents lblTimer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
