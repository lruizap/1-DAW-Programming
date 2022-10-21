namespace _03_Calculadora
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
            this.TBoperador1 = new System.Windows.Forms.TextBox();
            this.TBoperador2 = new System.Windows.Forms.TextBox();
            this.TBresultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBoperador1
            // 
            this.TBoperador1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoperador1.Location = new System.Drawing.Point(12, 12);
            this.TBoperador1.Name = "TBoperador1";
            this.TBoperador1.PlaceholderText = "Introduce el primer valor";
            this.TBoperador1.Size = new System.Drawing.Size(262, 32);
            this.TBoperador1.TabIndex = 0;
            this.TBoperador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBoperador2
            // 
            this.TBoperador2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBoperador2.Location = new System.Drawing.Point(12, 104);
            this.TBoperador2.Name = "TBoperador2";
            this.TBoperador2.PlaceholderText = "Introduce el segundo valor";
            this.TBoperador2.Size = new System.Drawing.Size(262, 32);
            this.TBoperador2.TabIndex = 1;
            this.TBoperador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBresultado
            // 
            this.TBresultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBresultado.Location = new System.Drawing.Point(12, 195);
            this.TBresultado.Name = "TBresultado";
            this.TBresultado.PlaceholderText = "Resultado";
            this.TBresultado.ReadOnly = true;
            this.TBresultado.Size = new System.Drawing.Size(262, 32);
            this.TBresultado.TabIndex = 2;
            this.TBresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(349, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(492, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 67);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(492, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 67);
            this.button3.TabIndex = 5;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(349, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 67);
            this.button4.TabIndex = 6;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 259);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBresultado);
            this.Controls.Add(this.TBoperador2);
            this.Controls.Add(this.TBoperador1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TBoperador1;
        private TextBox TBoperador2;
        private TextBox TBresultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}