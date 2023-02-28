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

        private void btnStart_Click(object sender, EventArgs e)
        {
            chrome.Navigate().GoToUrl(txtUrl.Text);
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

            Sleep(5000);

            var actionConfig = chrome.FindElement(By.XPath($"/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr[{txtNumberConfig.Text}]/td[2]/a"));
            actionConfig.Click();


            var actionEdit = chrome.FindElement(By.XPath("//li[text()[normalize-space()='Edit']]"));
            actionEdit.Click();

            Sleep();

            for (int i = Convert.ToInt32(txtFrom.Text); i <= Convert.ToInt32(txtTo.Text); i++)
            {

                var addClient = chrome.FindElement(By.XPath("//label[text()='Clients']/following-sibling::span"));
                addClient.Click();

                Sleep();

                var client = chrome.FindElement(By.XPath($"(//div[@role='button'])[{i + 2}]"));
                client.Click();

                Sleep();
                                     
                var clientName = chrome.FindElement(By.XPath($"//div[@id='inbound-modal']/div[2]/div[1]/div[2]/div[2]/form[2]/div[{i}]/div[1]/div[2]/div[1]/form[1]/div[1]/div[2]/div[1]/span[1]/input[1]"));
                clientName.Clear();
                clientName.SendKeys($"{txtName.Text}-{i-1}");

                var clientTotalTraffic = chrome.FindElement(By.XPath($"(//input[@class='ant-input-number-input'])[{i}]"));
                clientTotalTraffic.SendKeys(txtTotalTraffic.Text);

            }

        }


        private static void Sleep(int seconds = 1000)
        {
            Thread.Sleep(seconds);
        }

    }
}
