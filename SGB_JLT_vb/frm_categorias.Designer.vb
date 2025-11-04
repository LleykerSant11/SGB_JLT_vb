<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_categorias
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
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.com_opest = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_buscat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btn_descargarexcel = New FontAwesome.Sharp.IconButton()
        Me.btn_limpiar = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_guardar = New FontAwesome.Sharp.IconButton()
        Me.pn_container.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.com_opest)
        Me.pn_container.Controls.Add(Me.btn_limpiar)
        Me.pn_container.Controls.Add(Me.btn_eliminar)
        Me.pn_container.Controls.Add(Me.btn_guardar)
        Me.pn_container.Controls.Add(Me.txt_descripcion)
        Me.pn_container.Controls.Add(Me.label5)
        Me.pn_container.Controls.Add(Me.label2)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(216, 561)
        Me.pn_container.TabIndex = 9
        '
        'com_opest
        '
        Me.com_opest.FormattingEnabled = True
        Me.com_opest.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.com_opest.Location = New System.Drawing.Point(29, 97)
        Me.com_opest.Name = "com_opest"
        Me.com_opest.Size = New System.Drawing.Size(165, 21)
        Me.com_opest.TabIndex = 20
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(29, 58)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(163, 20)
        Me.txt_descripcion.TabIndex = 15
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(26, 81)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Estado"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 42)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(66, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Descripcion:"
        '
        'lb_detusuario
        '
        Me.lb_detusuario.AutoSize = True
        Me.lb_detusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detusuario.Location = New System.Drawing.Point(12, 14)
        Me.lb_detusuario.Name = "lb_detusuario"
        Me.lb_detusuario.Size = New System.Drawing.Size(189, 22)
        Me.lb_detusuario.TabIndex = 0
        Me.lb_detusuario.Text = "Detalle de Categorias:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.txt_buscat)
        Me.Panel1.Controls.Add(Me.btn_descargarexcel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(229, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 66)
        Me.Panel1.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'txt_buscat
        '
        Me.txt_buscat.Location = New System.Drawing.Point(434, 23)
        Me.txt_buscat.Name = "txt_buscat"
        Me.txt_buscat.Size = New System.Drawing.Size(288, 20)
        Me.txt_buscat.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busacr por: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Listado de Categorias:"
        '
        'IconButton2
        '
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(763, 23)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 23)
        Me.IconButton2.TabIndex = 17
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.Location = New System.Drawing.Point(728, 23)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(29, 23)
        Me.IconButton1.TabIndex = 16
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'btn_descargarexcel
        '
        Me.btn_descargarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btn_descargarexcel.IconColor = System.Drawing.Color.Green
        Me.btn_descargarexcel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_descargarexcel.IconSize = 20
        Me.btn_descargarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_descargarexcel.Location = New System.Drawing.Point(7, 26)
        Me.btn_descargarexcel.Name = "btn_descargarexcel"
        Me.btn_descargarexcel.Size = New System.Drawing.Size(130, 28)
        Me.btn_descargarexcel.TabIndex = 14
        Me.btn_descargarexcel.Text = "Descargar Excel"
        Me.btn_descargarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_descargarexcel.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.btn_limpiar.IconColor = System.Drawing.Color.White
        Me.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_limpiar.IconSize = 25
        Me.btn_limpiar.Location = New System.Drawing.Point(29, 187)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(163, 35)
        Me.btn_limpiar.TabIndex = 18
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_eliminar.IconColor = System.Drawing.Color.White
        Me.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminar.IconSize = 25
        Me.btn_eliminar.Location = New System.Drawing.Point(28, 228)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.Text = "eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.btn_guardar.IconColor = System.Drawing.Color.White
        Me.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_guardar.IconSize = 25
        Me.btn_guardar.Location = New System.Drawing.Point(28, 146)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardar.TabIndex = 16
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'frm_categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pn_container)
        Me.MaximumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "frm_categorias"
        Me.Text = "frm_categorias"
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pn_container As Panel
    Private WithEvents com_opest As ComboBox
    Private WithEvents btn_limpiar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_guardar As FontAwesome.Sharp.IconButton
    Private WithEvents txt_descripcion As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label2 As Label
    Private WithEvents lb_detusuario As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_buscat As TextBox
    Friend WithEvents btn_descargarexcel As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
