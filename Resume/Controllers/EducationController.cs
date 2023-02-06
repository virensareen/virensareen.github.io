using Microsoft.AspNetCore.Mvc;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class EducationController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var educationQuery = new EducationQuery();
        var education = await educationQuery.GetEducationsByPersonId(1);
        
        return View(education);
    }
}