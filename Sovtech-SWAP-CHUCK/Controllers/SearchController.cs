using DbConsole;
using Microsoft.AspNetCore.Mvc;
using static Sovtech_SWAP_CHUCK.SwapiPeople;

namespace Sovtech_SWAP_CHUCK.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
    

        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Search")]
        public async Task<ActionResult> GetAsync(string query)
        {
            var result = ApiHelper.SendRequest("https://api.chucknorris.io/" + "jokes/search?query=" + query, "Get", String.Empty);
            var result2 = ApiHelper.SendRequest("https://swapi.dev/api/people/" + "?search=" + query, "Get", String.Empty);

            CategoryResponse categories  = result.code == 1 ? await result.content.ReadAsAsync<CategoryResponse>() : new CategoryResponse();
            PeopleResponse people = result2.code == 1 ? await result2.content.ReadAsAsync<PeopleResponse>() : new PeopleResponse();

            return Ok(new
            {
                categories = categories.result ?? new List<CategoryResult>(),
                people = people.results ?? new List<PeopleResult>()
            });
        }
    }
}
