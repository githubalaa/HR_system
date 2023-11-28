namespace Alaa_HR_sys
{
    partial class Income_Tax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income_Tax));
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(95, 254);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 115;
            label2.Text = "Tax Factor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 27);
            textBox2.TabIndex = 114;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(95, 218);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 113;
            label1.Text = "To (income per year)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 112;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(95, 180);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 111;
            label4.Text = "From (income per year)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(261, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 27);
            textBox4.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(95, 145);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 109;
            label3.Text = "Serial";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 27);
            textBox3.TabIndex = 108;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(659, 274);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 107;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(659, 221);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 106;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(659, 168);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 105;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(659, 115);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 104;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // Income_Tax
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Income_Tax";
            Text = "Income Tax";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}