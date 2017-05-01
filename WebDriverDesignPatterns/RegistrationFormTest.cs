using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverDesignPatterns.Pages.HomePage;
using WebDriverDesignPatterns.Pages.Models;
using WebDriverDesignPatterns.Pages.RegistrationPage;

namespace WebDriverDesignPatterns
{
    [TestFixture]
    public class RegistrationFormTest
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
        [Property("Registration", 1)]
        [Author("Hristina Petkova")]
        public void NavigateToRegistrationPage()
        {
            HomePage homePage = new HomePage(this.driver);
            RegistrationPage regPage = new RegistrationPage(this.driver);

            homePage.Navigate();
            homePage.registrateButton.Click();

            regPage.AssertRegistrationPageIsOpen("Registration");
        }

        [Test]
        [Property("Registration", 2)]
        [Author("Hristina Petkova")]
        public void RegistrateWithValidData()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool>{ true,false,false},                                               
                                                    new List<bool>{ true,false,false},
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

           regPage.AssesrtSuccessMessage("Thank you for your registration");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidPhone()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "mnnmnjnj",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "9999"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtNoValidPhoneMessage("* Minimum 10 Digits starting with Country Code");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutPhone()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "9999"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtNoValidPhoneMessage("* This field is required");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidEmail()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "hkhkkj",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "9999"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtNoValidEmailMessage("* Invalid email address");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidPasswordAndDifferentConfirmation()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "1234567",
                                                    "9999"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtNoValidPasslMessage("* Minimum 8 characters required");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidConfirmPassword()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "9999"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtNoValidConfirmPasslMessage("* Fields do not match");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidConfirmPassword1()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    ""
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtNoValidConfirmPasslMessage1("Mismatch");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutUserData()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "",
                                                    "",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Afghanistan",
                                                    "Year",
                                                    "Month",
                                                    "Day",
                                                    "",
                                                    "",
                                                    "",
                                                    "",
                                                    "",
                                                    "",
                                                    ""
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtWithoutUserData("* This field is required");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutFirstName()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);
            regPage.FirstName.Click();
            regPage.LastName.Click();

            regPage.AssesrtWithoutNameMessage("* This field is required");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutLastName()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888988829",
                                                    "uhgdhg",
                                                    "jgfd@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);
            regPage.LastName.Click();
            regPage.FirstName.Click();

            regPage.AssesrtWithoutNameMessage("* This field is required");
        }


        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithSameUserName()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtWithSameUserName("Error: Username already exists");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithSameEmail()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "jkijk",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtWithSameEmail("Error: E-mail address already exists");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutEmail()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { false, true, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "jkijk",
                                                    "",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtWithoutEmail("* This field is required");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutPassword()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { false, true, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "jkijk",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "",
                                                    ""
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtWithoutPassword("* This field is required");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithoutHobby()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { false, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "dfkhj",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtWithoutHobbyMessage("* This field is required");
        }

        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithNoValidPic()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "hjghj",
                                                    "bnnnnnb",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1998",
                                                    "11",
                                                    "5",
                                                    "0887123432",
                                                    "hbhb",
                                                    "bhjhb@gmail.com",
                                                    "C:\\Users\\user\\Desktop\\bathroom v1.pdf",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);
            regPage.UploadButton.Click();
            regPage.About.Click();
 
            regPage.AssesrtWithNoValidPic("* Invalid File");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithWeekPass()
        {//Ако по изискване паролата не трябва да е week, тестът е негативен
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationFormFields(regUser);
            regPage.AssesrtRegistrateWithWeekPass("Very weak");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithMediumPass()
        {//Ако по изискване паролата трябва да е strong, тестът е негативен
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "xrissti@gmail.com",
                                                    "",
                                                    "",
                                                    "qaz@qaz.com",
                                                    "qaz@qaz.com"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationFormFields(regUser);
            regPage.AssesrtRegistrateWithMediumPass("Strong");
        }
        [Test]
        [Property("Registration - negative test", 1)]
        [Author("Hristina Petkova")]
        public void RegistrateWithCyrEmail()
        {
            RegistrationPage regPage = new RegistrationPage(this.driver);
            RegistrationUser regUser = new RegistrationUser(
                                                    "Hristina",
                                                    "Petkova",
                                                    new List<bool> { true, false, false },
                                                    new List<bool> { true, false, false },
                                                    "Bulgaria",
                                                    "1974",
                                                    "10",
                                                    "2",
                                                    "0888088824",
                                                    "xrissti",
                                                    "дфжфдглб@йнйфкдаф.жфе",
                                                    "",
                                                    "",
                                                    "123456789",
                                                    "123456789"
                );
            regPage.NavigateTo();
            regPage.FillRegistrationForm(regUser);

            regPage.AssesrtCyrEmailMessage("Error: Username already exists\r\n" +
                "Error: E-mailField must contain a valid email address");
        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}

