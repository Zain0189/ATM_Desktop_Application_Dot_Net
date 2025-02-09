namespace ATM
{
    partial class Home
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
            panel1 = new Panel();
            depbtn1 = new Button();
            withbtn1 = new Button();
            fastbtn1 = new Button();
            balbtn1 = new Button();
            lgout1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(140, 28);
            label1.Name = "label1";
            label1.Size = new Size(588, 50);
            label1.TabIndex = 0;
            label1.Text = "SELECT TRANSACTION METHOD";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 110);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // depbtn1
            // 
            depbtn1.BackColor = Color.DeepSkyBlue;
            depbtn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depbtn1.Location = new Point(140, 168);
            depbtn1.Name = "depbtn1";
            depbtn1.Size = new Size(204, 58);
            depbtn1.TabIndex = 2;
            depbtn1.Text = "DEPOSIT";
            depbtn1.UseVisualStyleBackColor = false;
            depbtn1.Click += button1_Click;
            // 
            // withbtn1
            // 
            withbtn1.BackColor = Color.DeepSkyBlue;
            withbtn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withbtn1.Location = new Point(549, 168);
            withbtn1.Name = "withbtn1";
            withbtn1.Size = new Size(204, 58);
            withbtn1.TabIndex = 3;
            withbtn1.Text = "WITHDRAW";
            withbtn1.UseVisualStyleBackColor = false;
            withbtn1.Click += withbtn1_Click;
            // 
            // fastbtn1
            // 
            fastbtn1.BackColor = Color.DeepSkyBlue;
            fastbtn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fastbtn1.Location = new Point(140, 287);
            fastbtn1.Name = "fastbtn1";
            fastbtn1.Size = new Size(204, 57);
            fastbtn1.TabIndex = 4;
            fastbtn1.Text = "FAST CASH";
            fastbtn1.UseVisualStyleBackColor = false;
            fastbtn1.Click += fastbtn1_Click;
            // 
            // balbtn1
            // 
            balbtn1.BackColor = Color.DeepSkyBlue;
            balbtn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balbtn1.Location = new Point(549, 287);
            balbtn1.Name = "balbtn1";
            balbtn1.Size = new Size(204, 57);
            balbtn1.TabIndex = 5;
            balbtn1.Text = "BALANCE";
            balbtn1.UseVisualStyleBackColor = false;
            balbtn1.Click += button4_Click;
            // 
            // lgout1
            // 
            lgout1.BackColor = Color.LawnGreen;
            lgout1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lgout1.Location = new Point(343, 462);
            lgout1.Name = "lgout1";
            lgout1.Size = new Size(204, 47);
            lgout1.TabIndex = 6;
            lgout1.Text = "LOG OUT";
            lgout1.UseVisualStyleBackColor = false;
            lgout1.Click += button5_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(887, 521);
            Controls.Add(lgout1);
            Controls.Add(balbtn1);
            Controls.Add(fastbtn1);
            Controls.Add(withbtn1);
            Controls.Add(depbtn1);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button depbtn1;
        private Button withbtn1;
        private Button fastbtn1;
        private Button balbtn1;
        private Button lgout1;
    }
}