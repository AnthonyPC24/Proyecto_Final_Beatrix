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
            lbltituloform = new Label();
            lblNombreProyecto = new Label();
            labelFechaInicio = new Label();
            label1 = new Label();
            lblFechaInicio = new Label();
            lblFechaEntrega = new Label();
            labelFechaEntrega = new Label();
            labelUsuarios = new Label();
            txtUsuariosAsignados = new TextBox();
            txtDescripcion = new TextBox();
            labelDescripcion = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lbltituloform
            // 
            lbltituloform.AutoSize = true;
            lbltituloform.Location = new Point(342, 35);
            lbltituloform.Name = "lbltituloform";
            lbltituloform.Size = new Size(117, 15);
            lbltituloform.TabIndex = 0;
            lbltituloform.Text = "Detalles del Proyecto";
            // 
            // lblNombreProyecto
            // 
            lblNombreProyecto.AutoSize = true;
            lblNombreProyecto.Location = new Point(377, 94);
            lblNombreProyecto.Name = "lblNombreProyecto";
            lblNombreProyecto.Size = new Size(38, 15);
            lblNombreProyecto.TabIndex = 1;
            lblNombreProyecto.Text = "label1";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Location = new Point(377, 137);
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(38, 15);
            labelFechaInicio.TabIndex = 2;
            labelFechaInicio.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 175);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Fecha de Inicio:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(421, 175);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(38, 15);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "label2";
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Location = new Point(421, 220);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(38, 15);
            lblFechaEntrega.TabIndex = 6;
            lblFechaEntrega.Text = "label2";
            lblFechaEntrega.Click += label2_Click;
            // 
            // labelFechaEntrega
            // 
            labelFechaEntrega.AutoSize = true;
            labelFechaEntrega.Location = new Point(270, 220);
            labelFechaEntrega.Name = "labelFechaEntrega";
            labelFechaEntrega.Size = new Size(100, 15);
            labelFechaEntrega.TabIndex = 5;
            labelFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // labelUsuarios
            // 
            labelUsuarios.AutoSize = true;
            labelUsuarios.Location = new Point(270, 263);
            labelUsuarios.Name = "labelUsuarios";
            labelUsuarios.Size = new Size(52, 15);
            labelUsuarios.TabIndex = 7;
            labelUsuarios.Text = "Usuarios";
            // 
            // txtUsuariosAsignados
            // 
            txtUsuariosAsignados.Location = new Point(421, 260);
            txtUsuariosAsignados.Multiline = true;
            txtUsuariosAsignados.Name = "txtUsuariosAsignados";
            txtUsuariosAsignados.ReadOnly = true;
            txtUsuariosAsignados.Size = new Size(100, 23);
            txtUsuariosAsignados.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(421, 311);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(270, 314);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(69, 15);
            labelDescripcion.TabIndex = 9;
            labelDescripcion.Text = "Descripcion";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(352, 363);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormProyectosGerard3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(txtDescripcion);
            Controls.Add(labelDescripcion);
            Controls.Add(txtUsuariosAsignados);
            Controls.Add(labelUsuarios);
            Controls.Add(lblFechaEntrega);
            Controls.Add(labelFechaEntrega);
            Controls.Add(lblFechaInicio);
            Controls.Add(label1);
            Controls.Add(labelFechaInicio);
            Controls.Add(lblNombreProyecto);
            Controls.Add(lbltituloform);
            Name = "FormProyectosGerard3";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltituloform;
        private Label lblNombreProyecto;
        private Label labelFechaInicio;
        private Label label1;
        private Label lblFechaInicio;
        private Label lblFechaEntrega;
        private Label labelFechaEntrega;
        private Label labelUsuarios;
        private TextBox txtUsuariosAsignados;
        private TextBox txtDescripcion;
        private Label labelDescripcion;
        private Button btnCerrar;
    }
}