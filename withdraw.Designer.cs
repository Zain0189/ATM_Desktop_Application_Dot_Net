namespace ATM
{
    partial class withdraw
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
            label2 = new Label();
            label3 = new Label();
            wthdrawtxt1 = new TextBox();
            button1 = new Button();
            button5 = new Button();
            backbtn4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(backbtn4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 109);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(132, 30);
            label2.Name = "label2";
            label2.Size = new Size(595, 50);
            label2.TabIndex = 0;
            label2.Text = "ENTER AMOUNT TO WITHDRAW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(224, 226);
            label3.Name = "label3";
            label3.Size = new Size(159, 38);
            label3.TabIndex = 13;
            label3.Text = "AMOUNT: ";
            // 
            // wthdrawtxt1
            // 
            wthdrawtxt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wthdrawtxt1.Location = new Point(430, 230);
            wthdrawtxt1.Name = "wthdrawtxt1";
            wthdrawtxt1.Size = new Size(164, 34);
            wthdrawtxt1.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(430, 299);
            button1.Name = "button1";
            button1.Size = new Size(164, 47);
            button1.TabIndex = 15;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LawnGreen;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(342, 441);
            button5.Name = "button5";
            button5.Size = new Size(164, 40);
            button5.TabIndex = 16;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // backbtn4
            // 
            backbtn4.Location = new Point(842, 21);
            backbtn4.Name = "backbtn4";
            backbtn4.Size = new Size(33, 29);
            backbtn4.TabIndex = 17;
            backbtn4.Text = "X";
            backbtn4.UseVisualStyleBackColor = true;
            backbtn4.Click += backbtn4_Click;
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 521);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(wthdrawtxt1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "withdraw";
            Text = "withdraw";
            Load += withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox wthdrawtxt1;
        private Button button1;
        private Button button5;
        private Button backbtn4;
    }
}