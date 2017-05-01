using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public IWebElement DefaultFuncTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-1"));
            }
        }
        public IWebElement DraggableView
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableview"));
            }
        }
        public IWebElement DroppableView
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }
        public IWebElement AcceptTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement DraggMe
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableaccept\"]/p"));
            }
        }
        public IWebElement Accept
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"droppableaccept\"]/p"));
            }
        }
        public IWebElement PreventPropagationTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
        }
        public IWebElement DraggMePrev
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggableprop\"]/p"));
            }
        }
        public IWebElement Droppableprop
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableprop"));
            }
        }
        public IWebElement RevertDraggablePositionTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));
            }
        }
        public IWebElement RevertWhenDropped
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggablerevert\"]/p"));
            }
        }
        public IWebElement Droppablerevert
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppablerevert"));
            }
        }
        public IWebElement ShoppingCardTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-5"));
            }
        }
        public IWebElement Bags
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-8\"]/a"));
            }
        }
        public IWebElement ZebraStripped
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-9\"]/ul/li[1]"));
            }
        }
        public IWebElement BlackLeather
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"ui-id-9\"]/ul/li[2]"));
            }
        }
        public IWebElement ShoppingCard
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"cart\"]/div/ol"));
            }
        }
    }
}
