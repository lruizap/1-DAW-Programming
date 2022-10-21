namespace _05_Conversor_Pulgadas
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
            this.Centimetros = new System.Windows.Forms.TextBox();
            this.Pulgadas = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Centimetros
            // 
            this.Centimetros.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Centimetros.Location = new System.Drawing.Point(40, 153);
            this.Centimetros.Name = "Centimetros";
            this.Centimetros.PlaceholderText = "Centímetros";
            this.Centimetros.Size = new System.Drawing.Size(250, 43);
            this.Centimetros.TabIndex = 0;
            this.Centimetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Centimetros.TextChanged += new System.EventHandler(this.Centimetros_TextChanged);
            // 
            // Pulgadas
            // 
            this.Pulgadas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pulgadas.Location = new System.Drawing.Point(40, 249);
            this.Pulgadas.Name = "Pulgadas";
            this.Pulgadas.PlaceholderText = "Pulgadas";
            this.Pulgadas.Size = new System.Drawing.Size(250, 43);
            this.Pulgadas.TabIndex = 1;
            this.Pulgadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pulgadas.TextChanged += new System.EventHandler(this.Pulgadas_TextChanged);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(72, 22);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(202, 54);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Conversor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 354);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.Pulgadas);
            this.Controls.Add(this.Centimetros);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Centimetros;
        private TextBox Pulgadas;
        private Label titulo;
    }
}