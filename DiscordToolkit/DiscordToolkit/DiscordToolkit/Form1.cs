using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;

namespace DiscordToolkit
{
    public partial class Form1 : Form
    {
        static String userv8 = "https://discord.com/api/v8/users/@me";

        static Boolean spam = false;

        static Random random;
        static String[] words;
        static Random random2;
        static String[] proxiesT;
        static List<String> proxies;

        public Form1()
        {
            InitializeComponent();
        }

        private void thirteenButton1_Click(object sender, EventArgs e)
        {
            HttpRequest httpRequest = new HttpRequest();
            try
            {
                httpRequest.Delete(WebhookDeleteTarget.Text);
                if (httpRequest.Response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("The Webhook has been successfully deleted!", "DiscordToolKit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete the Webhook", "DiscordToolKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid URL, it may be deleted", "DiscordToolKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thirteenButton3_Click(object sender, EventArgs e)
        {
            HttpRequest basicInfo = new HttpRequest();
            basicInfo.UserAgentRandomize();
            try
            {
                basicInfo.AddHeader("Authorization", TokenToLookup.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a token.", "DiscordToolKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            try
            {
                var result = basicInfo.Get(userv8);
                TokenInfoResults.Text = result.ToString().Replace("\"", "").Replace("}", "").Replace("{", "").Replace(", ", "\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid token.", "DiscordToolKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //TokenInfoResults.Text = "Test\nResults";
        }

        private void thirteenButton2_Click(object sender, EventArgs e)
        {
            random = new Random();
            words = spamList.Text.Split('\n');

            random2 = new Random();
            proxiesT = spamProxies.Text.Split('\n');
            proxies = new List<string>(proxiesT);

            spam = true;
            for (int x = 0; x < Int32.Parse(threads.Text); x++)
            {
                new Thread(Bot).Start();
            }
        }

        private void Bot()
        {
            while (spam)
            {
                HttpRequest httpRequest = new HttpRequest();
                httpRequest.UserAgentRandomize();

                String proxy = proxies[random2.Next(proxies.Count)];

                try
                {
                    httpRequest.Proxy = HttpProxyClient.Parse(proxy);
                    var body = new RequestParams();
                    body["username"] = "Kami147";
                    body["avatar_url"] = "https://avatars0.githubusercontent.com/u/57001729?s=460&u=b9554da9dbc53de926894e1ec13788ef58d7a614&v=4";
                    body["content"] = words[random.Next(words.Length)];

                    try
                    {
                        httpRequest.Post(spamTarget.Text, body);
                        var count = Int32.Parse(sentAmount.Text);
                        count += 1;
                        sentAmount.Text = count.ToString();
                        Thread.Sleep(15000);
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show(e.ToString());
                    }
                }
                catch (Exception)
                {
 
                }
            }
            
        }

        private void thirteenButton4_Click(object sender, EventArgs e)
        {
            spam = false;
        }

        private void WebhookSpammer_Click(object sender, EventArgs e)
        {

        }
    }
}
