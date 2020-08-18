using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Hello()
        {
            return Content("Hello World");
        }
        public IActionResult HelloUser(string userName)
        {
            return Content($"Hello {userName}");
        }
    }
}