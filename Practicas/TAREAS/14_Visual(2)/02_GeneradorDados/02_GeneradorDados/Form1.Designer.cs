namespace _02_GeneradorDados
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
            this.NumDadosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CarasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DadoslistBox = new System.Windows.Forms.ListBox();
            this.buttonTirar = new System.Windows.Forms.Button();
            this.SumaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDadosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarasNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumDadosNumericUpDown
            // 
            this.NumDadosNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumDadosNumericUpDown.Location = new System.Drawing.Point(63, 130);
            this.NumDadosNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumDadosNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDadosNumericUpDown.Name = "NumDadosNumericUpDown";
            this.NumDadosNumericUpDown.Size = new System.Drawing.Size(211, 43);
            this.NumDadosNumericUpDown.TabIndex = 0;
            this.NumDadosNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CarasNumericUpDown
            // 
            this.CarasNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarasNumericUpDown.Location = new System.Drawing.Point(63, 275);
            this.CarasNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CarasNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CarasNumericUpDown.Name = "CarasNumericUpDown";
            this.CarasNumericUpDown.Size = new System.Drawing.Size(211, 43);
            this.CarasNumericUpDown.TabIndex = 1;
            this.CarasNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "GeneradorDados";
            // 
            // DadoslistBox
            // 
            this.DadoslistBox.FormattingEnabled = true;
            this.DadoslistBox.ItemHeight = 15;
            this.DadoslistBox.Location = new System.Drawing.Point(515, 104);
            this.DadoslistBox.Name = "DadoslistBox";
            this.DadoslistBox.Size = new System.Drawing.Size(273, 334);
            this.DadoslistBox.TabIndex = 3;
            // 
            // buttonTirar
            // 
            this.buttonTirar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTirar.Location = new System.Drawing.Point(300, 193);
            this.buttonTirar.Name = "buttonTirar";
            this.buttonTirar.Size = new System.Drawing.Size(175, 65);
            this.buttonTirar.TabIndex = 4;
            this.buttonTirar.Text = "Tirar";
            this.buttonTirar.UseVisualStyleBackColor = true;
            this.buttonTirar.Click += new System.EventHandler(this.buttonTirar_Click);
            // 
            // SumaTextBox
            // 
            this.SumaTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumaTextBox.Location = new System.Drawing.Point(300, 404);
            this.SumaTextBox.Name = "SumaTextBox";
            this.SumaTextBox.PlaceholderText = "SUMA";
            this.SumaTextBox.Size = new System.Drawing.Size(175, 34);
            this.SumaTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumaTextBox);
            this.Controls.Add(this.buttonTirar);
            this.Controls.Add(this.DadoslistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarasNumericUpDown);
            this.Controls.Add(this.NumDadosNumericUpDown);
            this.Name = "Form1";
            this.Text = "GeneradorDados";
            ((System.ComponentModel.ISupportInitialize)(this.NumDadosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarasNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown NumDadosNumericUpDown;
        private NumericUpDown CarasNumericUpDown;
        private Label label1;
        private ListBox DadoslistBox;
        private Button buttonTirar;
        private TextBox SumaTextBox;
    }
}