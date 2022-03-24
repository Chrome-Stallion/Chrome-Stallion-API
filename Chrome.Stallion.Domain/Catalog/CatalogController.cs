using Microsoft.AspNetCore.Mvc;
using Chrome.Stallion.Domain.Catalog;

namespace Chrome.Stallion.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [httpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}