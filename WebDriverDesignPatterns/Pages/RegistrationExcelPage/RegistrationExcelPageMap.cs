using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.RegistrationExcelPage
{
    public partial class RegistrationExcelPage : BasePage
    {
        public IWebElement FirstName
        {
            get
            {
                return this.Driver.FindElement(By.Id("name_3_firstname"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return this.Driver.FindElement(By.Id("name_3_lastname"));
            }
        }

        public List<IWebElement> MatrialStatus
        {
            get
            {
                return this.Driver.FindElements(By.Name("radio_4[]")).ToList();
            }
        }
        public List<IWebElement> Hobbies
        {
            get
            {
                return Driver.FindElements(By.Name("checkbox_5[]")).ToList();
            }
        }
        private IWebElement CountryDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("dropdown_7"));
            }
        }

        public SelectElement CountryOption
        {
            get
            {
                return new SelectElement(CountryDD);
            }
        }

        private IWebElement MounthDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("mm_date_8"));
            }
        }

        public SelectElement MounthOption
        {
            get
            {
                return new SelectElement(MounthDD);
            }
        }

        private IWebElement DayDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("dd_date_8"));
            }
        }

        public SelectElement DayOption
        {
            get
            {
                return new SelectElement(DayDD);
            }
        }

        private IWebElement YearDD
        {
            get
            {
                return this.Driver.FindElement(By.Id("yy_date_8"));
            }
        }

        public SelectElement YearOption
        {
            get
            {
                return new SelectElement(YearDD);
            }
        }


        public IWebElement Phone
        {
            get
            {
                return Driver.FindElement(By.Id("phone_9"));
            }
        }
        public IWebElement UserName
        {
            get
            {
                return this.Driver.FindElement(By.Id("username"));
            }
        }

        public IWebElement Email
        {
            get
            {
                return Driver.FindElement(By.Id("email_1"));
            }
        }
        public IWebElement UploadButton
        {
            get
            {
                return this.Driver.FindElement(By.Id("profile_pic_10"));
            }
        }

        public IWebElement About
        {
            get
            {
                return this.Driver.FindElement(By.Id("description"));
            }
        }


        public IWebElement Password
        {
            get
            {
                return Driver.FindElement(By.Id("password_2"));
            }
        }
        public IWebElement ConfirmPassword
        {
            get
            {
                return Driver.FindElement(By.Id("confirm_password_password_2"));
            }
        }
        public IWebElement SubmitButton
        {
            get
            {
                return this.Driver.FindElement(By.Name("pie_submit"));
            }
        }
        public IWebElement ErrPhone
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageConfirmPass
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageConfirmPass1
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("piereg_passwordStrength")));
                return this.Driver.FindElement(By.Id("piereg_passwordStrength"));
            }
        }
        public IWebElement ErrorMessagePass
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
            }
        }
        public IWebElement ErrorMessageWithoutUserData
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("legend_txt")));
                return this.Driver.FindElement(By.ClassName("legend_txt"));
            }

        }

        public IWebElement ErrorMessageWithoutName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("legend_txt")));
                return this.Driver.FindElement(By.ClassName("legend_txt"));
            }
        }
        public IWebElement ErrorMessageWithSameUserName
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("piereg_login_error")));
                return this.Driver.FindElement(By.ClassName("piereg_login_error"));
            }
        }
        public IWebElement ErrorMessageWithSameEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("piereg_login_error")));
                return this.Driver.FindElement(By.ClassName("piereg_login_error"));
            }
        }
        public IWebElement ErrorMessageWithoutEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("legend_txt")));
                return this.Driver.FindElement(By.ClassName("legend_txt"));
            }
        }
        public IWebElement ErrorMessageWithoutPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("legend_txt")));
                return this.Driver.FindElement(By.ClassName("legend_txt"));
            }
        }
        public IWebElement ErrorMessageWithoutHobby
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[3]/div/div[2]/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[3]/div/div[2]/span"));
            }
        }
        public IWebElement ErrorMessageWithNoValidPic
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[9]/div/div/span")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[9]/div/div/span"));
            }
        }
        public IWebElement ClickAnywhere
        {
            get
            {
                return this.Driver.FindElement(By.Id("piereg_pie_form_heading"));
            }
        }
        public IWebElement ErrorRegistrateWithWeekPass
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("piereg_pass_v_week")));
                return this.Driver.FindElement(By.ClassName("piereg_pass_v_week"));
            }
        }
        public IWebElement ErrorRegistrateWithMediumPass
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("piereg_passwordStrength")));
                return this.Driver.FindElement(By.Id("piereg_passwordStrength"));
            }
        }
        public IWebElement ErrorRegistrateWithStrongPass
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.Id("piereg_passwordStrength")));
                return this.Driver.FindElement(By.Id("piereg_passwordStrength"));
            }
        }
        public IWebElement ErrorCyrEmailMessage
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName("piereg_login_error")));
                return this.Driver.FindElement(By.ClassName("piereg_login_error"));
            }
        }

    }
}
