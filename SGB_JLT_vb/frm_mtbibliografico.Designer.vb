<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mtbibliografico
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.txt_buscat = New System.Windows.Forms.TextBox()
        Me.btn_descargarexcel = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pn_container = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lb_categoria = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.lb_descripcion = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lb_nombre = New System.Windows.Forms.Label()
        Me.com_opest = New System.Windows.Forms.ComboBox()
        Me.btn_limpiar = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_guardar = New FontAwesome.Sharp.IconButton()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.label_estado = New System.Windows.Forms.Label()
        Me.lb_codigo = New System.Windows.Forms.Label()
        Me.lb_detusuario = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pn_container.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(279, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 66)
        Me.Panel1.TabIndex = 20
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
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
        'txt_buscat
        '
        Me.txt_buscat.Location = New System.Drawing.Point(434, 23)
        Me.txt_buscat.Name = "txt_buscat"
        Me.txt_buscat.Size = New System.Drawing.Size(288, 20)
        Me.txt_buscat.TabIndex = 14
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
        Me.Label6.Size = New System.Drawing.Size(245, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Listado de M.Bibliografico:"
        '
        'pn_container
        '
        Me.pn_container.BackColor = System.Drawing.Color.White
        Me.pn_container.Controls.Add(Me.ComboBox2)
        Me.pn_container.Controls.Add(Me.lb_categoria)
        Me.pn_container.Controls.Add(Me.txt_descripcion)
        Me.pn_container.Controls.Add(Me.lb_descripcion)
        Me.pn_container.Controls.Add(Me.txt_nombre)
        Me.pn_container.Controls.Add(Me.lb_nombre)
        Me.pn_container.Controls.Add(Me.com_opest)
        Me.pn_container.Controls.Add(Me.btn_limpiar)
        Me.pn_container.Controls.Add(Me.btn_eliminar)
        Me.pn_container.Controls.Add(Me.btn_guardar)
        Me.pn_container.Controls.Add(Me.txt_codigo)
        Me.pn_container.Controls.Add(Me.label_estado)
        Me.pn_container.Controls.Add(Me.lb_codigo)
        Me.pn_container.Controls.Add(Me.lb_detusuario)
        Me.pn_container.Dock = System.Windows.Forms.DockStyle.Left
        Me.pn_container.Location = New System.Drawing.Point(0, 0)
        Me.pn_container.Name = "pn_container"
        Me.pn_container.Size = New System.Drawing.Size(239, 561)
        Me.pn_container.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(28, 175)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox2.TabIndex = 25
        '
        'lb_categoria
        '
        Me.lb_categoria.AutoSize = True
        Me.lb_categoria.Location = New System.Drawing.Point(25, 159)
        Me.lb_categoria.Name = "lb_categoria"
        Me.lb_categoria.Size = New System.Drawing.Size(52, 13)
        Me.lb_categoria.TabIndex = 24
        Me.lb_categoria.Text = "Categoria"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(30, 136)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(163, 20)
        Me.txt_descripcion.TabIndex = 23
        '
        'lb_descripcion
        '
        Me.lb_descripcion.AutoSize = True
        Me.lb_descripcion.Location = New System.Drawing.Point(26, 120)
        Me.lb_descripcion.Name = "lb_descripcion"
        Me.lb_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lb_descripcion.TabIndex = 22
        Me.lb_descripcion.Text = "Descripcion"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(30, 97)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(163, 20)
        Me.txt_nombre.TabIndex = 21
        '
        'lb_nombre
        '
        Me.lb_nombre.AutoSize = True
        Me.lb_nombre.Location = New System.Drawing.Point(27, 81)
        Me.lb_nombre.Name = "lb_nombre"
        Me.lb_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lb_nombre.TabIndex = 20
        Me.lb_nombre.Text = "Nombre"
        '
        'com_opest
        '
        Me.com_opest.FormattingEnabled = True
        Me.com_opest.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.com_opest.Location = New System.Drawing.Point(28, 215)
        Me.com_opest.Name = "com_opest"
        Me.com_opest.Size = New System.Drawing.Size(165, 21)
        Me.com_opest.TabIndex = 19
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_limpiar.ForeColor = System.Drawing.Color.White
        Me.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical
        Me.btn_limpiar.IconColor = System.Drawing.Color.White
        Me.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_limpiar.IconSize = 25
        Me.btn_limpiar.Location = New System.Drawing.Point(27, 309)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(26, 350)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(163, 35)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.Text = "Eliminar"
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
        Me.btn_guardar.Location = New System.Drawing.Point(26, 268)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(163, 35)
        Me.btn_guardar.TabIndex = 16
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(29, 58)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(163, 20)
        Me.txt_codigo.TabIndex = 15
        '
        'label_estado
        '
        Me.label_estado.AutoSize = True
        Me.label_estado.Location = New System.Drawing.Point(27, 199)
        Me.label_estado.Name = "label_estado"
        Me.label_estado.Size = New System.Drawing.Size(40, 13)
        Me.label_estado.TabIndex = 12
        Me.label_estado.Text = "Estado"
        '
        'lb_codigo
        '
        Me.lb_codigo.AutoSize = True
        Me.lb_codigo.Location = New System.Drawing.Point(27, 42)
        Me.lb_codigo.Name = "lb_codigo"
        Me.lb_codigo.Size = New System.Drawing.Size(43, 13)
        Me.lb_codigo.TabIndex = 10
        Me.lb_codigo.Text = "Codigo:"
        '
        'lb_detusuario
        '
        Me.lb_detusuario.AutoSize = True
        Me.lb_detusuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detusuario.Location = New System.Drawing.Point(3, 9)
        Me.lb_detusuario.Name = "lb_detusuario"
        Me.lb_detusuario.Size = New System.Drawing.Size(233, 22)
        Me.lb_detusuario.TabIndex = 0
        Me.lb_detusuario.Text = "Detalle del M.Bibliografico:"
        '
        'frm_mtbibliografico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 561)
        Me.Controls.Add(Me.pn_container)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1150, 600)
        Me.Name = "frm_mtbibliografico"
        Me.Text = "frm_mtbibliografico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pn_container.ResumeLayout(False)
        Me.pn_container.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Panel1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_buscat As TextBox
    Friend WithEvents btn_descargarexcel As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents pn_container As Panel
    Private WithEvents ComboBox2 As ComboBox
    Private WithEvents lb_categoria As Label
    Private WithEvents txt_descripcion As TextBox
    Private WithEvents lb_descripcion As Label
    Private WithEvents txt_nombre As TextBox
    Private WithEvents lb_nombre As Label
    Private WithEvents com_opest As ComboBox
    Private WithEvents btn_limpiar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Private WithEvents btn_guardar As FontAwesome.Sharp.IconButton
    Private WithEvents txt_codigo As TextBox
    Private WithEvents label_estado As Label
    Private WithEvents lb_codigo As Label
    Private WithEvents lb_detusuario As Label
End Class
