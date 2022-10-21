namespace _07_Mini_Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AgendaTxt = new System.Windows.Forms.Label();
            this.textBox2Dia = new System.Windows.Forms.TextBox();
            this.textBox3Año = new System.Windows.Forms.TextBox();
            this.textBox4Mes = new System.Windows.Forms.TextBox();
            this.día = new System.Windows.Forms.Label();
            this.mes = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.delante = new System.Windows.Forms.Button();
            this.atrás = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(292, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(496, 426);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgendaTxt
            // 
            this.AgendaTxt.AutoSize = true;
            this.AgendaTxt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgendaTxt.Location = new System.Drawing.Point(83, 12);
            this.AgendaTxt.Name = "AgendaTxt";
            this.AgendaTxt.Size = new System.Drawing.Size(109, 37);
            this.AgendaTxt.TabIndex = 1;
            this.AgendaTxt.Text = "Agenda";
            // 
            // textBox2Dia
            // 
            this.textBox2Dia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2Dia.Location = new System.Drawing.Point(177, 122);
            this.textBox2Dia.Name = "textBox2Dia";
            this.textBox2Dia.Size = new System.Drawing.Size(109, 29);
            this.textBox2Dia.TabIndex = 2;
            // 
            // textBox3Año
            // 
            this.textBox3Año.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3Año.Location = new System.Drawing.Point(177, 255);
            this.textBox3Año.Name = "textBox3Año";
            this.textBox3Año.Size = new System.Drawing.Size(109, 29);
            this.textBox3Año.TabIndex = 3;
            // 
            // textBox4Mes
            // 
            this.textBox4Mes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4Mes.Location = new System.Drawing.Point(177, 187);
            this.textBox4Mes.Name = "textBox4Mes";
            this.textBox4Mes.Size = new System.Drawing.Size(109, 29);
            this.textBox4Mes.TabIndex = 4;
            // 
            // día
            // 
            this.día.AutoSize = true;
            this.día.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.día.Location = new System.Drawing.Point(116, 130);
            this.día.Name = "día";
            this.día.Size = new System.Drawing.Size(33, 21);
            this.día.TabIndex = 5;
            this.día.Text = "Día";
            // 
            // mes
            // 
            this.mes.AutoSize = true;
            this.mes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mes.Location = new System.Drawing.Point(116, 195);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(39, 21);
            this.mes.TabIndex = 6;
            this.mes.Text = "Mes";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Año.Location = new System.Drawing.Point(116, 263);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(38, 21);
            this.Año.TabIndex = 7;
            this.Año.Text = "Año";
            // 
            // delante
            // 
            this.delante.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delante.Location = new System.Drawing.Point(177, 339);
            this.delante.Name = "delante";
            this.delante.Size = new System.Drawing.Size(108, 99);
            this.delante.TabIndex = 8;
            this.delante.Text = "-->";
            this.delante.UseVisualStyleBackColor = true;
            this.delante.Click += new System.EventHandler(this.delante_Click);
            // 
            // atrás
            // 
            this.atrás.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.atrás.Location = new System.Drawing.Point(12, 339);
            this.atrás.Name = "atrás";
            this.atrás.Size = new System.Drawing.Size(108, 99);
            this.atrás.TabIndex = 9;
            this.atrás.Text = "<--";
            this.atrás.UseVisualStyleBackColor = true;
            this.atrás.Click += new System.EventHandler(this.atrás_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atrás);
            this.Controls.Add(this.delante);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.día);
            this.Controls.Add(this.textBox4Mes);
            this.Controls.Add(this.textBox3Año);
            this.Controls.Add(this.textBox2Dia);
            this.Controls.Add(this.AgendaTxt);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Mini-Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label AgendaTxt;
        private TextBox textBox2Dia;
        private TextBox textBox3Año;
        private TextBox textBox4Mes;
        private Label día;
        private Label mes;
        private Label Año;
        private Button delante;
        private Button atrás;
    }
}