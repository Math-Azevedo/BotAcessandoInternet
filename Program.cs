using EasyAutomationFramework;
using OpenQA.Selenium;
using System;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var web = new Web();

            web.StartBrowser();

            web.Navigate("https://google.com");

            web.AssignValue(TypeElement.Name, "q", "Hello World").element.SendKeys(Keys.Enter);

            web.CloseBrowser();
        }
    }
}
