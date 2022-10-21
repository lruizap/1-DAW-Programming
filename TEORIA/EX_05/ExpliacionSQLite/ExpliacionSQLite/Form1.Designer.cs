namespace ExpliacionSQLite
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
            this.button1CreateTable = new System.Windows.Forms.Button();
            this.button1Insert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1select = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1CreateTable
            // 
            this.button1CreateTable.Location = new System.Drawing.Point(12, 12);
            this.button1CreateTable.Name = "button1CreateTable";
            this.button1CreateTable.Size = new System.Drawing.Size(77, 64);
            this.button1CreateTable.TabIndex = 0;
            this.button1CreateTable.Text = "CREATE TABLE";
            this.button1CreateTable.UseVisualStyleBackColor = true;
            this.button1CreateTable.Click += new System.EventHandler(this.button1CreateTable_Click);
            // 
            // button1Insert
            // 
            this.button1Insert.Location = new System.Drawing.Point(14, 100);
            this.button1Insert.Name = "button1Insert";
            this.button1Insert.Size = new System.Drawing.Size(75, 56);
            this.button1Insert.TabIndex = 1;
            this.button1Insert.Text = "INSERT";
            this.button1Insert.UseVisualStyleBackColor = true;
            this.button1Insert.Click += new System.EventHandler(this.button1Insert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "id";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "text";
            this.textBox2.Size = new System.Drawing.Size(220, 23);
            this.textBox2.TabIndex = 3;
            // 
            // button1select
            // 
            this.button1select.Location = new System.Drawing.Point(14, 185);
            this.button1select.Name = "button1select";
            this.button1select.Size = new System.Drawing.Size(75, 56);
            this.button1select.TabIndex = 4;
            this.button1select.Text = "SELECT";
            this.button1select.UseVisualStyleBackColor = true;
            this.button1select.Click += new System.EventHandler(this.button1select_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(95, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 49);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1select);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1Insert);
            this.Controls.Add(this.button1CreateTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1CreateTable;
        private Button button1Insert;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1select;
        private ListBox listBox1;
    }
}