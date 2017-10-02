using OpenQA.Selenium;

namespace SeleniumExtensions
{
    public static class SeleniumExtensions
    {
        public static IWebElement FindElementByClassName(this ISearchContext objContext, string strClassNameToFind)
        {
            try
            {
                return objContext.FindElement(By.ClassName(strClassNameToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementByCssSelector(this ISearchContext objContext, string strCssSelectorToFind)
        {
            try
            {
                return objContext.FindElement(By.CssSelector(strCssSelectorToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementById(this ISearchContext objContext, string strIdToFind)
        {
            try
            {
                return objContext.FindElement(By.Id(strIdToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementByLinkText(this ISearchContext objContext, string strLinkTextToFind)
        {
            try
            {
                return objContext.FindElement(By.LinkText(strLinkTextToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementByName(this ISearchContext objContext, string strNameToFind)
        {
            try
            {
                return objContext.FindElement(By.Name(strNameToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementByPartialLinkText(this ISearchContext objContext, string strPartialLinkTextToFind)
        {
            try
            {
                return objContext.FindElement(By.PartialLinkText(strPartialLinkTextToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementByTagName(this ISearchContext objContext, string strTagNameToFind)
        {
            try
            {
                return objContext.FindElement(By.TagName(strTagNameToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement FindElementByXPath(this ISearchContext objContext, string strXPathToFind)
        {
            try
            {
                return objContext.FindElement(By.XPath(strXPathToFind));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}
