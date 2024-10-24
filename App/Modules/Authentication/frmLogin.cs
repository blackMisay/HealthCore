namespace App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (frmMain MainApp = new frmMain())
            {
                this.Hide();
                MainApp.ShowDialog();
                this.Show();
            }
        }
    }
}
