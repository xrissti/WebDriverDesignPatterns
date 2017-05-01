using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public IWebElement DragMeAround
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable"));
            }
        }
        public IWebElement DragVertically
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggabl"));
            }
        }
        public IWebElement ConstraintMovTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-2"));
            }
        }
        public IWebElement DragHorizontally
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggabl2\"]/p"));
            }
        }
        public IWebElement DragCursorStyleMinusFive
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"drag2\"]"));
            }
        }
       public IWebElement CursorStyleTab
       {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-3"));
            }
       }
        public IWebElement EventsTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-4"));
            }
        }
        public IWebElement DragEvent
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"dragevent\"]/p"));
            }
        }

        public IWebElement DragPlusSortTab
        {
            get
            {
                return this.Driver.FindElement(By.Id("ui-id-5"));
            }
        }
        public IWebElement DraggableBox
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"draggablebox\"]"));
            }
        }
       public IWebElement Sortablebox
        {
            get
            {
                return this.Driver.FindElement(By.Id("sortablebox"));
            }
        }
    }
}
