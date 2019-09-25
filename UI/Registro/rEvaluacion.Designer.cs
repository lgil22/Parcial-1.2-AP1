namespace Parcial1._2_AP1.UI
{
    partial class rEvaluacion
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Categorialabel = new System.Windows.Forms.Label();
            this.Valorlabel = new System.Windows.Forms.Label();
            this.Logradolabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.EstudiantetextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PerdidotextBox = new System.Windows.Forms.TextBox();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.LogradotextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(30, 32);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "Id";
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Location = new System.Drawing.Point(30, 62);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(57, 13);
            this.Estudiantelabel.TabIndex = 1;
            this.Estudiantelabel.Text = "Estudiante";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(203, 32);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 2;
            this.Fechalabel.Text = "Fecha";
            // 
            // Categorialabel
            // 
            this.Categorialabel.AutoSize = true;
            this.Categorialabel.Location = new System.Drawing.Point(128, 21);
            this.Categorialabel.Name = "Categorialabel";
            this.Categorialabel.Size = new System.Drawing.Size(43, 13);
            this.Categorialabel.TabIndex = 3;
            this.Categorialabel.Text = "Perdido";
            // 
            // Valorlabel
            // 
            this.Valorlabel.AutoSize = true;
            this.Valorlabel.Location = new System.Drawing.Point(6, 21);
            this.Valorlabel.Name = "Valorlabel";
            this.Valorlabel.Size = new System.Drawing.Size(31, 13);
            this.Valorlabel.TabIndex = 4;
            this.Valorlabel.Text = "Valor";
            // 
            // Logradolabel
            // 
            this.Logradolabel.AutoSize = true;
            this.Logradolabel.Location = new System.Drawing.Point(61, 21);
            this.Logradolabel.Name = "Logradolabel";
            this.Logradolabel.Size = new System.Drawing.Size(46, 13);
            this.Logradolabel.TabIndex = 5;
            this.Logradolabel.Text = "Logrado";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(52, 29);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(85, 20);
            this.IdtextBox.TabIndex = 6;
            // 
            // EstudiantetextBox
            // 
            this.EstudiantetextBox.Location = new System.Drawing.Point(93, 59);
            this.EstudiantetextBox.Name = "EstudiantetextBox";
            this.EstudiantetextBox.Size = new System.Drawing.Size(91, 20);
            this.EstudiantetextBox.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(246, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // PerdidotextBox
            // 
            this.PerdidotextBox.Location = new System.Drawing.Point(131, 37);
            this.PerdidotextBox.Name = "PerdidotextBox";
            this.PerdidotextBox.Size = new System.Drawing.Size(54, 20);
            this.PerdidotextBox.TabIndex = 9;
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(3, 37);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(52, 20);
            this.ValortextBox.TabIndex = 10;
            this.ValortextBox.TextChanged += new System.EventHandler(this.ValortextBox_TextChanged);
            // 
            // LogradotextBox
            // 
            this.LogradotextBox.Location = new System.Drawing.Point(64, 37);
            this.LogradotextBox.Name = "LogradotextBox";
            this.LogradotextBox.Size = new System.Drawing.Size(51, 20);
            this.LogradotextBox.TabIndex = 11;
            this.LogradotextBox.TextChanged += new System.EventHandler(this.ValortextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PerdidotextBox);
            this.groupBox1.Controls.Add(this.LogradotextBox);
            this.groupBox1.Controls.Add(this.Categorialabel);
            this.groupBox1.Controls.Add(this.ValortextBox);
            this.groupBox1.Controls.Add(this.Logradolabel);
            this.groupBox1.Controls.Add(this.Valorlabel);
            this.groupBox1.Location = new System.Drawing.Point(33, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificacion";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(42, 299);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 32);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(119, 299);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 32);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(200, 299);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 32);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // rEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 373);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.EstudiantetextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.IDlabel);
            this.Name = "rEvaluacion";
            this.Text = "rEvaluacion";
            this.Load += new System.EventHandler(this.REvaluacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Categorialabel;
        private System.Windows.Forms.Label Valorlabel;
        private System.Windows.Forms.Label Logradolabel;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox EstudiantetextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox PerdidotextBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.TextBox LogradotextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}