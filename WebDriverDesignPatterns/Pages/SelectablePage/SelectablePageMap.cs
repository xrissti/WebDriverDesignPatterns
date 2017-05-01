using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public IWebElement SelectableDefaultFuncTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-1"));
            }
        }
        public IWebElement Item1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[1]"));
            }
        }
        public IWebElement Item2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[2]"));
            }
        }
        public IWebElement Item3
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[3]"));
            }
        }
        public IWebElement Item4
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[4]"));
            }
        }
        public IWebElement DisplayAsGridTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement One
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable_grid\"]/li[1]"));
            }
        }
        public IWebElement Two
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable_grid\"]/li[2]"));
            }
        }
        public IWebElement Six
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable_grid\"]/li[6]"));
            }
        }
        public IWebElement SerializeTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement serializeItem1
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[1]"));
            }
        }
        public IWebElement serializeItem2
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[2]"));
            }
        }
        public IWebElement serializeItem3
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[2]"));
            }
        }
        public IWebElement SelectResult
        {
            get
            {
                return this.Driver.FindElement(By.Id("select-result"));
            }
        }

    }
}
