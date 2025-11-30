namespace Beatrix_Formulario
{
    partial class FormSubTareasTho
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
            buttonCancelarSubTarea = new Button();
            buttonCrearNuevaSubTarea = new Button();
            label1 = new Label();
            groupBoxNuevaTarea = new GroupBox();
            buttonQuitarUsuarioSubTarea = new Button();
            listBoxUsuariosSubTarea = new ListBox();
            labelDescripcionNuevaTarea = new Label();
            richTextBoxSubTareaDescripcion = new RichTextBox();
            comboBoxUsuariosAsignarsubTareas = new ComboBox();
            dateTimePickerFechasubTareaFin = new DateTimePicker();
            dateTimePickerFechaSubTareaInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBoxNombreNuevaSubTarea = new TextBox();
            comboBoxProyectosSubTareas = new ComboBox();
            comboBoxTareaSubTareas = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            groupBoxNuevaTarea.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancelarSubTarea
            // 
            buttonCancelarSubTarea.BackColor = Color.FromArgb(245, 168, 125);
            buttonCancelarSubTarea.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            buttonCancelarSubTarea.ForeColor = Color.White;
            buttonCancelarSubTarea.Location = new Point(657, 557);
            buttonCancelarSubTarea.Margin = new Padding(3, 4, 3, 4);
            buttonCancelarSubTarea.Name = "buttonCancelarSubTarea";
            buttonCancelarSubTarea.Size = new Size(119, 31);
            buttonCancelarSubTarea.TabIndex = 13;
            buttonCancelarSubTarea.Text = "Cancelar";
            buttonCancelarSubTarea.UseVisualStyleBackColor = false;
            buttonCancelarSubTarea.Click += buttonCancelarSubTarea_Click;
            // 
            // buttonCrearNuevaSubTarea
            // 
            buttonCrearNuevaSubTarea.BackColor = Color.FromArgb(41, 195, 205);
            buttonCrearNuevaSubTarea.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            buttonCrearNuevaSubTarea.ForeColor = Color.White;
            buttonCrearNuevaSubTarea.Location = new Point(782, 557);
            buttonCrearNuevaSubTarea.Margin = new Padding(3, 4, 3, 4);
            buttonCrearNuevaSubTarea.Name = "buttonCrearNuevaSubTarea";
            buttonCrearNuevaSubTarea.Size = new Size(119, 31);
            buttonCrearNuevaSubTarea.TabIndex = 12;
            buttonCrearNuevaSubTarea.Text = "Crear";
            buttonCrearNuevaSubTarea.UseVisualStyleBackColor = false;
            buttonCrearNuevaSubTarea.Click += buttonCrearNuevaSubTarea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(302, 15);
            label1.Name = "label1";
            label1.Size = new Size(299, 39);
            label1.TabIndex = 11;
            label1.Text = "Nueva Sub Tarea";
            // 
            // groupBoxNuevaTarea
            // 
            groupBoxNuevaTarea.Controls.Add(buttonQuitarUsuarioSubTarea);
            groupBoxNuevaTarea.Controls.Add(listBoxUsuariosSubTarea);
            groupBoxNuevaTarea.Controls.Add(labelDescripcionNuevaTarea);
            groupBoxNuevaTarea.Controls.Add(richTextBoxSubTareaDescripcion);
            groupBoxNuevaTarea.Controls.Add(comboBoxUsuariosAsignarsubTareas);
            groupBoxNuevaTarea.Controls.Add(dateTimePickerFechasubTareaFin);
            groupBoxNuevaTarea.Controls.Add(dateTimePickerFechaSubTareaInicio);
            groupBoxNuevaTarea.Controls.Add(label3);
            groupBoxNuevaTarea.Controls.Add(label2);
            groupBoxNuevaTarea.Controls.Add(textBoxNombreNuevaSubTarea);
            groupBoxNuevaTarea.Location = new Point(14, 160);
            groupBoxNuevaTarea.Margin = new Padding(3, 4, 3, 4);
            groupBoxNuevaTarea.Name = "groupBoxNuevaTarea";
            groupBoxNuevaTarea.Padding = new Padding(3, 4, 3, 4);
            groupBoxNuevaTarea.Size = new Size(887, 389);
            groupBoxNuevaTarea.TabIndex = 10;
            groupBoxNuevaTarea.TabStop = false;
            // 
            // buttonQuitarUsuarioSubTarea
            // 
            buttonQuitarUsuarioSubTarea.BackColor = Color.FromArgb(41, 195, 205);
            buttonQuitarUsuarioSubTarea.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            buttonQuitarUsuarioSubTarea.ForeColor = Color.White;
            buttonQuitarUsuarioSubTarea.Location = new Point(151, 333);
            buttonQuitarUsuarioSubTarea.Margin = new Padding(3, 4, 3, 4);
            buttonQuitarUsuarioSubTarea.Name = "buttonQuitarUsuarioSubTarea";
            buttonQuitarUsuarioSubTarea.Size = new Size(152, 31);
            buttonQuitarUsuarioSubTarea.TabIndex = 9;
            buttonQuitarUsuarioSubTarea.Text = "Quitar usuario";
            buttonQuitarUsuarioSubTarea.UseVisualStyleBackColor = false;
            buttonQuitarUsuarioSubTarea.Click += buttonQuitarUsuarioSubTarea_Click;
            // 
            // listBoxUsuariosSubTarea
            // 
            listBoxUsuariosSubTarea.FormattingEnabled = true;
            listBoxUsuariosSubTarea.Location = new Point(23, 140);
            listBoxUsuariosSubTarea.Margin = new Padding(3, 4, 3, 4);
            listBoxUsuariosSubTarea.Name = "listBoxUsuariosSubTarea";
            listBoxUsuariosSubTarea.Size = new Size(279, 184);
            listBoxUsuariosSubTarea.TabIndex = 10;
            // 
            // labelDescripcionNuevaTarea
            // 
            labelDescripcionNuevaTarea.AutoSize = true;
            labelDescripcionNuevaTarea.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelDescripcionNuevaTarea.ForeColor = Color.White;
            labelDescripcionNuevaTarea.Location = new Point(353, 112);
            labelDescripcionNuevaTarea.Name = "labelDescripcionNuevaTarea";
            labelDescripcionNuevaTarea.Size = new Size(110, 20);
            labelDescripcionNuevaTarea.TabIndex = 9;
            labelDescripcionNuevaTarea.Text = "Descripción";
            // 
            // richTextBoxSubTareaDescripcion
            // 
            richTextBoxSubTareaDescripcion.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            richTextBoxSubTareaDescripcion.Location = new Point(353, 140);
            richTextBoxSubTareaDescripcion.Margin = new Padding(3, 4, 3, 4);
            richTextBoxSubTareaDescripcion.Name = "richTextBoxSubTareaDescripcion";
            richTextBoxSubTareaDescripcion.Size = new Size(507, 224);
            richTextBoxSubTareaDescripcion.TabIndex = 8;
            richTextBoxSubTareaDescripcion.Text = "";
            // 
            // comboBoxUsuariosAsignarsubTareas
            // 
            comboBoxUsuariosAsignarsubTareas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            comboBoxUsuariosAsignarsubTareas.FormattingEnabled = true;
            comboBoxUsuariosAsignarsubTareas.Location = new Point(23, 73);
            comboBoxUsuariosAsignarsubTareas.Margin = new Padding(3, 4, 3, 4);
            comboBoxUsuariosAsignarsubTareas.Name = "comboBoxUsuariosAsignarsubTareas";
            comboBoxUsuariosAsignarsubTareas.Size = new Size(279, 26);
            comboBoxUsuariosAsignarsubTareas.TabIndex = 7;
            comboBoxUsuariosAsignarsubTareas.SelectedIndexChanged += comboBoxUsuariosAsignarsubTareas_SelectedIndexChanged;
            // 
            // dateTimePickerFechasubTareaFin
            // 
            dateTimePickerFechasubTareaFin.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            dateTimePickerFechasubTareaFin.Location = new Point(622, 72);
            dateTimePickerFechasubTareaFin.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechasubTareaFin.Name = "dateTimePickerFechasubTareaFin";
            dateTimePickerFechasubTareaFin.Size = new Size(238, 24);
            dateTimePickerFechasubTareaFin.TabIndex = 4;
            // 
            // dateTimePickerFechaSubTareaInicio
            // 
            dateTimePickerFechaSubTareaInicio.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            dateTimePickerFechaSubTareaInicio.Location = new Point(353, 72);
            dateTimePickerFechaSubTareaInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFechaSubTareaInicio.Name = "dateTimePickerFechaSubTareaInicio";
            dateTimePickerFechaSubTareaInicio.Size = new Size(238, 24);
            dateTimePickerFechaSubTareaInicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(622, 35);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de finalizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(353, 35);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio";
            // 
            // textBoxNombreNuevaSubTarea
            // 
            textBoxNombreNuevaSubTarea.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            textBoxNombreNuevaSubTarea.Location = new Point(23, 29);
            textBoxNombreNuevaSubTarea.Margin = new Padding(3, 4, 3, 4);
            textBoxNombreNuevaSubTarea.Name = "textBoxNombreNuevaSubTarea";
            textBoxNombreNuevaSubTarea.PlaceholderText = "Nombre de la tarea";
            textBoxNombreNuevaSubTarea.Size = new Size(189, 24);
            textBoxNombreNuevaSubTarea.TabIndex = 0;
            // 
            // comboBoxProyectosSubTareas
            // 
            comboBoxProyectosSubTareas.FormattingEnabled = true;
            comboBoxProyectosSubTareas.Location = new Point(126, 75);
            comboBoxProyectosSubTareas.Margin = new Padding(3, 4, 3, 4);
            comboBoxProyectosSubTareas.Name = "comboBoxProyectosSubTareas";
            comboBoxProyectosSubTareas.Size = new Size(190, 28);
            comboBoxProyectosSubTareas.TabIndex = 14;
            comboBoxProyectosSubTareas.SelectedIndexChanged += comboBoxProyectosSubTareas_SelectedIndexChanged;
            // 
            // comboBoxTareaSubTareas
            // 
            comboBoxTareaSubTareas.FormattingEnabled = true;
            comboBoxTareaSubTareas.Location = new Point(126, 113);
            comboBoxTareaSubTareas.Margin = new Padding(3, 4, 3, 4);
            comboBoxTareaSubTareas.Name = "comboBoxTareaSubTareas";
            comboBoxTareaSubTareas.Size = new Size(190, 28);
            comboBoxTareaSubTareas.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(37, 79);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 16;
            label4.Text = "Proyecto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 117);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 17;
            label5.Text = "Tareas";
            // 
            // FormSubTareasTho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 191, 159);
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxTareaSubTareas);
            Controls.Add(comboBoxProyectosSubTareas);
            Controls.Add(buttonCancelarSubTarea);
            Controls.Add(buttonCrearNuevaSubTarea);
            Controls.Add(label1);
            Controls.Add(groupBoxNuevaTarea);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSubTareasTho";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormSubTareasTho";
            groupBoxNuevaTarea.ResumeLayout(false);
            groupBoxNuevaTarea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelarSubTarea;
        private Button buttonCrearNuevaSubTarea;
        private Label label1;
        private GroupBox groupBoxNuevaTarea;
        private Button buttonQuitarUsuarioSubTarea;
        private ListBox listBoxUsuariosSubTarea;
        private Label labelDescripcionNuevaTarea;
        private RichTextBox richTextBoxSubTareaDescripcion;
        private ComboBox comboBoxUsuariosAsignarsubTareas;
        private DateTimePicker dateTimePickerFechasubTareaFin;
        private DateTimePicker dateTimePickerFechaSubTareaInicio;
        private Label label3;
        private Label label2;
        private TextBox textBoxNombreNuevaSubTarea;
        private ComboBox comboBoxProyectosSubTareas;
        private ComboBox comboBoxTareaSubTareas;
        private Label label4;
        private Label label5;
    }
}