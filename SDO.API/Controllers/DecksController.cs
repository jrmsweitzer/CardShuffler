using Microsoft.AspNetCore.Mvc;

namespace SDO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecksController : ControllerBase
    {

        [HttpPost]
        public void Post([FromBody] SDO.Models.Deck deck)
        {

        }
    }
}