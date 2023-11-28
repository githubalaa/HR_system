namespace Alaa_HR_sys
{
    partial class exp_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exp_base));
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(76, 205);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 53;
            label4.Text = "Expencess Type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(221, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(76, 170);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 51;
            label3.Text = "Expencess Code";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 27);
            textBox3.TabIndex = 50;
            textBox3.Validating += textBox3_Validating;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 276);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 49;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(655, 223);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 48;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(655, 170);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 47;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(655, 117);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 46;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(221, 251);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 24);
            checkBox1.TabIndex = 148;
            checkBox1.Text = "With Tax";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // exp_base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "exp_base";
            Text = "Expencess Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
    }
}