using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverDesignPatterns.Pages.Models;

namespace WebDriverDesignPatterns.Pages.ToolsQAPage
{
    public partial class ToolsQAPage : BasePage
    {
        public ToolsQAPage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://softuni.bg");
        }
        public void FillRegistrationForm(SoftUniUser User)
        {
            this.LoginButton.Click();
            Type(this.UserName, User.Username);
           Type(this.Password, User.Password);
        }

        private void ClickOnElements(List<IWebElement> elements, List<bool> conditions)
        {
            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i])
                {
                    elements[i].Click();
                }
            }
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }

}

