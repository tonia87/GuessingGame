<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblMsg.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblMsg.Location = New System.Drawing.Point(12, 19)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(283, 42)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "Label1"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(106, 85)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 29)
        Me.txtNumber.TabIndex = 2
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCheck
        '
        Me.btnCheck.BackgroundImage = Global.Guess_Game.My.Resources.Resources.abstract
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheck.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCheck.Location = New System.Drawing.Point(88, 144)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(139, 43)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check Your Input"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'frmGame
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 213)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblMsg)
        Me.Name = "frmGame"
        Me.Text = "Guess Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox

End Class
