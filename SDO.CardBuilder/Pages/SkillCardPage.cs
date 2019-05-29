using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SDO.Models.Yugioh.YugiohCardTypes;

namespace SDO.CardBuilder.Pages
{
    public class SkillCardPage : IndividualCardPage
    {
        public SkillCardPage(IWebDriver driver) : base(driver)
        {
        }

        private By _characterName = By.XPath("//tr[@class='cardtablerow'][./th/a[.='Types']]/td//a[1]");
        private By _skillActivation = By.XPath("//dl[dt[1][.='Skill activation']]/dd[1]");
        private By _skillEffect = By.XPath("//dl[dt[1][.='Skill activation']]/dd[2]");

        private By _setCodes = By.XPath("//td[dl/dt[.='English']]//tbody/tr[contains(.,'SBAD')]//a");

        public Skill GetCard()
        {
            var skill = new Skill(null)
            {
                Name = _driver.FindElement(_cardName).Text,
                Character = _driver.FindElement(_characterName).Text,
                SkillActivationDescription = _driver.FindElement(_skillActivation).Text,
                Description = _driver.FindElement(_skillEffect).Text,
            };

            foreach (var code in _driver.FindElements(_setCodes))
            {
                skill.SetCodes.Add(code.Text);
            }

            return skill;
        }
    }
}
