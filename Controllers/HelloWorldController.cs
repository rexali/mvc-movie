using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //test:  https://localhost:7298/HelloWorld/Welcome?name=Rick&numtimes=5
        public string Welcome(string name, int numTimes = 2)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        // test https://localhost:7298/HelloWorld/Test/3?name=Rick
        public string Test(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}