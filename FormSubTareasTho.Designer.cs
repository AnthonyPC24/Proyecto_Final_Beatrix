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
            buttonCancelarSubTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            buttonCancelarSubTarea.Location = new Point(632, 417);
            buttonCancelarSubTarea.Name = "buttonCancelarSubTarea";
            buttonCancelarSubTarea.Size = new Size(75, 23);
            buttonCancelarSubTarea.TabIndex = 13;
            buttonCancelarSubTarea.Text = "Cancelar";
            buttonCancelarSubTarea.UseVisualStyleBackColor = false;
            buttonCancelarSubTarea.Click += buttonCancelarSubTarea_Click;
            // 
            // buttonCrearNuevaSubTarea
            // 
            buttonCrearNuevaSubTarea.BackColor = Color.FromArgb(41, 195, 205);
            buttonCrearNuevaSubTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            buttonCrearNuevaSubTarea.Location = new Point(713, 417);
            buttonCrearNuevaSubTarea.Name = "buttonCrearNuevaSubTarea";
            buttonCrearNuevaSubTarea.Size = new Size(75, 23);
            buttonCrearNuevaSubTarea.TabIndex = 12;
            buttonCrearNuevaSubTarea.Text = "Crear";
            buttonCrearNuevaSubTarea.UseVisualStyleBackColor = false;
            buttonCrearNuevaSubTarea.Click += buttonCrearNuevaSubTarea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat ExtraBold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(264, 11);
            label1.Name = "label1";
            label1.Size = new Size(266, 42);
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
            groupBoxNuevaTarea.Location = new Point(12, 120);
            groupBoxNuevaTarea.Name = "groupBoxNuevaTarea";
            groupBoxNuevaTarea.Size = new Size(776, 292);
            groupBoxNuevaTarea.TabIndex = 10;
            groupBoxNuevaTarea.TabStop = false;
            // 
            // buttonQuitarUsuarioSubTarea
            // 
            buttonQuitarUsuarioSubTarea.BackColor = Color.White;
            buttonQuitarUsuarioSubTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            buttonQuitarUsuarioSubTarea.Location = new Point(132, 250);
            buttonQuitarUsuarioSubTarea.Name = "buttonQuitarUsuarioSubTarea";
            buttonQuitarUsuarioSubTarea.Size = new Size(133, 23);
            buttonQuitarUsuarioSubTarea.TabIndex = 9;
            buttonQuitarUsuarioSubTarea.Text = "Quitar usuario";
            buttonQuitarUsuarioSubTarea.UseVisualStyleBackColor = false;
            buttonQuitarUsuarioSubTarea.Click += buttonQuitarUsuarioSubTarea_Click;
            // 
            // listBoxUsuariosSubTarea
            // 
            listBoxUsuariosSubTarea.FormattingEnabled = true;
            listBoxUsuariosSubTarea.ItemHeight = 15;
            listBoxUsuariosSubTarea.Location = new Point(20, 105);
            listBoxUsuariosSubTarea.Name = "listBoxUsuariosSubTarea";
            listBoxUsuariosSubTarea.Size = new Size(245, 139);
            listBoxUsuariosSubTarea.TabIndex = 10;
            // 
            // labelDescripcionNuevaTarea
            // 
            labelDescripcionNuevaTarea.AutoSize = true;
            labelDescripcionNuevaTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            labelDescripcionNuevaTarea.Location = new Point(309, 84);
            labelDescripcionNuevaTarea.Name = "labelDescripcionNuevaTarea";
            labelDescripcionNuevaTarea.Size = new Size(80, 18);
            labelDescripcionNuevaTarea.TabIndex = 9;
            labelDescripcionNuevaTarea.Text = "Descripción";
            // 
            // richTextBoxSubTareaDescripcion
            // 
            richTextBoxSubTareaDescripcion.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            richTextBoxSubTareaDescripcion.Location = new Point(309, 105);
            richTextBoxSubTareaDescripcion.Name = "richTextBoxSubTareaDescripcion";
            richTextBoxSubTareaDescripcion.Size = new Size(444, 169);
            richTextBoxSubTareaDescripcion.TabIndex = 8;
            richTextBoxSubTareaDescripcion.Text = "";
            // 
            // comboBoxUsuariosAsignarsubTareas
            // 
            comboBoxUsuariosAsignarsubTareas.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            comboBoxUsuariosAsignarsubTareas.FormattingEnabled = true;
            comboBoxUsuariosAsignarsubTareas.Location = new Point(20, 55);
            comboBoxUsuariosAsignarsubTareas.Name = "comboBoxUsuariosAsignarsubTareas";
            comboBoxUsuariosAsignarsubTareas.Size = new Size(245, 26);
            comboBoxUsuariosAsignarsubTareas.TabIndex = 7;
            comboBoxUsuariosAsignarsubTareas.SelectedIndexChanged += comboBoxUsuariosAsignarsubTareas_SelectedIndexChanged;
            // 
            // dateTimePickerFechasubTareaFin
            // 
            dateTimePickerFechasubTareaFin.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            dateTimePickerFechasubTareaFin.Location = new Point(544, 54);
            dateTimePickerFechasubTareaFin.Name = "dateTimePickerFechasubTareaFin";
            dateTimePickerFechasubTareaFin.Size = new Size(209, 22);
            dateTimePickerFechasubTareaFin.TabIndex = 4;
            // 
            // dateTimePickerFechaSubTareaInicio
            // 
            dateTimePickerFechaSubTareaInicio.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            dateTimePickerFechaSubTareaInicio.Location = new Point(309, 54);
            dateTimePickerFechaSubTareaInicio.Name = "dateTimePickerFechaSubTareaInicio";
            dateTimePickerFechaSubTareaInicio.Size = new Size(209, 22);
            dateTimePickerFechaSubTareaInicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            label3.Location = new Point(544, 26);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 2;
            label3.Text = "Fecha de finalizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            label2.Location = new Point(309, 26);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio";
            // 
            // textBoxNombreNuevaSubTarea
            // 
            textBoxNombreNuevaSubTarea.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            textBoxNombreNuevaSubTarea.Location = new Point(20, 22);
            textBoxNombreNuevaSubTarea.Name = "textBoxNombreNuevaSubTarea";
            textBoxNombreNuevaSubTarea.PlaceholderText = "Nombre de la tarea";
            textBoxNombreNuevaSubTarea.Size = new Size(166, 22);
            textBoxNombreNuevaSubTarea.TabIndex = 0;
            // 
            // comboBoxProyectosSubTareas
            // 
            comboBoxProyectosSubTareas.FormattingEnabled = true;
            comboBoxProyectosSubTareas.Location = new Point(110, 56);
            comboBoxProyectosSubTareas.Name = "comboBoxProyectosSubTareas";
            comboBoxProyectosSubTareas.Size = new Size(167, 23);
            comboBoxProyectosSubTareas.TabIndex = 14;
            comboBoxProyectosSubTareas.SelectedIndexChanged += comboBoxProyectosSubTareas_SelectedIndexChanged;
            // 
            // comboBoxTareaSubTareas
            // 
            comboBoxTareaSubTareas.FormattingEnabled = true;
            comboBoxTareaSubTareas.Location = new Point(110, 85);
            comboBoxTareaSubTareas.Name = "comboBoxTareaSubTareas";
            comboBoxTareaSubTareas.Size = new Size(167, 23);
            comboBoxTareaSubTareas.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 59);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 16;
            label4.Text = "Proyecto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 88);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 17;
            label5.Text = "Tareas";
            // 
            // FormSubTareasTho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 191, 159);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxTareaSubTareas);
            Controls.Add(comboBoxProyectosSubTareas);
            Controls.Add(buttonCancelarSubTarea);
            Controls.Add(buttonCrearNuevaSubTarea);
            Controls.Add(label1);
            Controls.Add(groupBoxNuevaTarea);
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