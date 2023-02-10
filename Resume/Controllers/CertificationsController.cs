using Microsoft.AspNetCore.Mvc;
using Resume.Data.DataSetup;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class CertificationsController : Controller
{
    public async Task<IActionResult> Index()
    {
        var certificationQuery = new CertificationQuery();
        var certifications = await certificationQuery.GetCertificationByPersonId(DbHelper.GetPersonIdByName("Viren Sareen"));

        return View(certifications);
    }
}