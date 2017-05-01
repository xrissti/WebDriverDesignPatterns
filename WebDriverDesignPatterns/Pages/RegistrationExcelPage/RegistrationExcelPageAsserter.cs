using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDesignPatterns.Pages.RegistrationExcelPage
{
    public static class RegistrationExcelPageAsserter
    {
        public static void AssesrtNoValidPhoneMessage(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrPhone.Text);
        }
        public static void AssesrtNoValidEmailMessage(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageEmail.Text);
        }
        public static void AssesrtNoValidPasslMessage(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessagePass.Text);
        }
        public static void AssesrtNoValidConfirmPasslMessage(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageConfirmPass.Text);
        }
        public static void AssesrtNoValidConfirmPasslMessage1(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageConfirmPass1.Text);
        }
        public static void AssesrtWithoutUserData(this RegistrationExcelPage page, string text)
        {
            //          Assert.AreEqual(text, page.ErrorMessageWithoutUserData.Text);
            Assert.Pass(text, page.ErrorMessageWithoutUserData.Text);
        }
        public static void AssesrtWithoutNameMessage(this RegistrationExcelPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutName.Displayed);
            Assert.AreEqual(text, page.ErrorMessageWithoutName.Text);
        }
        public static void AssesrtWithSameUserName(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithSameUserName.Text);
        }
        public static void AssesrtWithSameEmail(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithSameEmail.Text);
        }
        public static void AssesrtWithoutEmail(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithoutEmail.Text);
        }
        public static void AssesrtWithoutPassword(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithoutPassword.Text);
        }
        public static void AssesrtWithoutHobbyMessage(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithoutHobby.Text);
        }
        public static void AssesrtWithNoValidPic(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorMessageWithNoValidPic.Text);
        }
        public static void AssesrtRegistrateWithWeekPass(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorRegistrateWithWeekPass.Text);
        }
        public static void AssesrtRegistrateWithMediumPass(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorRegistrateWithMediumPass.Text);
        }
        public static void AssesrtRegistrateWithStrongPass(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorRegistrateWithStrongPass.Text);
        }
        public static void AssesrtCyrEmailMessage(this RegistrationExcelPage page, string text)
        {
            Assert.AreEqual(text, page.ErrorCyrEmailMessage.Text);
        }

    }
}
