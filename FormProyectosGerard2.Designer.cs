namespace Beatrix_Formulario
{
    partial class FormProyectosGerard2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyectosGerard2));
            button2 = new Button();
            groupBox1 = new GroupBox();
            quitarUsuarios = new Button();
            label7 = new Label();
            comboBoxUsuarios = new ComboBox();
            richTextBox1 = new RichTextBox();
            listBoxUsuarios = new ListBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            btnCrear = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1350, 32);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(40, 39);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quitarUsuarios);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBoxUsuarios);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(listBoxUsuarios);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 85);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 405);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // quitarUsuarios
            // 
            quitarUsuarios.BackColor = Color.FromArgb(41, 195, 205);
            quitarUsuarios.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            quitarUsuarios.ForeColor = Color.White;
            quitarUsuarios.Location = new Point(598, 241);
            quitarUsuarios.Margin = new Padding(3, 4, 3, 4);
            quitarUsuarios.Name = "quitarUsuarios";
            quitarUsuarios.Size = new Size(202, 31);
            quitarUsuarios.TabIndex = 19;
            quitarUsuarios.Text = "Quitar Usuario";
            quitarUsuarios.UseVisualStyleBackColor = false;
            quitarUsuarios.Click += quitarUsuarios_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(598, 296);
            label7.Name = "label7";
            label7.Size = new Size(262, 80);
            label7.TabIndex = 18;
            label7.Text = "* Para crear las tareas haz clic en Crear y dirigete a la ventana de Tareas";
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(598, 60);
            comboBoxUsuarios.Margin = new Padding(3, 4, 3, 4);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(202, 28);
            comboBoxUsuarios.TabIndex = 17;
            comboBoxUsuarios.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(186, 215);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(289, 144);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.Location = new Point(598, 108);
            listBoxUsuarios.Margin = new Padding(3, 4, 3, 4);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(202, 124);
            listBoxUsuarios.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(186, 149);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(289, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 108);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 108);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 156);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 7;
            label4.Text = "Fechad e entrega";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 60);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 218);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(502, 64);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(245, 168, 125);
            button3.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(723, 498);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(41, 195, 205);
            btnCrear.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(815, 498);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 31);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(333, 31);
            label5.Name = "label5";
            label5.Size = new Size(273, 39);
            label5.TabIndex = 28;
            label5.Text = "Nuevo Proyecto";
            // 
            // FormProyectosGerard2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(914, 538);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnCrear);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProyectosGerard2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Proyecto";
            Load += FormProyectosGerard2_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Button button3;
        private Button btnCrear;
        private Label label5;
        private Label label6;
        private ListBox listBoxUsuarios;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private ComboBox comboBoxUsuarios;
        private Label label7;
        private Button quitarUsuarios;
    }
}