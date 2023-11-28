namespace Alaa_HR_sys
{
    partial class rec_ded_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rec_ded_base));
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(67, 199);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 65;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(67, 161);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 63;
            label4.Text = "Code";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 27);
            textBox4.TabIndex = 62;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 282);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 59;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(655, 229);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 58;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(655, 176);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 57;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(655, 123);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 56;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(67, 236);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 67;
            label2.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 66;
            // 
            // rec_ded_base
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "rec_ded_base";
            Text = "Recieves And Deductions Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
    }
}