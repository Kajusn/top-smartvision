using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using top_smartvision;

namespace UnitTestProject
{
    [TestClass]
    public class FormTests
    {
        private readonly RegisterForm _regForm;

        public FormTests()
        {
            _regForm = new RegisterForm();
        }

        [TestMethod]
        public void EmailValidation_IsFalse()
        {
            List<string> incorrectEmails = new List<string>();

            incorrectEmails.Add("");
            incorrectEmails.Add("@");
            incorrectEmails.Add("this is an invalid pattern");
            incorrectEmails.Add("invalid@@@pattern@gmail@.@com");
            incorrectEmails.Add("-------");
            incorrectEmails.Add("incorrect.email.email.-com");

            foreach (string pattern in incorrectEmails)
            {
                Assert.IsFalse(_regForm.EmailValidation(pattern));
            }

        }

        [TestMethod]
        public void EmailValidation_IsTrue()
        {
            List<string> correctEmails = new List<string>();

            correctEmails.Add("ponpon@gu.com");
            correctEmails.Add("a@a.lt");
            correctEmails.Add("aaaaaaaaaaaaa@gmail.com");
            correctEmails.Add("valid@gmail.com");
            correctEmails.Add("incorrect@one.lt");

            foreach (string pattern in correctEmails)
            {
                Assert.IsTrue(_regForm.EmailValidation(pattern));
            }

        }

        [TestMethod]
        public void FieldsFilledOut_IsTrue()
        {
            string user = "1";
            string first = "1";
            string last = "1";
            string pass = "1";
            string pass2 = "1";
            string email = "1";

            Assert.IsTrue(_regForm.FieldsFilledOut(user, first, last, pass, pass2, email));
        }

    }
}
