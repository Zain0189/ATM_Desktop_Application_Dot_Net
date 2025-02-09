namespace ATM
{
    partial class adminpin
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
            label2 = new Label();
            label4 = new Label();
            admintxt = new TextBox();
            adminbtn = new Button();
            lgout1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 115);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(192, 30);
            label1.Name = "label1";
            label1.Size = new Size(531, 50);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(341, 143);
            label2.Name = "label2";
            label2.Size = new Size(208, 46);
            label2.TabIndex = 7;
            label2.Text = "ADMIN PIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(202, 249);
            label4.Name = "label4";
            label4.Size = new Size(180, 38);
            label4.TabIndex = 8;
            label4.Text = "ADMIN PIN:";
            // 
            // admintxt
            // 
            admintxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admintxt.Location = new Point(404, 253);
            admintxt.Name = "admintxt";
            admintxt.Size = new Size(186, 34);
            admintxt.TabIndex = 9;
            admintxt.TextChanged += Pin_TextChanged;
            // 
            // adminbtn
            // 
            adminbtn.BackColor = Color.DeepSkyBlue;
            adminbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminbtn.Location = new Point(404, 327);
            adminbtn.Name = "adminbtn";
            adminbtn.Size = new Size(186, 40);
            adminbtn.TabIndex = 10;
            adminbtn.Text = "SUBMIT";
            adminbtn.UseVisualStyleBackColor = false;
            adminbtn.Click += adminbtn_Click;
            // 
            // lgout1
            // 
            lgout1.BackColor = Color.LawnGreen;
            lgout1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lgout1.Location = new Point(341, 472);
            lgout1.Name = "lgout1";
            lgout1.Size = new Size(169, 37);
            lgout1.TabIndex = 11;
            lgout1.Text = "HOME PAGE";
            lgout1.UseVisualStyleBackColor = false;
            lgout1.Click += lgout1_Click;
            // 
            // adminpin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 521);
            Controls.Add(lgout1);
            Controls.Add(adminbtn);
            Controls.Add(admintxt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "adminpin";
            Text = "adminpin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox admintxt;
        private Button adminbtn;
        private Button lgout1;
    }
}