using System;
using System.Windows.Forms;

namespace UgsApiTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboServerBaseUrl.SelectedIndex = 0;
        }

        private void btnAuthorizePlayer_Click(object sender, EventArgs e)
        {
            var form = new AuthorizationTestForm {ServerBaseUrl = cboServerBaseUrl.Text };
            form.ShowDialog();
        }

    }
}
