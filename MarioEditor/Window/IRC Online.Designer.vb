<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IRC))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtBoxKey = New System.Windows.Forms.TextBox()
        Me.lblChannel = New System.Windows.Forms.Label()
        Me.txtBoxChannel = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblKey)
        Me.GroupBox1.Controls.Add(Me.txtBoxKey)
        Me.GroupBox1.Controls.Add(Me.lblChannel)
        Me.GroupBox1.Controls.Add(Me.txtBoxChannel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Channel Info"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(6, 48)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(28, 13)
        Me.lblKey.TabIndex = 1
        Me.lblKey.Text = "Key:"
        '
        'txtBoxKey
        '
        Me.txtBoxKey.Location = New System.Drawing.Point(61, 45)
        Me.txtBoxKey.Name = "txtBoxKey"
        Me.txtBoxKey.Size = New System.Drawing.Size(133, 20)
        Me.txtBoxKey.TabIndex = 2
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.Location = New System.Drawing.Point(6, 22)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(49, 13)
        Me.lblChannel.TabIndex = 1
        Me.lblChannel.Text = "Channel:"
        '
        'txtBoxChannel
        '
        Me.txtBoxChannel.Location = New System.Drawing.Point(61, 19)
        Me.txtBoxChannel.Name = "txtBoxChannel"
        Me.txtBoxChannel.Size = New System.Drawing.Size(133, 20)
        Me.txtBoxChannel.TabIndex = 1
        Me.txtBoxChannel.Text = "#vsmbx"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUsername)
        Me.GroupBox2.Controls.Add(Me.txtBoxUsername)
        Me.GroupBox2.Controls.Add(Me.lblPassword)
        Me.GroupBox2.Controls.Add(Me.txtBoxPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NickServ"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(6, 22)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Location = New System.Drawing.Point(70, 19)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxUsername.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(6, 48)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Location = New System.Drawing.Point(70, 45)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxPassword.TabIndex = 4
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(137, 167)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Join"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'IRC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 202)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IRC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IRC Connection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents txtBoxKey As System.Windows.Forms.TextBox
    Friend WithEvents lblChannel As System.Windows.Forms.Label
    Friend WithEvents txtBoxChannel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
End Class
