using Microsoft.AspNetCore.Mvc;
using Resume.Data.DataSetup;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class EducationController : Controller
{
    public async Task<IActionResult> Index()
    {
        var educationQuery = new EducationQuery();
        var education = await educationQuery.GetEducationsByPersonId(DbHelper.GetPersonIdByName("Viren Sareen"));
        
        return View(education);
    }
}