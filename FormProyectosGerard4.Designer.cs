namespace Beatrix_Formulario
{
    partial class FormProyectosGerard4
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
            label5 = new Label();
            groupBox1 = new GroupBox();
            quitarUsuarios = new Button();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(333, 43);
            label5.Name = "label5";
            label5.Size = new Size(234, 36);
            label5.TabIndex = 32;
            label5.Text = "Editar Proyecto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quitarUsuarios);
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
            groupBox1.Location = new Point(14, 97);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 405);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // quitarUsuarios
            // 
            quitarUsuarios.Location = new Point(568, 241);
            quitarUsuarios.Margin = new Padding(3, 4, 3, 4);
            quitarUsuarios.Name = "quitarUsuarios";
            quitarUsuarios.Size = new Size(202, 31);
            quitarUsuarios.TabIndex = 19;
            quitarUsuarios.Text = "Quitar Usuario";
            quitarUsuarios.UseVisualStyleBackColor = true;
            quitarUsuarios.Click += quitarUsuarios_Click_1;
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(568, 60);
            comboBoxUsuarios.Margin = new Padding(3, 4, 3, 4);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(202, 28);
            comboBoxUsuarios.TabIndex = 17;
            comboBoxUsuarios.SelectedIndexChanged += comboBoxUsuarios_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(193, 215);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(289, 144);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.Location = new Point(568, 108);
            listBoxUsuarios.Margin = new Padding(3, 4, 3, 4);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(202, 124);
            listBoxUsuarios.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(193, 149);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(289, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(193, 108);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 108);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 157);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 7;
            label4.Text = "Fechad e entrega";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(193, 60);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 232);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button3
            // 
            button3.Location = new Point(698, 527);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 30;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(585, 527);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 31);
            btnCrear.TabIndex = 29;
            btnCrear.Text = "Aceptar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormProyectosGerard4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(btnCrear);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProyectosGerard4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += FormProyectosGerard4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private GroupBox groupBox1;
        private Button quitarUsuarios;
        private ComboBox comboBoxUsuarios;
        private RichTextBox richTextBox1;
        private ListBox listBoxUsuarios;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button btnCrear;
    }
}