namespace Alaa_HR_sys
{
    partial class Vac_op
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vac_op));
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(50, 192);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 75;
            label1.Text = "First Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 74;
            textBox1.Validating += textBox1_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(50, 154);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 73;
            label4.Text = "Vacation Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(50, 119);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 71;
            label3.Text = "Employee ID";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 278);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 69;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(655, 225);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 68;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(655, 172);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 67;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(655, 119);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 66;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(51, 237);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 77;
            label2.Text = "Last Date";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(353, 157);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 81;
            label6.Text = "Vacation Days";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(353, 194);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 24);
            checkBox1.TabIndex = 84;
            checkBox1.Text = "Posted";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(160, 231);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(166, 27);
            dateTimePicker2.TabIndex = 85;
            dateTimePicker2.Value = new DateTime(2023, 11, 12, 0, 0, 0, 0);
            dateTimePicker2.Validating += dateTimePicker2_Validating;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(160, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 27);
            dateTimePicker1.TabIndex = 86;
            dateTimePicker1.Value = new DateTime(2023, 11, 6, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.BackColor = Color.WhiteSmoke;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(463, 157);
            label5.Name = "label5";
            label5.Size = new Size(112, 27);
            label5.TabIndex = 87;
            // 
            // Vac_op
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Vac_op";
            Text = "Employee Vacation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}