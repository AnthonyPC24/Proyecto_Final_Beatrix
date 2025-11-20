namespace Beatrix_Formulario
{
    partial class FormUsuarios
    {
        private Panel panelBarraOpciones;
        private Label labelBeatrix;
        private Button btnReuniones;
        private Button btnTareas;
        private Button btnProyetos;
        private Button btnInicio;
        private Panel panelUsuario;
        private TextBox txtCorreu;
        private TextBox txtNombre;
        private PictureBox pictureBoxUsuario;
        private Label lblNombre;
        private TextBox txtTele;
        private Label label2;
        private Button btnEditar;
        private Label lblTele;
        private Label lblCrearUsuario;
        private Label lblTitulo;


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
            panelBarraOpciones = new Panel();
            labelBeatrix = new Label();
            btnReuniones = new Button();
            btnTareas = new Button();
            btnProyetos = new Button();
            btnInicio = new Button();
            panelUsuario = new Panel();
            btnEditar = new Button();
            lblTele = new Label();
            label2 = new Label();
            lblNombre = new Label();
            txtTele = new TextBox();
            txtCorreu = new TextBox();
            txtNombre = new TextBox();
            pictureBoxUsuario = new PictureBox();
            lblCrearUsuario = new Label();
            lblTitulo = new Label();
            pbUser = new PictureBox();
            panelBarraOpciones.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // panelBarraOpciones
            // 
            panelBarraOpciones.BackColor = Color.FromArgb(41, 195, 205);
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
            panelBarraOpciones.TabIndex = 3;
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
            btnReuniones.Location = new Point(17, 567);
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
            btnTareas.Location = new Point(17, 488);
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
            btnProyetos.Location = new Point(17, 409);
            btnProyetos.Margin = new Padding(3, 4, 3, 4);
            btnProyetos.Name = "btnProyetos";
            btnProyetos.Size = new Size(213, 71);
            btnProyetos.TabIndex = 1;
            btnProyetos.Text = "Proyectos";
            btnProyetos.UseVisualStyleBackColor = false;
            btnProyetos.Click += btnProyetos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 195, 205);
            btnInicio.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(17, 331);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(213, 71);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BorderStyle = BorderStyle.FixedSingle;
            panelUsuario.Controls.Add(btnEditar);
            panelUsuario.Controls.Add(lblTele);
            panelUsuario.Controls.Add(label2);
            panelUsuario.Controls.Add(lblNombre);
            panelUsuario.Controls.Add(txtTele);
            panelUsuario.Controls.Add(txtCorreu);
            panelUsuario.Controls.Add(txtNombre);
            panelUsuario.Controls.Add(pictureBoxUsuario);
            panelUsuario.Location = new Point(371, 46);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(755, 273);
            panelUsuario.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(41, 191, 205);
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(529, 216);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTele
            // 
            lblTele.AutoSize = true;
            lblTele.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTele.Location = new Point(282, 167);
            lblTele.Name = "lblTele";
            lblTele.Size = new Size(116, 24);
            lblTele.TabIndex = 6;
            lblTele.Text = "Telefono Movil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 116);
            label2.Name = "label2";
            label2.Size = new Size(147, 24);
            label2.TabIndex = 5;
            label2.Text = "Correo Electronico";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(282, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(154, 24);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre y apellidos";
            // 
            // txtTele
            // 
            txtTele.Location = new Point(450, 164);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(173, 27);
            txtTele.TabIndex = 3;
            // 
            // txtCorreu
            // 
            txtCorreu.Location = new Point(450, 113);
            txtCorreu.Name = "txtCorreu";
            txtCorreu.Size = new Size(173, 27);
            txtCorreu.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(450, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 1;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Image = Properties.Resources.usuario;
            pictureBoxUsuario.Location = new Point(90, 62);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(125, 125);
            pictureBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuario.TabIndex = 0;
            pictureBoxUsuario.TabStop = false;
            // 
            // lblCrearUsuario
            // 
            lblCrearUsuario.AutoSize = true;
            lblCrearUsuario.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearUsuario.ForeColor = Color.FromArgb(41, 191, 205);
            lblCrearUsuario.Location = new Point(319, 378);
            lblCrearUsuario.Name = "lblCrearUsuario";
            lblCrearUsuario.Size = new Size(127, 24);
            lblCrearUsuario.TabIndex = 12;
            lblCrearUsuario.Text = "+ Crear Usuario";
            lblCrearUsuario.Click += lblCrearUsuario_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Montserrat Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(41, 191, 205);
            lblTitulo.Location = new Point(654, 397);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 28);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Todos los usuarios";
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.usuario;
            pbUser.Location = new Point(31, 95);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(185, 185);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 6;
            pbUser.TabStop = false;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblTitulo);
            Controls.Add(lblCrearUsuario);
            Controls.Add(panelUsuario);
            Controls.Add(panelBarraOpciones);
            MinimizeBox = false;
            Name = "FormUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUser;
    }
}