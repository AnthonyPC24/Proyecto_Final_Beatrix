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
        private Button btnActualizar;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelBarraOpciones = new Panel();
            btnConfiguracion = new Button();
            pbUser = new PictureBox();
            labelBeatrix = new Label();
            btnReuniones = new Button();
            btnTareas = new Button();
            btnProyetos = new Button();
            btnInicio = new Button();
            panelUsuario = new Panel();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            btnActualizar = new Button();
            lblTele = new Label();
            label2 = new Label();
            pictureBoxUsuario = new PictureBox();
            lblNombre = new Label();
            txtTele = new TextBox();
            txtCorreu = new TextBox();
            txtNombre = new TextBox();
            lblCrearUsuario = new Label();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            lblPassword = new Label();
            txtPassword = new TextBox();
            panelBarraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
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
            panelBarraOpciones.TabIndex = 3;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(41, 195, 205);
            btnConfiguracion.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Location = new Point(17, 584);
            btnConfiguracion.Margin = new Padding(3, 4, 3, 4);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(213, 71);
            btnConfiguracion.TabIndex = 7;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.usuario;
            pbUser.Location = new Point(50, 95);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(146, 143);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 6;
            pbUser.TabStop = false;
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
            btnReuniones.Location = new Point(17, 505);
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
            btnTareas.Location = new Point(17, 426);
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
            btnProyetos.Location = new Point(17, 347);
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
            btnInicio.Location = new Point(17, 269);
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
            panelUsuario.Controls.Add(lblPassword);
            panelUsuario.Controls.Add(txtPassword);
            panelUsuario.Controls.Add(lblNombreUsuario);
            panelUsuario.Controls.Add(txtNombreUsuario);
            panelUsuario.Controls.Add(btnActualizar);
            panelUsuario.Controls.Add(lblTele);
            panelUsuario.Controls.Add(label2);
            panelUsuario.Controls.Add(pictureBoxUsuario);
            panelUsuario.Controls.Add(lblNombre);
            panelUsuario.Controls.Add(txtTele);
            panelUsuario.Controls.Add(txtCorreu);
            panelUsuario.Controls.Add(txtNombre);
            panelUsuario.Location = new Point(409, 34);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(687, 306);
            panelUsuario.TabIndex = 4;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(40, 42);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(161, 24);
            lblNombreUsuario.TabIndex = 9;
            lblNombreUsuario.Text = "Nombre de usuarios";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(208, 39);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(173, 27);
            txtNombreUsuario.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(41, 191, 205);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(511, 233);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblTele
            // 
            lblTele.AutoSize = true;
            lblTele.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTele.Location = new Point(40, 190);
            lblTele.Name = "lblTele";
            lblTele.Size = new Size(116, 24);
            lblTele.TabIndex = 6;
            lblTele.Text = "Telefono Movil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 139);
            label2.Name = "label2";
            label2.Size = new Size(147, 24);
            label2.TabIndex = 5;
            label2.Text = "Correo Electronico";
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Image = Properties.Resources.usuario;
            pictureBoxUsuario.Location = new Point(492, 42);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(125, 125);
            pictureBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuario.TabIndex = 0;
            pictureBoxUsuario.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(40, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(154, 24);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre y apellidos";
            // 
            // txtTele
            // 
            txtTele.Location = new Point(208, 187);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(173, 27);
            txtTele.TabIndex = 3;
            // 
            // txtCorreu
            // 
            txtCorreu.Location = new Point(208, 136);
            txtCorreu.Name = "txtCorreu";
            txtCorreu.Size = new Size(173, 27);
            txtCorreu.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblCrearUsuario
            // 
            lblCrearUsuario.AutoSize = true;
            lblCrearUsuario.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearUsuario.ForeColor = Color.FromArgb(41, 191, 205);
            lblCrearUsuario.Location = new Point(328, 347);
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
            lblTitulo.Location = new Point(654, 356);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 28);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Todos los usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.FromArgb(41, 195, 205);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = SystemColors.ActiveBorder;
            dgvUsuarios.Location = new Point(409, 401);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(687, 231);
            dgvUsuarios.TabIndex = 14;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(40, 238);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(116, 24);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Telefono Movil";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(208, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 27);
            txtPassword.TabIndex = 10;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblTitulo);
            Controls.Add(lblCrearUsuario);
            Controls.Add(panelUsuario);
            Controls.Add(panelBarraOpciones);
            MinimizeBox = false;
            Name = "FormUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConfiguracionUsuarios";
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUser;
        private Button btnConfiguracion;
        private DataGridView dgvUsuarios;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}