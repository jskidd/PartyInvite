using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvite.Models;

namespace PartyInvite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult RSVPForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RSVPForm(Response response)
    {
        if (ModelState.IsValid)
        {
            Repository.AddResponse(response);
            return View("Thanks", response);
        }

        return View();
    }

    public IActionResult ListResponses()
    {
        return View(Repository.Responses.Where(r => r.WillAttend == true));
    }
}
