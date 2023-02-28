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
            chrome = new ChromeDriver(txtPath.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            chrome.Navigate().GoToUrl(txtUrl.Text);
            chrome.Manage().Window.Maximize();

            Sleep();

            var usernameElement = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[1]/div/div/span/span/input"));
            usernameElement.SendKeys(txtUsername.Text);

            Sleep();

            var passwordElement = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[2]/div/div/span/span/input"));
            passwordElement.SendKeys(txtPassword.Text);

            Sleep();

            var loginButton = chrome.FindElement(By.XPath("/html/body/section/main/div[2]/div/form/div[3]/div/div/span/button"));
            loginButton.Click();

            Sleep();

            var inboundslistButton = chrome.FindElement(By.XPath("/html/body/section/aside/div/ul/li[2]"));
            inboundslistButton.Click();

            Sleep();

            var actionConfig = chrome.FindElement(By.XPath("/html/body/section/section/main/div/div/div[2]/div[2]/div/div/div/div/div/div/div/table/tbody/tr/td[2]/a"));
            actionConfig.Click();

            Sleep();

            var actionEdit = chrome.FindElement(By.XPath("//li[text()[normalize-space()='Edit']]"));
            actionEdit.Click();

            Sleep();

            for (int i = 1; i <= 10; i++)
            {
                var addClient = chrome.FindElement(By.XPath("//label[text()='Clients']/following-sibling::span"));
                addClient.Click();

                Sleep();

                var clientName = chrome.FindElement(By.XPath($"(//div[@role='button'])[{i + 2}]"));
                clientName.Click();
            }


            Sleep();
        }


        private static void Sleep(int seconds = 1000)
        {
            Thread.Sleep(seconds);
        }

    }
}
