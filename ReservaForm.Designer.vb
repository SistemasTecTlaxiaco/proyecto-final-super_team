<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservaForm))
        Me.PanelLado = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReservadas = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.PanelArriba = New System.Windows.Forms.Panel()
        Me.LabelTop = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroHabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAbajo = New System.Windows.Forms.Panel()
        Me.lbMonto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.lbIDcliente = New System.Windows.Forms.Label()
        Me.btnCompletar = New System.Windows.Forms.Button()
        Me.lbNoHabitaciones = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbNoReserva = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelArriba.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelAbajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLado
        '
        Me.PanelLado.BackColor = System.Drawing.Color.SandyBrown
        Me.PanelLado.Controls.Add(Me.PictureBox1)
        Me.PanelLado.Controls.Add(Me.MonthCalendar1)
        Me.PanelLado.Controls.Add(Me.Label4)
        Me.PanelLado.Controls.Add(Me.btnReservadas)
        Me.PanelLado.Controls.Add(Me.ComboBox1)
        Me.PanelLado.Controls.Add(Me.btnReservar)
        Me.PanelLado.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLado.Location = New System.Drawing.Point(0, 0)
        Me.PanelLado.Name = "PanelLado"
        Me.PanelLado.Size = New System.Drawing.Size(301, 657)
        Me.PanelLado.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(31, 321)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tipo de habitación"
        '
        'btnReservadas
        '
        Me.btnReservadas.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnReservadas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReservadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservadas.Location = New System.Drawing.Point(12, 179)
        Me.btnReservadas.Name = "btnReservadas"
        Me.btnReservadas.Size = New System.Drawing.Size(266, 60)
        Me.btnReservadas.TabIndex = 12
        Me.btnReservadas.Text = "Habitaciones Seleccionadas"
        Me.btnReservadas.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SENCILLA", "DOBLE", "TRIPLE", "SUITE", "TODAS"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 283)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 26)
        Me.ComboBox1.TabIndex = 11
        '
        'btnReservar
        '
        Me.btnReservar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnReservar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservar.Location = New System.Drawing.Point(12, 113)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(266, 60)
        Me.btnReservar.TabIndex = 10
        Me.btnReservar.Text = "Reservar Habitación"
        Me.btnReservar.UseVisualStyleBackColor = False
        '
        'PanelArriba
        '
        Me.PanelArriba.BackColor = System.Drawing.Color.LightSalmon
        Me.PanelArriba.Controls.Add(Me.LabelTop)
        Me.PanelArriba.Controls.Add(Me.MenuStrip1)
        Me.PanelArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArriba.Location = New System.Drawing.Point(301, 0)
        Me.PanelArriba.Name = "PanelArriba"
        Me.PanelArriba.Size = New System.Drawing.Size(1058, 82)
        Me.PanelArriba.TabIndex = 1
        '
        'LabelTop
        '
        Me.LabelTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTop.AutoSize = True
        Me.LabelTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTop.Location = New System.Drawing.Point(377, 37)
        Me.LabelTop.Name = "LabelTop"
        Me.LabelTop.Size = New System.Drawing.Size(305, 29)
        Me.LabelTop.TabIndex = 1
        Me.LabelTop.Text = "Reserva de Habitaciones"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.ReservasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1058, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroClientesToolStripMenuItem, Me.RegistroHabitacionesToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'RegistroClientesToolStripMenuItem
        '
        Me.RegistroClientesToolStripMenuItem.Name = "RegistroClientesToolStripMenuItem"
        Me.RegistroClientesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RegistroClientesToolStripMenuItem.Text = "Registro clientes"
        '
        'RegistroHabitacionesToolStripMenuItem
        '
        Me.RegistroHabitacionesToolStripMenuItem.Name = "RegistroHabitacionesToolStripMenuItem"
        Me.RegistroHabitacionesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RegistroHabitacionesToolStripMenuItem.Text = "Registro Habitaciones"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarToolStripMenuItem})
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'GestionarToolStripMenuItem
        '
        Me.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem"
        Me.GestionarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.GestionarToolStripMenuItem.Text = "Gestionar"
        '
        'PanelAbajo
        '
        Me.PanelAbajo.BackColor = System.Drawing.Color.LightSalmon
        Me.PanelAbajo.Controls.Add(Me.lbMonto)
        Me.PanelAbajo.Controls.Add(Me.Label7)
        Me.PanelAbajo.Controls.Add(Me.btnCliente)
        Me.PanelAbajo.Controls.Add(Me.lbIDcliente)
        Me.PanelAbajo.Controls.Add(Me.btnCompletar)
        Me.PanelAbajo.Controls.Add(Me.lbNoHabitaciones)
        Me.PanelAbajo.Controls.Add(Me.Label5)
        Me.PanelAbajo.Controls.Add(Me.lbNoReserva)
        Me.PanelAbajo.Controls.Add(Me.Label3)
        Me.PanelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAbajo.Location = New System.Drawing.Point(301, 573)
        Me.PanelAbajo.Name = "PanelAbajo"
        Me.PanelAbajo.Size = New System.Drawing.Size(1058, 84)
        Me.PanelAbajo.TabIndex = 2
        '
        'lbMonto
        '
        Me.lbMonto.AutoSize = True
        Me.lbMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMonto.ForeColor = System.Drawing.Color.Red
        Me.lbMonto.Location = New System.Drawing.Point(404, 40)
        Me.lbMonto.Name = "lbMonto"
        Me.lbMonto.Size = New System.Drawing.Size(30, 31)
        Me.lbMonto.TabIndex = 18
        Me.lbMonto.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(212, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 31)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total a pagar:"
        '
        'btnCliente
        '
        Me.btnCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Location = New System.Drawing.Point(588, 13)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(227, 60)
        Me.btnCliente.TabIndex = 16
        Me.btnCliente.Text = "Seleccionar Cliente"
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'lbIDcliente
        '
        Me.lbIDcliente.AutoSize = True
        Me.lbIDcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIDcliente.Location = New System.Drawing.Point(548, 10)
        Me.lbIDcliente.Name = "lbIDcliente"
        Me.lbIDcliente.Size = New System.Drawing.Size(19, 20)
        Me.lbIDcliente.TabIndex = 15
        Me.lbIDcliente.Text = "0"
        Me.lbIDcliente.Visible = False
        '
        'btnCompletar
        '
        Me.btnCompletar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompletar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCompletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompletar.Location = New System.Drawing.Point(821, 13)
        Me.btnCompletar.Name = "btnCompletar"
        Me.btnCompletar.Size = New System.Drawing.Size(227, 60)
        Me.btnCompletar.TabIndex = 14
        Me.btnCompletar.Text = "Completar Reserva"
        Me.btnCompletar.UseVisualStyleBackColor = False
        '
        'lbNoHabitaciones
        '
        Me.lbNoHabitaciones.AutoSize = True
        Me.lbNoHabitaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNoHabitaciones.Location = New System.Drawing.Point(159, 50)
        Me.lbNoHabitaciones.Name = "lbNoHabitaciones"
        Me.lbNoHabitaciones.Size = New System.Drawing.Size(19, 20)
        Me.lbNoHabitaciones.TabIndex = 13
        Me.lbNoHabitaciones.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Seleccionadas"
        '
        'lbNoReserva
        '
        Me.lbNoReserva.AutoSize = True
        Me.lbNoReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNoReserva.Location = New System.Drawing.Point(159, 17)
        Me.lbNoReserva.Name = "lbNoReserva"
        Me.lbNoReserva.Size = New System.Drawing.Size(19, 20)
        Me.lbNoReserva.TabIndex = 11
        Me.lbNoReserva.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Reserva #"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(301, 82)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1058, 491)
        Me.PanelPrincipal.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'ReservaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 657)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.PanelAbajo)
        Me.Controls.Add(Me.PanelArriba)
        Me.Controls.Add(Me.PanelLado)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReservaForm"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLado.ResumeLayout(False)
        Me.PanelLado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelArriba.ResumeLayout(False)
        Me.PanelArriba.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelAbajo.ResumeLayout(False)
        Me.PanelAbajo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLado As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReservadas As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnReservar As Button
    Friend WithEvents PanelArriba As Panel
    Friend WithEvents PanelAbajo As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents LabelTop As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroHabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbMonto As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCliente As Button
    Friend WithEvents lbIDcliente As Label
    Friend WithEvents btnCompletar As Button
    Friend WithEvents lbNoHabitaciones As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbNoReserva As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
