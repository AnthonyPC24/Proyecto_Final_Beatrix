namespace Beatrix_Formulario
{
    partial class FormReunionesDy2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReunionesDy2));
            labelNuevaReunion = new Label();
            textBoxAsunto = new TextBox();
            labelAsunto = new Label();
            labelFechaHora = new Label();
            dateTimePickerFechaHoraNuevaReunion = new DateTimePicker();
            labelParticipantes = new Label();
            panelParaHoy = new Panel();
            labelContador1 = new Label();
            labelContador2 = new Label();
            checkedListBoxParticipantes = new CheckedListBox();
            buttonCancelar = new Button();
            buttonCrear = new Button();
            labelInformacion = new Label();
            richTextBoxInformacion = new RichTextBox();
            panelParaHoy.SuspendLayout();
            SuspendLayout();
            // 
            // labelNuevaReunion
            // 
            labelNuevaReunion.AutoSize = true;
            labelNuevaReunion.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic);
            labelNuevaReunion.ForeColor = Color.White;
            labelNuevaReunion.Location = new Point(140, 16);
            labelNuevaReunion.Name = "labelNuevaReunion";
            labelNuevaReunion.Size = new Size(214, 31);
            labelNuevaReunion.TabIndex = 9;
            labelNuevaReunion.Text = "Nueva Reunión";
            // 
            // textBoxAsunto
            // 
            textBoxAsunto.Location = new Point(42, 93);
            textBoxAsunto.Name = "textBoxAsunto";
            textBoxAsunto.Size = new Size(423, 23);
            textBoxAsunto.TabIndex = 10;
            textBoxAsunto.TextChanged += textBoxAsunto_TextChanged;
            // 
            // labelAsunto
            // 
            labelAsunto.AutoSize = true;
            labelAsunto.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAsunto.ForeColor = Color.White;
            labelAsunto.Location = new Point(42, 68);
            labelAsunto.Name = "labelAsunto";
            labelAsunto.Size = new Size(69, 24);
            labelAsunto.TabIndex = 11;
            labelAsunto.Text = "Asunto";
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaHora.ForeColor = Color.White;
            labelFechaHora.Location = new Point(42, 125);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(124, 24);
            labelFechaHora.TabIndex = 12;
            labelFechaHora.Text = "Fecha y Hora";
            // 
            // dateTimePickerFechaHoraNuevaReunion
            // 
            dateTimePickerFechaHoraNuevaReunion.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFechaHoraNuevaReunion.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaHoraNuevaReunion.Location = new Point(42, 150);
            dateTimePickerFechaHoraNuevaReunion.Name = "dateTimePickerFechaHoraNuevaReunion";
            dateTimePickerFechaHoraNuevaReunion.Size = new Size(219, 23);
            dateTimePickerFechaHoraNuevaReunion.TabIndex = 13;
            // 
            // labelParticipantes
            // 
            labelParticipantes.AutoSize = true;
            labelParticipantes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelParticipantes.ForeColor = Color.White;
            labelParticipantes.Location = new Point(42, 182);
            labelParticipantes.Name = "labelParticipantes";
            labelParticipantes.Size = new Size(116, 24);
            labelParticipantes.TabIndex = 14;
            labelParticipantes.Text = "Participantes";
            // 
            // panelParaHoy
            // 
            panelParaHoy.BackColor = Color.FromArgb(41, 191, 225);
            panelParaHoy.BorderStyle = BorderStyle.FixedSingle;
            panelParaHoy.Controls.Add(labelContador1);
            panelParaHoy.Controls.Add(labelContador2);
            panelParaHoy.Controls.Add(checkedListBoxParticipantes);
            panelParaHoy.Controls.Add(buttonCancelar);
            panelParaHoy.Controls.Add(buttonCrear);
            panelParaHoy.Controls.Add(labelInformacion);
            panelParaHoy.Controls.Add(richTextBoxInformacion);
            panelParaHoy.Controls.Add(labelParticipantes);
            panelParaHoy.Controls.Add(dateTimePickerFechaHoraNuevaReunion);
            panelParaHoy.Controls.Add(labelFechaHora);
            panelParaHoy.Controls.Add(labelAsunto);
            panelParaHoy.Controls.Add(textBoxAsunto);
            panelParaHoy.Controls.Add(labelNuevaReunion);
            panelParaHoy.Dock = DockStyle.Fill;
            panelParaHoy.Location = new Point(0, 0);
            panelParaHoy.Name = "panelParaHoy";
            panelParaHoy.Size = new Size(528, 421);
            panelParaHoy.TabIndex = 7;
            // 
            // labelContador1
            // 
            labelContador1.AutoSize = true;
            labelContador1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContador1.ForeColor = Color.White;
            labelContador1.Location = new Point(470, 96);
            labelContador1.Name = "labelContador1";
            labelContador1.Size = new Size(35, 15);
            labelContador1.TabIndex = 22;
            labelContador1.Text = "0/30";
            // 
            // labelContador2
            // 
            labelContador2.AutoSize = true;
            labelContador2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContador2.ForeColor = Color.White;
            labelContador2.Location = new Point(463, 353);
            labelContador2.Name = "labelContador2";
            labelContador2.Size = new Size(35, 15);
            labelContador2.TabIndex = 21;
            labelContador2.Text = "0/60";
            // 
            // checkedListBoxParticipantes
            // 
            checkedListBoxParticipantes.FormattingEnabled = true;
            checkedListBoxParticipantes.HorizontalScrollbar = true;
            checkedListBoxParticipantes.Location = new Point(42, 207);
            checkedListBoxParticipantes.Name = "checkedListBoxParticipantes";
            checkedListBoxParticipantes.Size = new Size(415, 76);
            checkedListBoxParticipantes.TabIndex = 20;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(245, 168, 125);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(235, 378);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(104, 23);
            buttonCancelar.TabIndex = 19;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonCrear
            // 
            buttonCrear.BackColor = Color.FromArgb(41, 195, 205);
            buttonCrear.Cursor = Cursors.Hand;
            buttonCrear.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCrear.ForeColor = Color.White;
            buttonCrear.Location = new Point(345, 378);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(112, 23);
            buttonCrear.TabIndex = 18;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = false;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInformacion.ForeColor = Color.White;
            labelInformacion.Location = new Point(42, 305);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(108, 24);
            labelInformacion.TabIndex = 17;
            labelInformacion.Text = "Información";
            // 
            // richTextBoxInformacion
            // 
            richTextBoxInformacion.Location = new Point(42, 330);
            richTextBoxInformacion.Name = "richTextBoxInformacion";
            richTextBoxInformacion.Size = new Size(415, 43);
            richTextBoxInformacion.TabIndex = 16;
            richTextBoxInformacion.Text = "";
            richTextBoxInformacion.TextChanged += richTextBoxInformacion_TextChanged;
            // 
            // FormReunionesDy2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(528, 421);
            Controls.Add(panelParaHoy);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReunionesDy2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Reunión";
            panelParaHoy.ResumeLayout(false);
            panelParaHoy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNuevaReunion;
        private TextBox textBoxAsunto;
        private Label labelAsunto;
        private Label labelFechaHora;
        private DateTimePicker dateTimePickerFechaHoraNuevaReunion;
        private Label labelParticipantes;
        private Panel panelParaHoy;
        private RichTextBox richTextBoxInformacion;
        private Label labelInformacion;
        private Button buttonCancelar;
        private Button buttonCrear;
        private CheckedListBox checkedListBoxParticipantes;
        private Label labelContador2;
        private Label labelContador1;
    }
}