using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumDesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverDesignPatterns.Pages.AutomationPracticePage;
using WebDriverDesignPatterns.Pages.DraggablePage;
using WebDriverDesignPatterns.Pages.DroppablePage;
using WebDriverDesignPatterns.Pages.Models;
using WebDriverDesignPatterns.Pages.RegistrationPage;
using WebDriverDesignPatterns.Pages.ResizablePage;
using WebDriverDesignPatterns.Pages.SelectablePage;
using WebDriverDesignPatterns.Pages.SortablePage;
using WebDriverDesignPatterns.Pages.ToolsQAPage;

namespace WebDriverDesignPatterns
{
    [TestFixture]
    class AutomationPracticeTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string path = ConfigurationManager.AppSettings["Logs"] +
                    TestContext.CurrentContext.Test.Name + ".txt";
                File.WriteAllText(path, TestContext.CurrentContext.Test.FullName +
                    "" + TestContext.CurrentContext.TestDirectory);
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + TestContext.CurrentContext.Test.Name + ".jpg",
                                                        ScreenshotImageFormat.Jpeg);
            }
                this.driver.Quit();
        }

        [Test]
        [Property("ToolsQA", 1)]
        public void HandlePopUp()
        {
            var homePage = new AutomationPracticePage(this.driver);
            var pageToolsQA = new ToolsQAPage(this.driver);
            homePage.Driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";

            homePage.newBrwTab.Click();
            this.driver.SwitchTo().ActiveElement();

            Assert.AreEqual("http://20tvni1sjxyh352kld2lslvc.wpengine.netdna-cdn.com/wp-content/uploads/2014/08/Toolsqa.jpg", pageToolsQA.Logo.GetAttribute("src"));
        }

        [Test]
        [Property("ToolsQA - Draggable", 1)]
        public void DraggableDefaultFunc()
        {
            var draggablePage = new DraggablePage(this.driver);

            draggablePage.Driver.Url = "http://demoqa.com/draggable/";

  //          var styleBefore = draggablePage.dragMeAround.GetAttribute("style");

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(draggablePage.DragMeAround).ClickAndHold().MoveByOffset(200,200).Release(draggablePage.DragMeAround).Perform();

            var styleAfter = draggablePage.DragMeAround.GetAttribute("style");

            Assert.IsTrue(styleAfter.Contains("width"));
            Assert.IsTrue(styleAfter.Contains("left: 200px; top: 200px;"));
        }

        [Test]
        [Property("ToolsQA - Draggable", 1)]
        public void DraggableVertically()
        {
            var draggablePage = new DraggablePage(this.driver);

            draggablePage.Driver.Url = "http://demoqa.com/draggable/";
            draggablePage.ConstraintMovTab.Click();

            Actions builder = new Actions(this.driver);
            var styleVerticallyBefore = draggablePage.DragVertically.GetAttribute("style");

            builder.MoveToElement(draggablePage.DragVertically).ClickAndHold().MoveByOffset(0, -48).Release(draggablePage.DragVertically).Perform();

            var styleVerticallyAfter = draggablePage.DragVertically.GetAttribute("style");

            Assert.IsTrue(styleVerticallyAfter.Contains("position: relative; height: 90px; bottom: auto; left: 0px; top: -48px;"));
            Assert.AreNotEqual(styleVerticallyBefore, styleVerticallyAfter);
        }

        [Test]
        [Property("ToolsQA - Draggable", 1)]
        public void DraggableCursorStyleMinusFive()
        {
            var draggablePage = new DraggablePage(this.driver);

            draggablePage.Driver.Url = "http://demoqa.com/draggable/";
            draggablePage.CursorStyleTab.Click();

            Actions builder = new Actions(this.driver);
            var styleCursorStyleMinusFiveBefor = draggablePage.DragCursorStyleMinusFive.GetAttribute("style");

            builder.MoveToElement(draggablePage.DragCursorStyleMinusFive).KeyDown(Keys.Control).ClickAndHold().MoveByOffset(0, -48).Release(draggablePage.DragCursorStyleMinusFive).KeyUp(Keys.Control).Perform();

            var styleCursorStyleMinusFiveAfter = draggablePage.DragCursorStyleMinusFive.GetAttribute("style");

            Assert.IsTrue(styleCursorStyleMinusFiveAfter.Contains("left: 109.031px; top: 61.5313px;"));
            Assert.AreNotEqual(styleCursorStyleMinusFiveBefor, styleCursorStyleMinusFiveAfter);
        }
        [Test]
        [Property("ToolsQA - Draggable", 1)]
        public void DraggableEvents()
        {
            var draggablePage = new DraggablePage(this.driver);

            draggablePage.Driver.Url = "http://demoqa.com/draggable/";
            draggablePage.EventsTab.Click();

            Actions builder = new Actions(this.driver);
            var start = draggablePage.DragEvent.FindElement(By.XPath("//*[@id=\"event-start\"]"));

            builder.MoveToElement(draggablePage.DragEvent).ClickAndHold().MoveByOffset(0, -48).Release(draggablePage.DragEvent).Perform();

            var stop = draggablePage.DragEvent.FindElement(By.XPath("//*[@id=\"event-stop\"]"));

            Assert.IsTrue(start.Text.Contains("“start” invoked 1x"));
            Assert.IsTrue(stop.Text.Contains("“stop” invoked 1x"));
        }
        [Test]
        [Property("ToolsQA - Draggable", 1)]
        public void DraggablePlusSortable()
        {
            var draggablePage = new DraggablePage(this.driver);

            draggablePage.Driver.Url = "http://demoqa.com/draggable/";
            draggablePage.DragPlusSortTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(draggablePage.DraggableBox).DragAndDrop(draggablePage.DraggableBox,draggablePage.Sortablebox).Release().Perform();

            Assert.IsTrue(draggablePage.Sortablebox.Text.Contains("Drag me down"));
        }

        [Test]
        [Property("ToolsQA", 1)]
        [Author("Hristina Petkova")]
        public void MyNavigateToSoftUni()
        {
            ToolsQAPage toolsQAPage = new ToolsQAPage(this.driver);
            SoftUniUser user = new SoftUniUser();
            toolsQAPage.NavigateTo();

            user = AccessExcelData.GetTestData("Login");


            toolsQAPage.FillRegistrationForm(user);

            IWebElement login = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div[1]/form/input[2]"));
            login.Click();
            IWebElement logo = driver.FindElement(By.XPath("//*[@id=\"page-header\"]/div[1]/div/div/div[1]/a/img[1]"));


            Assert.IsTrue(logo.Displayed);
        }
        [Test]
        [Property("ToolsQA - Droppable", 1)]
        public void DroppableDefaultFunc()
        {
            DroppablePage droppablePage = new DroppablePage(this.driver);

            droppablePage.Driver.Url = "http://demoqa.com/droppable/";
            droppablePage.DefaultFuncTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(droppablePage.DraggableView).DragAndDrop(droppablePage.DraggableView,droppablePage.DroppableView).Release().Perform();

            Assert.IsTrue(droppablePage.DroppableView.Text.Contains("Dropped"));
        }
        [Test]
        [Property("ToolsQA - Droppable", 1)]
        public void DroppableAccept()
        {
            DroppablePage droppablePage = new DroppablePage(this.driver);

            droppablePage.Driver.Url = "http://demoqa.com/droppable/";
            droppablePage.AcceptTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(droppablePage.DraggMe).DragAndDrop(droppablePage.DraggMe, droppablePage.Accept).Release().Perform();

            Assert.IsTrue(droppablePage.Accept.Text.Contains("Dropped!"));
        }
        [Test]
        [Property("ToolsQA - Droppable", 1)]
        public void DroppablePreventPropagation()
        {
            DroppablePage droppablePage = new DroppablePage(this.driver);

            droppablePage.Driver.Url = "http://demoqa.com/droppable/";
            droppablePage.PreventPropagationTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(droppablePage.DraggMePrev).DragAndDrop(droppablePage.DraggMePrev, droppablePage.Droppableprop).Release().Perform();

            Assert.AreEqual("Dropped!\r\nInner droppable (not greedy)", droppablePage.Droppableprop.Text);
        }
        [Test]
        [Property("ToolsQA - Droppable", 1)]
        public void DroppableRevertDraggablePosition()
        {
            DroppablePage droppablePage = new DroppablePage(this.driver);

            droppablePage.Driver.Url = "http://demoqa.com/droppable/";
            droppablePage.RevertDraggablePositionTab.Click();

            Actions builder = new Actions(this.driver);

            var classBefore = droppablePage.Droppablerevert.GetAttribute("class");

            builder.MoveToElement(droppablePage.RevertWhenDropped).DragAndDrop(droppablePage.RevertWhenDropped, droppablePage.Droppablerevert).Release().Perform();

            var classAfter = droppablePage.Droppablerevert.GetAttribute("class");

            Assert.IsTrue(classAfter.Contains("highlight"));
            Assert.AreNotEqual(classBefore,classAfter);
        }
        [Test]
        [Property("ToolsQA - Droppable", 1)]
        public void DroppableShoppingCardDemo()
        {
            DroppablePage droppablePage = new DroppablePage(this.driver);

            droppablePage.Driver.Url = "http://demoqa.com/droppable/";
            droppablePage.ShoppingCardTab.Click();

            Actions builder = new Actions(this.driver);

            var shoppingCardBefore = droppablePage.ShoppingCard.Text;

            builder.MoveToElement(droppablePage.Bags).Click().Perform();
            builder.MoveToElement(droppablePage.ZebraStripped).DragAndDrop(droppablePage.ZebraStripped, droppablePage.ShoppingCard).Release().
                    MoveToElement(droppablePage.BlackLeather).DragAndDrop(droppablePage.BlackLeather,droppablePage.ShoppingCard).Release().Perform();

            var shoppingCardAfter = droppablePage.ShoppingCard.Text;

            Assert.IsTrue(shoppingCardAfter.Contains("Zebra Striped"));
            Assert.IsTrue(shoppingCardAfter.Contains("Black Leather"));
            Assert.AreNotEqual(shoppingCardBefore, shoppingCardAfter);
        }
        [Test]
        [Property("ToolsQA - Resizable", 1)]
        public void ResizableDefaultFunc()
        {
            ResizablePage resizablePage = new ResizablePage(this.driver);

            resizablePage.Driver.Url = "http://demoqa.com/resizable/";
            resizablePage.ResizableDefaultFuncTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(resizablePage.GripSmall).ClickAndHold(resizablePage.GripSmall).MoveByOffset(50,-100).Release().Perform();

           Assert.IsTrue(resizablePage.Resizable.GetAttribute("style").Contains("width"));
        }
        [Test]
        [Property("ToolsQA - Resizable", 1)]
        public void ResizableAnimate()
        {
            ResizablePage resizablePage = new ResizablePage(this.driver);

            resizablePage.Driver.Url = "http://demoqa.com/resizable/";
            resizablePage.AnimateTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(resizablePage.AnimateGripSmall).ClickAndHold(resizablePage.AnimateGripSmall).MoveByOffset(-50, 100).Release().Perform();

            Assert.IsTrue(resizablePage.Resizableani.GetAttribute("style").Contains("width"));
        }
        [Test]
        [Property("ToolsQA - Resizable", 1)]
        public void ResizableConstrainResizeArea()
        {
            ResizablePage resizablePage = new ResizablePage(this.driver);

            resizablePage.Driver.Url = "http://demoqa.com/resizable/";
            resizablePage.ConstrainResizeAreaTab.Click();

            Actions builder = new Actions(this.driver);

            var heigthContainer1 = resizablePage.Container1.Size.Height;

            builder.MoveToElement(resizablePage.GripSmallDiagonal).ClickAndHold(resizablePage.GripSmallDiagonal).MoveByOffset(-50, 100).Release().Perform();

            var heigthResizableConstrain = resizablePage.ResizableConstrain.Size.Height;

            Assert.IsTrue(resizablePage.ResizableConstrain.GetAttribute("style").Contains("width"));
            Assert.IsTrue(heigthResizableConstrain<heigthContainer1);
        }
        [Test]
        [Property("ToolsQA - Selectable", 1)]
        public void SelectableDefaultFunc()
        {
            SelectablePage selectablePage = new SelectablePage(this.driver);

            selectablePage.Driver.Url = "http://demoqa.com/selectable/";
            selectablePage.SelectableDefaultFuncTab.Click();

            Actions builder = new Actions(this.driver);


            builder.MoveToElement(selectablePage.Item1).ClickAndHold(selectablePage.Item1).
                MoveToElement(selectablePage.Item2).ClickAndHold(selectablePage.Item2).
                MoveToElement(selectablePage.Item3).ClickAndHold(selectablePage.Item3).
                MoveToElement(selectablePage.Item4).Click().Release().Perform();

            var classItem1Before = selectablePage.Item1.GetAttribute("class");

            builder.MoveToElement(selectablePage.Item1).Click().Release().Perform();

            var classItem1After = selectablePage.Item2.GetAttribute("class");

            Assert.IsTrue(classItem1Before.Contains("selected"));
        }
        [Test]
        [Property("ToolsQA - Selectable", 1)]
        public void SelectableDisplayAsGrid()
        {
            SelectablePage selectablePage = new SelectablePage(this.driver);

            selectablePage.Driver.Url = "http://demoqa.com/selectable/";
            selectablePage.DisplayAsGridTab.Click();

            Actions builder = new Actions(this.driver);


            builder.MoveToElement(selectablePage.One).ClickAndHold(selectablePage.One).
                MoveToElement(selectablePage.Six).ClickAndHold(selectablePage.Six).Release().Perform();

            var classOne = selectablePage.Two.GetAttribute("class");

            Assert.IsTrue(classOne.Contains("selected"));
        }
        [Test]
        [Property("ToolsQA - Selectable", 1)]
        public void SelectableSerialize()
        {
            SelectablePage selectablePage = new SelectablePage(this.driver);

            selectablePage.Driver.Url = "http://demoqa.com/selectable/";
            selectablePage.SerializeTab.Click();

            Actions builder = new Actions(this.driver);


            builder.MoveToElement(selectablePage.serializeItem1).ClickAndHold(selectablePage.serializeItem1).
                MoveToElement(selectablePage.serializeItem2).ClickAndHold(selectablePage.serializeItem2).
                MoveToElement(selectablePage.serializeItem3).ClickAndHold(selectablePage.serializeItem3).Release().Perform();

            Assert.AreEqual("#1#2", selectablePage.SelectResult.Text);
        }
        [Test]
        [Property("ToolsQA - Sortable", 1)]
        public void SortableDefaultFunc()
        {
            SortablePage  sortablePage = new SortablePage(this.driver);

            sortablePage.Driver.Url = "http://demoqa.com/sortable/";
            sortablePage.SortableDefaultFuncTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(sortablePage.SortableItem1).ClickAndHold(sortablePage.SortableItem1).
                MoveByOffset(-15,100).Perform();

            var style = sortablePage.SortableItem1.GetAttribute("style");

            builder.Release().Perform();

            Assert.IsTrue(style.Contains("width"));
        }
        [Test]
        [Property("ToolsQA - Sortable", 1)]
        public void SortablePortlets()
        {
            SortablePage sortablePage = new SortablePage(this.driver);

            sortablePage.Driver.Url = "http://demoqa.com/sortable/";
            sortablePage.PortletsTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(sortablePage.PlusThick).Click().Perform();
            var classPlus = sortablePage.PlusThick.GetAttribute("class");

            Assert.IsTrue(classPlus.Contains("plusthick"));
        }
        [Test]
        [Property("ToolsQA - Sortable", 1)]
        public void SortablePortletContent()
        {
            SortablePage sortablePage = new SortablePage(this.driver);

            sortablePage.Driver.Url = "http://demoqa.com/sortable/";
            sortablePage.PortletsTab.Click();

            Actions builder = new Actions(this.driver);

            builder.MoveToElement(sortablePage.PlusThick).Click().Perform();
            var stylePortletContent = sortablePage.PortletContent.GetAttribute("style");

            Assert.IsTrue(stylePortletContent.Contains("display: none;"));
        }
    }
}
