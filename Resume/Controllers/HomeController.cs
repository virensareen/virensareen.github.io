using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Resume.Data.Queries;
using Resume.Models;

namespace Resume.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> Index()
    {
        var personQuery = new PersonQuery();
        var person = await personQuery.GetPersonByName("Viren Sareen");

        return View(person);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}