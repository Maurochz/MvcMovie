using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ Reemplazar el método index:

        public IActionResult Index()
        {
            return View();
        }


        // 
        // GET: /HelloWorld/Welcome/ Agregar este método:

        // public string Welcome()
        //{
        //      return "This is the Welcome action method...";
        // }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;


            return View();
        }



    }
}
