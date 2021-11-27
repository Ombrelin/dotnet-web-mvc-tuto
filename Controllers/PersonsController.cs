using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using net_web_tuto.Database;
using net_web_tuto.Models;

[Route("persons")]
public class PersonsController : Controller {

    private readonly ApplicationDbContext context;

    public PersonsController(ApplicationDbContext context){
        this.context = context;
    }

    [HttpGet]
    public IActionResult PersonsPage(){
        List<Person> persons = this.context.Persons.ToList();

        return View("persons", persons);
    }

    [HttpPost("add")]
    public IActionResult AddPerson(Person p){
        this.context.Persons.Add(p);
        this.context.SaveChanges();

        return new RedirectResult("/persons");
    }

    [HttpGet("{id}")]
    public IActionResult GetOnePerson(Guid id){
        Person person = this.context.Persons
            .Where(p => p.Id == id)
            .First();

        return View("person", person);
    }
}