<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox_result = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_division = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_subtract = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_equal = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_dot = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_00 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_result
        '
        Me.TextBox_result.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox_result.Location = New System.Drawing.Point(12, 12)
        Me.TextBox_result.Multiline = True
        Me.TextBox_result.Name = "TextBox_result"
        Me.TextBox_result.Size = New System.Drawing.Size(284, 58)
        Me.TextBox_result.TabIndex = 0
        Me.TextBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_clear
        '
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderSize = 2
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_clear.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_clear.Location = New System.Drawing.Point(12, 96)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(52, 36)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "C"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 2
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_delete.Location = New System.Drawing.Point(245, 96)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(51, 36)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "de"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_multiply.FlatAppearance.BorderSize = 2
        Me.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_multiply.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_multiply.Location = New System.Drawing.Point(168, 96)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(51, 36)
        Me.btn_multiply.TabIndex = 4
        Me.btn_multiply.Text = "*"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_division
        '
        Me.btn_division.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_division.FlatAppearance.BorderSize = 2
        Me.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_division.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_division.Location = New System.Drawing.Point(90, 96)
        Me.btn_division.Name = "btn_division"
        Me.btn_division.Size = New System.Drawing.Size(51, 36)
        Me.btn_division.TabIndex = 5
        Me.btn_division.Text = "/"
        Me.btn_division.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_8.FlatAppearance.BorderSize = 2
        Me.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_8.Location = New System.Drawing.Point(90, 151)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(51, 36)
        Me.btn_8.TabIndex = 9
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_9.FlatAppearance.BorderSize = 2
        Me.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_9.Location = New System.Drawing.Point(168, 151)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(51, 36)
        Me.btn_9.TabIndex = 8
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_subtract
        '
        Me.btn_subtract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_subtract.FlatAppearance.BorderSize = 2
        Me.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_subtract.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_subtract.Location = New System.Drawing.Point(245, 151)
        Me.btn_subtract.Name = "btn_subtract"
        Me.btn_subtract.Size = New System.Drawing.Size(51, 36)
        Me.btn_subtract.TabIndex = 7
        Me.btn_subtract.Text = "-"
        Me.btn_subtract.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_7.FlatAppearance.BorderSize = 2
        Me.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_7.Location = New System.Drawing.Point(12, 151)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(52, 36)
        Me.btn_7.TabIndex = 6
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_5.FlatAppearance.BorderSize = 2
        Me.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_5.Location = New System.Drawing.Point(90, 203)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(51, 36)
        Me.btn_5.TabIndex = 13
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_6.FlatAppearance.BorderSize = 2
        Me.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_6.Location = New System.Drawing.Point(168, 203)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(51, 36)
        Me.btn_6.TabIndex = 12
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_plus
        '
        Me.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_plus.FlatAppearance.BorderSize = 2
        Me.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_plus.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_plus.Location = New System.Drawing.Point(245, 203)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(51, 36)
        Me.btn_plus.TabIndex = 11
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_4.FlatAppearance.BorderSize = 2
        Me.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_4.Location = New System.Drawing.Point(12, 203)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(52, 36)
        Me.btn_4.TabIndex = 10
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_2.FlatAppearance.BorderSize = 2
        Me.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_2.Location = New System.Drawing.Point(90, 255)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(51, 36)
        Me.btn_2.TabIndex = 17
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_3.FlatAppearance.BorderSize = 2
        Me.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_3.Location = New System.Drawing.Point(168, 255)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(51, 36)
        Me.btn_3.TabIndex = 16
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_equal
        '
        Me.btn_equal.BackColor = System.Drawing.Color.Blue
        Me.btn_equal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_equal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_equal.FlatAppearance.BorderSize = 2
        Me.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_equal.ForeColor = System.Drawing.Color.White
        Me.btn_equal.Location = New System.Drawing.Point(245, 255)
        Me.btn_equal.Name = "btn_equal"
        Me.btn_equal.Size = New System.Drawing.Size(51, 88)
        Me.btn_equal.TabIndex = 15
        Me.btn_equal.Text = "="
        Me.btn_equal.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_1.FlatAppearance.BorderSize = 2
        Me.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_1.Location = New System.Drawing.Point(12, 255)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(52, 36)
        Me.btn_1.TabIndex = 14
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_0.FlatAppearance.BorderSize = 2
        Me.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_0.Location = New System.Drawing.Point(12, 307)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(52, 36)
        Me.btn_0.TabIndex = 21
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_dot
        '
        Me.btn_dot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dot.FlatAppearance.BorderSize = 2
        Me.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_dot.Location = New System.Drawing.Point(168, 307)
        Me.btn_dot.Name = "btn_dot"
        Me.btn_dot.Size = New System.Drawing.Size(51, 36)
        Me.btn_dot.TabIndex = 20
        Me.btn_dot.Text = " ."
        Me.btn_dot.UseVisualStyleBackColor = True
        '
        'btn_00
        '
        Me.btn_00.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_00.FlatAppearance.BorderSize = 2
        Me.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_00.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_00.Location = New System.Drawing.Point(90, 307)
        Me.btn_00.Name = "btn_00"
        Me.btn_00.Size = New System.Drawing.Size(51, 36)
        Me.btn_00.TabIndex = 22
        Me.btn_00.Text = "00"
        Me.btn_00.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(307, 361)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_00)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_dot)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_equal)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_subtract)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_division)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.TextBox_result)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_result As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_subtract As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_dot As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_00 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
