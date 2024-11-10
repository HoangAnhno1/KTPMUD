namespace DANG_NHAP
{
    partial class Dang_nhap
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
            btnDN = new Button();
            txtTK = new TextBox();
            label1 = new Label();
            txtMK = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnDangky = new Button();
            SuspendLayout();
            // 
            // btnDN
            // 
            btnDN.BackColor = SystemColors.ControlLightLight;
            btnDN.Location = new Point(168, 179);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(94, 29);
            btnDN.TabIndex = 0;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += button1_Click;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(203, 89);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(170, 27);
            txtTK.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 92);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập: ";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(203, 124);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(170, 27);
            txtMK.TabIndex = 7;
            txtMK.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 127);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(138, 29);
            label3.Name = "label3";
            label3.Size = new Size(217, 39);
            label3.TabIndex = 6;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnDangky
            // 
            btnDangky.Location = new Point(279, 179);
            btnDangky.Name = "btnDangky";
            btnDangky.Size = new Size(94, 29);
            btnDangky.TabIndex = 8;
            btnDangky.Text = "Đăng ký";
            btnDangky.UseVisualStyleBackColor = true;
            btnDangky.Click += btnDangky_Click;
            // 
            // Dang_nhap
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(483, 276);
            Controls.Add(btnDangky);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMK);
            Controls.Add(label1);
            Controls.Add(txtTK);
            Controls.Add(btnDN);
            Name = "Dang_nhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDN;
        private TextBox txtTK;
        private Label label1;
        private TextBox txtMK;
        private Label label2;
        private Label label3;
        private Button btnDangky;
    }
}
