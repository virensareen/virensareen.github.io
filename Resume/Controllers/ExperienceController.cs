using Microsoft.AspNetCore.Mvc;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class ExperienceController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var experienceQuery = new ExperienceQuery();
        var experience = await experienceQuery.GetExperiencesByPersonId(1);
        
        return View(experience);
    }
}