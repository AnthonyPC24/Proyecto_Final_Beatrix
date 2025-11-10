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
            button2.Location = new Point(1181, 24);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 304);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(497, 45);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(177, 23);
            comboBoxUsuarios.TabIndex = 17;
            comboBoxUsuarios.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(169, 161);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(253, 109);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.ItemHeight = 15;
            listBoxUsuarios.Location = new Point(497, 81);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(177, 94);
            listBoxUsuarios.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(169, 112);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(253, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(169, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 81);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 118);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 7;
            label4.Text = "Fechad e entrega";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(169, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 174);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 48);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button3
            // 
            button3.Location = new Point(611, 386);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(512, 386);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat ExtraBold", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(291, 23);
            label5.Name = "label5";
            label5.Size = new Size(223, 38);
            label5.TabIndex = 28;
            label5.Text = "Nuevo Proyecto";
            // 
            // FormProyectosGerard2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnCrear);
            Name = "FormProyectosGerard2";
            Text = "FormProyectosGerard2";
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
    }
}