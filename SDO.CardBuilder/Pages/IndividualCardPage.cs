using OpenQA.Selenium;
using SDO.Models.Yugioh;
using System;

namespace SDO.CardBuilder.Pages
{
    public class IndividualCardPage
    {
        public IWebDriver _driver;
        public IndividualCardPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By _cardType = By.XPath("//tr[@class='cardtablerow'][./th/a[.='Card type']]/td//a");
        protected By _cardName = By.XPath("//th[@class='cardtable-header']");

        public YugiohGameCard GetCard()
        {
            var cardType = _driver.FindElement(_cardType).Text;
            switch(cardType)
            {
                case "Skill":
                    return new SkillCardPage(_driver).GetCard();
                case "Monster":
                    return new MonsterPage(_driver).GetCard();
                case "Spell":
                    return new SpellPage(_driver).GetCard();
                case "Trap":
                    return new SpellPage(_driver).GetCard();
                default:
                    return null;
            }
        }

        protected bool Exists(By by)
        {
            try
            {
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
                _driver.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }
    }
}
