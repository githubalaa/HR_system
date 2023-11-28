namespace Alaa_HR_sys
{
    partial class overtime_op
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overtime_op));
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(35, 116);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 109;
            label3.Text = "Employee ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 27);
            textBox3.TabIndex = 108;
            textBox3.Validating += textBox3_Validating;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 275);
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
            button3.Location = new Point(655, 222);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 106;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(655, 169);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 105;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(655, 116);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 104;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(35, 267);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 131;
            label1.Text = "OverTime Factor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(34, 222);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 129;
            label8.Text = "OverTime Hours";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(34, 172);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 128;
            label9.Text = "OverTime Date";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(191, 218);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(130, 27);
            textBox6.TabIndex = 127;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(191, 259);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(130, 27);
            textBox8.TabIndex = 125;
            textBox8.Text = "2";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(187, 169);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 27);
            dateTimePicker1.TabIndex = 132;
            dateTimePicker1.Value = new DateTime(2023, 10, 16, 20, 38, 3, 0);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(191, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 133;
            checkBox1.Text = "Posted";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // overtime_op
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "overtime_op";
            Text = "Employee Overtime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox8;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
    }
}