namespace Alaa_HR_sys
{
    partial class Bouns_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bouns_base));
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(41, 189);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 57;
            label4.Text = "Bouns Type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(41, 154);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 55;
            label3.Text = "Bouns ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 27);
            textBox3.TabIndex = 54;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(644, 278);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 61;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(644, 225);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 60;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(644, 172);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 59;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(644, 119);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 58;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(41, 227);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 63;
            label1.Text = "Bouns Factor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 27);
            textBox1.TabIndex = 62;
            // 
            // Bouns_base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Name = "Bouns_base";
            Text = "Bouns Base";
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
        private Label label1;
        private TextBox textBox1;
    }
}