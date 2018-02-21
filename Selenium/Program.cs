using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using Selenium;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new FirefoxDriver()
            {
                Url = "http://google.pl"
                //"http://localhost/selenium/index.php"
            };
            //Zadanie 1
            //var element = driver.FindElementByName("imie");
            //element.SendKeys("Jan");
            //var element3 = driver.FindElementByName("nazwisko");
            //element3.SendKeys("Kowalski");
            //var element2 = driver.FindElementByName("submit");
            //element2.Click();
            //Thread.Sleep(5000);
            //driver.Close();
            var element = driver.FindElementByCssSelector("#lst-ib");
            element.SendKeys("jak zbudować helikopter \n");
            Thread.Sleep(3000);
            var lista = driver.FindElementsByCssSelector("div > h3 > a");
            Console.WriteLine("Znaleziono: " + lista.Count);
            foreach (var zmienna in lista)
            {
                Console.WriteLine(zmienna.GetAttribute("innerText") + " ");
                Console.WriteLine(zmienna.GetAttribute("href") + " ");
            }


            for (int n = 3; n < 5; n++)
            {
                var element2 = driver.FindElementByCssSelector($"#nav > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child({n}) > a:nth-child(1)");
                lista = driver.FindElementsByCssSelector("div > h3 > a");
                Console.WriteLine("Znaleziono: " + lista.Count);
                foreach (var zmienna in lista)
                {
                    Console.WriteLine(zmienna.GetAttribute("innerText") + " ");
                    Console.WriteLine(zmienna.GetAttribute("href") + " ");
                }
                var element3 = driver.FindElementByCssSelector("#pnnext > span:nth-child(2)");
                element3.Click();
                Thread.Sleep(3000);
            }
                      
        }

        private static void println(object p)
        {
            throw new NotImplementedException();
        }
    }
}
