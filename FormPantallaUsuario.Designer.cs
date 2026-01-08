namespace Beatrix_Formulario
{
    partial class FormPantallaUsuario
    {
        private Panel panelUserInfo;
        private Button btnCrear;
        private TextBox txtTele;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtUser;
        private Label lblTele;
        private Label lblCorreo;
        private Label lblUsuario;
        private Label lblNombre;
        private PictureBox pictureBoxUser;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPantallaUsuario));
            panelUserInfo = new Panel();
            comboBoxRol = new ComboBox();
            lblRol = new Label();
            btnCrear = new Button();
            txtTele = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtUser = new TextBox();
            lblTele = new Label();
            lblCorreo = new Label();
            lblUsuario = new Label();
            lblNombre = new Label();
            pictureBoxUser = new PictureBox();
            panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panelUserInfo
            // 
            panelUserInfo.BackColor = Color.FromArgb(41, 191, 225);
            panelUserInfo.BorderStyle = BorderStyle.FixedSingle;
            panelUserInfo.Controls.Add(comboBoxRol);
            panelUserInfo.Controls.Add(lblRol);
            panelUserInfo.Controls.Add(btnCrear);
            panelUserInfo.Controls.Add(txtTele);
            panelUserInfo.Controls.Add(txtCorreo);
            panelUserInfo.Controls.Add(txtNombre);
            panelUserInfo.Controls.Add(txtUser);
            panelUserInfo.Controls.Add(lblTele);
            panelUserInfo.Controls.Add(lblCorreo);
            panelUserInfo.Controls.Add(lblUsuario);
            panelUserInfo.Controls.Add(lblNombre);
            panelUserInfo.Controls.Add(pictureBoxUser);
            panelUserInfo.Dock = DockStyle.Fill;
            panelUserInfo.Location = new Point(0, 0);
            panelUserInfo.Margin = new Padding(3, 2, 3, 2);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(415, 393);
            panelUserInfo.TabIndex = 6;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Administrador", "Usuarios", "Visitante" });
            comboBoxRol.Location = new Point(210, 295);
            comboBoxRol.Margin = new Padding(3, 2, 3, 2);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(159, 23);
            comboBoxRol.TabIndex = 16;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(46, 298);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(32, 17);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(41, 191, 205);
            btnCrear.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(154, 341);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(91, 27);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtTele
            // 
            txtTele.Location = new Point(210, 260);
            txtTele.Margin = new Padding(3, 2, 3, 2);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(159, 23);
            txtTele.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(210, 226);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(159, 23);
            txtCorreo.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 190);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(210, 157);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(159, 23);
            txtUser.TabIndex = 10;
            // 
            // lblTele
            // 
            lblTele.AutoSize = true;
            lblTele.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTele.ForeColor = Color.White;
            lblTele.Location = new Point(46, 262);
            lblTele.Name = "lblTele";
            lblTele.Size = new Size(114, 17);
            lblTele.TabIndex = 8;
            lblTele.Text = "Telefono movil";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(46, 226);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(143, 17);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo Electronico";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(46, 157);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(146, 17);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Nombre de usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(46, 190);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(147, 17);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre y apellidos";
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.usuario;
            pictureBoxUser.Location = new Point(154, 16);
            pictureBoxUser.Margin = new Padding(3, 2, 3, 2);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(131, 112);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 0;
            pictureBoxUser.TabStop = false;
            // 
            // FormPantallaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(415, 393);
            Controls.Add(panelUserInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormPantallaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Usuario";
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxRol;
        private Label lblRol;
    }
}