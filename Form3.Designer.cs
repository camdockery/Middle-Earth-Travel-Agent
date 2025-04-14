namespace Middle_Earth_Travel_Agent
{
    partial class Form3
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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            checkedListBox2 = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(2, -1);
            label1.Name = "label1";
            label1.Size = new Size(914, 175);
            label1.TabIndex = 2;
            label1.Text = "Booking";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(679, 199);
            checkedListBox1.Margin = new Padding(3, 4, 3, 4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(151, 92);
            checkedListBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(234, 435);
            button1.Name = "button1";
            button1.Size = new Size(448, 100);
            button1.TabIndex = 4;
            button1.Text = "Go On An Adventure!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(459, 199);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 70);
            checkedListBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 164);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 164);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(104, 199);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(monthCalendar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(checkedListBox2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private CheckedListBox checkedListBox2;
        private Label label2;
        private Label label3;
        private MonthCalendar monthCalendar1;
    }
}