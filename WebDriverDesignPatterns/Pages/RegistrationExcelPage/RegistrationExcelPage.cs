using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebDriverDesignPatterns.Pages.Models;

namespace WebDriverDesignPatterns.Pages.RegistrationExcelPage
{
    public partial class RegistrationExcelPage : BasePage
    {
        public RegistrationExcelPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
        }

        public void FillRegistrationExcelForm(RegistrationExcelUser regExcelUser)
        {
            Type(this.FirstName, regExcelUser.FirstName);
            Type(this.LastName, regExcelUser.LastName);
            ClickOnElements(this.MatrialStatus, regExcelUser.MatrialStatus);
            ClickOnElements(this.Hobbies, regExcelUser.Hobbies);
            this.CountryOption.SelectByText(regExcelUser.Country);
            this.MounthOption.SelectByText(regExcelUser.BirthMonth);
            this.DayOption.SelectByText(regExcelUser.BirthDay);
            this.YearOption.SelectByText(regExcelUser.BirthYear);
            Type(this.Phone, regExcelUser.Phone);
            Type(this.UserName, regExcelUser.Username);
            Type(this.Email, regExcelUser.Email);
            this.UploadButton.Click();
            this.Driver.SwitchTo().ActiveElement().SendKeys(regExcelUser.Picture);
            Type(this.About, regExcelUser.About);
            Type(this.Password, regExcelUser.Password);
            Type(this.ConfirmPassword, regExcelUser.ConfirmPassword);
            this.SubmitButton.Click();
        }

        private void ClickOnElements(List<IWebElement> elements, string conditions)
        {
            var choices = conditions.Split();

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i].Equals("true"))
                {
                    elements[i].Click();
                }
            }
        }

        private void Type(IWebElement element, string text)
        {
            element.Click();
            if (text == null)
            {
                element.SendKeys(Keys.Enter);
            }
            else
            {
                if (!text.Equals(""))
                {
                    element.SendKeys(text);
                }
            }
        }


    }


}

