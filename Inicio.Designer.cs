namespace Beatrix_Formulario
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
           
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            ColumnTarea = new DataGridViewTextBoxColumn();
            ColumnEspecificaciones = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            monthCalendar = new MonthCalendar();
            comboBoxProyecto = new ComboBox();
            panelBarraOpciones = new Panel();
            labelBeatrix = new Label();
            btnReuniones = new Button();
            btnTareas = new Button();
            buttonProyetos = new Button();
            buttonInicio = new Button();
            dgvReuniones = new DataGridView();
            ColumnTitulo = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnUsuarios = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            dgvTarea = new DataGridView();
            panelBarraOpciones.SuspendLayout();
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
            panelBarraOpciones.Controls.Add(labelBeatrix);
            panelBarraOpciones.Controls.Add(btnReuniones);
            panelBarraOpciones.Controls.Add(btnTareas);
            panelBarraOpciones.Controls.Add(buttonProyetos);
            panelBarraOpciones.Controls.Add(buttonInicio);
            panelBarraOpciones.Dock = DockStyle.Left;
            panelBarraOpciones.Location = new Point(0, 0);
            panelBarraOpciones.Margin = new Padding(3, 4, 3, 4);
            panelBarraOpciones.Name = "panelBarraOpciones";
            panelBarraOpciones.Size = new Size(250, 673);
            panelBarraOpciones.TabIndex = 14;
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
            btnReuniones.Location = new Point(14, 567);
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
            btnTareas.Location = new Point(14, 488);
            btnTareas.Margin = new Padding(3, 4, 3, 4);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(213, 71);
            btnTareas.TabIndex = 2;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // buttonProyetos
            // 
            buttonProyetos.BackColor = Color.FromArgb(41, 195, 205);
            buttonProyetos.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProyetos.ForeColor = Color.White;
            buttonProyetos.Location = new Point(14, 409);
            buttonProyetos.Margin = new Padding(3, 4, 3, 4);
            buttonProyetos.Name = "buttonProyetos";
            buttonProyetos.Size = new Size(213, 71);
            buttonProyetos.TabIndex = 1;
            buttonProyetos.Text = "Proyectos";
            buttonProyetos.UseVisualStyleBackColor = false;
            buttonProyetos.Click += buttonProyetos_Click;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(41, 195, 205);
            buttonInicio.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInicio.ForeColor = Color.White;
            buttonInicio.Location = new Point(14, 331);
            buttonInicio.Margin = new Padding(3, 4, 3, 4);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(213, 71);
            buttonInicio.TabIndex = 0;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
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
            dataGridViewCellStyle1.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReuniones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReuniones.Columns.AddRange(new DataGridViewColumn[] { ColumnTitulo, ColumnFecha, ColumnUsuarios, ColumnDescripcion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReuniones.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Font = new Font("Montserrat", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTarea.ColumnHeadersHeight = 50;
            dgvTarea.Columns.AddRange(new DataGridViewColumn[] { ColumnTarea, ColumnEspecificaciones, ColumnUsuario });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTarea.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTarea.GridColor = Color.White;
            dgvTarea.Location = new Point(273, 54);
            dgvTarea.Name = "dgvTarea";
            dgvTarea.ReadOnly = true;
            dgvTarea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 9F);
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
            dgvTarea.Size = new Size(965, 281);
            dgvTarea.TabIndex = 10;
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReuniones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTarea).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Button buttonProyetos;
        private Button buttonInicio;
        private DataGridView dgvReuniones;
        private DataGridViewTextBoxColumn ColumnTitulo;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnUsuarios;
        private DataGridViewTextBoxColumn ColumnDescripcion;
    }
}