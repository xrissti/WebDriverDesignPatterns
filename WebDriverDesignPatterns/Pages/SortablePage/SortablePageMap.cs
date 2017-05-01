using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.SortablePage
{
    public partial class SortablePage : BasePage 
    {
        public IWebElement SortableDefaultFuncTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-1"));
            }
        }
        public IWebElement SortableItem1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sortable\"]/li[1]"));
            }
        }
        public IWebElement PortletsTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));
            }
        }
        public IWebElement PlusThick
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tabs-4\"]/div/div[1]/div[2]/div[1]/span"));
            }
        }
        public IWebElement PortletContent
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tabs-4\"]/div/div[1]/div[2]/div[2]"));
            }
        }
    }
}
