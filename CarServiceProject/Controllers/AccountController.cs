using System.Diagnostics;
using CarServiceLibrary.Models;
using CarServiceLibrary.Models.Entities;
using CarServiceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceProject.Controllers;

public class AccountController : Controller
{
    private CarServiceDbContext _db;

    public AccountController(CarServiceDbContext context)
    {
        _db = context;
    }

    public IActionResult Test() => View();

    public IActionResult Login() => View();

    public IActionResult Registration() => View();

    [HttpPost]
    public async Task<IActionResult> RegisterAccount(Users user)
    {
        if (ModelState.IsValid)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return RedirectToAction("Login");
        }
        else
        {
            return Content("Не валидно!");
        }
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}