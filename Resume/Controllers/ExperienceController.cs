using Microsoft.AspNetCore.Mvc;
using Resume.Data.DataSetup;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class ExperienceController : Controller
{
    public async Task<IActionResult> Index()
    {
        var experienceQuery = new ExperienceQuery();
        var experience = await experienceQuery.GetExperiencesByPersonId(DbHelper.GetPersonIdByName("Viren Sareen"));
        
        return View(experience);
    }
}