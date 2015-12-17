using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AFT.UGS.Core.Clients;
using AFT.UGS.Core.Interfaces.Extensions;
using AFT.UGS.Core.Messages.OAuth;
using AFT.UGS.Core.Messages.Players;
using Newtonsoft.Json;

namespace UgsApiTester
{
    public partial class AuthorizationTestForm : Form
    {
        private IBrandApiClient _apiClient;
        private Dictionary<string, ClientCredential> _credentials;

        public AuthorizationTestForm()
        {
            InitializeComponent();
        }

        public string ServerBaseUrl { get; set; }

        private void AuthorizationTestForm_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabGetToken;

            _credentials = new Dictionary<string, ClientCredential>();
            _credentials.Add("BRAND_3", new ClientCredential { ClientId = "BRAND_3", ClientSecret = "w0jdfZGyDB3gWFJqGsBCTO3E7liTDgYoVrCaP7t13JMzryNIuKA3G2" });
            _credentials.Add("SSS", new ClientCredential { ClientId = "SSS", ClientSecret = "xVskIE6tVczOZ5OVxcypvaHg1w5ycV116hvmFdKXnEBdWCQu91uSug" });

            _credentials.Keys.AsEnumerable().Each(item => cboClientName.Items.Add(item));
            cboClientName.SelectedIndex = 0;

            _apiClient = new BrandApiClient(ServerBaseUrl);

            this.Text += " - " + ServerBaseUrl;
        }

        private void cboClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientName.SelectedIndex >= 0)
            {
                var cr = _credentials[cboClientName.Text];
                txtClientId.Text = cr.ClientId;
                txtClientSecret.Text = cr.ClientSecret;
            }
        }

        private void ShowError(Exception ex)
        {
            if (ex is AggregateException)
            {
                var aggEx = (AggregateException) ex;
                var sb = new StringBuilder();
                foreach (var innerEx in aggEx.InnerExceptions)
                {
                    sb.AppendLine(innerEx.GetBaseException().Message);
                }
                txtResponse.Text = sb.ToString();
                MessageBox.Show(aggEx.Message);
            }
            else
            {
                txtResponse.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetOAuthToken_Click(object sender, EventArgs e)
        {
            var clientCredentials = new ClientCredentialsTokenRequest()
            {
                client_id = txtClientId.Text,
                client_secret = txtClientSecret.Text,
                grant_type = cboGrantType.Text,
                scope = cboScope.Text
            };

            TokenResponse brandTokenResponse = null;

            try
            {

                var task = Task.Run(async () =>
                {
                    brandTokenResponse = await _apiClient.GetTokenAsync(clientCredentials);
                });

                task.Wait();

                txtAccessToken.Text = brandTokenResponse.access_token;
                txtResponse.Text = JsonConvert.SerializeObject(brandTokenResponse);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            // Authorize a player

            var request = new AuthorizePlayerRequest()
            {
                ipaddress = "184.70.137.34",
                username = "testuser112",
                userid = "1234567891",
                tag = "{\"aff\": \"123\"}",
                lang = "zh-CN",
                cur = "RMB",
                betlimitid = 1,
                loginurl = "http://ugslobby.com/login",
                cashierurl = "http://ugslobby.com/cashier",
                termsurl = "http://ugslobby.com/terms",
                helpurl = "http://ugslobby.com/help"
            };


            AuthorizePlayerResponse resp = null;
            try
            {
                var task = Task.Run(async () =>
                {
                    resp = await _apiClient.AuthorizePlayerAsync(request, txtAccessToken.Text);
                });

                task.Wait();

                txtPlayerToken.Text = resp.authtoken;
                txtResponse.Text = JsonConvert.SerializeObject(resp);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
    }
}
