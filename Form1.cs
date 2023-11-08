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
using OpenQA.Selenium.Support.UI;

namespace AnimeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAutoDownload_Click(object sender, EventArgs e)
        {
            var driver = new ChromeDriver();
            try
            {
                driver.Url = "https://animefenix.tv/user/login";

                var txtUsername = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("username")));
                var txtPwd = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("password")));
                var btnSend = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("send_button")));

                txtUsername.SendKeys("animeweb");
                txtPwd.SendKeys("Alm.27.01.06");
                btnSend.Click();

                while (!driver.Url.Contains("zerotwo"))
                    Thread.Sleep(10);

                driver.Url = "https://animefenix.tv/ver/" + txtAnimeName.Text + "-1/descarga";

                while (!driver.Url.Contains(txtAnimeName.Text)) 
                    Thread.Sleep(10);

                var burstCloudBtn = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("burstcloud")));
                burstCloudBtn.Click();

                driver.Quit();
            }
            catch (Exception)
            {
                driver.Quit();
                throw;
            }
        }
    }
}
