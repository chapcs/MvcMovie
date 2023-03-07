using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    Random random = new Random();
    //
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    //
    // GET: /HelloWorld/Welcome/
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numtimes = 1)
    {
        // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        ViewData["Message"] = "Hello " + name;
        ViewData["Numtimes"] = numtimes;
        return View();
    }
}
