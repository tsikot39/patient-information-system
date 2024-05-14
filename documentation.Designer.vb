<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class documentation
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
        Me.dgvdocumentation = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbactivities = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpdatedone = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtissues = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaction = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpdategranted = New System.Windows.Forms.DateTimePicker()
        Me.txtfunder = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvdocumentation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdocumentation
        '
        Me.dgvdocumentation.AllowUserToAddRows = False
        Me.dgvdocumentation.AllowUserToDeleteRows = False
        Me.dgvdocumentation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvdocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdocumentation.Location = New System.Drawing.Point(13, 13)
        Me.dgvdocumentation.Name = "dgvdocumentation"
        Me.dgvdocumentation.ReadOnly = True
        Me.dgvdocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdocumentation.Size = New System.Drawing.Size(659, 150)
        Me.dgvdocumentation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Activities"
        '
        'cbactivities
        '
        Me.cbactivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbactivities.FormattingEnabled = True
        Me.cbactivities.Location = New System.Drawing.Point(238, 171)
        Me.cbactivities.Name = "cbactivities"
        Me.cbactivities.Size = New System.Drawing.Size(434, 21)
        Me.cbactivities.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date Done"
        '
        'dtpdatedone
        '
        Me.dtpdatedone.CustomFormat = """"""
        Me.dtpdatedone.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatedone.Location = New System.Drawing.Point(238, 198)
        Me.dtpdatedone.Name = "dtpdatedone"
        Me.dtpdatedone.ShowCheckBox = True
        Me.dtpdatedone.Size = New System.Drawing.Size(121, 21)
        Me.dtpdatedone.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Psychological Issues and Concerns Identified"
        '
        'txtissues
        '
        Me.txtissues.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtissues.Location = New System.Drawing.Point(238, 225)
        Me.txtissues.Name = "txtissues"
        Me.txtissues.Size = New System.Drawing.Size(434, 21)
        Me.txtissues.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Action Taken"
        '
        'txtaction
        '
        Me.txtaction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaction.Location = New System.Drawing.Point(238, 252)
        Me.txtaction.Name = "txtaction"
        Me.txtaction.Size = New System.Drawing.Size(434, 21)
        Me.txtaction.TabIndex = 8
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(508, 532)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(427, 532)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(265, 532)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(184, 532)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 12
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(103, 532)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 13
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(346, 532)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Remarks"
        '
        'txtremarks
        '
        Me.txtremarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtremarks.Location = New System.Drawing.Point(238, 279)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(434, 91)
        Me.txtremarks.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Assistance Granted"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Date"
        '
        'dtpdategranted
        '
        Me.dtpdategranted.CustomFormat = """"""
        Me.dtpdategranted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdategranted.Location = New System.Drawing.Point(100, 420)
        Me.dtpdategranted.Name = "dtpdategranted"
        Me.dtpdategranted.ShowCheckBox = True
        Me.dtpdategranted.Size = New System.Drawing.Size(121, 21)
        Me.dtpdategranted.TabIndex = 19
        '
        'txtfunder
        '
        Me.txtfunder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfunder.Location = New System.Drawing.Point(100, 447)
        Me.txtfunder.Name = "txtfunder"
        Me.txtfunder.Size = New System.Drawing.Size(572, 21)
        Me.txtfunder.TabIndex = 20
        '
        'txtamount
        '
        Me.txtamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtamount.Location = New System.Drawing.Point(100, 474)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(121, 21)
        Me.txtamount.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Name of Funder"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 482)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Amount"
        '
        'documentation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtfunder)
        Me.Controls.Add(Me.dtpdategranted)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtaction)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtissues)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpdatedone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbactivities)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdocumentation)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "documentation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOCUMENTATION"
        CType(Me.dgvdocumentation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdocumentation As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbactivities As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpdatedone As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtissues As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtaction As System.Windows.Forms.TextBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpdategranted As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfunder As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
