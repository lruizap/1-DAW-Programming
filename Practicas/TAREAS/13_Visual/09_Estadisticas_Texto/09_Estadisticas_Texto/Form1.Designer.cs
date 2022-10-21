namespace _09_Estadisticas_Texto
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
            this.Texto = new System.Windows.Forms.TextBox();
            this.nLetras = new System.Windows.Forms.TextBox();
            this.letras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nConsonantes = new System.Windows.Forms.TextBox();
            this.nVocales = new System.Windows.Forms.TextBox();
            this.nEspacios = new System.Windows.Forms.TextBox();
            this.nPalabras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Texto.Location = new System.Drawing.Point(12, 12);
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Texto.Size = new System.Drawing.Size(908, 677);
            this.Texto.TabIndex = 0;
            this.Texto.TextChanged += new System.EventHandler(this.Texto_TextChanged);
            // 
            // nLetras
            // 
            this.nLetras.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nLetras.Location = new System.Drawing.Point(1106, 30);
            this.nLetras.Name = "nLetras";
            this.nLetras.ReadOnly = true;
            this.nLetras.Size = new System.Drawing.Size(65, 43);
            this.nLetras.TabIndex = 1;
            this.nLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letras
            // 
            this.letras.AutoSize = true;
            this.letras.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letras.Location = new System.Drawing.Point(926, 12);
            this.letras.Name = "letras";
            this.letras.Size = new System.Drawing.Size(174, 74);
            this.letras.TabIndex = 2;
            this.letras.Text = "El número de\r\nletras es de :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(926, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 111);
            this.label2.TabIndex = 4;
            this.label2.Text = "El número de\r\nconsonantes\r\nes de :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(926, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 111);
            this.label3.TabIndex = 5;
            this.label3.Text = "El número de\r\nvocales\r\nes de :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(926, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 111);
            this.label4.TabIndex = 6;
            this.label4.Text = "El número de\r\nespacios\r\nes de :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(926, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 111);
            this.label5.TabIndex = 7;
            this.label5.Text = "El número de\r\npalabras \r\nes de :";
            // 
            // nConsonantes
            // 
            this.nConsonantes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nConsonantes.Location = new System.Drawing.Point(1106, 617);
            this.nConsonantes.Name = "nConsonantes";
            this.nConsonantes.ReadOnly = true;
            this.nConsonantes.Size = new System.Drawing.Size(65, 43);
            this.nConsonantes.TabIndex = 8;
            this.nConsonantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nVocales
            // 
            this.nVocales.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nVocales.Location = new System.Drawing.Point(1106, 460);
            this.nVocales.Name = "nVocales";
            this.nVocales.ReadOnly = true;
            this.nVocales.Size = new System.Drawing.Size(65, 43);
            this.nVocales.TabIndex = 9;
            this.nVocales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nEspacios
            // 
            this.nEspacios.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nEspacios.Location = new System.Drawing.Point(1106, 312);
            this.nEspacios.Name = "nEspacios";
            this.nEspacios.ReadOnly = true;
            this.nEspacios.Size = new System.Drawing.Size(65, 43);
            this.nEspacios.TabIndex = 10;
            this.nEspacios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nPalabras
            // 
            this.nPalabras.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nPalabras.Location = new System.Drawing.Point(1106, 165);
            this.nPalabras.Name = "nPalabras";
            this.nPalabras.ReadOnly = true;
            this.nPalabras.Size = new System.Drawing.Size(65, 43);
            this.nPalabras.TabIndex = 11;
            this.nPalabras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 701);
            this.Controls.Add(this.nPalabras);
            this.Controls.Add(this.nEspacios);
            this.Controls.Add(this.nVocales);
            this.Controls.Add(this.nConsonantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.letras);
            this.Controls.Add(this.nLetras);
            this.Controls.Add(this.Texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Texto;
        private TextBox nLetras;
        private Label letras;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nConsonantes;
        private TextBox nVocales;
        private TextBox nEspacios;
        private TextBox nPalabras;
    }
}