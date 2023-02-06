using Microsoft.AspNetCore.Mvc;
using Resume.Data.Queries;

namespace Resume.Controllers;

public class CertificationsController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var certificationQuery = new CertificationQuery();
        var certifications = await certificationQuery.GetCertificationByPersonId(1);

        return View(certifications);
    }
}