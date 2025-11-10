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
            labelNuevaReunion.Font = new Font("Montserrat", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNuevaReunion.Location = new Point(164, -1);
            labelNuevaReunion.Name = "labelNuevaReunion";
            labelNuevaReunion.Size = new Size(240, 45);
            labelNuevaReunion.TabIndex = 9;
            labelNuevaReunion.Text = "Nueva Reunión";
            // 
            // textBoxAsunto
            // 
            textBoxAsunto.Location = new Point(75, 125);
            textBoxAsunto.Name = "textBoxAsunto";
            textBoxAsunto.Size = new Size(423, 23);
            textBoxAsunto.TabIndex = 10;
            textBoxAsunto.TextChanged += textBoxAsunto_TextChanged;
            // 
            // labelAsunto
            // 
            labelAsunto.AutoSize = true;
            labelAsunto.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAsunto.Location = new Point(241, 93);
            labelAsunto.Name = "labelAsunto";
            labelAsunto.Size = new Size(81, 29);
            labelAsunto.TabIndex = 11;
            labelAsunto.Text = "Asunto";
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaHora.Location = new Point(216, 151);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(137, 29);
            labelFechaHora.TabIndex = 12;
            labelFechaHora.Text = "Fecha y Hora";
            // 
            // dateTimePickerFechaHoraNuevaReunion
            // 
            dateTimePickerFechaHoraNuevaReunion.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFechaHoraNuevaReunion.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaHoraNuevaReunion.Location = new Point(185, 185);
            dateTimePickerFechaHoraNuevaReunion.Name = "dateTimePickerFechaHoraNuevaReunion";
            dateTimePickerFechaHoraNuevaReunion.Size = new Size(219, 23);
            dateTimePickerFechaHoraNuevaReunion.TabIndex = 13;
            // 
            // labelParticipantes
            // 
            labelParticipantes.AutoSize = true;
            labelParticipantes.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelParticipantes.Location = new Point(215, 223);
            labelParticipantes.Name = "labelParticipantes";
            labelParticipantes.Size = new Size(138, 29);
            labelParticipantes.TabIndex = 14;
            labelParticipantes.Text = "Participantes";
            // 
            // panelParaHoy
            // 
            panelParaHoy.BackColor = Color.FromArgb(41, 191, 205);
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
            panelParaHoy.Size = new Size(570, 623);
            panelParaHoy.TabIndex = 7;
            // 
            // labelContador1
            // 
            labelContador1.AutoSize = true;
            labelContador1.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContador1.ForeColor = Color.White;
            labelContador1.Location = new Point(504, 125);
            labelContador1.Name = "labelContador1";
            labelContador1.Size = new Size(34, 19);
            labelContador1.TabIndex = 22;
            labelContador1.Text = "0/30";
            // 
            // labelContador2
            // 
            labelContador2.AutoSize = true;
            labelContador2.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContador2.ForeColor = Color.White;
            labelContador2.Location = new Point(496, 448);
            labelContador2.Name = "labelContador2";
            labelContador2.Size = new Size(34, 19);
            labelContador2.TabIndex = 21;
            labelContador2.Text = "0/60";
            // 
            // checkedListBoxParticipantes
            // 
            checkedListBoxParticipantes.FormattingEnabled = true;
            checkedListBoxParticipantes.HorizontalScrollbar = true;
            checkedListBoxParticipantes.Location = new Point(75, 267);
            checkedListBoxParticipantes.Name = "checkedListBoxParticipantes";
            checkedListBoxParticipantes.Size = new Size(415, 94);
            checkedListBoxParticipantes.TabIndex = 20;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(245, 168, 125);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(320, 503);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(170, 37);
            buttonCancelar.TabIndex = 19;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonCrear
            // 
            buttonCrear.BackColor = Color.FromArgb(41, 195, 205);
            buttonCrear.Cursor = Cursors.Hand;
            buttonCrear.Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCrear.ForeColor = Color.White;
            buttonCrear.Location = new Point(75, 503);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(170, 37);
            buttonCrear.TabIndex = 18;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = false;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // labelInformacion
            // 
            labelInformacion.AutoSize = true;
            labelInformacion.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInformacion.Location = new Point(215, 386);
            labelInformacion.Name = "labelInformacion";
            labelInformacion.Size = new Size(130, 29);
            labelInformacion.TabIndex = 17;
            labelInformacion.Text = "Información";
            // 
            // richTextBoxInformacion
            // 
            richTextBoxInformacion.Location = new Point(75, 435);
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
            ClientSize = new Size(570, 623);
            Controls.Add(panelParaHoy);
            Name = "FormReunionesDy2";
            Text = "FormReunionesDy2";
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