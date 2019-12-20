using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloController.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // When we want to display the form in a different URL we would use:
            //string html = "<form method = 'post' action='/Hello/Display'>" 
            string html = "<form method = 'post' >" +
                "<input type ='text' name ='name' />"
                + "<input type = 'submit' value ='Greet me'/>"
                + "</form>";
            return View();

            //return Redirect("/Hello/Goodbye");
            //return Content(html, "text/html");
        }
        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0} </h1>", name), "text/html");
        }

        // Handle Request to /Hello/Name (URL Segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0} </h1>", name), "text/html");

        }



        /*
        // I can use ... Index( string name = "World") and does the same
        if (string.IsNullOrEmpty(name))
        {
            name = "World";
        }
        return Content(string.Format("<h1>Hello {0} </h1>",name),"text/html");
        */


        //Hello/Goodbuy is the default...
        //[Route("/Hello/Aloha")]

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }

    }
}