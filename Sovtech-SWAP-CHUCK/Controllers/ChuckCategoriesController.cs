using DbConsole;
using Microsoft.AspNetCore.Mvc;

namespace Sovtech_SWAP_CHUCK.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ChuckCategoriesController : ControllerBase
    {
      

        private readonly ILogger<ChuckCategoriesController> _logger;

        public ChuckCategoriesController(ILogger<ChuckCategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetChuckCategories")]
        public async Task<IEnumerable<String>> Get()
        {
          var result =  ApiHelper.SendRequest("https://api.chucknorris.io/", "Get", "jokes/categories");
            if(result.code != 1) { return new List<string>(); }

            List<string> categories = await result.content.ReadAsAsync<List<string>>();
              return categories;
        }
    }
}
