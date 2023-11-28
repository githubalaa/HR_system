namespace Alaa_HR_sys
{
    partial class Exp_op
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exp_op));
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(40, 247);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 101;
            label2.Text = "Expencess Amount";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 27);
            textBox2.TabIndex = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(40, 211);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 99;
            label1.Text = "Expencess Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(40, 173);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 97;
            label4.Text = "Expencess Code";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(197, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 27);
            textBox4.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(40, 138);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 95;
            label3.Text = "Employee ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 27);
            textBox3.TabIndex = 94;
            textBox3.Validating += textBox3_Validating;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 276);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 93;
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
            button3.TabIndex = 92;
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
            button2.TabIndex = 91;
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
            button1.TabIndex = 90;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(40, 285);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 103;
            label5.Text = "Expencess Description";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(197, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 27);
            textBox5.TabIndex = 102;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(197, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 27);
            dateTimePicker1.TabIndex = 145;
            // 
            // Exp_op
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Exp_op";
            Text = "Employee Expencess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
    }
}