namespace ATM
{
    partial class DEPOSIT
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
            backbtn2 = new Button();
            label2 = new Label();
            lgout2 = new Button();
            depbtn2 = new Button();
            label3 = new Label();
            deptxt1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(backbtn2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 109);
            panel1.TabIndex = 4;
            // 
            // backbtn2
            // 
            backbtn2.Location = new Point(842, 23);
            backbtn2.Name = "backbtn2";
            backbtn2.Size = new Size(33, 29);
            backbtn2.TabIndex = 14;
            backbtn2.Text = "X";
            backbtn2.UseVisualStyleBackColor = true;
            backbtn2.Click += backbtn2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(182, 35);
            label2.Name = "label2";
            label2.Size = new Size(536, 50);
            label2.TabIndex = 0;
            label2.Text = "ENTER AMOUNT TO DEPOSIT";
            // 
            // lgout2
            // 
            lgout2.BackColor = Color.LawnGreen;
            lgout2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lgout2.Location = new Point(339, 447);
            lgout2.Name = "lgout2";
            lgout2.Size = new Size(164, 40);
            lgout2.TabIndex = 10;
            lgout2.Text = "LOG OUT";
            lgout2.UseVisualStyleBackColor = false;
            lgout2.Click += lgout2_Click;
            // 
            // depbtn2
            // 
            depbtn2.BackColor = Color.DeepSkyBlue;
            depbtn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depbtn2.Location = new Point(431, 296);
            depbtn2.Name = "depbtn2";
            depbtn2.Size = new Size(164, 47);
            depbtn2.TabIndex = 11;
            depbtn2.Text = "DEPOSIT";
            depbtn2.UseVisualStyleBackColor = false;
            depbtn2.Click += depbtn2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(227, 222);
            label3.Name = "label3";
            label3.Size = new Size(159, 38);
            label3.TabIndex = 12;
            label3.Text = "AMOUNT: ";
            // 
            // deptxt1
            // 
            deptxt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deptxt1.Location = new Point(431, 226);
            deptxt1.Name = "deptxt1";
            deptxt1.Size = new Size(164, 34);
            deptxt1.TabIndex = 13;
            deptxt1.TextChanged += deptxt1_TextChanged;
            // 
            // DEPOSIT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 521);
            Controls.Add(deptxt1);
            Controls.Add(label3);
            Controls.Add(depbtn2);
            Controls.Add(lgout2);
            Controls.Add(panel1);
            Name = "DEPOSIT";
            Text = "deposit";
            Load += DEPOSIT_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button lgout2;
        private Button depbtn2;
        private Label label3;
        private TextBox deptxt1;
        private Button backbtn2;
    }
}