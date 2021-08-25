using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowTraining.PageObjects
{
    class HomePage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        #region HomePageProperties
        IWebElement SearchField
        {
            get
            {
                return driver.FindElement(By.Name("q"));
            }
        }
        #endregion

        public void EnterSearchText(string searchTerm)
        {
            wait.Until(x => SearchField).SendKeys(searchTerm);
            SearchField.SendKeys(Keys.Return);
        }
    }
}
