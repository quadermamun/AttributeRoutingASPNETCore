using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        [Route("[action]")]
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
