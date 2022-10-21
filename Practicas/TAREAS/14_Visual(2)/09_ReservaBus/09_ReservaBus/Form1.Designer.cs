namespace _09_ReservaBus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Reservas = new System.Windows.Forms.ColumnHeader();
            this.Plazas = new System.Windows.Forms.ColumnHeader();
            this.ReservaButton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 551);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reservas,
            this.Plazas});
            this.listView1.Location = new System.Drawing.Point(725, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(416, 584);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Reservas
            // 
            this.Reservas.Text = "Reservas";
            this.Reservas.Width = 160;
            // 
            // Plazas
            // 
            this.Plazas.Text = "Planzas";
            this.Plazas.Width = 160;
            // 
            // ReservaButton1
            // 
            this.ReservaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservaButton1.Location = new System.Drawing.Point(12, 12);
            this.ReservaButton1.Name = "ReservaButton1";
            this.ReservaButton1.Size = new System.Drawing.Size(116, 56);
            this.ReservaButton1.TabIndex = 3;
            this.ReservaButton1.Text = "Hacer Reserva";
            this.ReservaButton1.UseVisualStyleBackColor = true;
            this.ReservaButton1.Click += new System.EventHandler(this.ReservaButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(148, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nombre Reserva";
            this.textBox1.Size = new System.Drawing.Size(165, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 637);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ReservaButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private ListView listView1;
        private ColumnHeader Reservas;
        private ColumnHeader Plazas;
        private Button ReservaButton1;
        private TextBox textBox1;
    }
}