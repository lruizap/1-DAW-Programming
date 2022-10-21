namespace _06_LeeListaCSV
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
            this.CargarDatosButton = new System.Windows.Forms.Button();
            this.NombreFicheroTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CargarDatosButton
            // 
            this.CargarDatosButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CargarDatosButton.Location = new System.Drawing.Point(642, 252);
            this.CargarDatosButton.Name = "CargarDatosButton";
            this.CargarDatosButton.Size = new System.Drawing.Size(164, 46);
            this.CargarDatosButton.TabIndex = 1;
            this.CargarDatosButton.Text = "Cargar Datos";
            this.CargarDatosButton.UseVisualStyleBackColor = true;
            this.CargarDatosButton.Click += new System.EventHandler(this.CargarDatosButton_Click);
            // 
            // NombreFicheroTextBox
            // 
            this.NombreFicheroTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreFicheroTextBox.Location = new System.Drawing.Point(642, 161);
            this.NombreFicheroTextBox.Name = "NombreFicheroTextBox";
            this.NombreFicheroTextBox.PlaceholderText = "Nombre Fichero";
            this.NombreFicheroTextBox.Size = new System.Drawing.Size(164, 34);
            this.NombreFicheroTextBox.TabIndex = 2;
            this.NombreFicheroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 471);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 495);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.NombreFicheroTextBox);
            this.Controls.Add(this.CargarDatosButton);
            this.Name = "Form1";
            this.Text = "LeeListaCSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CargarDatosButton;
        private TextBox NombreFicheroTextBox;
        private ListView listView1;
    }
}