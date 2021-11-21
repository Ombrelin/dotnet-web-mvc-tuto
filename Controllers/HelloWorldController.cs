using Microsoft.AspNetCore.Mvc;
using net_web_tuto.Models;

[Route("hello-world")]
public class HelloWorldController : Controller {
    
    [HttpGet]
    public IActionResult HelloWorldForm()
    {
        return View("hello-world-form");
    }

    [HttpPost("salute")]
    public IActionResult SayHello(Person person)
    {
        return View("hello-world", person);
    }
}