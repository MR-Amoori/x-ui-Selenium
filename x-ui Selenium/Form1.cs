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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Linq.Expressions;

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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Repeat:

            try
            {
                chrome.Navigate().GoToUrl(txtUrl.Text + ":" + txtPort.Text);
                chrome.Manage().Window.Maximize();

                Sleep(2000);

                var usernameElement = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[1]/div/div/span/span/input"));
                usernameElement.SendKeys(txtUsername.Text);


                var passwordElement = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[2]/div/div/span/span/input"));
                passwordElement.SendKeys(txtPassword.Text);


                var loginButton = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[3]/div/div/span/button"));
                loginButton.Click();

                Sleep(5000);

                var inboundslistButton = chrome.FindElement(By.XPath("/html/body/section/aside/div/ul/li[2]"));
                inboundslistButton.Click();

                Sleep();
            }
            catch 
            {
                goto Repeat;
            }

        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Repeat:

            try
            {
                var actionConfig = chrome.FindElement(By.XPath($"/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr[{txtNumberConfig.Text}]/td[2]/a"));
                actionConfig.Click();


                var actionEdit = chrome.FindElement(By.XPath("//li[text()[normalize-space()='Edit']]"));
                actionEdit.Click();

                Sleep();

                for (int i = Convert.ToInt32(txtFrom.Text); i <= Convert.ToInt32(txtTo.Text); i++)
                {

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

                }
            }
            catch 
            {
                chrome.Navigate().Refresh();
                Sleep();
                goto Repeat;
            }
        }


        private void btnGetConfigs_Click(object sender, EventArgs e)
        {
            List<string> configs = new List<string>();

            try
            {
                var plussElement = chrome.FindElement(By.XPath($"//td[@class='ant-table-row-expand-icon-cell']//div[1]"));
                plussElement.Click();

                for (int i = 0; i <= 999; i++)
                {
                    var qrElement = chrome.FindElement(By.XPath($"/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr[2]/td[2]/div/div/div/div/div/div/table/tbody/tr[{i + 1}]/td[5]"));
                    configs.Add($"vless://{qrElement.Text}@{txtUrl.Text}:{txtPort.Text}?type=grpc&security=tls&serviceName=&sni=dns.mohsenvahedi.top&flow=#NameDN-");
                   
                }
            }
            catch
            {
                //string path =  "Result.txt";
                //StringBuilder sbResult = new StringBuilder();
                //int number = 1;
                //foreach (string config in configs)
                //{
                //    sbResult.Append(number.ToString());
                //    sbResult.AppendLine(config);
                //    sbResult.AppendLine();  
                //}
                //File.WriteAllText(path, config);
            }
        }

        private static void Sleep(int seconds = 1000)
        {
            Thread.Sleep(seconds);
        }



    }
}
