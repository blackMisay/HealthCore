namespace App
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnlogin = new Button();
            cboxremem = new CheckBox();
            lblusername = new Label();
            txtusername = new TextBox();
            lbl_logacc = new Label();
            txtpassword = new TextBox();
            lblpass = new Label();
            picbox_logo = new PictureBox();
            linkpass = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picbox_logo).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.MediumOrchid;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 12F);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(64, 362);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(247, 37);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // cboxremem
            // 
            cboxremem.AutoSize = true;
            cboxremem.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboxremem.ForeColor = Color.Gray;
            cboxremem.Location = new Point(64, 318);
            cboxremem.Name = "cboxremem";
            cboxremem.Size = new Size(117, 23);
            cboxremem.TabIndex = 1;
            cboxremem.Text = "Remember me";
            cboxremem.UseVisualStyleBackColor = true;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.Gray;
            lblusername.Location = new Point(64, 189);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(81, 21);
            lblusername.TabIndex = 2;
            lblusername.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 12F);
            txtusername.Location = new Point(64, 213);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(247, 29);
            txtusername.TabIndex = 3;
            // 
            // lbl_logacc
            // 
            lbl_logacc.AutoSize = true;
            lbl_logacc.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_logacc.ForeColor = Color.Gray;
            lbl_logacc.Location = new Point(95, 141);
            lbl_logacc.Name = "lbl_logacc";
            lbl_logacc.Size = new Size(179, 25);
            lbl_logacc.TabIndex = 4;
            lbl_logacc.Text = "Log in your account";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F);
            txtpassword.Location = new Point(64, 283);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '•';
            txtpassword.Size = new Size(247, 29);
            txtpassword.TabIndex = 6;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpass.ForeColor = Color.Gray;
            lblpass.Location = new Point(61, 259);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(76, 21);
            lblpass.TabIndex = 5;
            lblpass.Text = "Password";
            // 
            // picbox_logo
            // 
            picbox_logo.BackgroundImageLayout = ImageLayout.Center;
            picbox_logo.Image = (Image)resources.GetObject("picbox_logo.Image");
            picbox_logo.Location = new Point(128, 31);
            picbox_logo.Name = "picbox_logo";
            picbox_logo.Size = new Size(112, 107);
            picbox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox_logo.TabIndex = 8;
            picbox_logo.TabStop = false;
            // 
            // linkpass
            // 
            linkpass.AutoSize = true;
            linkpass.LinkColor = Color.MediumOrchid;
            linkpass.Location = new Point(211, 322);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(100, 15);
            linkpass.TabIndex = 9;
            linkpass.TabStop = true;
            linkpass.Text = "Forgot Password?";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(369, 440);
            Controls.Add(linkpass);
            Controls.Add(picbox_logo);
            Controls.Add(txtpassword);
            Controls.Add(lblpass);
            Controls.Add(lbl_logacc);
            Controls.Add(txtusername);
            Controls.Add(lblusername);
            Controls.Add(cboxremem);
            Controls.Add(btnlogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picbox_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlogin;
        private CheckBox cboxremem;
        private Label lblusername;
        private TextBox txtusername;
        private Label lbl_logacc;
        private TextBox txtpassword;
        private Label lblpass;
        private PictureBox picbox_logo;
        private LinkLabel linkpass;
    }
}
