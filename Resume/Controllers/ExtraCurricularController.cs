using Microsoft.AspNetCore.Mvc;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class ExtraCurricularController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var extraCurricularQuery = new ExtraCurricularQuery();
        var extraCurriculars = await extraCurricularQuery.GetExtraCurricularsByPersonId(1);

        return View(extraCurriculars);
    }
}