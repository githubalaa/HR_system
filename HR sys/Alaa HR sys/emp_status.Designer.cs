namespace Alaa_HR_sys
{
    partial class emp_status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_status));
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
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
            label2.Location = new Point(34, 187);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 57;
            label2.Text = "Status ID";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 27);
            textBox2.TabIndex = 56;
            textBox2.Validating += textBox2_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(34, 234);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 53;
            label4.Text = "Status Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(207, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 52;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(634, 284);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 51;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(634, 231);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 50;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(634, 178);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 49;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(634, 125);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 48;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // emp_status
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "emp_status";
            Text = "Employee Status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}