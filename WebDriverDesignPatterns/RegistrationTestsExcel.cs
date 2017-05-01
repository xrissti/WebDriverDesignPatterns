using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverDesignPatterns.Pages.Models;
using WebDriverDesignPatterns.Pages.RegistrationExcelPage;

namespace WebDriverDesignPatterns
{
    [TestFixture]
    class RegistrationTestsExcel
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
            this.driver.Quit();
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidPhone()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithNoValidPhone");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtNoValidPhoneMessage("* Minimum 10 Digits starting with Country Code");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistateWithoutPhone()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithoutPhone");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtNoValidPhoneMessage("* This field is required");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidEmail()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithNoValidEmail");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtNoValidEmailMessage("* Invalid email address");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidPasswordAndDifferentConfirmation()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithNoValidPasswordAndDifferentConfirmation");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtNoValidPasslMessage("* Minimum 8 characters required");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidConfirmPassword()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithNoValidConfirmPassword");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtNoValidConfirmPasslMessage("* Fields do not match");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidConfirmPassword1()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithNoValidConfirmPassword1");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtNoValidConfirmPasslMessage1("Mismatch");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithStrongPass()
        {//Ако по изискване паролата трябва да е strong, тестът е негативен
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithStrongPass");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtRegistrateWithStrongPass("Strong");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutFirstName()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithoutName");
            regExcelPage.FillRegistrationExcelForm(user);
            regExcelPage.FirstName.Click();
            regExcelPage.LastName.Click();

            regExcelPage.AssesrtWithoutNameMessage("* This field is required");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutLastName()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithoutLastName");
            regExcelPage.FillRegistrationExcelForm(user);
            regExcelPage.LastName.Click();
            regExcelPage.FirstName.Click();

            regExcelPage.AssesrtWithoutNameMessage("* This field is required");
        }


        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithSameUserName()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithSameUserName");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtWithSameUserName("Error: Username already exists");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithSameEmail()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithSameEmail");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtWithSameEmail("Error: E-mail address already exists");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutEmail()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithoutEmail");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtWithoutEmail("* Invalid email address");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutPassword()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithoutPassword");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtWithoutPassword("* This field is required");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutHobby()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithoutHobby");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtWithoutHobbyMessage("* This field is required");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidPic()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithNoValidPic");
            regExcelPage.FillRegistrationExcelForm(user);
            regExcelPage.UploadButton.Click();
            regExcelPage.About.Click();

            regExcelPage.AssesrtWithNoValidPic("* Invalid File");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithWeekPass()
        {//Ако по изискване паролата не трябва да е week, тестът е негативен
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithWeekPass");

            regExcelPage.FillRegistrationExcelForm(user);
            regExcelPage.AssesrtRegistrateWithWeekPass("Very weak");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithMediumPass()
        {//Ако по изискване паролата трябва да е strong, тестът е негативен
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithMediumPass");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtRegistrateWithMediumPass("Medium");
        }

        [Test]
        [Property("RegisterTestWithExcelData", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithCyrEmail()
        {
            RegistrationExcelPage regExcelPage = new RegistrationExcelPage(this.driver);
            RegistrationExcelUser user = new RegistrationExcelUser();
            regExcelPage.NavigateTo();

            user = AccessExcelData.GetTestDataReg("WithCyrEmail");
            regExcelPage.FillRegistrationExcelForm(user);

            regExcelPage.AssesrtCyrEmailMessage("Error: Username already exists\r\n" +
                "Error: E-mailField must contain a valid email address");
        }
    }
}
