using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.ToolsQAPage
{
    public partial class ToolsQAPage : BasePage
    {
        public IWebElement Logo
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"page\"]/div[1]/header/div/a/img"));
            }
        }
        public IWebElement UserName
        {
            get
            {
                return this.Driver.FindElement(By.Name("username"));
            }
        }
        public IWebElement Password
        {
            get
            {
                return Driver.FindElement(By.Name("password"));
            }
        }
        public IWebElement LoginButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.LinkText("Вход")));
                return this.Driver.FindElement(By.LinkText("Вход"));
            }
        }
    }
}
