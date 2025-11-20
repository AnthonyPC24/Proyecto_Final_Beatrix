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
            panelUserInfo = new Panel();
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
            panelUserInfo.BorderStyle = BorderStyle.FixedSingle;
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
            panelUserInfo.Location = new Point(0, 0);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(784, 542);
            panelUserInfo.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(41, 191, 205);
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(333, 444);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(104, 36);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtTele
            // 
            txtTele.Location = new Point(391, 368);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(193, 27);
            txtTele.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(391, 325);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(193, 27);
            txtCorreo.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(391, 281);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 27);
            txtNombre.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(391, 236);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(193, 27);
            txtUser.TabIndex = 10;
            // 
            // lblTele
            // 
            lblTele.AutoSize = true;
            lblTele.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTele.Location = new Point(207, 370);
            lblTele.Name = "lblTele";
            lblTele.Size = new Size(118, 24);
            lblTele.TabIndex = 8;
            lblTele.Text = "Telefono movil";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(207, 325);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(147, 24);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo Electronico";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(207, 236);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(154, 24);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Nombre de usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(207, 281);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(154, 24);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre y apellidos";
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.usuario;
            pictureBoxUser.Location = new Point(315, 53);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(150, 150);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 0;
            pictureBoxUser.TabStop = false;
            // 
            // FormPantallaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(782, 538);
            Controls.Add(panelUserInfo);
            MinimizeBox = false;
            Name = "FormPantallaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPantallaUsuario";
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}