using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.CardBuilder
{
    public class CardListPage
    {
        private IWebDriver _driver;
        public CardListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By cardNameRows = By.XPath("//table[@id='Top_table']/tbody/tr[contains(.,'SBAD')]");

        public List<string> GetCardNames()
        {
            var rows = _driver.FindElements(cardNameRows);
            var list = new List<string>();

            foreach (var row in rows)
            {
                var name = row.FindElement(By.XPath("./td[2]/a")).Text;
                var rarity = row.FindElement(By.XPath("./td[3]/a")).Text;
                var cardType = row.FindElement(By.XPath("./td[4]/a")).Text;
                list.Add(name);
            }

            return list;
        }


    }
}
