using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace x_ui_Selenium
{
    public partial class frmMain : Form
    {
        ChromeDriver chrome;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            chrome = new ChromeDriver(Application.StartupPath);
            tabControl1.TabPages[0].Text = "Panel";
            tabControl1.TabPages[1].Text = "Telegram Bot";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
        Repeat:

            try
            {
                chrome.Navigate().GoToUrl("https://" + txtSubDomain.Text + "." + txtUrl.Text + ":" + txtPort.Text);
                chrome.Manage().Window.Maximize();

                Sleep(10000);

                var usernameElement = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[1]/div/div/span/span/input"));
                usernameElement.SendKeys(txtUsername.Text);


                var passwordElement = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[2]/div/div/span/span/input"));
                passwordElement.SendKeys(txtPassword.Text);


                var loginButton = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[3]/div/div/span/button"));
                loginButton.Click();

                Sleep(5000);

                var inboundslistButton = chrome.FindElement(By.XPath("/html/body/section/aside/div/ul/li[2]"));
                inboundslistButton.Click();
            }
            catch
            {
                goto Repeat;
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {


            var actionConfig = chrome.FindElement(By.XPath($"/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr[1]/td[2]/a"));
            actionConfig.Click();


            var actionEdit = chrome.FindElement(By.XPath("//li[text()[normalize-space()='Edit']]"));
            actionEdit.Click();

            Sleep();

            pgBar.Maximum = int.Parse(txtTo.Text) - int.Parse(txtFrom.Text);
            int number = 1;

            for (int i = Convert.ToInt32(txtFrom.Text); i <= Convert.ToInt32(txtTo.Text); i++)
            {
                pgBar.Value = number;

                var addClient = chrome.FindElement(By.XPath("//label[text()='Clients']/following-sibling::span"));
                addClient.Click();

                Sleep(250);

                var client = chrome.FindElement(By.XPath($"(//div[@class='ant-collapse-header'])[{i}]"));
                client.Click();

                Sleep(250);

                var clientName = chrome.FindElement(By.CssSelector($"div#inbound-modal>div:nth-of-type(2)>div>div:nth-of-type(2)>div:nth-of-type(2)>form:nth-of-type(2)>div:nth-of-type({i})>div>div:nth-of-type(2)>div>form>div>div:nth-of-type(2)>div>span>input"));
                clientName.Clear();
                clientName.SendKeys($"{txtName.Text}-{i - 1}");

                var clientTotalTraffic = chrome.FindElement(By.XPath($"(//input[@class='ant-input-number-input'])[{i}]"));
                clientTotalTraffic.SendKeys(txtTotalTraffic.Text);

                number++;
            }

        }

        private void btnGetConfigs_Click(object sender, EventArgs e)
        {
            List<string> configs = new List<string>();
            int number = 1;
            try
            {
                var plussElement = chrome.FindElement(By.XPath($"//td[@class='ant-table-row-expand-icon-cell']//div[1]"));
                plussElement.Click();

                for (int i = 0; i <= 999; i++)
                {
                    pgBar.Value = number;
                    var qrElement = chrome.FindElement(By.XPath($"/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr[2]/td[2]/div/div/div/div/div/div/table/tbody/tr[{i + 1}]/td[5]"));
                    configs.Add($"vless://{qrElement.Text}@{txtSubAddress.Text + "." + txtUrl.Text}:{2087}?type=grpc&security=tls&serviceName=&sni={txtSubDomain.Text + "." + txtUrl.Text}&flow=#{txtName.Text}-{number}");
                    number++;
                }
            }
            catch
            {
                string path = "Result.txt";
                StringBuilder sbResult = new StringBuilder();
                number = 1;
                foreach (string config in configs)
                {
                    pgBar.Value = number;
                    sbResult.Append("Config " + number.ToString() + " : ");
                    sbResult.AppendLine(config);
                    sbResult.AppendLine();
                    number++;
                }
                System.IO.File.WriteAllText(path, sbResult.ToString());
            }
        }

        private static void Sleep(int seconds = 1000)
        {
            Thread.Sleep(seconds);
        }


        private static string Token = "";
        private Thread botThread;
        Telegram.Bot.TelegramBotClient bot;
        private void btnSendConfigs_Click(object sender, EventArgs e)
        {
            Token = txtToken.Text;
            botThread = new Thread(new ThreadStart(runBot));
            botThread.Start();
        }

        void runBot()
        {
            bot = new Telegram.Bot.TelegramBotClient(Token);

            int offset = 0;

            while (true)
            {
                Update[] update = bot.GetUpdatesAsync(offset).Result;
                foreach (var up in update)
                {
                    offset = up.Id + 1;

                    if (up.Message == null)
                        continue;
                    var text = up.Message.Text.ToLower();
                    var from = up.Message.From;
                    var chatId = up.Message.Chat.Id;

                    if (text.Contains("/start"))
                    {
                        List<string> configs = new List<string>();
                        try
                        {
                            var plussElement = chrome.FindElement(By.XPath($"//td[@class='ant-table-row-expand-icon-cell']//div[1]"));
                            plussElement.Click();

                            for (int i = 0; i <= 999; i++)
                            {
                                var qrElement = chrome.FindElement(By.XPath($"/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr[2]/td[2]/div/div/div/div/div/div/table/tbody/tr[{i + 1}]/td[5]"));
                                configs.Add($"vless://{qrElement.Text}@{txtSubAddress.Text + "." + txtUrl.Text}:{2087}?type=grpc&security=tls&serviceName=&sni={txtSubDomain.Text + "." + txtUrl.Text}&flow=#{txtName.Text}-{i + 1}");
                            }
                        }
                        catch
                        {
                            int number = 1;
                            foreach (string config in configs)
                            {
                                StringBuilder sbResult = new StringBuilder();
                                sbResult.AppendLine($"Config {number}:");
                                sbResult.AppendLine(config);
                                bot.SendTextMessageAsync(chatId, sbResult.ToString());
                                Sleep(2000);
                                number++;
                            }
                        }

                    }
                }
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            botThread.Abort();
        }

        private void btnStopBot_Click(object sender, EventArgs e)
        {
            botThread.Abort();
        }
    }
}
