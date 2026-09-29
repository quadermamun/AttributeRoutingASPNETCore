using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    //[Route("Home")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]        
        //[Route("Index")]
        //[Route("[action]")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }


        //[Route("About")]
        //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        //  [Route("[action]")]

        //[Route("Details/{id?}")]
        //[Route("[action]/{id?}")]
        [Route("{id?}")]

        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
