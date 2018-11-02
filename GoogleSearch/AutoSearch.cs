using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Windows;
using System.Diagnostics;

namespace GoogleSearch
{
    [TestClass]
    public class AutoSearch
    {
        IWebDriver cDriver;

        [TestMethod]
        public void ChromeSearch()
        {
            //Create an instance for IWebDriver and get the instance for Chrome Driver
            cDriver = new ChromeDriver();

            //Nevigate to Google page
            cDriver.Navigate().GoToUrl("http://www.google.com");

            //Find search textbox using UI Element
            IWebElement searchBox = cDriver.FindElement(By.Name("q"));

            //Enter search text
            searchBox.SendKeys("test automation is awesome");

            //Perform enter Key
            searchBox.SendKeys(Keys.Return);

            //Get the title of the search page
            string title = cDriver.Title;

            // print out the search page title in console
            Console.WriteLine("Title of the search page: {0}", title);
                        
            //Close browser
            cDriver.Close();
        }
    }
}
