using App.Modules.Dashboard;

namespace App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenModule(Form formModule)
        {
            formModule.TopLevel = false;
            formModule.FormBorderStyle = FormBorderStyle.None;
            formModule.Dock = DockStyle.Fill;
            pnlModule.Controls.Add(formModule);
            pnlModule.Tag = formModule;
            formModule.BringToFront();
            formModule.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.OpenModule(new frmDashboard());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You're about to log out.\nLogging out will end your current session.\n\nWould you like to continue?",
                                "Confirm Log Out",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
