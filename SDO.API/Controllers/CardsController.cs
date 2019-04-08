using Microsoft.AspNetCore.Mvc;
using SDO.Models.Yugioh;
using SDO.Services;
using System.Collections.Generic;

namespace SDO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private CardService _cardSvc;

        public CardsController()
        {
            _cardSvc = new CardService();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<YugiohGameCard>> Get()
        {
            return _cardSvc.GetAllCards();
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public ActionResult<YugiohGameCard> Get(string name)
        {
            return _cardSvc.GetCardByName(name);
        }
    }
}