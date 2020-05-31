<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RUMAH
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Click ""Button"" to Access The Reports of Data"}, -1, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.InactiveCaptionText, New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Click ""Button Koridor"" to Access The Coridor Data"}, -1, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.InactiveCaptionText, New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Click ""Button Customer"" to Access The Customer Data"}, -1, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.InactiveCaptionText, New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Click ""Button User"" to Access The User Data", System.Drawing.SystemColors.Window, System.Drawing.SystemColors.InactiveCaptionText, New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "USER FORM is Data to Access the Login Form", System.Drawing.SystemColors.Window, System.Drawing.Color.WhiteSmoke, New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Choose The Button To Access what You Want"}, -1, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.InactiveCaptionText, New System.Drawing.Font("Maiandra GD", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RUMAH))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.waktu = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.nama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Exitx = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Laporan = New System.Windows.Forms.TabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnlaporandata = New System.Windows.Forms.Button()
        Me.btnlaporanmaster = New System.Windows.Forms.Button()
        Me.Coridor = New System.Windows.Forms.TabPage()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Customer = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.TabPage()
        Me.VIEW1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnuser = New System.Windows.Forms.Button()
        Me.Menus = New System.Windows.Forms.TabPage()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnpengguna = New System.Windows.Forms.Button()
        Me.tab_menu = New System.Windows.Forms.TabControl()
        Me.about_us = New System.Windows.Forms.TabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.Exitx.SuspendLayout()
        Me.Laporan.SuspendLayout()
        Me.Coridor.SuspendLayout()
        Me.Customer.SuspendLayout()
        Me.User.SuspendLayout()
        Me.Menus.SuspendLayout()
        Me.tab_menu.SuspendLayout()
        Me.about_us.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 84)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 491)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'waktu
        '
        Me.waktu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.waktu.AutoSize = True
        Me.waktu.BackColor = System.Drawing.Color.Transparent
        Me.waktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.waktu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.waktu.Location = New System.Drawing.Point(967, 4)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(160, 44)
        Me.waktu.TabIndex = 2
        Me.waktu.Text = "WAKTU"
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.id, Me.nama, Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 553)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(90, 17)
        Me.ToolStripStatusLabel1.Text = "Selamat Bekerja"
        '
        'id
        '
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(78, 17)
        Me.id.Text = "administrator"
        '
        'nama
        '
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(121, 17)
        Me.nama.Text = "ToolStripStatusLabel3"
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(121, 17)
        Me.status.Text = "ToolStripStatusLabel2"
        '
        'Exitx
        '
        Me.Exitx.BackColor = System.Drawing.Color.Cornsilk
        Me.Exitx.Controls.Add(Me.Button10)
        Me.Exitx.Controls.Add(Me.Button9)
        Me.Exitx.Location = New System.Drawing.Point(4, 27)
        Me.Exitx.Name = "Exitx"
        Me.Exitx.Padding = New System.Windows.Forms.Padding(3)
        Me.Exitx.Size = New System.Drawing.Size(1255, 53)
        Me.Exitx.TabIndex = 7
        Me.Exitx.Text = "Keluar"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Silver
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(529, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(245, 41)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Log Out"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Silver
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(278, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(245, 41)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Exit"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Laporan
        '
        Me.Laporan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Laporan.Controls.Add(Me.ListView2)
        Me.Laporan.Controls.Add(Me.btnlaporandata)
        Me.Laporan.Controls.Add(Me.waktu)
        Me.Laporan.Controls.Add(Me.btnlaporanmaster)
        Me.Laporan.Location = New System.Drawing.Point(4, 27)
        Me.Laporan.Name = "Laporan"
        Me.Laporan.Padding = New System.Windows.Forms.Padding(3)
        Me.Laporan.Size = New System.Drawing.Size(1255, 53)
        Me.Laporan.TabIndex = 5
        Me.Laporan.Text = "Laporan"
        '
        'ListView2
        '
        Me.ListView2.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.ListView2.ForeColor = System.Drawing.SystemColors.Window
        ListViewItem1.ToolTipText = "NOTE :"
        Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView2.Location = New System.Drawing.Point(282, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(561, 76)
        Me.ListView2.TabIndex = 7
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Keterangan"
        Me.ColumnHeader3.Width = 433
        '
        'btnlaporandata
        '
        Me.btnlaporandata.BackColor = System.Drawing.SystemColors.Control
        Me.btnlaporandata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlaporandata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlaporandata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporandata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporandata.ForeColor = System.Drawing.Color.DarkRed
        Me.btnlaporandata.Location = New System.Drawing.Point(134, 3)
        Me.btnlaporandata.Name = "btnlaporandata"
        Me.btnlaporandata.Size = New System.Drawing.Size(129, 45)
        Me.btnlaporandata.TabIndex = 8
        Me.btnlaporandata.Text = "Data Laporan"
        Me.btnlaporandata.UseVisualStyleBackColor = False
        '
        'btnlaporanmaster
        '
        Me.btnlaporanmaster.BackColor = System.Drawing.SystemColors.Control
        Me.btnlaporanmaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlaporanmaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlaporanmaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporanmaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporanmaster.ForeColor = System.Drawing.Color.DarkRed
        Me.btnlaporanmaster.Location = New System.Drawing.Point(3, 3)
        Me.btnlaporanmaster.Name = "btnlaporanmaster"
        Me.btnlaporanmaster.Size = New System.Drawing.Size(125, 45)
        Me.btnlaporanmaster.TabIndex = 6
        Me.btnlaporanmaster.Text = "Lap. Master"
        Me.btnlaporanmaster.UseVisualStyleBackColor = False
        '
        'Coridor
        '
        Me.Coridor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Coridor.Controls.Add(Me.ListView3)
        Me.Coridor.Controls.Add(Me.Button12)
        Me.Coridor.Location = New System.Drawing.Point(4, 27)
        Me.Coridor.Name = "Coridor"
        Me.Coridor.Padding = New System.Windows.Forms.Padding(3)
        Me.Coridor.Size = New System.Drawing.Size(1255, 53)
        Me.Coridor.TabIndex = 4
        Me.Coridor.Text = "Data Iklan"
        '
        'ListView3
        '
        Me.ListView3.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.ListView3.ForeColor = System.Drawing.SystemColors.Window
        ListViewItem2.ToolTipText = "NOTE :"
        Me.ListView3.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.ListView3.Location = New System.Drawing.Point(125, 0)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(748, 51)
        Me.ListView3.TabIndex = 12
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Keterangan"
        Me.ColumnHeader4.Width = 588
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.DarkRed
        Me.Button12.Location = New System.Drawing.Point(3, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(116, 44)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "Data Koridor"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Customer
        '
        Me.Customer.BackColor = System.Drawing.Color.RoyalBlue
        Me.Customer.Controls.Add(Me.ListView1)
        Me.Customer.Controls.Add(Me.Button6)
        Me.Customer.Location = New System.Drawing.Point(4, 27)
        Me.Customer.Name = "Customer"
        Me.Customer.Padding = New System.Windows.Forms.Padding(3)
        Me.Customer.Size = New System.Drawing.Size(1255, 53)
        Me.Customer.TabIndex = 3
        Me.Customer.Text = "Data Pelanggan"
        Me.Customer.ToolTipText = "Pelanggan"
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Window
        ListViewItem3.ToolTipText = "NOTE :"
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(129, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(734, 47)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Keterangan"
        Me.ColumnHeader2.Width = 48
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkRed
        Me.Button6.Location = New System.Drawing.Point(3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 46)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Customer"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.User.AutoScroll = True
        Me.User.BackColor = System.Drawing.Color.DodgerBlue
        Me.User.Controls.Add(Me.VIEW1)
        Me.User.Controls.Add(Me.btnuser)
        Me.User.Location = New System.Drawing.Point(4, 27)
        Me.User.Name = "User"
        Me.User.Padding = New System.Windows.Forms.Padding(3)
        Me.User.Size = New System.Drawing.Size(1255, 53)
        Me.User.TabIndex = 2
        Me.User.Text = "Data User"
        '
        'VIEW1
        '
        Me.VIEW1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.VIEW1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.VIEW1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.VIEW1.ForeColor = System.Drawing.SystemColors.Window
        ListViewItem4.ToolTipText = "NOTE :"
        Me.VIEW1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4})
        Me.VIEW1.Location = New System.Drawing.Point(115, 1)
        Me.VIEW1.Name = "VIEW1"
        Me.VIEW1.Size = New System.Drawing.Size(727, 49)
        Me.VIEW1.TabIndex = 1
        Me.VIEW1.UseCompatibleStateImageBehavior = False
        Me.VIEW1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Keterangan"
        Me.ColumnHeader1.Width = 52
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.SystemColors.Control
        Me.btnuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.Color.DarkRed
        Me.btnuser.Location = New System.Drawing.Point(3, 2)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(110, 47)
        Me.btnuser.TabIndex = 0
        Me.btnuser.Text = "Data Pengguna"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'Menus
        '
        Me.Menus.BackColor = System.Drawing.Color.RoyalBlue
        Me.Menus.Controls.Add(Me.ListView4)
        Me.Menus.Controls.Add(Me.btnlaporan)
        Me.Menus.Controls.Add(Me.Button4)
        Me.Menus.Controls.Add(Me.Button3)
        Me.Menus.Controls.Add(Me.btnpengguna)
        Me.Menus.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Menus.Location = New System.Drawing.Point(4, 27)
        Me.Menus.Name = "Menus"
        Me.Menus.Padding = New System.Windows.Forms.Padding(3)
        Me.Menus.Size = New System.Drawing.Size(1255, 53)
        Me.Menus.TabIndex = 0
        Me.Menus.Text = "Menu"
        '
        'ListView4
        '
        Me.ListView4.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
        Me.ListView4.ForeColor = System.Drawing.SystemColors.Window
        ListViewItem5.ToolTipText = "NOTE :"
        Me.ListView4.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5})
        Me.ListView4.Location = New System.Drawing.Point(425, 0)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(466, 75)
        Me.ListView4.TabIndex = 5
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Keterangan"
        Me.ColumnHeader5.Width = 433
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.SystemColors.Control
        Me.btnlaporan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.ForeColor = System.Drawing.Color.DarkRed
        Me.btnlaporan.Location = New System.Drawing.Point(319, 0)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(110, 50)
        Me.btnlaporan.TabIndex = 4
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkRed
        Me.Button4.Location = New System.Drawing.Point(211, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 50)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Data Koridor Iklan"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(102, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Customer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnpengguna
        '
        Me.btnpengguna.BackColor = System.Drawing.SystemColors.Control
        Me.btnpengguna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpengguna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnpengguna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpengguna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpengguna.ForeColor = System.Drawing.Color.DarkRed
        Me.btnpengguna.Location = New System.Drawing.Point(0, 0)
        Me.btnpengguna.Name = "btnpengguna"
        Me.btnpengguna.Size = New System.Drawing.Size(103, 50)
        Me.btnpengguna.TabIndex = 1
        Me.btnpengguna.Text = "Data Pengguna"
        Me.btnpengguna.UseVisualStyleBackColor = False
        '
        'tab_menu
        '
        Me.tab_menu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tab_menu.Controls.Add(Me.Menus)
        Me.tab_menu.Controls.Add(Me.User)
        Me.tab_menu.Controls.Add(Me.Customer)
        Me.tab_menu.Controls.Add(Me.Coridor)
        Me.tab_menu.Controls.Add(Me.Laporan)
        Me.tab_menu.Controls.Add(Me.Exitx)
        Me.tab_menu.Controls.Add(Me.about_us)
        Me.tab_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tab_menu.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_menu.ItemSize = New System.Drawing.Size(120, 23)
        Me.tab_menu.Location = New System.Drawing.Point(0, 0)
        Me.tab_menu.Name = "tab_menu"
        Me.tab_menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tab_menu.SelectedIndex = 0
        Me.tab_menu.Size = New System.Drawing.Size(1263, 84)
        Me.tab_menu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tab_menu.TabIndex = 0
        Me.tab_menu.Tag = "MENU"
        '
        'about_us
        '
        Me.about_us.Controls.Add(Me.Button11)
        Me.about_us.Location = New System.Drawing.Point(4, 27)
        Me.about_us.Name = "about_us"
        Me.about_us.Size = New System.Drawing.Size(1255, 53)
        Me.about_us.TabIndex = 8
        Me.about_us.Text = "About Us"
        Me.about_us.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.DarkRed
        Me.Button11.Location = New System.Drawing.Point(770, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(136, 45)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "About Maker"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1126, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Click Here For Help"
        '
        'RUMAH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1263, 575)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tab_menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "RUMAH"
        Me.Text = "Menu Home Jasa Marga Tangerang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Exitx.ResumeLayout(False)
        Me.Laporan.ResumeLayout(False)
        Me.Laporan.PerformLayout()
        Me.Coridor.ResumeLayout(False)
        Me.Customer.ResumeLayout(False)
        Me.User.ResumeLayout(False)
        Me.Menus.ResumeLayout(False)
        Me.tab_menu.ResumeLayout(False)
        Me.about_us.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents waktu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Exitx As System.Windows.Forms.TabPage
    Friend WithEvents Laporan As System.Windows.Forms.TabPage
    Friend WithEvents Coridor As System.Windows.Forms.TabPage
    Friend WithEvents Customer As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents User As System.Windows.Forms.TabPage
    Friend WithEvents VIEW1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents Menus As System.Windows.Forms.TabPage
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnpengguna As System.Windows.Forms.Button
    Friend WithEvents tab_menu As System.Windows.Forms.TabControl
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnlaporandata As System.Windows.Forms.Button
    Friend WithEvents btnlaporanmaster As System.Windows.Forms.Button
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents about_us As System.Windows.Forms.TabPage
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents nama As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status As System.Windows.Forms.ToolStripStatusLabel
End Class
