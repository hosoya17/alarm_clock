namespace alarm_clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 84);
            label1.Name = "label1";
            label1.Size = new Size(689, 129);
            label1.TabIndex = 0;
            label1.Text = "00時00分00秒";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBox1.Location = new Point(192, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox2.Location = new Point(339, 332);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(106, 23);
            comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 326);
            label2.Name = "label2";
            label2.Size = new Size(29, 29);
            label2.TabIndex = 3;
            label2.Text = "時";
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(451, 326);
            label3.Name = "label3";
            label3.Size = new Size(29, 29);
            label3.TabIndex = 4;
            label3.Text = "分";
            // 
            // button1
            // 
            button1.Location = new Point(486, 332);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 5;
            button1.Text = "アラームセット";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(241, 279);
            label6.Name = "label6";
            label6.Size = new Size(328, 47);
            label6.TabIndex = 8;
            label6.Text = "設定時刻:00時00分";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(339, 55);
            label7.Name = "label7";
            label7.Size = new Size(116, 29);
            label7.TabIndex = 9;
            label7.Text = "時間です。";
            label7.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(388, 400);
            button2.Name = "button2";
            button2.Size = new Size(83, 38);
            button2.TabIndex = 10;
            button2.Text = "停止";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(299, 400);
            button3.Name = "button3";
            button3.Size = new Size(83, 38);
            button3.TabIndex = 11;
            button3.Text = "スヌーズ";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "目覚まし時計";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}