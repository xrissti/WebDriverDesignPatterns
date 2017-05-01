﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages
{
    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            this.Driver.Manage().Window.Maximize();
        }

        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }
        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }
    }
}
