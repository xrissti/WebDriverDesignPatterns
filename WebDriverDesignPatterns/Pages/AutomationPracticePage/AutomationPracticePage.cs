using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriverDesignPatterns.Pages.AutomationPracticePage
{
    public partial class AutomationPracticePage : BasePage
    {
        public AutomationPracticePage(IWebDriver driver) 
            : base(driver)
        {
        }
    }
}
