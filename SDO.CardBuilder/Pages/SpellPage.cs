using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.CardBuilder.Pages
{
    public class SpellPage : IndividualCardPage
    {
        public SpellPage(IWebDriver driver) : base(driver)
        {
        }

        private By _equipLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Equip']");
        private By _fieldLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Field']");
        private By _continuousLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Continuous']");
        private By _ritualLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Ritual']");
        private By _quickplayLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Quickplay']");
        private By _normalSpellLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Property']]/td//a[.='Quickplay']");
        private By _cardCode = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Password']]/td//a[1]");
        private By _description = By.XPath("//td[@class='cardtablespanrow'][1]");

        public Spell GetCard()
        {
            if (Exists(_equipLocator))
                return GetEquipCard();
            if (Exists(_fieldLocator))
                return GetFieldCard();
            if (Exists(_continuousLocator))
                return GetContinuousCard();
            if (Exists(_ritualLocator))
                return GetRitualCard();
            if (Exists(_quickplayLocator))
                return GetQuickplayCard();
            else
                return GetNormalSpellCard();
        }

        public EquipSpell GetEquipCard()
        {
            return new EquipSpell(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public FieldSpell GetFieldCard()
        {
            return new FieldSpell(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public RitualSpell GetRitualCard()
        {
            return new RitualSpell(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public ContinuousSpell GetContinuousCard()
        {
            return new ContinuousSpell(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public QuickplaySpell GetQuickplayCard()
        {
            return new QuickplaySpell(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }

        public NormalSpell GetNormalSpellCard()
        {
            return new NormalSpell(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text,
            };
        }
    }
}
