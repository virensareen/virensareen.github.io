using Microsoft.AspNetCore.Mvc;
using Resume.Data.DataSetup;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class ExtraCurricularController : Controller
{
    public async Task<IActionResult> Index()
    {
        var extraCurricularQuery = new ExtraCurricularQuery();
        var extraCurriculars = await extraCurricularQuery.GetExtraCurricularsByPersonId(DbHelper.GetPersonIdByName("Viren Sareen"));

        return View(extraCurriculars);
    }
}