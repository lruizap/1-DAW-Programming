namespace _03_MultiConversor
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
            this.ValorAConvertirTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.PulgadasRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CentígradosRadioButton = new System.Windows.Forms.RadioButton();
            this.KelvinRadioButton = new System.Windows.Forms.RadioButton();
            this.CentímetrosradioButton = new System.Windows.Forms.RadioButton();
            this.UnidadesConvLabel = new System.Windows.Forms.Label();
            this.UnidadesResultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValorAConvertirTextBox
            // 
            this.ValorAConvertirTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorAConvertirTextBox.Location = new System.Drawing.Point(133, 132);
            this.ValorAConvertirTextBox.Name = "ValorAConvertirTextBox";
            this.ValorAConvertirTextBox.PlaceholderText = "Valor a convertir";
            this.ValorAConvertirTextBox.Size = new System.Drawing.Size(239, 34);
            this.ValorAConvertirTextBox.TabIndex = 0;
            this.ValorAConvertirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultadoTextBox.Location = new System.Drawing.Point(133, 249);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.PlaceholderText = "Resultado";
            this.ResultadoTextBox.ReadOnly = true;
            this.ResultadoTextBox.Size = new System.Drawing.Size(239, 34);
            this.ResultadoTextBox.TabIndex = 1;
            this.ResultadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.Location = new System.Drawing.Point(285, 9);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(230, 39);
            this.TituloLabel.TabIndex = 2;
            this.TituloLabel.Text = "MultiConversor";
            // 
            // PulgadasRadioButton
            // 
            this.PulgadasRadioButton.AutoSize = true;
            this.PulgadasRadioButton.Location = new System.Drawing.Point(6, 32);
            this.PulgadasRadioButton.Name = "PulgadasRadioButton";
            this.PulgadasRadioButton.Size = new System.Drawing.Size(182, 25);
            this.PulgadasRadioButton.TabIndex = 3;
            this.PulgadasRadioButton.TabStop = true;
            this.PulgadasRadioButton.Text = "Pulgadas-Centímetros";
            this.PulgadasRadioButton.UseVisualStyleBackColor = true;
            this.PulgadasRadioButton.CheckedChanged += new System.EventHandler(this.PulgadasRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CentígradosRadioButton);
            this.groupBox1.Controls.Add(this.KelvinRadioButton);
            this.groupBox1.Controls.Add(this.CentímetrosradioButton);
            this.groupBox1.Controls.Add(this.PulgadasRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(573, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Conversiones";
            // 
            // CentígradosRadioButton
            // 
            this.CentígradosRadioButton.AutoSize = true;
            this.CentígradosRadioButton.Location = new System.Drawing.Point(6, 142);
            this.CentígradosRadioButton.Name = "CentígradosRadioButton";
            this.CentígradosRadioButton.Size = new System.Drawing.Size(160, 25);
            this.CentígradosRadioButton.TabIndex = 6;
            this.CentígradosRadioButton.TabStop = true;
            this.CentígradosRadioButton.Text = "Centígrados-Kelvin";
            this.CentígradosRadioButton.UseVisualStyleBackColor = true;
            this.CentígradosRadioButton.CheckedChanged += new System.EventHandler(this.CentígradosRadioButton_CheckedChanged);
            // 
            // KelvinRadioButton
            // 
            this.KelvinRadioButton.AutoSize = true;
            this.KelvinRadioButton.Location = new System.Drawing.Point(6, 111);
            this.KelvinRadioButton.Name = "KelvinRadioButton";
            this.KelvinRadioButton.Size = new System.Drawing.Size(160, 25);
            this.KelvinRadioButton.TabIndex = 5;
            this.KelvinRadioButton.TabStop = true;
            this.KelvinRadioButton.Text = "Kelvin-Centígrados";
            this.KelvinRadioButton.UseVisualStyleBackColor = true;
            this.KelvinRadioButton.CheckedChanged += new System.EventHandler(this.KelvinRadioButton_CheckedChanged);
            // 
            // CentímetrosradioButton
            // 
            this.CentímetrosradioButton.AutoSize = true;
            this.CentímetrosradioButton.Location = new System.Drawing.Point(6, 63);
            this.CentímetrosradioButton.Name = "CentímetrosradioButton";
            this.CentímetrosradioButton.Size = new System.Drawing.Size(182, 25);
            this.CentímetrosradioButton.TabIndex = 4;
            this.CentímetrosradioButton.TabStop = true;
            this.CentímetrosradioButton.Text = "Centímetros-Pulgadas";
            this.CentímetrosradioButton.UseVisualStyleBackColor = true;
            this.CentímetrosradioButton.CheckedChanged += new System.EventHandler(this.CentímetrosradioButton_CheckedChanged);
            // 
            // UnidadesConvLabel
            // 
            this.UnidadesConvLabel.AutoSize = true;
            this.UnidadesConvLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnidadesConvLabel.Location = new System.Drawing.Point(403, 135);
            this.UnidadesConvLabel.Name = "UnidadesConvLabel";
            this.UnidadesConvLabel.Size = new System.Drawing.Size(94, 28);
            this.UnidadesConvLabel.TabIndex = 5;
            this.UnidadesConvLabel.Text = "Unidades";
            // 
            // UnidadesResultLabel
            // 
            this.UnidadesResultLabel.AutoSize = true;
            this.UnidadesResultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnidadesResultLabel.Location = new System.Drawing.Point(403, 252);
            this.UnidadesResultLabel.Name = "UnidadesResultLabel";
            this.UnidadesResultLabel.Size = new System.Drawing.Size(94, 28);
            this.UnidadesResultLabel.TabIndex = 6;
            this.UnidadesResultLabel.Text = "Unidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnidadesResultLabel);
            this.Controls.Add(this.UnidadesConvLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.ValorAConvertirTextBox);
            this.Name = "Form1";
            this.Text = "MultiConversor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ValorAConvertirTextBox;
        private TextBox ResultadoTextBox;
        private Label TituloLabel;
        private RadioButton PulgadasRadioButton;
        private GroupBox groupBox1;
        private RadioButton CentígradosRadioButton;
        private RadioButton KelvinRadioButton;
        private RadioButton CentímetrosradioButton;
        private Label UnidadesConvLabel;
        private Label UnidadesResultLabel;
    }
}