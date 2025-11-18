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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarea).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 191, 205);
            panel1.Controls.Add(labelBeatrix);
            panel1.Controls.Add(btnReunion);
            panel1.Controls.Add(btnTareas);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnProyectos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 681);
            panel1.TabIndex = 7;
            // 
            // labelBeatrix
            // 
            labelBeatrix.AutoSize = true;
            labelBeatrix.Font = new Font("Montserrat Black", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeatrix.ForeColor = Color.Transparent;
            labelBeatrix.Location = new Point(12, 26);
            labelBeatrix.Name = "labelBeatrix";
            labelBeatrix.Size = new Size(112, 38);
            labelBeatrix.TabIndex = 5;
            labelBeatrix.Text = "Beatrix";
            // 
            // btnReunion
            // 
            btnReunion.BackColor = Color.FromArgb(41, 191, 205);
            btnReunion.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReunion.ForeColor = SystemColors.ButtonHighlight;
            btnReunion.Location = new Point(12, 437);
            btnReunion.Margin = new Padding(3, 2, 3, 2);
            btnReunion.Name = "btnReunion";
            btnReunion.Size = new Size(186, 53);
            btnReunion.TabIndex = 4;
            btnReunion.Text = "Reuniones";
            btnReunion.UseVisualStyleBackColor = false;
            btnReunion.Click += btnReunion_Click_1;
            // 
            // btnTareas
            // 
            btnTareas.BackColor = Color.FromArgb(41, 191, 205);
            btnTareas.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTareas.ForeColor = Color.White;
            btnTareas.Location = new Point(12, 380);
            btnTareas.Margin = new Padding(3, 2, 3, 2);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(186, 53);
            btnTareas.TabIndex = 3;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = false;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 191, 205);
            btnInicio.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(12, 266);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 53);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.BackColor = Color.FromArgb(41, 191, 205);
            btnProyectos.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.ForeColor = Color.White;
            btnProyectos.Location = new Point(12, 323);
            btnProyectos.Margin = new Padding(3, 2, 3, 2);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(186, 53);
            btnProyectos.TabIndex = 2;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(41, 191, 205);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(457, 21);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 31);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button1_Click;
            // 
            // txtBuscarProyecto
            // 
            txtBuscarProyecto.BackColor = Color.FromArgb(224, 224, 224);
            txtBuscarProyecto.Location = new Point(266, 26);
            txtBuscarProyecto.Name = "txtBuscarProyecto";
            txtBuscarProyecto.Size = new Size(185, 23);
            txtBuscarProyecto.TabIndex = 9;
            // 
            // dataGridViewTarea
            // 
            dataGridViewTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTarea.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTarea.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTarea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarea.Columns.AddRange(new DataGridViewColumn[] { Column1, ColumnUsuario, Column2 });
            dataGridViewTarea.GridColor = SystemColors.Control;
            dataGridViewTarea.Location = new Point(266, 183);
            dataGridViewTarea.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTarea.Name = "dataGridViewTarea";
            dataGridViewTarea.ReadOnly = true;
            dataGridViewTarea.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTarea.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarea.Size = new Size(973, 435);
            dataGridViewTarea.TabIndex = 18;
            dataGridViewTarea.CellContentClick += dataGridViewTarea_CellContentClick;
            dataGridViewTarea.CellDoubleClick += dataGridViewTarea_CellDoubleClick;
            dataGridViewTarea.SelectionChanged += dataGridViewTarea_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
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
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(245, 168, 125);
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(457, 121);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(185, 42);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 191, 205);
            button4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(266, 121);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(185, 42);
            button4.TabIndex = 19;
            button4.Text = "+ Crear Proyecto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat ExtraBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(1113, 21);
            label1.Name = "label1";
            label1.Size = new Size(126, 33);
            label1.TabIndex = 20;
            label1.Text = "Proyectos";
            // 
            // FormProyectosGerard1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridViewTarea);
            Controls.Add(txtBuscarProyecto);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Name = "FormProyectosGerard1";
            Text = "FormProyectosGerard1";
            Load += FormProyectosGerard1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}