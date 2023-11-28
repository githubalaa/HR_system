namespace Alaa_HR_sys
{
    partial class cost_center
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cost_center));
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(323, 168);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 43;
            label4.Text = "Cost Cente Level-2 ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(496, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(99, 27);
            textBox4.TabIndex = 42;
            textBox4.Validating += textBox4_Validating;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 279);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 39;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(655, 226);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 38;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(655, 173);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 37;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(655, 120);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 36;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(48, 232);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 45;
            label1.Text = "Cost Center Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(21, 168);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 47;
            label2.Text = "Cost Center Level-1 ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 27);
            textBox2.TabIndex = 46;
            textBox2.Validating += textBox2_Validating_1;
            // 
            // cost_center
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
            Name = "cost_center";
            Text = "cost centers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}