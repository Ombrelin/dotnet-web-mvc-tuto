using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net_web_tuto.Models;

[Route("hello-world")]
public class HelloWorldController : Controller {
    
    [HttpGet]
    public IActionResult HelloWorldForm()
    {
        ViewBag.SessionValue = HttpContext.Session.GetString("key");
        return View("hello-world-form");
    }

    [HttpPost("salute")]
    public IActionResult SayHello(Person person)
    {
        HttpContext.Session.SetString("key", "value");
        return View("hello-world", person);
    }
}