<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PartidaIni = New System.Windows.Forms.Button()
        Me.NewJugada = New System.Windows.Forms.Button()
        Me.FinPar = New System.Windows.Forms.Button()
        Me.CreditoIni = New System.Windows.Forms.TextBox()
        Me.HoraIni = New System.Windows.Forms.TextBox()
        Me.NumJuegos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrecioJugada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CreditoActual = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCombinacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartidasCombinacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New ladefi.Database1DataSet()
        Me.Partidas_CombinacionesTableAdapter = New ladefi.Database1DataSetTableAdapters.Partidas_CombinacionesTableAdapter()
        Me.NombreJugador = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartidasCombinacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PartidaIni
        '
        Me.PartidaIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PartidaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartidaIni.Location = New System.Drawing.Point(51, 468)
        Me.PartidaIni.Name = "PartidaIni"
        Me.PartidaIni.Size = New System.Drawing.Size(326, 77)
        Me.PartidaIni.TabIndex = 0
        Me.PartidaIni.Text = "IniciarPartida"
        Me.PartidaIni.UseVisualStyleBackColor = False
        '
        'NewJugada
        '
        Me.NewJugada.BackColor = System.Drawing.Color.LightGreen
        Me.NewJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewJugada.Location = New System.Drawing.Point(51, 88)
        Me.NewJugada.Name = "NewJugada"
        Me.NewJugada.Size = New System.Drawing.Size(717, 71)
        Me.NewJugada.TabIndex = 1
        Me.NewJugada.Text = "Nueva Jugada"
        Me.NewJugada.UseVisualStyleBackColor = False
        '
        'FinPar
        '
        Me.FinPar.BackColor = System.Drawing.Color.DarkKhaki
        Me.FinPar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinPar.Location = New System.Drawing.Point(417, 468)
        Me.FinPar.Name = "FinPar"
        Me.FinPar.Size = New System.Drawing.Size(345, 77)
        Me.FinPar.TabIndex = 2
        Me.FinPar.Text = "Finalizar Partida"
        Me.FinPar.UseVisualStyleBackColor = False
        '
        'CreditoIni
        '
        Me.CreditoIni.BackColor = System.Drawing.Color.Gray
        Me.CreditoIni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CreditoIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditoIni.ForeColor = System.Drawing.Color.Black
        Me.CreditoIni.Location = New System.Drawing.Point(51, 226)
        Me.CreditoIni.Name = "CreditoIni"
        Me.CreditoIni.Size = New System.Drawing.Size(326, 31)
        Me.CreditoIni.TabIndex = 3
        '
        'HoraIni
        '
        Me.HoraIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HoraIni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HoraIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraIni.Location = New System.Drawing.Point(587, 212)
        Me.HoraIni.Name = "HoraIni"
        Me.HoraIni.Size = New System.Drawing.Size(175, 31)
        Me.HoraIni.TabIndex = 4
        '
        'NumJuegos
        '
        Me.NumJuegos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NumJuegos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumJuegos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumJuegos.Location = New System.Drawing.Point(580, 403)
        Me.NumJuegos.Name = "NumJuegos"
        Me.NumJuegos.Size = New System.Drawing.Size(175, 31)
        Me.NumJuegos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Credito Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(714, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(583, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Juegos Realizados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(629, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio Partida"
        '
        'PrecioJugada
        '
        Me.PrecioJugada.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrecioJugada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrecioJugada.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioJugada.Location = New System.Drawing.Point(586, 300)
        Me.PrecioJugada.Name = "PrecioJugada"
        Me.PrecioJugada.Size = New System.Drawing.Size(175, 31)
        Me.PrecioJugada.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(46, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Credito Actual"
        '
        'CreditoActual
        '
        Me.CreditoActual.BackColor = System.Drawing.Color.Silver
        Me.CreditoActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CreditoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditoActual.Location = New System.Drawing.Point(51, 356)
        Me.CreditoActual.Name = "CreditoActual"
        Me.CreditoActual.Size = New System.Drawing.Size(326, 53)
        Me.CreditoActual.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdCombinacionDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PartidasCombinacionesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(904, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(424, 517)
        Me.DataGridView1.TabIndex = 14
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'IdCombinacionDataGridViewTextBoxColumn
        '
        Me.IdCombinacionDataGridViewTextBoxColumn.DataPropertyName = "IdCombinacion"
        Me.IdCombinacionDataGridViewTextBoxColumn.HeaderText = "IdCombinacion"
        Me.IdCombinacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCombinacionDataGridViewTextBoxColumn.Name = "IdCombinacionDataGridViewTextBoxColumn"
        Me.IdCombinacionDataGridViewTextBoxColumn.Width = 125
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.Width = 125
        '
        'PartidasCombinacionesBindingSource
        '
        Me.PartidasCombinacionesBindingSource.DataMember = "Partidas_Combinaciones"
        Me.PartidasCombinacionesBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Partidas_CombinacionesTableAdapter
        '
        Me.Partidas_CombinacionesTableAdapter.ClearBeforeFill = True
        '
        'NombreJugador
        '
        Me.NombreJugador.BackColor = System.Drawing.Color.Silver
        Me.NombreJugador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NombreJugador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreJugador.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NombreJugador.Location = New System.Drawing.Point(140, 26)
        Me.NombreJugador.Name = "NombreJugador"
        Me.NombreJugador.Size = New System.Drawing.Size(615, 23)
        Me.NombreJugador.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1367, 607)
        Me.Controls.Add(Me.NombreJugador)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CreditoActual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PrecioJugada)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumJuegos)
        Me.Controls.Add(Me.HoraIni)
        Me.Controls.Add(Me.CreditoIni)
        Me.Controls.Add(Me.FinPar)
        Me.Controls.Add(Me.NewJugada)
        Me.Controls.Add(Me.PartidaIni)
        Me.Name = "Form1"
        Me.Text = "Tragaperras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartidasCombinacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PartidaIni As Button
    Friend WithEvents NewJugada As Button
    Friend WithEvents FinPar As Button
    Friend WithEvents CreditoIni As TextBox
    Friend WithEvents HoraIni As TextBox
    Friend WithEvents NumJuegos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PrecioJugada As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CreditoActual As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PartidasCombinacionesBindingSource As BindingSource
    Friend WithEvents Partidas_CombinacionesTableAdapter As Database1DataSetTableAdapters.Partidas_CombinacionesTableAdapter
    Friend WithEvents NombreJugador As TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCombinacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
