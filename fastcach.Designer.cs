namespace ATM
{
    partial class fastcach
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            backbtn1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(backbtn1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 110);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(140, 28);
            label1.Name = "label1";
            label1.Size = new Size(605, 50);
            label1.TabIndex = 0;
            label1.Text = "SELECT AMOUNT TO WITHDRAW";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(140, 167);
            button1.Name = "button1";
            button1.Size = new Size(204, 47);
            button1.TabIndex = 3;
            button1.Text = "RS 500";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(551, 167);
            button2.Name = "button2";
            button2.Size = new Size(204, 47);
            button2.TabIndex = 4;
            button2.Text = "RS 1000";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(140, 265);
            button3.Name = "button3";
            button3.Size = new Size(204, 47);
            button3.TabIndex = 5;
            button3.Text = "RS 2000";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(551, 265);
            button4.Name = "button4";
            button4.Size = new Size(204, 47);
            button4.TabIndex = 6;
            button4.Text = "RS 5000";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(140, 356);
            button5.Name = "button5";
            button5.Size = new Size(204, 47);
            button5.TabIndex = 7;
            button5.Text = "RS 10000";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DeepSkyBlue;
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(551, 356);
            button6.Name = "button6";
            button6.Size = new Size(204, 47);
            button6.TabIndex = 8;
            button6.Text = "RS 25000";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LawnGreen;
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(374, 457);
            button7.Name = "button7";
            button7.Size = new Size(160, 36);
            button7.TabIndex = 9;
            button7.Text = "LOG OUT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // backbtn1
            // 
            backbtn1.Location = new Point(833, 28);
            backbtn1.Name = "backbtn1";
            backbtn1.Size = new Size(33, 29);
            backbtn1.TabIndex = 10;
            backbtn1.Text = "X";
            backbtn1.UseVisualStyleBackColor = true;
            backbtn1.Click += button8_Click;
            // 
            // fastcach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 521);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "fastcach";
            Text = "fastcach";
            Load += fastcach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button backbtn1;
    }
}