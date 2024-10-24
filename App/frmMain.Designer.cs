namespace App
{
    partial class frmMain
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
            pnlHeader = new Panel();
            lblAppName = new Label();
            pbAppLogo = new PictureBox();
            flpSideBar = new FlowLayoutPanel();
            lblSectionOverview = new Label();
            btnDashboard = new Button();
            btnPatient = new Button();
            btnAppointment = new Button();
            pnlSideBar = new Panel();
            flpSideBarBottom = new FlowLayoutPanel();
            btnLogout = new Button();
            btnSettings = new Button();
            lblSectionAccount = new Label();
            pnlModule = new Panel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppLogo).BeginInit();
            flpSideBar.SuspendLayout();
            pnlSideBar.SuspendLayout();
            flpSideBarBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pbAppLogo);
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(236, 48);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(54, 8);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(179, 32);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "   HEALTHCORE";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbAppLogo
            // 
            pbAppLogo.BackColor = Color.Transparent;
            pbAppLogo.BackgroundImage = Properties.Resources.app_logo;
            pbAppLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbAppLogo.Dock = DockStyle.Left;
            pbAppLogo.Location = new Point(0, 0);
            pbAppLogo.Name = "pbAppLogo";
            pbAppLogo.Size = new Size(48, 48);
            pbAppLogo.TabIndex = 0;
            pbAppLogo.TabStop = false;
            // 
            // flpSideBar
            // 
            flpSideBar.BackColor = Color.Transparent;
            flpSideBar.Controls.Add(pnlHeader);
            flpSideBar.Controls.Add(lblSectionOverview);
            flpSideBar.Controls.Add(btnDashboard);
            flpSideBar.Controls.Add(btnPatient);
            flpSideBar.Controls.Add(btnAppointment);
            flpSideBar.Dock = DockStyle.Fill;
            flpSideBar.FlowDirection = FlowDirection.TopDown;
            flpSideBar.Location = new Point(16, 16);
            flpSideBar.Name = "flpSideBar";
            flpSideBar.Size = new Size(236, 564);
            flpSideBar.TabIndex = 1;
            // 
            // lblSectionOverview
            // 
            lblSectionOverview.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionOverview.ForeColor = SystemColors.AppWorkspace;
            lblSectionOverview.Location = new Point(3, 54);
            lblSectionOverview.Name = "lblSectionOverview";
            lblSectionOverview.Size = new Size(233, 32);
            lblSectionOverview.TabIndex = 1;
            lblSectionOverview.Text = "OVERVIEW";
            lblSectionOverview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.GrayText;
            btnDashboard.Image = Properties.Resources.module_dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 89);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(230, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "      &Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPatient
            // 
            btnPatient.FlatAppearance.BorderSize = 0;
            btnPatient.FlatStyle = FlatStyle.Flat;
            btnPatient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatient.ForeColor = SystemColors.GrayText;
            btnPatient.Image = Properties.Resources.module_patient;
            btnPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatient.Location = new Point(3, 143);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(233, 48);
            btnPatient.TabIndex = 2;
            btnPatient.Text = "      &Patient";
            btnPatient.TextAlign = ContentAlignment.MiddleLeft;
            btnPatient.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            btnAppointment.FlatAppearance.BorderSize = 0;
            btnAppointment.FlatStyle = FlatStyle.Flat;
            btnAppointment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppointment.ForeColor = SystemColors.GrayText;
            btnAppointment.Image = Properties.Resources.module_appointment;
            btnAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointment.Location = new Point(3, 197);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(233, 48);
            btnAppointment.TabIndex = 3;
            btnAppointment.Text = "      &Appointment";
            btnAppointment.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointment.UseVisualStyleBackColor = true;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(236, 238, 239);
            pnlSideBar.Controls.Add(flpSideBar);
            pnlSideBar.Controls.Add(flpSideBarBottom);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(16);
            pnlSideBar.Size = new Size(268, 744);
            pnlSideBar.TabIndex = 2;
            // 
            // flpSideBarBottom
            // 
            flpSideBarBottom.Controls.Add(btnLogout);
            flpSideBarBottom.Controls.Add(btnSettings);
            flpSideBarBottom.Controls.Add(lblSectionAccount);
            flpSideBarBottom.Dock = DockStyle.Bottom;
            flpSideBarBottom.FlowDirection = FlowDirection.BottomUp;
            flpSideBarBottom.Location = new Point(16, 580);
            flpSideBarBottom.Name = "flpSideBarBottom";
            flpSideBarBottom.Size = new Size(236, 148);
            flpSideBarBottom.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.GrayText;
            btnLogout.Image = Properties.Resources.app_logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 97);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(236, 48);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "      &Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = SystemColors.GrayText;
            btnSettings.Image = Properties.Resources.app_settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 43);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(236, 48);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "      &Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // lblSectionAccount
            // 
            lblSectionAccount.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionAccount.ForeColor = SystemColors.AppWorkspace;
            lblSectionAccount.Location = new Point(3, 8);
            lblSectionAccount.Name = "lblSectionAccount";
            lblSectionAccount.Size = new Size(233, 32);
            lblSectionAccount.TabIndex = 4;
            lblSectionAccount.Text = "ACCOUNT";
            lblSectionAccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlModule
            // 
            pnlModule.Dock = DockStyle.Fill;
            pnlModule.Location = new Point(268, 0);
            pnlModule.Name = "pnlModule";
            pnlModule.Size = new Size(781, 744);
            pnlModule.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1049, 744);
            Controls.Add(pnlModule);
            Controls.Add(pnlSideBar);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmMain";
            Text = "HEALTHCORE";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAppLogo).EndInit();
            flpSideBar.ResumeLayout(false);
            pnlSideBar.ResumeLayout(false);
            flpSideBarBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private FlowLayoutPanel flpSideBar;
        private Button btnDashboard;
        private Label lblSectionOverview;
        private Button btnPatient;
        private Button btnAppointment;
        private PictureBox pbAppLogo;
        private Label lblAppName;
        private Panel pnlSideBar;
        private FlowLayoutPanel flpSideBarBottom;
        private Button btnLogout;
        private Label lblSectionAccount;
        private Button btnSettings;
        private Panel pnlModule;
    }
}