namespace Beatrix_Formulario
{
    partial class FormProyectosGerard1
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Logo = new PictureBox();
            linkLabel1 = new LinkLabel();
            labelBeatrix = new Label();
            btnReunion = new Button();
            btnTareas = new Button();
            btnInicio = new Button();
            btnProyectos = new Button();
            btnBuscar = new Button();
            txtBuscarProyecto = new TextBox();
            dataGridViewTarea = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            button4 = new Button();
            label1 = new Label();
            buttonIdioma = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 191, 205);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(labelBeatrix);
            panel1.Controls.Add(btnReunion);
            panel1.Controls.Add(btnTareas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnProyectos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 908);
            panel1.TabIndex = 7;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(38, 106);
            Logo.Name = "Logo";
            Logo.Size = new Size(165, 160);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 8;
            Logo.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(245, 168, 125);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = SystemColors.ControlLightLight;
            linkLabel1.Location = new Point(47, 755);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Configuración";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // labelBeatrix
            // 
            labelBeatrix.AutoSize = true;
            labelBeatrix.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeatrix.ForeColor = Color.Transparent;
            labelBeatrix.Location = new Point(14, 24);
            labelBeatrix.Name = "labelBeatrix";
            labelBeatrix.Size = new Size(114, 36);
            labelBeatrix.TabIndex = 5;
            labelBeatrix.Text = "Beatrix";
            // 
            // btnReunion
            // 
            btnReunion.BackColor = Color.FromArgb(41, 191, 205);
            btnReunion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReunion.ForeColor = SystemColors.ButtonHighlight;
            btnReunion.Location = new Point(14, 583);
            btnReunion.Name = "btnReunion";
            btnReunion.Size = new Size(213, 71);
            btnReunion.TabIndex = 4;
            btnReunion.Text = "Reuniones";
            btnReunion.UseVisualStyleBackColor = false;
            btnReunion.Click += btnReunion_Click_1;
            // 
            // btnTareas
            // 
            btnTareas.BackColor = Color.FromArgb(41, 191, 205);
            btnTareas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTareas.ForeColor = Color.White;
            btnTareas.Location = new Point(14, 507);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(213, 71);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 191, 205);
            btnInicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(14, 355);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(213, 71);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.BackColor = Color.FromArgb(41, 191, 205);
            btnProyectos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.ForeColor = Color.White;
            btnProyectos.Location = new Point(14, 431);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(213, 71);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(41, 191, 205);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(522, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 41);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button1_Click;
            // 
            // txtBuscarProyecto
            // 
            txtBuscarProyecto.BackColor = Color.FromArgb(224, 224, 224);
            txtBuscarProyecto.Location = new Point(304, 35);
            txtBuscarProyecto.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProyecto.Name = "txtBuscarProyecto";
            txtBuscarProyecto.Size = new Size(211, 27);
            txtBuscarProyecto.TabIndex = 9;
            // 
            // dataGridViewTarea
            // 
            dataGridViewTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTarea.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTarea.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarea.Columns.AddRange(new DataGridViewColumn[] { Column1, ColumnUsuario, Column2 });
            dataGridViewTarea.GridColor = SystemColors.Control;
            dataGridViewTarea.Location = new Point(304, 244);
            dataGridViewTarea.Name = "dataGridViewTarea";
            dataGridViewTarea.ReadOnly = true;
            dataGridViewTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTarea.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarea.Size = new Size(1112, 580);
            dataGridViewTarea.TabIndex = 18;
            dataGridViewTarea.CellContentClick += dataGridViewTarea_CellContentClick;
            dataGridViewTarea.CellDoubleClick += dataGridViewTarea_CellDoubleClick;
            dataGridViewTarea.SelectionChanged += dataGridViewTarea_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuario/s";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha de Entrega";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(245, 168, 125);
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(522, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(211, 56);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 191, 205);
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(304, 161);
            button4.Name = "button4";
            button4.Size = new Size(211, 56);
            button4.TabIndex = 19;
            button4.Text = "+ Crear Proyecto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(1219, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 20;
            label1.Text = "Proyectos";
            // 
            // buttonIdioma
            // 
            buttonIdioma.BackgroundImage = Properties.Resources.mini_espana;
            buttonIdioma.BackgroundImageLayout = ImageLayout.Zoom;
            buttonIdioma.Cursor = Cursors.Hand;
            buttonIdioma.FlatAppearance.BorderSize = 0;
            buttonIdioma.FlatStyle = FlatStyle.Flat;
            buttonIdioma.Location = new Point(1370, 28);
            buttonIdioma.Margin = new Padding(3, 4, 3, 4);
            buttonIdioma.Name = "buttonIdioma";
            buttonIdioma.Size = new Size(46, 33);
            buttonIdioma.TabIndex = 21;
            buttonIdioma.UseVisualStyleBackColor = true;
            // 
            // FormProyectosGerard1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 908);
            Controls.Add(buttonIdioma);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridViewTarea);
            Controls.Add(txtBuscarProyecto);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProyectosGerard1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyectos";
            FormClosing += FormProyectosGerard1_FormClosing;
            Load += FormProyectosGerard1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnReunion;
        private Button btnTareas;
        private Button btnInicio;
        private Button btnProyectos;
        private Button btnBuscar;
        private TextBox txtBuscarProyecto;
        private DataGridView dataGridViewTarea;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnUsuario;
        private DataGridViewTextBoxColumn Column2;
        private Button btnEliminar;
        private Button button4;
        private Label labelBeatrix;
        private Label label1;
        private LinkLabel linkLabel1;
        private PictureBox Logo;
        private Button buttonIdioma;
    }
}