using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.CardBuilder.Pages
{
    public class MonsterPage : IndividualCardPage
    {
        public MonsterPage(IWebDriver driver) : base(driver)
        {
        }

        private By _attributeLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Attribute']]/td//a[1]");
        private By _typesLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[contains(.,'Type')]]/td//a[1]");
        private By _effectLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Types']]/td//a[.='Effect']");
        private By _fusionLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Types']]/td//a[.='Fusion']");
        private By _flipEffectLocator = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Types']]/td//a[.='Flip']");
        private By _level = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Level']]/td//a[1]");
        private By _atk = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='ATK']]/td//a[1]");
        private By _def = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='ATK']]/td//a[2]");
        private By _cardCode = By.XPath("//table[@class='cardtable']/tbody/tr[th/a[.='Password']]/td//a[1]");
        private By _description = By.XPath("//td[@class='cardtablespanrow'][1]");

        public Monster GetCard()
        {
            if (Exists(_fusionLocator))
                return GetFusionMonster();

            if (Exists(_effectLocator))
                return GetEffectMonster();
            else
                return GetNormalMonster();
        }

        private EffectMonster GetEffectMonster()
        {
            return new EffectMonster(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                Attribute = GetMonsterAttribute(_driver.FindElement(_attributeLocator).Text),
                Type = GetMonsterType(_driver.FindElement(_typesLocator).Text),
                HasFlipEffect = Exists(_flipEffectLocator),
                Level = int.Parse(_driver.FindElement(_level).Text),
                ATK = int.Parse(_driver.FindElement(_atk).Text),
                DEF = int.Parse(_driver.FindElement(_def).Text),
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text
            };
        }

        private NormalMonster GetNormalMonster()
        {
            return new NormalMonster(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                Type = GetMonsterType(_driver.FindElement(_typesLocator).Text),
                Level = int.Parse(_driver.FindElement(_level).Text),
                ATK = int.Parse(_driver.FindElement(_atk).Text),
                DEF = int.Parse(_driver.FindElement(_def).Text),
                CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                Description = _driver.FindElement(_description).Text
            };
        }

        private FusionMonster GetFusionMonster()
        {
            if (Exists(_effectLocator))
            {
                return new EffectFusionMonster(null)
                {
                    Name = _driver.FindElement(_cardName).Text,
                    Type = GetMonsterType(_driver.FindElement(_typesLocator).Text),
                    Level = int.Parse(_driver.FindElement(_level).Text),
                    ATK = int.Parse(_driver.FindElement(_atk).Text),
                    DEF = int.Parse(_driver.FindElement(_def).Text),
                    CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                    Description = _driver.FindElement(_description).Text
                };
            }
            else
            {
                return new NormalFusionMonster(null)
                {
                    Name = _driver.FindElement(_cardName).Text,
                    Type = GetMonsterType(_driver.FindElement(_typesLocator).Text),
                    Level = int.Parse(_driver.FindElement(_level).Text),
                    ATK = int.Parse(_driver.FindElement(_atk).Text),
                    DEF = int.Parse(_driver.FindElement(_def).Text),
                    CardCode = int.Parse(_driver.FindElement(_cardCode).Text),
                    Description = _driver.FindElement(_description).Text
                };
            }
        }

        private MonsterType GetMonsterType(string type)
        {
            Enum.TryParse(type, out MonsterType monsterType);
            return monsterType;
        }

        private MonsterAttribute GetMonsterAttribute(string attribute)
        {
            Enum.TryParse(attribute, out MonsterAttribute monsterType);
            return monsterType;
        }
    }
}
