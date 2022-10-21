namespace _04_Adivino
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
            this.Menor = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.Label();
            this.Mayor = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.NºIntentos = new System.Windows.Forms.Label();
            this.intentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menor
            // 
            this.Menor.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menor.Location = new System.Drawing.Point(65, 270);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(67, 67);
            this.Menor.TabIndex = 0;
            this.Menor.Text = "<";
            this.Menor.UseVisualStyleBackColor = true;
            this.Menor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Numero.Location = new System.Drawing.Point(253, 53);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(0, 54);
            this.Numero.TabIndex = 1;
            this.Numero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mayor
            // 
            this.Mayor.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mayor.Location = new System.Drawing.Point(377, 270);
            this.Mayor.Name = "Mayor";
            this.Mayor.Size = new System.Drawing.Size(67, 67);
            this.Mayor.TabIndex = 2;
            this.Mayor.Text = ">";
            this.Mayor.UseVisualStyleBackColor = true;
            this.Mayor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Igual.Location = new System.Drawing.Point(220, 270);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(67, 67);
            this.Igual.TabIndex = 3;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // NºIntentos
            // 
            this.NºIntentos.AutoSize = true;
            this.NºIntentos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NºIntentos.Location = new System.Drawing.Point(12, 378);
            this.NºIntentos.Name = "NºIntentos";
            this.NºIntentos.Size = new System.Drawing.Size(359, 37);
            this.NºIntentos.TabIndex = 4;
            this.NºIntentos.Text = "El número de intentos es de :";
            // 
            // intentos
            // 
            this.intentos.AutoSize = true;
            this.intentos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intentos.Location = new System.Drawing.Point(377, 378);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(0, 37);
            this.intentos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.NºIntentos);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Mayor);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Menor);
            this.Name = "Form1";
            this.Text = "Adivino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Menor;
        private Label Numero;
        private Button Mayor;
        private Button Igual;
        private Label NºIntentos;
        private Label intentos;
    }
}