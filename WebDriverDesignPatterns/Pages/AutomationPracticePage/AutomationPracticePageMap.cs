using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public IWebElement newBrwTab
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/p[4]/button"));
            }
        }
    }
}
