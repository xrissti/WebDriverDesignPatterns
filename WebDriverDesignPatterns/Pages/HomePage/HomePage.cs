using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        private String url = "http://www.demoqa.com";

        public HomePage(IWebDriver driver)
            :base(driver)
        {
        }
        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }
    }
}
