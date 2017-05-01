using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverDesignPatterns.Pages.Models;

namespace WebDriverDesignPatterns.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
  //      private String url;

        public RegistrationPage(IWebDriver driver)
            :base(driver)
        {
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
        }
        public void FillRegistrationForm(RegistrationUser regUser)
        {
            Type(this.FirstName, regUser.FirstName);
            Type(this.LastName, regUser.LastName);
            ClickOnElements(this.MatrialStatus, regUser.MatrialStatus);
            ClickOnElements(this.Hobbies, regUser.Hobbies);
            this.CountryOption.SelectByText(regUser.Country);
            this.MounthOption.SelectByText(regUser.BirthMonth);
            this.DayOption.SelectByText(regUser.BirthDay);
            this.YearOption.SelectByText(regUser.BirthYear);
            Type(this.Phone, regUser.Phone);
            Type(this.UserName, regUser.UserName);
            Type(this.Email, regUser.Email);
            this.UploadButton.Click();
            this.Driver.SwitchTo().ActiveElement().SendKeys(regUser.Picture);
            Type(this.About, regUser.About);
            Type(this.Password, regUser.Password);
            Type(this.ConfirmPassword, regUser.ConfirmPassword);
            this.SubmitButton.Click();
        }

        public void FillRegistrationFormFields(RegistrationUser regUser)
        {
            Type(this.Password, regUser.Password);
            Type(this.ConfirmPassword, regUser.ConfirmPassword);
            this.ConfirmPassword.SendKeys(Keys.Enter);          
        }


        private void ClickOnElements(List<IWebElement> elements, List<bool> conditions)
        {
            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i])
                {
                    elements[i].Click();
                }
            }
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }

}
