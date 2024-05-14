<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class familycomposition
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
        Me.dgvfamilycomposition = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrelation = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbgender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbeducation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnature = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtincome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtothersource = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttotalincome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpercapita = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txtoccupation = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvfamilycomposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvfamilycomposition
        '
        Me.dgvfamilycomposition.AllowUserToAddRows = False
        Me.dgvfamilycomposition.AllowUserToDeleteRows = False
        Me.dgvfamilycomposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvfamilycomposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfamilycomposition.Location = New System.Drawing.Point(13, 14)
        Me.dgvfamilycomposition.Name = "dgvfamilycomposition"
        Me.dgvfamilycomposition.ReadOnly = True
        Me.dgvfamilycomposition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvfamilycomposition.Size = New System.Drawing.Size(659, 150)
        Me.dgvfamilycomposition.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtname
        '
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Location = New System.Drawing.Point(134, 263)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(538, 21)
        Me.txtname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Relationship to Parent"
        '
        'txtrelation
        '
        Me.txtrelation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrelation.Location = New System.Drawing.Point(134, 290)
        Me.txtrelation.Name = "txtrelation"
        Me.txtrelation.Size = New System.Drawing.Size(538, 21)
        Me.txtrelation.TabIndex = 2
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(134, 317)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(538, 21)
        Me.txtage.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Age"
        '
        'cbgender
        '
        Me.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Location = New System.Drawing.Point(134, 345)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(121, 21)
        Me.cbgender.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gender"
        '
        'cbeducation
        '
        Me.cbeducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbeducation.FormattingEnabled = True
        Me.cbeducation.Location = New System.Drawing.Point(134, 372)
        Me.cbeducation.Name = "cbeducation"
        Me.cbeducation.Size = New System.Drawing.Size(121, 21)
        Me.cbeducation.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Educational Attainment"
        '
        'txtnature
        '
        Me.txtnature.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnature.Location = New System.Drawing.Point(134, 426)
        Me.txtnature.Name = "txtnature"
        Me.txtnature.Size = New System.Drawing.Size(538, 21)
        Me.txtnature.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nature of Employment"
        '
        'txtincome
        '
        Me.txtincome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtincome.Location = New System.Drawing.Point(134, 453)
        Me.txtincome.Name = "txtincome"
        Me.txtincome.Size = New System.Drawing.Size(538, 21)
        Me.txtincome.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Income"
        '
        'txtothersource
        '
        Me.txtothersource.Location = New System.Drawing.Point(572, 171)
        Me.txtothersource.Name = "txtothersource"
        Me.txtothersource.Size = New System.Drawing.Size(100, 21)
        Me.txtothersource.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Other Source/s of income/Family Support"
        '
        'txttotalincome
        '
        Me.txttotalincome.Location = New System.Drawing.Point(572, 198)
        Me.txttotalincome.Name = "txttotalincome"
        Me.txttotalincome.Size = New System.Drawing.Size(100, 21)
        Me.txttotalincome.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(346, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Income (family income + other income)"
        '
        'txtpercapita
        '
        Me.txtpercapita.Location = New System.Drawing.Point(572, 226)
        Me.txtpercapita.Name = "txtpercapita"
        Me.txtpercapita.Size = New System.Drawing.Size(100, 21)
        Me.txtpercapita.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(290, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(276, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "PER CAPITA INCOME (Total Income/No. of dependents)"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(188, 489)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 21
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(270, 489)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 22
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(352, 489)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 23
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(434, 489)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 24
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(516, 489)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 25
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(597, 489)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 26
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txtoccupation
        '
        Me.txtoccupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtoccupation.Location = New System.Drawing.Point(134, 399)
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.Size = New System.Drawing.Size(538, 21)
        Me.txtoccupation.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 407)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Occupation"
        '
        'familycomposition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtoccupation)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpercapita)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttotalincome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtothersource)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtincome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnature)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbeducation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbgender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtrelation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvfamilycomposition)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "familycomposition"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FAMILY COMPOSITION"
        CType(Me.dgvfamilycomposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvfamilycomposition As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrelation As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbgender As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbeducation As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnature As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtincome As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtothersource As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttotalincome As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpercapita As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents txtoccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
