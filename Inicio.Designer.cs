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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
 
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            ColumnTarea = new DataGridViewTextBoxColumn();
            ColumnEspecificaciones = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            monthCalendar = new MonthCalendar();
            comboBoxProyecto = new ComboBox();
            panelBarraOpciones = new Panel();
            Logo = new PictureBox();
            linkLabel1 = new LinkLabel();
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
            dgvTarea = new DataGridView();
            panelBarraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReuniones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).BeginInit();
            SuspendLayout();
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
            monthCalendar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(239, 297);
            monthCalendar.Margin = new Padding(8, 7, 8, 7);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 6;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // comboBoxProyecto
            // 
            comboBoxProyecto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxProyecto.FormattingEnabled = true;
            comboBoxProyecto.Items.AddRange(new object[] { "Proyecto 1", "Proyecto 2", "Proyecto 3" });
            comboBoxProyecto.Location = new Point(239, 9);
            comboBoxProyecto.Margin = new Padding(3, 2, 3, 2);
            comboBoxProyecto.Name = "comboBoxProyecto";
            comboBoxProyecto.Size = new Size(133, 23);
            comboBoxProyecto.TabIndex = 7;
            comboBoxProyecto.Text = "Proyecto 1";
            comboBoxProyecto.SelectedIndexChanged += comboBoxProyecto_SelectedIndexChanged;
            // 
            // panelBarraOpciones
            // 
            panelBarraOpciones.BackColor = Color.FromArgb(41, 195, 205);
            panelBarraOpciones.Controls.Add(Logo);
            panelBarraOpciones.Controls.Add(linkLabel1);
            panelBarraOpciones.Controls.Add(labelBeatrix);
            panelBarraOpciones.Controls.Add(btnReuniones);
            panelBarraOpciones.Controls.Add(btnTareas);
            panelBarraOpciones.Controls.Add(btnProyetos);
            panelBarraOpciones.Controls.Add(btnInicio);
            panelBarraOpciones.Dock = DockStyle.Left;
            panelBarraOpciones.Location = new Point(0, 0);
            panelBarraOpciones.Name = "panelBarraOpciones";
            panelBarraOpciones.Size = new Size(219, 505);
            panelBarraOpciones.TabIndex = 14;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(36, 58);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(144, 120);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 10;
            Logo.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(245, 168, 125);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = SystemColors.ControlLightLight;
            linkLabel1.Location = new Point(44, 460);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Configuración";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // labelBeatrix
            // 
            labelBeatrix.AutoSize = true;
            labelBeatrix.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeatrix.ForeColor = Color.Transparent;
            labelBeatrix.Location = new Point(12, 18);
            labelBeatrix.Name = "labelBeatrix";
            labelBeatrix.Size = new Size(94, 29);
            labelBeatrix.TabIndex = 4;
            labelBeatrix.Text = "Beatrix";
            // 
            // btnReuniones
            // 
            btnReuniones.BackColor = Color.FromArgb(41, 195, 205);
            btnReuniones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnReuniones.ForeColor = Color.White;
            btnReuniones.Location = new Point(12, 375);
            btnReuniones.Name = "btnReuniones";
            btnReuniones.Size = new Size(186, 53);
            btnReuniones.TabIndex = 3;
            btnReuniones.Text = "Reuniones";
            btnReuniones.UseVisualStyleBackColor = false;
            btnReuniones.Click += btnReuniones_Click;
            // 
            // btnTareas
            // 
            btnTareas.BackColor = Color.FromArgb(41, 195, 205);
            btnTareas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTareas.ForeColor = Color.White;
            btnTareas.Location = new Point(12, 316);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(186, 53);
            btnTareas.TabIndex = 2;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnProyetos
            // 
            btnProyetos.BackColor = Color.FromArgb(41, 195, 205);
            btnProyetos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnProyetos.ForeColor = Color.White;
            btnProyetos.Location = new Point(12, 256);
            btnProyetos.Name = "btnProyetos";
            btnProyetos.Size = new Size(186, 53);
            btnProyetos.TabIndex = 1;
            btnProyetos.Text = "Proyectos";
            btnProyetos.UseVisualStyleBackColor = false;
            btnProyetos.Click += buttonProyetos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 195, 205);
            btnInicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(12, 198);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 53);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReuniones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReuniones.Columns.AddRange(new DataGridViewColumn[] { ColumnTitulo, ColumnFecha, ColumnUsuarios, ColumnDescripcion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReuniones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReuniones.Location = new Point(458, 279);
            dgvReuniones.Margin = new Padding(3, 2, 3, 2);
            dgvReuniones.Name = "dgvReuniones";
            dgvReuniones.RowHeadersVisible = false;
            dgvReuniones.RowHeadersWidth = 51;
            dgvReuniones.Size = new Size(625, 200);
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
            // dgvTarea
            // 
            dgvTarea.AllowUserToResizeColumns = false;
            dgvTarea.AllowUserToResizeRows = false;
            dgvTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTarea.BackgroundColor = Color.White;
            dgvTarea.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvTarea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTarea.ColumnHeadersHeight = 50;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { ColumnTarea, ColumnEspecificaciones, ColumnUsuario });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTarea.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTarea.GridColor = Color.White;
            dgvTarea.Location = new Point(239, 40);
            dgvTarea.Margin = new Padding(3, 2, 3, 2);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTarea.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTarea.RowHeadersVisible = false;
            dgvTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTarea.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvTarea.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTarea.RowTemplate.Height = 50;
            dgvTarea.Size = new Size(844, 211);
            dgvTarea.TabIndex = 10;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1104, 505);
            Controls.Add(dgvReuniones);
            Controls.Add(panelBarraOpciones);
            Controls.Add(dgvTarea);
            Controls.Add(comboBoxProyecto);
            Controls.Add(monthCalendar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosing += Inicio_FormClosing;
            Load += Inicio_Load;
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReuniones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel linkLabel1;
        private PictureBox Logo;
    }
}