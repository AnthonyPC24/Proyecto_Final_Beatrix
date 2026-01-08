namespace Beatrix_Formulario
{
    partial class FormProyectosGerard3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyectosGerard3));
            labelTituloProyecto = new Label();
            label1 = new Label();
            lblFechaInicio = new Label();
            lblFechaEntrega = new Label();
            labelFechaEntrega = new Label();
            labelUsuarios = new Label();
            txtUsuariosAsignados = new TextBox();
            labelDescripcion = new Label();
            btnCerrar = new Button();
            txtBoxDescr = new TextBox();
            buttonEditar = new Button();
            SuspendLayout();
            // 
            // labelTituloProyecto
            // 
            labelTituloProyecto.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic);
            labelTituloProyecto.ForeColor = Color.White;
            labelTituloProyecto.Location = new Point(10, 23);
            labelTituloProyecto.Name = "labelTituloProyecto";
            labelTituloProyecto.Size = new Size(495, 30);
            labelTituloProyecto.TabIndex = 1;
            labelTituloProyecto.Text = "label1";
            labelTituloProyecto.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 91);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 3;
            label1.Text = "Fecha de Inicio:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblFechaInicio.Location = new Point(157, 93);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(52, 17);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "label2";
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblFechaEntrega.Location = new Point(434, 94);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(52, 17);
            lblFechaEntrega.TabIndex = 6;
            lblFechaEntrega.Text = "label2";
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            labelFechaEntrega.ForeColor = Color.White;
            labelFechaEntrega.Location = new Point(268, 91);
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(145, 18);
            labelFechaEntrega.TabIndex = 5;
            labelFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // labelUsuarios
            // 
            labelUsuarios.AutoSize = true;
            labelUsuarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelUsuarios.ForeColor = Color.White;
            labelUsuarios.Location = new Point(10, 128);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(195, 20);
            labelUsuarios.TabIndex = 7;
            labelUsuarios.Text = "Usuarios Participantes:";
            // 
            // txtUsuariosAsignados
            // 
            txtUsuariosAsignados.Location = new Point(217, 124);
            txtUsuariosAsignados.Multiline = true;
            txtUsuariosAsignados.Name = "txtUsuariosAsignados";
            txtUsuariosAsignados.ReadOnly = true;
            txtUsuariosAsignados.Size = new Size(288, 23);
            txtUsuariosAsignados.TabIndex = 8;
            txtUsuariosAsignados.TextChanged += txtUsuariosAsignados_TextChanged;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDescripcion.ForeColor = Color.White;
            labelDescripcion.Location = new Point(11, 167);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(108, 20);
            labelDescripcion.TabIndex = 9;
            labelDescripcion.Text = "Descripcion:";
            labelDescripcion.Click += labelDescripcion_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(245, 168, 125);
            btnCerrar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(291, 311);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(104, 23);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtBoxDescr
            // 
            txtBoxDescr.Location = new Point(130, 167);
            txtBoxDescr.Multiline = true;
            txtBoxDescr.Name = "txtBoxDescr";
            txtBoxDescr.ReadOnly = true;
            txtBoxDescr.Size = new Size(377, 139);
            txtBoxDescr.TabIndex = 12;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(41, 195, 205);
            buttonEditar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(401, 311);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(104, 23);
            buttonEditar.TabIndex = 13;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // FormProyectosGerard3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(528, 346);
            Controls.Add(buttonEditar);
            Controls.Add(txtBoxDescr);
            Controls.Add(btnCerrar);
            Controls.Add(labelDescripcion);
            Controls.Add(txtUsuariosAsignados);
            Controls.Add(labelUsuarios);
            Controls.Add(lblFechaEntrega);
            Controls.Add(labelFechaEntrega);
            Controls.Add(lblFechaInicio);
            Controls.Add(label1);
            Controls.Add(labelTituloProyecto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProyectosGerard3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto";
            Load += FormProyectosGerard3_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTituloProyecto;
        private Label label1;
        private Label lblFechaInicio;
        private Label lblFechaEntrega;
        private Label labelFechaEntrega;
        private Label labelUsuarios;
        private TextBox txtUsuariosAsignados;
        private Label labelDescripcion;
        private Button btnCerrar;
        private TextBox txtBoxDescr;
        private Button buttonEditar;
    }
}