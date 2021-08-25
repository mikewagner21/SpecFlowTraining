using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace Specflow.Framework
{
    [TestFixture(BrowserTarget.Chrome)]

    public abstract class BaseTest
    {
        protected LocalDriverBuilder builder;
        protected string startingUrl;
        protected string epochStartTime;
        protected string targetBrowser;
        protected CommonUtils commonUtils = new CommonUtils();

        protected BaseTest(string browser)
        {
            this.targetBrowser = browser;
            this.epochStartTime = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        }
        public IWebDriver InitializeDriver()
        {
            LocalDriverBuilder builder = new LocalDriverBuilder();
            this.startingUrl = "http://google.com";
            var driver = builder.Launch(targetBrowser, this.startingUrl);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
