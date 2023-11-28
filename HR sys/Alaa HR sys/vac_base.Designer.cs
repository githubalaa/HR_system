namespace Alaa_HR_sys
{
    partial class vac_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vac_base));
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label13 = new Label();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label11 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(27, 153);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 43;
            label4.Text = "Vacation Type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(27, 118);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 41;
            label3.Text = "Vacation Code";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 27);
            textBox3.TabIndex = 40;
            textBox3.Validating += textBox3_Validating;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 277);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 39;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(655, 224);
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
            button2.Location = new Point(655, 171);
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
            button1.Location = new Point(655, 118);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 36;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(22, 192);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 45;
            label2.Text = "Vacation Factor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 27);
            textBox2.TabIndex = 44;
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "mmm";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(154, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(122, 28);
            comboBox2.TabIndex = 59;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(22, 241);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 58;
            label13.Text = "Religion ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(458, 152);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 24);
            checkBox1.TabIndex = 60;
            checkBox1.Text = "Yearly Reset";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label11);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(19, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 38);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(329, 8);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 24);
            radioButton3.TabIndex = 34;
            radioButton3.TabStop = true;
            radioButton3.Text = "All";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(245, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 33;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(176, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(3, 14);
            label11.Name = "label11";
            label11.Size = new Size(147, 20);
            label11.TabIndex = 31;
            label11.Text = "Gender Specification";
            // 
            // vac_base
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox2);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "vac_base";
            Text = "vacations Information";
            Load += vac_base_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label13;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label11;
    }
}