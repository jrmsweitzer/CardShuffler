using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SDO.CardBuilder.Pages;
using SDO.Models.Yugioh;

namespace SDO.CardBuilder
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void GetCardsAsModels()
        {
            var url = "https://yugipedia.com/wiki/Speed_Duel:_Attack_from_the_Deep";

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            var cards = new CardListPage(driver).GetCardNames();
            List<YugiohGameCard> AllCards = new List<YugiohGameCard>();

            foreach (var cardName in cards)
            {
                driver.FindElement(By.LinkText(cardName)).Click();

                var card = new IndividualCardPage(driver).GetCard();
                AllCards.Add(card);
                driver.Navigate().Back();
            }

            if (AllCards.Count < 50)
                throw new Exception("Did not get all cards");
            if (AllCards.Any(c => c == null))
                throw new Exception("Some cards are null");
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
