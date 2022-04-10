using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithVaildation.Controllers
{

public class SurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Survey()
    {
        return View("Survey");
    }

    [HttpPost("/process")]
    public IActionResult Process(SurveyModel survey)
    {
        if (!ModelState.IsValid)
        {
            return View("Survey");
        }
        return View("Results", survey);
    }

    [HttpGet("/results")]
    public ViewResult Results(SurveyModel survey)
    {
        return View("Results", survey);
    }
}

}