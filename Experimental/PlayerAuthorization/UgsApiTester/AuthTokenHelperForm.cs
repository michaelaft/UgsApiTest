using System;
using System.Windows.Forms;
using AFT.UGS.Core.Interfaces.Tokens;
using AFT.UGS.Services.Infrastructure;
using AFT.UGS.Services.Infrastructure.Tokens;
using Newtonsoft.Json;

namespace UgsApiTester
{
    public partial class AuthTokenHelperForm : Form
    {
        public AuthTokenHelperForm()
        {
            InitializeComponent();
        }

        private void DecryptToken()
        {
            try
            {
                ITokenProvider tp = new TokenProvider(new UgsTokenConfig(), new Base62TokenEncoder());

                var baseTokenData = tp.DecryptToken(txtToken.Text);

                txtDecrypted.Clear();
                txtDecrypted.AppendText("Token kind: " + baseTokenData.Kind.ToString() + "\r\n");
                txtDecrypted.AppendText("Token content in JSON format: \r\n");
                var decrypted = JsonConvert.SerializeObject(baseTokenData, Formatting.Indented);
                txtDecrypted.AppendText(decrypted);
                Clipboard.SetText(decrypted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecryptToken_Click(object sender, EventArgs e)
        {
            DecryptToken();
        }
    }
}
