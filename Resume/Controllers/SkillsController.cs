using Microsoft.AspNetCore.Mvc;
using Resume.Data.DataSetup;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class SkillsController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var skillsQuery = new SkillsQuery();
        var skills = await skillsQuery.GetSkillsByPersonId(DbHelper.GetPersonIdByName("Viren Sareen"));

        return View(skills);
    }
}