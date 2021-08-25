using Specflow.Wrappers;
using OpenQA.Selenium;
using System;

namespace Specflow.Framework
{
    public class LocalDriverBuilder
    {
        private readonly WebDriverFactory factory;

        public LocalDriverBuilder() : this(new WebDriverFactory())
        {
        }

        internal LocalDriverBuilder(WebDriverFactory factory)
        {
            this.factory = factory;
        }

        public virtual IWebDriver Launch(string browserTarget, string startingUrl)
        {
            var driver = CreateWebDriver(browserTarget);
            driver.Navigate().GoToUrl(startingUrl);
            return driver;
        }

        private IWebDriver CreateWebDriver(string browserTarget)
        {
            switch (browserTarget)
            {
                case BrowserTarget.Chrome:
                    return factory.CreateLocalChromeDriver();
                default:
                    throw new NotSupportedException($"{browserTarget} is not a supported local browser type.");
            }
        }
    }
}

