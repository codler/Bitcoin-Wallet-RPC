using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace BitcoinWalletRPC
{
    public partial class BitcoinWalletRPC : Form
    {
        string version = "1.0";
        string user_agent = "Bitcoin-Wallet-RPC/";
        string url = null;
        bool debug = false;

        public BitcoinWalletRPC()
        {
            InitializeComponent();
        }

        private static bool cert(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }

        private void BitcoinWalletRPC_Load(object sender, EventArgs e)
        {
            user_agent = "Bitcoin-Wallet-RPC/" + version;
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            url = "http://" + rpc_host.Text + ":" + rpc_port.Text;

            WebClient c = new WebClient();
            c.Credentials = new NetworkCredential(rpc_user.Text, rpc_password.Text);

            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(cert);
            c.Headers.Add("User-Agent", user_agent);
            
            result.Text = c.UploadString(url, "POST", "{\"jsonrpc\": \"1.0\", \"id\":\"curltest\", \"method\": \"" + rpc_method.Text + "\", \"params\": [" + rpc_params.Text + "] }");
            
        }

        private void be_lookup_balance_Click(object sender, EventArgs e)
        {
            label_be_balance.Text = "Balance: " + simple_wget("http://blockexplorer.com/q/getreceivedbyaddress/" + be_address.Text);
        }

        public string simple_wget(string url)
        {
            WebClient c = new WebClient();
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(cert);
            c.Headers.Add("User-Agent", user_agent);

            return c.DownloadString(url);
        }
    }
}
