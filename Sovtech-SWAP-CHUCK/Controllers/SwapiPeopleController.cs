using DbConsole;
using Microsoft.AspNetCore.Mvc;
using static Sovtech_SWAP_CHUCK.SwapiPeople;

namespace Sovtech_SWAP_CHUCK.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SwapiPeopleController : ControllerBase
    {
     

        private readonly ILogger<SwapiPeopleController> _logger;

        public SwapiPeopleController(ILogger<SwapiPeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "SwapiPeople")]
        public async Task<ActionResult> Get()
        {
            var result = ApiHelper.SendRequest("https://swapi.dev/api/people/", "Get", "");
            if (result.code != 1) { return Ok(new List<PeopleResult>()); }

            PeopleResponse categories = await result.content.ReadAsAsync<PeopleResponse>();
            return Ok(categories.results);
        }
    }
}
