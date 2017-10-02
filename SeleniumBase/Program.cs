using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtensions;

namespace SeleniumBase
{
    public class Program
    {
        // Constants
        private const string mc_strUrl = "https://www.google.com/"; // Replace with the URL you want to navigate to
        private const double mc_dblTimeout = 1; // The web driver timeout in minutes

        public static void Main(string[] args)
        {
            try
            {
                // Initialize the web driver
                using (IWebDriver objDriver = new ChromeDriver())
                {
                    // Initialize the web driver wait
                    WebDriverWait objWait = new WebDriverWait(objDriver, TimeSpan.FromMinutes(mc_dblTimeout));
                    objWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

                    // Navigate to the specified URL
                    objDriver.Navigate().GoToUrl(mc_strUrl);

                    /*
                     * The rest of your code goes here.
                     * 
                     * Here is an example of a common pattern to use:
                     */

                    // Wait until the element with id "lst-ib" exists on the page
                    objWait.Until(d => d.FindElementById("lst-ib"));

                    // Get the element with id "lst-ib"
                    IWebElement objSearchBox = objDriver.FindElementById("lst-ib");

                    // Send the element some text input
                    objSearchBox.SendKeys("kittens");
                    objSearchBox.SendKeys(Keys.Enter);

                    // Wait indefinitely. This is just so the browser doesn't automatically close.
                    objWait.Until(d => false);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
