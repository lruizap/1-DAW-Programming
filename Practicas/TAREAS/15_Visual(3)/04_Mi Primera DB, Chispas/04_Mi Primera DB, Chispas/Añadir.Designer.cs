namespace _04_Mi_Primera_DB__Chispas
{
    partial class Añadir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3stock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1Cancelar = new System.Windows.Forms.Button();
            this.textBox1codigo = new System.Windows.Forms.TextBox();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3stock
            // 
            this.textBox3stock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3stock.Location = new System.Drawing.Point(78, 373);
            this.textBox3stock.Name = "textBox3stock";
            this.textBox3stock.Size = new System.Drawing.Size(231, 29);
            this.textBox3stock.TabIndex = 4;
            this.textBox3stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3stock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Stock";
            // 
            // textBox2precio
            // 
            this.textBox2precio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2precio.Location = new System.Drawing.Point(78, 287);
            this.textBox2precio.Name = "textBox2precio";
            this.textBox2precio.Size = new System.Drawing.Size(231, 29);
            this.textBox2precio.TabIndex = 3;
            this.textBox2precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2precio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Precio";
            // 
            // textBox4Descripcion
            // 
            this.textBox4Descripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4Descripcion.Location = new System.Drawing.Point(109, 107);
            this.textBox4Descripcion.MaxLength = 50;
            this.textBox4Descripcion.Multiline = true;
            this.textBox4Descripcion.Name = "textBox4Descripcion";
            this.textBox4Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4Descripcion.Size = new System.Drawing.Size(446, 113);
            this.textBox4Descripcion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Descripción";
            // 
            // button1Cancelar
            // 
            this.button1Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1Cancelar.Location = new System.Drawing.Point(447, 439);
            this.button1Cancelar.Name = "button1Cancelar";
            this.button1Cancelar.Size = new System.Drawing.Size(108, 44);
            this.button1Cancelar.TabIndex = 6;
            this.button1Cancelar.Text = "Cancelar";
            this.button1Cancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1codigo
            // 
            this.textBox1codigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1codigo.Location = new System.Drawing.Point(78, 26);
            this.textBox1codigo.Name = "textBox1codigo";
            this.textBox1codigo.Size = new System.Drawing.Size(231, 29);
            this.textBox1codigo.TabIndex = 1;
            this.textBox1codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1codigo_KeyPress);
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1Aceptar.Location = new System.Drawing.Point(333, 439);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(108, 44);
            this.button1Aceptar.TabIndex = 5;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código";
            // 
            // Añadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 502);
            this.Controls.Add(this.textBox3stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4Descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1Cancelar);
            this.Controls.Add(this.textBox1codigo);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.label1);
            this.Name = "Añadir";
            this.Text = "Añadir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox3stock;
        private Label label3;
        private TextBox textBox2precio;
        private Label label2;
        private TextBox textBox4Descripcion;
        private Label label4;
        private Button button1Cancelar;
        private TextBox textBox1codigo;
        private Button button1Aceptar;
        private Label label1;
    }
}