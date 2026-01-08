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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProyectosGerard4));
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
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(254, 28);
            label5.Name = "label5";
            label5.Size = new Size(215, 31);
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
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 288);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            // 
            // quitarUsuarios
            // 
            quitarUsuarios.BackColor = Color.FromArgb(41, 195, 205);
            quitarUsuarios.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            quitarUsuarios.ForeColor = Color.White;
            quitarUsuarios.Location = new Point(518, 181);
            quitarUsuarios.Name = "quitarUsuarios";
            quitarUsuarios.Size = new Size(177, 23);
            quitarUsuarios.TabIndex = 19;
            quitarUsuarios.Text = "Quitar Usuario";
            quitarUsuarios.UseVisualStyleBackColor = false;
            quitarUsuarios.Click += quitarUsuarios_Click_1;
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(518, 48);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(177, 23);
            comboBoxUsuarios.TabIndex = 17;
            comboBoxUsuarios.SelectedIndexChanged += comboBoxUsuarios_SelectedIndexChanged;
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
            listBoxUsuarios.Location = new Point(518, 75);
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
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 81);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 116);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
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
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 159);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(439, 48);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Usuarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 45);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(245, 168, 125);
            button3.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(520, 367);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 30;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(41, 195, 205);
            btnCrear.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(629, 367);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(104, 23);
            btnCrear.TabIndex = 29;
            btnCrear.Text = "Aceptar";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormProyectosGerard4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 191, 205);
            ClientSize = new Size(744, 398);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(btnCrear);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProyectosGerard4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Proyecto";
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