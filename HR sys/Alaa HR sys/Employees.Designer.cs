namespace Alaa_HR_sys
{
    partial class Employees
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox12 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox14 = new TextBox();
            label15 = new Label();
            textBox15 = new TextBox();
            label16 = new Label();
            textBox16 = new TextBox();
            label17 = new Label();
            textBox17 = new TextBox();
            label18 = new Label();
            textBox18 = new TextBox();
            label21 = new Label();
            label23 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            bindingSource1 = new BindingSource(components);
            label24 = new Label();
            comboBox4 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Checked = false;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(421, 246);
            dateTimePicker3.MaxDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTimePicker3.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(147, 27);
            dateTimePicker3.TabIndex = 56;
            dateTimePicker3.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Checked = false;
            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(118, 318);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(140, 27);
            dateTimePicker2.TabIndex = 55;
            dateTimePicker2.Value = new DateTime(2023, 11, 19, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(655, 117);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 0;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(655, 170);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(655, 223);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(655, 276);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 3;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 4;
            textBox1.Validating += textBox1_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(1, 45);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 5;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(1, 80);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Position";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1, 113);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 9;
            label3.Text = "Salary";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(1, 148);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 11;
            label4.Text = "Department ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 27);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(1, 182);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 13;
            label5.Text = "Section ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(116, 179);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 27);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(1, 218);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 15;
            label6.Text = "Cost Center L-1";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(116, 215);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 27);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(1, 252);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 17;
            label7.Text = "Cost Center L-2";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(116, 249);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(140, 27);
            textBox7.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(1, 287);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(71, 20);
            label8.TabIndex = 19;
            label8.Text = "Join Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(289, 250);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(76, 20);
            label9.TabIndex = 35;
            label9.Text = "Birth Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(289, 215);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 33;
            label10.Text = "Marital Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(3, 14);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 31;
            label11.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(289, 114);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 29;
            label12.Text = "SSN";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(421, 111);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(147, 27);
            textBox12.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(289, 80);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 27;
            label13.Text = "Religion ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(289, 388);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 25;
            label14.Text = "Email";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(421, 385);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(147, 27);
            textBox14.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(289, 355);
            label15.Name = "label15";
            label15.Size = new Size(96, 20);
            label15.TabIndex = 23;
            label15.Text = "Iban Number";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(421, 352);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(147, 27);
            textBox15.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(289, 45);
            label16.Name = "label16";
            label16.Size = new Size(119, 20);
            label16.TabIndex = 21;
            label16.Text = "Employee Name";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(421, 42);
            textBox16.Name = "textBox16";
            textBox16.PlaceholderText = "Write The Full Name";
            textBox16.Size = new Size(147, 27);
            textBox16.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(289, 321);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(132, 20);
            label17.TabIndex = 39;
            label17.Text = "Employee Address";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(421, 318);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(147, 27);
            textBox17.TabIndex = 38;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Location = new Point(289, 286);
            label18.Name = "label18";
            label18.Size = new Size(105, 20);
            label18.TabIndex = 37;
            label18.Text = "Phone number";
            // 
            // textBox18
            // 
            textBox18.ForeColor = SystemColors.InfoText;
            textBox18.Location = new Point(421, 283);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(147, 27);
            textBox18.TabIndex = 36;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Location = new Point(1, 323);
            label21.Name = "label21";
            label21.Size = new Size(106, 20);
            label21.TabIndex = 41;
            label21.Text = "Resigned Date";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Location = new Point(-3, 357);
            label23.Name = "label23";
            label23.Size = new Size(119, 20);
            label23.TabIndex = 48;
            label23.Text = "Employee Status";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label11);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(289, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 38);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(201, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 33;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(132, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "mmm";
            comboBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 355);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 25);
            comboBox1.TabIndex = 52;
            comboBox1.Text = "The Current Status";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(118, 389);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 24);
            checkBox1.TabIndex = 53;
            checkBox1.Text = "In Test";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(116, 282);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 27);
            dateTimePicker1.TabIndex = 54;
            dateTimePicker1.Value = new DateTime(2023, 11, 12, 0, 0, 0, 0);
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.DisplayMember = "mmm";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(421, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(147, 28);
            comboBox2.TabIndex = 57;
            // 
            // comboBox3
            // 
            comboBox3.DisplayMember = "mmm";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(421, 212);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(147, 28);
            comboBox3.TabIndex = 58;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Location = new Point(290, 148);
            label24.Name = "label24";
            label24.Size = new Size(82, 20);
            label24.TabIndex = 61;
            label24.Text = "Nationality";
            // 
            // comboBox4
            // 
            comboBox4.DisplayMember = "mmm";
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(421, 144);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(147, 28);
            comboBox4.TabIndex = 62;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 454);
            Controls.Add(comboBox4);
            Controls.Add(label24);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label17);
            Controls.Add(textBox17);
            Controls.Add(label18);
            Controls.Add(textBox18);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(textBox12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(textBox14);
            Controls.Add(label15);
            Controls.Add(textBox15);
            Controls.Add(label16);
            Controls.Add(textBox16);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
        private Label label14;
        private TextBox textBox14;
        private Label label15;
        private TextBox textBox15;
        private Label label16;
        private TextBox textBox16;
        private Label label17;
        private TextBox textBox17;
        private Label label18;
        private TextBox textBox18;
        private Label label21;
        private Label label23;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private BindingSource bindingSource1;
        private Label label24;
        private ComboBox comboBox4;
    }
}