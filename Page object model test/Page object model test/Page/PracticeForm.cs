

using OpenQA.Selenium;
using Page_object_model_test.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver = Page_object_model_test.Driver.WebDriver;

namespace Page_object_model_test.Page
{
    public class PracticeForm
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Email => driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));
        public IWebElement Mobile => driver.FindElement(By.Id("usersNumber"));
        public IWebElement Subjects => driver.FindElement(By.Id("subjectsContainer"));
        public IWebElement Hobby => driver.FindElement(By.Id("hobbies-checkbox-2"));
        public IWebElement Button => driver.FindElement(By.Id("submit"));

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterLastName(string lastname)
        {
            LastName.SendKeys(lastname);
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }
        public void SelectGender()
        {
            Gender.Click();
        }
        public void EnterMobile(string mobile)
        {
            Mobile.SendKeys(mobile);
        }
        public void EnterSubjects()
        {
          
            Subjects.Click();
        }
        
        public void EnterHobby(string hobby)
        {
            Hobby.Click();
        }
        public void PressButton()
        {
            Button.Submit();
        }

    }
}
