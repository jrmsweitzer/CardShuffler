using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.CardBuilder.Pages
{
    public class TrapPage : IndividualCardPage
    {
        public TrapPage(IWebDriver driver) : base(driver)
        {
        }
        
        private By _continuousLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Continuous']");
        private By _counterLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Counter']");
        private By _cardCode = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Password']]/td//a[1]");
        private By _description = By.XPath("//td[@class='cardtablespanrow'][1]");

        public Trap GetCard()
        {
            if (Exists(_continuousLocator))
                return GetContinuousCard();
            if (Exists(_counterLocator))
                return GetCounterTrap();
            else
                return GetNormalTrap();
        }

        public ContinuousTrap GetContinuousCard()
        {
            return new ContinuousTrap(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public CounterTrap GetCounterTrap()
        {
            return new CounterTrap(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public NormalTrap GetNormalTrap()
        {
            return new NormalTrap(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }
    }
}
