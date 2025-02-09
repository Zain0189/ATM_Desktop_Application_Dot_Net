namespace ATM
{
    partial class balance
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
            baltxt = new TextBox();
            button5 = new Button();
            chbalbtn = new Button();
            backbtn3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(backbtn3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 105);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(332, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 50);
            label1.TabIndex = 0;
            label1.Text = "BALANCE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(122, 306);
            label2.Name = "label2";
            label2.Size = new Size(221, 38);
            label2.TabIndex = 5;
            label2.Text = "ACC BALANCE: ";
            // 
            // baltxt
            // 
            baltxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            baltxt.Location = new Point(380, 310);
            baltxt.Name = "baltxt";
            baltxt.Size = new Size(186, 34);
            baltxt.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = Color.LawnGreen;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(348, 455);
            button5.Name = "button5";
            button5.Size = new Size(164, 40);
            button5.TabIndex = 9;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // chbalbtn
            // 
            chbalbtn.BackColor = Color.DeepSkyBlue;
            chbalbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbalbtn.Location = new Point(357, 229);
            chbalbtn.Name = "chbalbtn";
            chbalbtn.Size = new Size(222, 40);
            chbalbtn.TabIndex = 10;
            chbalbtn.Text = "CHECK BALANCE";
            chbalbtn.UseVisualStyleBackColor = false;
            chbalbtn.Click += chbalbtn_Click;
            // 
            // backbtn3
            // 
            backbtn3.Location = new Point(842, 29);
            backbtn3.Name = "backbtn3";
            backbtn3.Size = new Size(33, 29);
            backbtn3.TabIndex = 11;
            backbtn3.Text = "X";
            backbtn3.UseVisualStyleBackColor = true;
            backbtn3.Click += backbtn3_Click;
            // 
            // balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 521);
            Controls.Add(chbalbtn);
            Controls.Add(button5);
            Controls.Add(baltxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "balance";
            Text = "balance";
            Load += balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox baltxt;
        private Button button5;
        private Button chbalbtn;
        private Button backbtn3;
    }
}