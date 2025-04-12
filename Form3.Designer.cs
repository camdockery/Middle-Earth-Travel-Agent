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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(2, -1);
            label1.Name = "label1";
            label1.Size = new Size(800, 131);
            label1.TabIndex = 2;
            label1.Text = "Booking";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Horse?", "Great Eagle?" });
            checkedListBox1.Location = new Point(594, 149);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 40);
            checkedListBox1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}