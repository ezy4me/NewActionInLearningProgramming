using System.Diagnostics;
using CarServiceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceProject.Controllers;

public class MainActionsController : Controller
{
    private readonly ILogger<MainActionsController> _logger;

    public MainActionsController(ILogger<MainActionsController> logger)
    {
        _logger = logger;
    }

    #region MyRegion

    public IActionResult Diagnostic()
    {
        return View();
    }

    public IActionResult Maintenance()
    {
        return View();
    }

    public IActionResult Repair()
    {
        return View();
    }

    public IActionResult Detailing()
    {
        return View();
    }

    public IActionResult Contacts()
    {
        return View();
    }

    public IActionResult OnMarks()
    {
        return View();
    }
    
    public IActionResult AboutService()
    {
        return View();
    }

    #endregion
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}