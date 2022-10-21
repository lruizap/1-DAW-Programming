
namespace VaidrollTeamWindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblvalor1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.NumericUpDown();
            this.btngenerar = new System.Windows.Forms.Button();
            this.lblvalor2 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Figura geométrica:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.Black;
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.ForeColor = System.Drawing.Color.White;
            this.txtresultado.Location = new System.Drawing.Point(31, 227);
            this.txtresultado.Margin = new System.Windows.Forms.Padding(0);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtresultado.Size = new System.Drawing.Size(451, 325);
            this.txtresultado.TabIndex = 2;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblvalor1
            // 
            this.lblvalor1.AutoSize = true;
            this.lblvalor1.Location = new System.Drawing.Point(27, 87);
            this.lblvalor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(201, 20);
            this.lblvalor1.TabIndex = 3;
            this.lblvalor1.Text = "Ingresar el radio del circulo:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(313, 85);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(121, 26);
            this.txtnum1.TabIndex = 4;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(31, 184);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(451, 37);
            this.btngenerar.TabIndex = 5;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // lblvalor2
            // 
            this.lblvalor2.AutoSize = true;
            this.lblvalor2.Location = new System.Drawing.Point(25, 137);
            this.lblvalor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalor2.Name = "lblvalor2";
            this.lblvalor2.Size = new System.Drawing.Size(201, 20);
            this.lblvalor2.TabIndex = 7;
            this.lblvalor2.Text = "Ingresar el radio del circulo:";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(313, 135);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(121, 26);
            this.txtnum2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(520, 584);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblvalor2);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblvalor1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de figuras geométricas con asteriscos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblvalor1;
        private System.Windows.Forms.NumericUpDown txtnum1;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label lblvalor2;
        private System.Windows.Forms.NumericUpDown txtnum2;
    }
}

