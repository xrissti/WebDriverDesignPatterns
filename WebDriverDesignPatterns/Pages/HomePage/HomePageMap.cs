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
        public IWebElement Title
        {
            get
            {
                return this.Driver.FindElement(By.ClassName("entry-title"));
            }
        }
        public IWebElement registrateButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"menu-item-374\"]/a"));
            }
        }
    }
}

