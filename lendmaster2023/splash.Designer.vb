<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Me.MyprogressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.PercentageLb1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MyprogressBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyprogressBar1
        '
        Me.MyprogressBar1.Controls.Add(Me.PercentageLb1)
        Me.MyprogressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.MyprogressBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MyprogressBar1.ForeColor = System.Drawing.Color.White
        Me.MyprogressBar1.Location = New System.Drawing.Point(173, 173)
        Me.MyprogressBar1.Minimum = 0
        Me.MyprogressBar1.Name = "MyprogressBar1"
        Me.MyprogressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Me.MyprogressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.MyprogressBar1.Size = New System.Drawing.Size(277, 277)
        Me.MyprogressBar1.TabIndex = 0
        '
        'PercentageLb1
        '
        Me.PercentageLb1.AutoSize = True
        Me.PercentageLb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PercentageLb1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PercentageLb1.Location = New System.Drawing.Point(94, 126)
        Me.PercentageLb1.Name = "PercentageLb1"
        Me.PercentageLb1.Size = New System.Drawing.Size(35, 35)
        Me.PercentageLb1.TabIndex = 1
        Me.PercentageLb1.Text = "%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(151, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LEND MASTER"
        '
        'Timer1
        '
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(676, 489)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyprogressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        Me.MyprogressBar1.ResumeLayout(False)
        Me.MyprogressBar1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyprogressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents PercentageLb1 As Label
    Friend WithEvents Timer1 As Timer
End Class
