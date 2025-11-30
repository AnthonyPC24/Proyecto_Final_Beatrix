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
            labelTituloProyecto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloProyecto.Location = new Point(177, 69);
            labelTituloProyecto.Name = "labelTituloProyecto";
            labelTituloProyecto.Size = new Size(566, 40);
            labelTituloProyecto.TabIndex = 1;
            labelTituloProyecto.Text = "label1";
            labelTituloProyecto.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            label1.Location = new Point(177, 159);
            label1.Name = "label1";
            label1.Size = new Size(161, 24);
            label1.TabIndex = 3;
            label1.Text = "Fecha de Inicio:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblFechaInicio.Location = new Point(331, 159);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(66, 24);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "label2";
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            lblFechaEntrega.Location = new Point(680, 159);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(66, 24);
            lblFechaEntrega.TabIndex = 6;
            lblFechaEntrega.Text = "label2";
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            labelFechaEntrega.Location = new Point(505, 159);
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(184, 24);
            labelFechaEntrega.TabIndex = 5;
            labelFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // labelUsuarios
            // 
            labelUsuarios.AutoSize = true;
            labelUsuarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelUsuarios.Location = new Point(177, 241);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(235, 25);
            labelUsuarios.TabIndex = 7;
            labelUsuarios.Text = "Usuarios Participantes:";
            // 
            // txtUsuariosAsignados
            // 
            txtUsuariosAsignados.Location = new Point(414, 244);
            txtUsuariosAsignados.Margin = new Padding(3, 4, 3, 4);
            txtUsuariosAsignados.Multiline = true;
            txtUsuariosAsignados.Name = "txtUsuariosAsignados";
            txtUsuariosAsignados.ReadOnly = true;
            txtUsuariosAsignados.Size = new Size(329, 29);
            txtUsuariosAsignados.TabIndex = 8;
            txtUsuariosAsignados.TextChanged += txtUsuariosAsignados_TextChanged;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDescripcion.Location = new Point(177, 311);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(132, 25);
            labelDescripcion.TabIndex = 9;
            labelDescripcion.Text = "Descripcion:";
            labelDescripcion.Click += labelDescripcion_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(402, 540);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(86, 31);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtBoxDescr
            // 
            txtBoxDescr.Location = new Point(312, 311);
            txtBoxDescr.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescr.Multiline = true;
            txtBoxDescr.Name = "txtBoxDescr";
            txtBoxDescr.ReadOnly = true;
            txtBoxDescr.Size = new Size(430, 184);
            txtBoxDescr.TabIndex = 12;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(522, 540);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 13;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // FormProyectosGerard3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProyectosGerard3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
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