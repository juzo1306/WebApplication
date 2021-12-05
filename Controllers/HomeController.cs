using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("/")]
    //Controller
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Index(string myname)
        {
            ViewBag.Message = "Hello , " + myname;
            return View();
        }


/*
        [HttpGet]
        [Route("/about")]
        public IActionResult AboutMe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutMe(int salary)
        {
            string view="";
            if(salary == 0)
			{
                 view = "Empty";
			}
            ViewBag.Message = "Your salary is" + view;
            return View();
        }

*/

    }
    
   
}
