using Microsoft.AspNetCore.Mvc;
using Project.Tigers.Domain.Catalog;

namespace Project.Tigers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
       [HttpGet]
       public IActionResult GetItems()
       {
           return Ok("hello world.");
       } 
    }
}
