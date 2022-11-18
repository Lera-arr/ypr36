﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2_ypr36
{
    [TestFixture]//создание теста
    public class Class4

    {
        IWebDriver webDriver = new ChromeDriver(); //создание и инициализации на браузер

        [TestCase]//Тестовый случай
        public void yaru_reguest()
        {
            webDriver.Url = "https://ya.ru/"; //установка адреса и переход в браузер
    
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"text\"]"));

            search.SendKeys("Туры по России");

            IWebElement button = webDriver.FindElement(By.XPath("/html/body/main/div[2]/form/div/button"));
            Console.WriteLine(button.Displayed);
            Console.WriteLine(button.Text);
            Console.WriteLine(button.Selected);

        }


    }

}