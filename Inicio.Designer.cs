namespace Beatrix_Formulario
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private MonthCalendar monthCalendar;
        private ComboBox comboBoxProyecto;
        private DataGridView dgvTarea;
        private DataGridViewTextBoxColumn ColumnTarea;
        private DataGridViewTextBoxColumn ColumnEspecificaciones;
        private DataGridViewTextBoxColumn ColumnUsuario;
        private Panel panelBarraOpciones;
        private Label labelBeatrix;
        private Button btnReuniones;
        private Button btnTareas;
        private Button btnProyetos;
        private Button btnInicio;
        private DataGridView dgvReuniones;
        private DataGridViewTextBoxColumn ColumnTitulo;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnUsuarios;
        private DataGridViewTextBoxColumn ColumnDescripcion;

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
   
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            ColumnTarea = new DataGridViewTextBoxColumn();
            ColumnEspecificaciones = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            monthCalendar = new MonthCalendar();
            comboBoxProyecto = new ComboBox();
            panelBarraOpciones = new Panel();
            pbUser = new PictureBox();
            labelBeatrix = new Label();
            btnReuniones = new Button();
            btnTareas = new Button();
            btnProyetos = new Button();
            btnInicio = new Button();
            dgvReuniones = new DataGridView();
            ColumnTitulo = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnUsuarios = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            btnConfiguracion = new Button();
            dgvTarea = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            panelBarraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReuniones).BeginInit();
            SuspendLayout();
            // 
            // dgvTarea
            // 
            dgvTarea.AllowUserToResizeColumns = false;
            dgvTarea.AllowUserToResizeRows = false;
            dgvTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTarea.BackgroundColor = Color.White;
            dgvTarea.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvTarea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle13.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvTarea.ColumnHeadersHeight = 50;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { ColumnTarea, ColumnEspecificaciones, ColumnUsuario });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvTarea.DefaultCellStyle = dataGridViewCellStyle14;
            dgvTarea.GridColor = Color.White;
            dgvTarea.Location = new Point(273, 54);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvTarea.RowHeadersVisible = false;
            dgvTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTarea.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvTarea.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTarea.RowTemplate.Height = 50;
            dgvTarea.Size = new Size(965, 281);
            dgvTarea.TabIndex = 10;
            // 
            // ColumnTarea
            // 
            ColumnTarea.HeaderText = "Tarea";
            ColumnTarea.MinimumWidth = 6;
            ColumnTarea.Name = "ColumnTarea";
            ColumnTarea.ReadOnly = true;
            // 
            // ColumnEspecificaciones
            // 
            ColumnEspecificaciones.HeaderText = "Especificaciones";
            ColumnEspecificaciones.MinimumWidth = 6;
            ColumnEspecificaciones.Name = "ColumnEspecificaciones";
            ColumnEspecificaciones.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuario/s";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(273, 396);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 6;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // comboBoxProyecto
            // 
            comboBoxProyecto.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxProyecto.FormattingEnabled = true;
            comboBoxProyecto.Items.AddRange(new object[] { "Proyecto 1", "Proyecto 2", "Proyecto 3" });
            comboBoxProyecto.Location = new Point(273, 12);
            comboBoxProyecto.Name = "comboBoxProyecto";
            comboBoxProyecto.Size = new Size(151, 32);
            comboBoxProyecto.TabIndex = 7;
            comboBoxProyecto.Text = "Proyecto 1";
            comboBoxProyecto.SelectedIndexChanged += comboBoxProyecto_SelectedIndexChanged;
            // 
            // panelBarraOpciones
            // 
            panelBarraOpciones.BackColor = Color.FromArgb(41, 195, 205);
            panelBarraOpciones.Controls.Add(btnConfiguracion);
            panelBarraOpciones.Controls.Add(pbUser);
            panelBarraOpciones.Controls.Add(labelBeatrix);
            panelBarraOpciones.Controls.Add(btnReuniones);
            panelBarraOpciones.Controls.Add(btnTareas);
            panelBarraOpciones.Controls.Add(btnProyetos);
            panelBarraOpciones.Controls.Add(btnInicio);
            panelBarraOpciones.Dock = DockStyle.Left;
            panelBarraOpciones.Location = new Point(0, 0);
            panelBarraOpciones.Margin = new Padding(3, 4, 3, 4);
            panelBarraOpciones.Name = "panelBarraOpciones";
            panelBarraOpciones.Size = new Size(250, 673);
            panelBarraOpciones.TabIndex = 14;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.usuario;
            pbUser.Location = new Point(50, 95);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(146, 143);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 5;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // labelBeatrix
            // 
            labelBeatrix.AutoSize = true;
            labelBeatrix.Font = new Font("Montserrat Black", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeatrix.ForeColor = Color.Transparent;
            labelBeatrix.Location = new Point(14, 24);
            labelBeatrix.Name = "labelBeatrix";
            labelBeatrix.Size = new Size(139, 47);
            labelBeatrix.TabIndex = 4;
            labelBeatrix.Text = "Beatrix";
            // 
            // btnReuniones
            // 
            btnReuniones.BackColor = Color.FromArgb(41, 195, 205);
            btnReuniones.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReuniones.ForeColor = Color.White;
            btnReuniones.Location = new Point(14, 500);
            btnReuniones.Margin = new Padding(3, 4, 3, 4);
            btnReuniones.Name = "btnReuniones";
            btnReuniones.Size = new Size(213, 71);
            btnReuniones.TabIndex = 3;
            btnReuniones.Text = "Reuniones";
            btnReuniones.UseVisualStyleBackColor = false;
            btnReuniones.Click += btnReuniones_Click;
            // 
            // btnTareas
            // 
            btnTareas.BackColor = Color.FromArgb(41, 195, 205);
            btnTareas.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTareas.ForeColor = Color.White;
            btnTareas.Location = new Point(14, 421);
            btnTareas.Margin = new Padding(3, 4, 3, 4);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(213, 71);
            btnTareas.TabIndex = 2;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnProyetos
            // 
            btnProyetos.BackColor = Color.FromArgb(41, 195, 205);
            btnProyetos.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyetos.ForeColor = Color.White;
            btnProyetos.Location = new Point(14, 342);
            btnProyetos.Margin = new Padding(3, 4, 3, 4);
            btnProyetos.Name = "btnProyetos";
            btnProyetos.Size = new Size(213, 71);
            btnProyetos.TabIndex = 1;
            btnProyetos.Text = "Proyectos";
            btnProyetos.UseVisualStyleBackColor = false;
            btnProyetos.Click += buttonProyetos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 195, 205);
            btnInicio.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(14, 264);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(213, 71);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += buttonInicio_Click;
            // 
            // dgvReuniones
            // 
            dgvReuniones.AllowUserToAddRows = false;
            dgvReuniones.AllowUserToDeleteRows = false;
            dgvReuniones.AllowUserToResizeColumns = false;
            dgvReuniones.AllowUserToResizeRows = false;
            dgvReuniones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReuniones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReuniones.BackgroundColor = Color.FromArgb(41, 195, 205);
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvReuniones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReuniones.Columns.AddRange(new DataGridViewColumn[] { ColumnTitulo, ColumnFecha, ColumnUsuarios, ColumnDescripcion });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvReuniones.DefaultCellStyle = dataGridViewCellStyle18;
            dgvReuniones.Location = new Point(524, 372);
            dgvReuniones.Name = "dgvReuniones";
            dgvReuniones.RowHeadersVisible = false;
            dgvReuniones.RowHeadersWidth = 51;
            dgvReuniones.Size = new Size(714, 266);
            dgvReuniones.TabIndex = 15;
            // 
            // ColumnTitulo
            // 
            ColumnTitulo.HeaderText = "Tarea";
            ColumnTitulo.MinimumWidth = 6;
            ColumnTitulo.Name = "ColumnTitulo";
            ColumnTitulo.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.MinimumWidth = 6;
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            // 
            // ColumnUsuarios
            // 
            ColumnUsuarios.HeaderText = "Usuarios";
            ColumnUsuarios.MinimumWidth = 6;
            ColumnUsuarios.Name = "ColumnUsuarios";
            ColumnUsuarios.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.HeaderText = "Descripción";
            ColumnDescripcion.MinimumWidth = 6;
            ColumnDescripcion.Name = "ColumnDescripcion";
            ColumnDescripcion.ReadOnly = true;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(41, 195, 205);
            btnConfiguracion.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Location = new Point(14, 579);
            btnConfiguracion.Margin = new Padding(3, 4, 3, 4);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(213, 71);
            btnConfiguracion.TabIndex = 8;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvReuniones);
            Controls.Add(panelBarraOpciones);
            Controls.Add(dgvTarea);
            Controls.Add(comboBoxProyecto);
            Controls.Add(monthCalendar);
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReuniones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbUser;
        private Button btnConfiguracion;
    }
}