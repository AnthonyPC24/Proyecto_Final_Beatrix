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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            panelBarraOpciones = new Panel();
            Logo = new PictureBox();
            linkLabel1 = new LinkLabel();
            labelBeatrix = new Label();
            btnReuniones = new Button();
            btnTareas = new Button();
            btnProyetos = new Button();
            btnInicio = new Button();
            panelUsuario = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            btnActualizar = new Button();
            pictureBoxUsuario = new PictureBox();
            lblTele = new Label();
            label2 = new Label();
            lblNombre = new Label();
            txtTele = new TextBox();
            txtCorreu = new TextBox();
            txtNombre = new TextBox();
            lblCrearUsuario = new Label();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            label1 = new Label();
            panelBarraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
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
            panelBarraOpciones.TabIndex = 3;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.None;
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(33, 64);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(144, 120);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 11;
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
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Configuración";
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
            btnReuniones.Location = new Point(15, 379);
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
            btnTareas.Location = new Point(15, 320);
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
            btnProyetos.Location = new Point(15, 260);
            btnProyetos.Name = "btnProyetos";
            btnProyetos.Size = new Size(186, 53);
            btnProyetos.TabIndex = 1;
            btnProyetos.Text = "Proyectos";
            btnProyetos.UseVisualStyleBackColor = false;
            btnProyetos.Click += btnProyetos_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(41, 195, 205);
            btnInicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(15, 202);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(186, 53);
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
            panelUsuario.Controls.Add(pictureBoxUsuario);
            panelUsuario.Controls.Add(lblTele);
            panelUsuario.Controls.Add(label2);
            panelUsuario.Controls.Add(lblNombre);
            panelUsuario.Controls.Add(txtTele);
            panelUsuario.Controls.Add(txtCorreu);
            panelUsuario.Controls.Add(txtNombre);
            panelUsuario.Location = new Point(275, 53);
            panelUsuario.Margin = new Padding(3, 2, 3, 2);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(788, 230);
            panelUsuario.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(483, 96);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(630, 94);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(137, 23);
            txtPassword.TabIndex = 10;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(159, 60);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(119, 15);
            lblNombreUsuario.TabIndex = 9;
            lblNombreUsuario.Text = "Nombre de usuarios";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(306, 58);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(135, 23);
            txtNombreUsuario.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(41, 191, 205);
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(684, 165);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 22);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Image = Properties.Resources.usuario;
            pictureBoxUsuario.Location = new Point(24, 45);
            pictureBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(109, 94);
            pictureBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuario.TabIndex = 0;
            pictureBoxUsuario.TabStop = false;
            // 
            // lblTele
            // 
            lblTele.AutoSize = true;
            lblTele.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTele.Location = new Point(483, 60);
            lblTele.Name = "lblTele";
            lblTele.Size = new Size(87, 15);
            lblTele.TabIndex = 6;
            lblTele.Text = "Telefono Movil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 133);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 5;
            label2.Text = "Correo Electronico";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(159, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre y apellidos";
            // 
            // txtTele
            // 
            txtTele.Location = new Point(630, 58);
            txtTele.Margin = new Padding(3, 2, 3, 2);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(137, 23);
            txtTele.TabIndex = 3;
            // 
            // txtCorreu
            // 
            txtCorreu.Location = new Point(306, 130);
            txtCorreu.Margin = new Padding(3, 2, 3, 2);
            txtCorreu.Name = "txtCorreu";
            txtCorreu.Size = new Size(135, 23);
            txtCorreu.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(306, 94);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblCrearUsuario
            // 
            lblCrearUsuario.AutoSize = true;
            lblCrearUsuario.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearUsuario.ForeColor = Color.FromArgb(41, 191, 205);
            lblCrearUsuario.Location = new Point(287, 288);
            lblCrearUsuario.Name = "lblCrearUsuario";
            lblCrearUsuario.Size = new Size(108, 15);
            lblCrearUsuario.TabIndex = 12;
            lblCrearUsuario.Text = "+ Crear Usuario";
            lblCrearUsuario.Click += lblCrearUsuario_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(41, 191, 205);
            lblTitulo.Location = new Point(572, 295);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 18);
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = SystemColors.ActiveBorder;
            dgvUsuarios.Location = new Point(358, 323);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(601, 173);
            dgvUsuarios.TabIndex = 14;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(275, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 15;
            label1.Text = "Usuarios";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1104, 505);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblTitulo);
            Controls.Add(lblCrearUsuario);
            Controls.Add(panelUsuario);
            Controls.Add(panelBarraOpciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuración";
            FormClosing += FormUsuarios_FormClosing;
            panelBarraOpciones.ResumeLayout(false);
            panelBarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvUsuarios;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblPassword;
        private TextBox txtPassword;
        private LinkLabel linkLabel1;
        private PictureBox Logo;
        private Label label1;
    }
}