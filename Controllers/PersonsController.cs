using Microsoft.AspNetCore.Mvc;
using net_web_tuto.Database;
using net_web_tuto.Models;

[Route("persons")]
public class PersonsController : Controller {

    private readonly ApplicationDbContext context;

    public PersonsController(ApplicationDbContext context){
        this.context = context;
    }

}