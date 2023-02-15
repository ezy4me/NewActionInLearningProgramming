using System.Diagnostics;
using CarServiceLibrary.Models;
using CarServiceLibrary.ViewModels;
using CarServiceProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarServiceProject.Controllers;

public class MainActionsController : Controller
{
    private readonly ILogger<MainActionsController> _logger;
	private CarServiceDbContext _db;

	public MainActionsController(ILogger<MainActionsController> logger, CarServiceDbContext context)
    {
        _logger = logger;
        _db = context;
    }

	

	#region MyRegion

	public IActionResult Diagnostic()
    {
        var services = _db.Services.Where(s => s.TypeId == 4).ToList();
        ServicesViewModel vm = new ServicesViewModel();
        vm.Services = services;
        return View(vm);
    }

	public async Task<IActionResult> Maintenance()
	{
		var services = _db.Services.Where(s => s.TypeId == 2).ToList();
		var vm = new ServicesViewModel();
        vm.Services = services;
		return View(vm);
	}

    public IActionResult GetService(int id)
    {
        var service = _db.Services.Find(id);
        return Json(service);
    }

	public IActionResult Repair()
    {
        return View();
    }

    public IActionResult Detailing()
    {
		var services = _db.Services.Where(s => s.TypeId == 3).ToList();
		ServicesViewModel vm = new ServicesViewModel();
		vm.Services = services;
		return View(vm);
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