<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pizza))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUser = New System.Windows.Forms.Label()
        Me.grpTypePizza = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbMeat = New System.Windows.Forms.RadioButton()
        Me.rbStufCPep = New System.Windows.Forms.RadioButton()
        Me.rbVeggie = New System.Windows.Forms.RadioButton()
        Me.rbThiCru = New System.Windows.Forms.RadioButton()
        Me.rbHulaHa = New System.Windows.Forms.RadioButton()
        Me.rbClasPep = New System.Windows.Forms.RadioButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chBrow = New System.Windows.Forms.CheckBox()
        Me.chBuffRan = New System.Windows.Forms.CheckBox()
        Me.chBuffalo = New System.Windows.Forms.CheckBox()
        Me.chBreSti = New System.Windows.Forms.CheckBox()
        Me.chRanch = New System.Windows.Forms.CheckBox()
        Me.chBbq = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTypePizza.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 72)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.App.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Black
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.App.My.Resources.Resources.twitter
        Me.PictureBox7.Location = New System.Drawing.Point(895, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(30, 43)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.App.My.Resources.Resources.instagram
        Me.PictureBox3.Location = New System.Drawing.Point(831, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.App.My.Resources.Resources.facebook
        Me.PictureBox2.Location = New System.Drawing.Point(757, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'txtUser
        '
        Me.txtUser.AutoSize = True
        Me.txtUser.BackColor = System.Drawing.Color.Black
        Me.txtUser.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(58, 22)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(63, 40)
        Me.txtUser.TabIndex = 0
        Me.txtUser.Text = "User"
        '
        'grpTypePizza
        '
        Me.grpTypePizza.Controls.Add(Me.Label6)
        Me.grpTypePizza.Controls.Add(Me.Label4)
        Me.grpTypePizza.Controls.Add(Me.Label5)
        Me.grpTypePizza.Controls.Add(Me.Label3)
        Me.grpTypePizza.Controls.Add(Me.Label2)
        Me.grpTypePizza.Controls.Add(Me.Label1)
        Me.grpTypePizza.Controls.Add(Me.rbMeat)
        Me.grpTypePizza.Controls.Add(Me.rbStufCPep)
        Me.grpTypePizza.Controls.Add(Me.rbVeggie)
        Me.grpTypePizza.Controls.Add(Me.rbThiCru)
        Me.grpTypePizza.Controls.Add(Me.rbHulaHa)
        Me.grpTypePizza.Controls.Add(Me.rbClasPep)
        Me.grpTypePizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpTypePizza.Font = New System.Drawing.Font("Dubai", 9.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTypePizza.Location = New System.Drawing.Point(26, 196)
        Me.grpTypePizza.Name = "grpTypePizza"
        Me.grpTypePizza.Size = New System.Drawing.Size(344, 447)
        Me.grpTypePizza.TabIndex = 12
        Me.grpTypePizza.TabStop = False
        Me.grpTypePizza.Text = "Pizza Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 34)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "$22"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 34)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "$20"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 34)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "$24"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 34)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "$24"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "$17"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "$14"
        '
        'rbMeat
        '
        Me.rbMeat.AutoSize = True
        Me.rbMeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbMeat.Location = New System.Drawing.Point(0, 396)
        Me.rbMeat.Name = "rbMeat"
        Me.rbMeat.Size = New System.Drawing.Size(144, 38)
        Me.rbMeat.TabIndex = 0
        Me.rbMeat.TabStop = True
        Me.rbMeat.Text = "3 Meat Treat"
        Me.rbMeat.UseVisualStyleBackColor = True
        '
        'rbStufCPep
        '
        Me.rbStufCPep.AutoSize = True
        Me.rbStufCPep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbStufCPep.Location = New System.Drawing.Point(6, 180)
        Me.rbStufCPep.Name = "rbStufCPep"
        Me.rbStufCPep.Size = New System.Drawing.Size(231, 38)
        Me.rbStufCPep.TabIndex = 0
        Me.rbStufCPep.TabStop = True
        Me.rbStufCPep.Text = "Stuffed Crust Pepperoni"
        Me.rbStufCPep.UseVisualStyleBackColor = True
        '
        'rbVeggie
        '
        Me.rbVeggie.AutoSize = True
        Me.rbVeggie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbVeggie.Location = New System.Drawing.Point(6, 324)
        Me.rbVeggie.Name = "rbVeggie"
        Me.rbVeggie.Size = New System.Drawing.Size(93, 38)
        Me.rbVeggie.TabIndex = 0
        Me.rbVeggie.TabStop = True
        Me.rbVeggie.Text = "Veggie"
        Me.rbVeggie.UseVisualStyleBackColor = True
        '
        'rbThiCru
        '
        Me.rbThiCru.AutoSize = True
        Me.rbThiCru.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbThiCru.Location = New System.Drawing.Point(6, 108)
        Me.rbThiCru.Name = "rbThiCru"
        Me.rbThiCru.Size = New System.Drawing.Size(209, 38)
        Me.rbThiCru.TabIndex = 0
        Me.rbThiCru.TabStop = True
        Me.rbThiCru.Text = "Thin Crust Pepperoni"
        Me.rbThiCru.UseVisualStyleBackColor = True
        '
        'rbHulaHa
        '
        Me.rbHulaHa.AutoSize = True
        Me.rbHulaHa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbHulaHa.Location = New System.Drawing.Point(6, 252)
        Me.rbHulaHa.Name = "rbHulaHa"
        Me.rbHulaHa.Size = New System.Drawing.Size(155, 38)
        Me.rbHulaHa.TabIndex = 0
        Me.rbHulaHa.TabStop = True
        Me.rbHulaHa.Text = "Hula Hawaiian"
        Me.rbHulaHa.UseVisualStyleBackColor = True
        '
        'rbClasPep
        '
        Me.rbClasPep.AutoSize = True
        Me.rbClasPep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbClasPep.Location = New System.Drawing.Point(6, 36)
        Me.rbClasPep.Name = "rbClasPep"
        Me.rbClasPep.Size = New System.Drawing.Size(178, 38)
        Me.rbClasPep.TabIndex = 0
        Me.rbClasPep.TabStop = True
        Me.rbClasPep.Text = "Classic Pepperoni"
        Me.rbClasPep.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.App.My.Resources.Resources.pizza1
        Me.PictureBox4.Location = New System.Drawing.Point(376, 68)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(204, 140)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chBrow)
        Me.GroupBox1.Controls.Add(Me.chBuffRan)
        Me.GroupBox1.Controls.Add(Me.chBuffalo)
        Me.GroupBox1.Controls.Add(Me.chBreSti)
        Me.GroupBox1.Controls.Add(Me.chRanch)
        Me.GroupBox1.Controls.Add(Me.chBbq)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Dubai", 9.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(603, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 447)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sides"
        '
        'chBrow
        '
        Me.chBrow.AutoSize = True
        Me.chBrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chBrow.Location = New System.Drawing.Point(16, 393)
        Me.chBrow.Name = "chBrow"
        Me.chBrow.Size = New System.Drawing.Size(153, 38)
        Me.chBrow.TabIndex = 2
        Me.chBrow.Text = "Brownies 3pcs"
        Me.chBrow.UseVisualStyleBackColor = True
        '
        'chBuffRan
        '
        Me.chBuffRan.AutoSize = True
        Me.chBuffRan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chBuffRan.Location = New System.Drawing.Point(16, 249)
        Me.chBuffRan.Name = "chBuffRan"
        Me.chBuffRan.Size = New System.Drawing.Size(149, 38)
        Me.chBuffRan.TabIndex = 2
        Me.chBuffRan.Text = "Buffalo Ranch"
        Me.chBuffRan.UseVisualStyleBackColor = True
        '
        'chBuffalo
        '
        Me.chBuffalo.AutoSize = True
        Me.chBuffalo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chBuffalo.Location = New System.Drawing.Point(16, 108)
        Me.chBuffalo.Name = "chBuffalo"
        Me.chBuffalo.Size = New System.Drawing.Size(196, 38)
        Me.chBuffalo.TabIndex = 2
        Me.chBuffalo.Text = "Wings-Buffalo 8pcs"
        Me.chBuffalo.UseVisualStyleBackColor = True
        '
        'chBreSti
        '
        Me.chBreSti.AutoSize = True
        Me.chBreSti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chBreSti.Location = New System.Drawing.Point(16, 322)
        Me.chBreSti.Name = "chBreSti"
        Me.chBreSti.Size = New System.Drawing.Size(179, 38)
        Me.chBreSti.TabIndex = 2
        Me.chBreSti.Text = "Bread Sticks 8pcs"
        Me.chBreSti.UseVisualStyleBackColor = True
        '
        'chRanch
        '
        Me.chRanch.AutoSize = True
        Me.chRanch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chRanch.Location = New System.Drawing.Point(16, 178)
        Me.chRanch.Name = "chRanch"
        Me.chRanch.Size = New System.Drawing.Size(86, 38)
        Me.chRanch.TabIndex = 2
        Me.chRanch.Text = "Ranch"
        Me.chRanch.UseVisualStyleBackColor = True
        '
        'chBbq
        '
        Me.chBbq.AutoSize = True
        Me.chBbq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chBbq.Location = New System.Drawing.Point(15, 37)
        Me.chBbq.Name = "chBbq"
        Me.chBbq.Size = New System.Drawing.Size(176, 38)
        Me.chBbq.TabIndex = 2
        Me.chBbq.Text = "Wings-BBQ 8pcs"
        Me.chBbq.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 34)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "$5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 34)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "$3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(290, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 34)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "$7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(290, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 34)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "$3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(290, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 34)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "$10"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 34)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "$10"
        '
        'btnCheckout
        '
        Me.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Location = New System.Drawing.Point(738, 96)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(223, 56)
        Me.btnCheckout.TabIndex = 14
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(26, 96)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(69, 31)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(26, 666)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 31)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pizza
        '
        Me.AcceptButton = Me.btnCheckout
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(973, 738)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpTypePizza)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(995, 794)
        Me.Name = "pizza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTypePizza.ResumeLayout(False)
        Me.grpTypePizza.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUser As Label
    Friend WithEvents grpTypePizza As GroupBox
    Friend WithEvents rbMeat As RadioButton
    Friend WithEvents rbStufCPep As RadioButton
    Friend WithEvents rbVeggie As RadioButton
    Friend WithEvents rbThiCru As RadioButton
    Friend WithEvents rbHulaHa As RadioButton
    Friend WithEvents rbClasPep As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chBrow As CheckBox
    Friend WithEvents chBuffRan As CheckBox
    Friend WithEvents chBuffalo As CheckBox
    Friend WithEvents chBreSti As CheckBox
    Friend WithEvents chRanch As CheckBox
    Friend WithEvents chBbq As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
End Class
