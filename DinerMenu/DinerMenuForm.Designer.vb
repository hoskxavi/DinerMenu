<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenuForm
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpecialsTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialsNameBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SoupButton.Location = New System.Drawing.Point(45, 341)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(165, 75)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup of the Day"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SaladButton.Location = New System.Drawing.Point(308, 341)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(167, 75)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Chef's Special"
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FishButton.Location = New System.Drawing.Point(574, 341)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(163, 75)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish Special"
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ExitButton.Location = New System.Drawing.Point(344, 441)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 29)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 31.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(118, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 64)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hoskins Pub and Grub"
        '
        'SpecialsTextBox
        '
        Me.SpecialsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SpecialsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpecialsTextBox.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.SpecialsTextBox.Location = New System.Drawing.Point(130, 152)
        Me.SpecialsTextBox.Multiline = True
        Me.SpecialsTextBox.Name = "SpecialsTextBox"
        Me.SpecialsTextBox.Size = New System.Drawing.Size(523, 174)
        Me.SpecialsTextBox.TabIndex = 5
        Me.SpecialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SpecialsNameBox
        '
        Me.SpecialsNameBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SpecialsNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpecialsNameBox.Font = New System.Drawing.Font("Segoe Script", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.SpecialsNameBox.Location = New System.Drawing.Point(130, 76)
        Me.SpecialsNameBox.Multiline = True
        Me.SpecialsNameBox.Name = "SpecialsNameBox"
        Me.SpecialsNameBox.Size = New System.Drawing.Size(523, 70)
        Me.SpecialsNameBox.TabIndex = 6
        Me.SpecialsNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.SpecialsNameBox)
        Me.Controls.Add(Me.SpecialsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "Hoskins Pub and Grub Specials Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SpecialsTextBox As TextBox
    Friend WithEvents SpecialsNameBox As TextBox
End Class
