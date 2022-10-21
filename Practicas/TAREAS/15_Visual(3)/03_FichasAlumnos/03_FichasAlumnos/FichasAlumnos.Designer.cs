namespace _03_FichasAlumnos
{
    partial class FichasAlumnos
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
            this.label1Nombre = new System.Windows.Forms.Label();
            this.textBox1Nombre = new System.Windows.Forms.TextBox();
            this.label2FechaNac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3Sex = new System.Windows.Forms.Label();
            this.radioButton1Hombre = new System.Windows.Forms.RadioButton();
            this.radioButton2Mujer = new System.Windows.Forms.RadioButton();
            this.checkBox1Repetidor = new System.Windows.Forms.CheckBox();
            this.label4Repetidor = new System.Windows.Forms.Label();
            this.label5NotaFinal = new System.Windows.Forms.Label();
            this.textBox1Nota = new System.Windows.Forms.TextBox();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.button2Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Nombre
            // 
            this.label1Nombre.AutoSize = true;
            this.label1Nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Nombre.Location = new System.Drawing.Point(12, 34);
            this.label1Nombre.Name = "label1Nombre";
            this.label1Nombre.Size = new System.Drawing.Size(68, 21);
            this.label1Nombre.TabIndex = 0;
            this.label1Nombre.Text = "Nombre";
            // 
            // textBox1Nombre
            // 
            this.textBox1Nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1Nombre.Location = new System.Drawing.Point(100, 31);
            this.textBox1Nombre.Name = "textBox1Nombre";
            this.textBox1Nombre.PlaceholderText = "   Nombre y apellidos";
            this.textBox1Nombre.Size = new System.Drawing.Size(234, 29);
            this.textBox1Nombre.TabIndex = 1;
            this.textBox1Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Nombre_KeyPress);
            // 
            // label2FechaNac
            // 
            this.label2FechaNac.AutoSize = true;
            this.label2FechaNac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2FechaNac.Location = new System.Drawing.Point(12, 85);
            this.label2FechaNac.Name = "label2FechaNac";
            this.label2FechaNac.Size = new System.Drawing.Size(155, 21);
            this.label2FechaNac.TabIndex = 2;
            this.label2FechaNac.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 79);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 5, 17, 12, 57, 54, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // label3Sex
            // 
            this.label3Sex.AutoSize = true;
            this.label3Sex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3Sex.Location = new System.Drawing.Point(12, 134);
            this.label3Sex.Name = "label3Sex";
            this.label3Sex.Size = new System.Drawing.Size(43, 21);
            this.label3Sex.TabIndex = 4;
            this.label3Sex.Text = "Sexo";
            // 
            // radioButton1Hombre
            // 
            this.radioButton1Hombre.AutoSize = true;
            this.radioButton1Hombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1Hombre.Location = new System.Drawing.Point(158, 132);
            this.radioButton1Hombre.Name = "radioButton1Hombre";
            this.radioButton1Hombre.Size = new System.Drawing.Size(85, 25);
            this.radioButton1Hombre.TabIndex = 5;
            this.radioButton1Hombre.TabStop = true;
            this.radioButton1Hombre.Text = "Hombre";
            this.radioButton1Hombre.UseVisualStyleBackColor = true;
            // 
            // radioButton2Mujer
            // 
            this.radioButton2Mujer.AutoSize = true;
            this.radioButton2Mujer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2Mujer.Location = new System.Drawing.Point(249, 132);
            this.radioButton2Mujer.Name = "radioButton2Mujer";
            this.radioButton2Mujer.Size = new System.Drawing.Size(69, 25);
            this.radioButton2Mujer.TabIndex = 6;
            this.radioButton2Mujer.TabStop = true;
            this.radioButton2Mujer.Text = "Mujer";
            this.radioButton2Mujer.UseVisualStyleBackColor = true;
            // 
            // checkBox1Repetidor
            // 
            this.checkBox1Repetidor.AutoSize = true;
            this.checkBox1Repetidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1Repetidor.Location = new System.Drawing.Point(158, 183);
            this.checkBox1Repetidor.Name = "checkBox1Repetidor";
            this.checkBox1Repetidor.Size = new System.Drawing.Size(15, 14);
            this.checkBox1Repetidor.TabIndex = 7;
            this.checkBox1Repetidor.UseVisualStyleBackColor = true;
            // 
            // label4Repetidor
            // 
            this.label4Repetidor.AutoSize = true;
            this.label4Repetidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4Repetidor.Location = new System.Drawing.Point(12, 179);
            this.label4Repetidor.Name = "label4Repetidor";
            this.label4Repetidor.Size = new System.Drawing.Size(78, 21);
            this.label4Repetidor.TabIndex = 8;
            this.label4Repetidor.Text = "Repetidor";
            // 
            // label5NotaFinal
            // 
            this.label5NotaFinal.AutoSize = true;
            this.label5NotaFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5NotaFinal.Location = new System.Drawing.Point(12, 226);
            this.label5NotaFinal.Name = "label5NotaFinal";
            this.label5NotaFinal.Size = new System.Drawing.Size(81, 21);
            this.label5NotaFinal.TabIndex = 9;
            this.label5NotaFinal.Text = "Nota Final";
            // 
            // textBox1Nota
            // 
            this.textBox1Nota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1Nota.Location = new System.Drawing.Point(100, 223);
            this.textBox1Nota.Name = "textBox1Nota";
            this.textBox1Nota.PlaceholderText = "  Nota Final";
            this.textBox1Nota.Size = new System.Drawing.Size(130, 29);
            this.textBox1Nota.TabIndex = 10;
            this.textBox1Nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Nota_KeyPress_1);
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1Aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1Aceptar.Location = new System.Drawing.Point(100, 327);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(100, 30);
            this.button1Aceptar.TabIndex = 11;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1Aceptar_Click);
            // 
            // button2Cancelar
            // 
            this.button2Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2Cancelar.Location = new System.Drawing.Point(215, 327);
            this.button2Cancelar.Name = "button2Cancelar";
            this.button2Cancelar.Size = new System.Drawing.Size(103, 30);
            this.button2Cancelar.TabIndex = 12;
            this.button2Cancelar.Text = "Cancelar";
            this.button2Cancelar.UseVisualStyleBackColor = true;
            // 
            // FichasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 369);
            this.Controls.Add(this.button2Cancelar);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.textBox1Nota);
            this.Controls.Add(this.label5NotaFinal);
            this.Controls.Add(this.label4Repetidor);
            this.Controls.Add(this.checkBox1Repetidor);
            this.Controls.Add(this.radioButton2Mujer);
            this.Controls.Add(this.radioButton1Hombre);
            this.Controls.Add(this.label3Sex);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2FechaNac);
            this.Controls.Add(this.textBox1Nombre);
            this.Controls.Add(this.label1Nombre);
            this.MaximizeBox = false;
            this.Name = "FichasAlumnos";
            this.Text = "FichasAlumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1Nombre;
        private TextBox textBox1Nombre;
        private Label label2FechaNac;
        private DateTimePicker dateTimePicker1;
        private Label label3Sex;
        private RadioButton radioButton1Hombre;
        private RadioButton radioButton2Mujer;
        private CheckBox checkBox1Repetidor;
        private Label label4Repetidor;
        private Label label5NotaFinal;
        private TextBox textBox1Nota;
        private Button button1Aceptar;
        private Button button2Cancelar;
    }
}