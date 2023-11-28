namespace Alaa_HR_sys
{
    partial class Bouns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bouns));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(642, 279);
            button4.Name = "button4";
            button4.Size = new Size(133, 41);
            button4.TabIndex = 65;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(642, 226);
            button3.Name = "button3";
            button3.Size = new Size(133, 41);
            button3.TabIndex = 64;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(642, 173);
            button2.Name = "button2";
            button2.Size = new Size(133, 41);
            button2.TabIndex = 63;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(642, 120);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 62;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(208, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 27);
            dateTimePicker1.TabIndex = 155;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(51, 246);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 150;
            label1.Text = "Bouns Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(51, 208);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 149;
            label4.Text = "Bouns ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 27);
            textBox4.TabIndex = 148;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(51, 173);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 147;
            label3.Text = "Employee ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 27);
            textBox3.TabIndex = 146;
            // 
            // Bouns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bouns";
            Text = "Bouns";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
    }
}