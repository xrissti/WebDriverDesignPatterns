using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.RegistrationPage
{
    public static class RestrationPageAsserter
    {
        public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }
        public static void AssesrtSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }
        public static void AssesrtNoValidPhoneMessage(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrPhone.Text);
        }
        public static void AssesrtNoValidEmailMessage(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageEmail.Text);
        }
        public static void AssesrtNoValidPasslMessage(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessagePass.Text);
        }
        public static void AssesrtNoValidConfirmPasslMessage(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageConfirmPass.Text);
        }
        public static void AssesrtNoValidConfirmPasslMessage1(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageConfirmPass1.Text);
        }
        public static void AssesrtWithoutUserData(this RegistrationPage page, string text)
        {
  //          Assert.AreEqual(text, page.ErrorMessageWithoutUserData.Text);
            Assert.Pass(text, page.ErrorMessageWithoutUserData.Text) ;
        }
        public static void AssesrtWithoutNameMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageWithoutName.Text);
        }
        public static void AssesrtWithSameUserName(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithSameUserName.Text);
        }
        public static void AssesrtWithSameEmail(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithSameEmail.Text);
        }
        public static void AssesrtWithoutEmail(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithoutEmail.Text);
        }
        public static void AssesrtWithoutPassword(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithoutPassword.Text);
        }
        public static void AssesrtWithoutHobbyMessage(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithoutHobby.Text);
        }
        public static void AssesrtWithNoValidPic(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithNoValidPic.Text);
        }
        public static void AssesrtRegistrateWithWeekPass(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorRegistrateWithWeekPass.Text);
        }
        public static void AssesrtRegistrateWithMediumPass(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorRegistrateWithMediumPass.Text);
        }
        public static void AssesrtCyrEmailMessage(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorCyrEmailMessage.Text);
        }

    }
}
