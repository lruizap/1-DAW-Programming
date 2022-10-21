namespace _01_CreaDiccionario
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
            this.Diccionario = new System.Windows.Forms.ListBox();
            this.PalEN = new System.Windows.Forms.TextBox();
            this.PalESP = new System.Windows.Forms.TextBox();
            this.AddB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Diccionario
            // 
            this.Diccionario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Diccionario.FormattingEnabled = true;
            this.Diccionario.ItemHeight = 28;
            this.Diccionario.Location = new System.Drawing.Point(12, 12);
            this.Diccionario.Name = "Diccionario";
            this.Diccionario.Size = new System.Drawing.Size(421, 424);
            this.Diccionario.TabIndex = 0;
            this.Diccionario.SelectedIndexChanged += new System.EventHandler(this.Diccionario_SelectedIndexChanged);
            // 
            // PalEN
            // 
            this.PalEN.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PalEN.Location = new System.Drawing.Point(463, 12);
            this.PalEN.Name = "PalEN";
            this.PalEN.PlaceholderText = "Palabra En Inglés";
            this.PalEN.Size = new System.Drawing.Size(290, 34);
            this.PalEN.TabIndex = 1;
            this.PalEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PalESP
            // 
            this.PalESP.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PalESP.Location = new System.Drawing.Point(463, 111);
            this.PalESP.Name = "PalESP";
            this.PalESP.PlaceholderText = "Palabra En Español";
            this.PalESP.Size = new System.Drawing.Size(290, 34);
            this.PalESP.TabIndex = 2;
            this.PalESP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddB.Location = new System.Drawing.Point(463, 213);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(118, 51);
            this.AddB.TabIndex = 3;
            this.AddB.Text = "Añadir";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Enabled = false;
            this.DeleteB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteB.Location = new System.Drawing.Point(635, 213);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(118, 51);
            this.DeleteB.TabIndex = 4;
            this.DeleteB.Text = "Borrar";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.PalESP);
            this.Controls.Add(this.PalEN);
            this.Controls.Add(this.Diccionario);
            this.Name = "Form1";
            this.Text = "CreaDiccionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Diccionario;
        private TextBox PalEN;
        private TextBox PalESP;
        private Button AddB;
        private Button DeleteB;
    }
}