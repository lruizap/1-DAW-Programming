namespace _06_Traductor_inglés_español
{
    partial class Traductor
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
            this.ingles = new System.Windows.Forms.TextBox();
            this.español = new System.Windows.Forms.TextBox();
            this.TraductorTexto = new System.Windows.Forms.Label();
            this.ENES = new System.Windows.Forms.Button();
            this.ESEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ingles
            // 
            this.ingles.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingles.Location = new System.Drawing.Point(30, 148);
            this.ingles.Name = "ingles";
            this.ingles.Size = new System.Drawing.Size(322, 43);
            this.ingles.TabIndex = 0;
            // 
            // español
            // 
            this.español.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.español.Location = new System.Drawing.Point(30, 292);
            this.español.Name = "español";
            this.español.Size = new System.Drawing.Size(322, 43);
            this.español.TabIndex = 1;
            // 
            // TraductorTexto
            // 
            this.TraductorTexto.AutoSize = true;
            this.TraductorTexto.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TraductorTexto.Location = new System.Drawing.Point(224, 29);
            this.TraductorTexto.Name = "TraductorTexto";
            this.TraductorTexto.Size = new System.Drawing.Size(256, 72);
            this.TraductorTexto.TabIndex = 2;
            this.TraductorTexto.Text = "Traductor";
            // 
            // ENES
            // 
            this.ENES.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ENES.Location = new System.Drawing.Point(444, 148);
            this.ENES.Name = "ENES";
            this.ENES.Size = new System.Drawing.Size(214, 43);
            this.ENES.TabIndex = 3;
            this.ENES.Text = "Inglés-Español";
            this.ENES.UseVisualStyleBackColor = true;
            this.ENES.Click += new System.EventHandler(this.ENES_Click);
            // 
            // ESEN
            // 
            this.ESEN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ESEN.Location = new System.Drawing.Point(444, 292);
            this.ESEN.Name = "ESEN";
            this.ESEN.Size = new System.Drawing.Size(214, 43);
            this.ESEN.TabIndex = 4;
            this.ESEN.Text = "Español-Inglés";
            this.ESEN.UseVisualStyleBackColor = true;
            this.ESEN.Click += new System.EventHandler(this.ESEN_Click);
            // 
            // Traductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.ESEN);
            this.Controls.Add(this.ENES);
            this.Controls.Add(this.TraductorTexto);
            this.Controls.Add(this.español);
            this.Controls.Add(this.ingles);
            this.Name = "Traductor";
            this.Text = "Traductor";
            this.Load += new System.EventHandler(this.Traductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ingles;
        private TextBox español;
        private Label TraductorTexto;
        private Button ENES;
        private Button ESEN;
    }
}