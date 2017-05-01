using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement ResizableDefaultFuncTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-1"));
            }
        }
        public IWebElement GripSmall
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[3]"));
            }
        }
        public IWebElement Resizable
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }
        public IWebElement AnimateTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement AnimateGripSmall
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizableani\"]/div[3]"));
            }
        }
        public IWebElement Resizableani
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizableani"));
            }
        }
        public IWebElement ConstrainResizeAreaTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement GripSmallDiagonal
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizableconstrain\"]/div[3]"));
            }
        }
        public IWebElement Container1
        {
            get
            {
                return this.Driver.FindElement(By.Id("container1"));
            }
        }
        public IWebElement ResizableConstrain
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizableconstrain"));
            }
        }

    }
}
