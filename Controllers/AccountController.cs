using Microsoft.AspNetCore.Mvc;
using Contractor_Claims.Models; // Adjust according to your models' namespace
using Contractor_Claims.Services; // Adjust according to your services' namespace

public class AccountController : Controller
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Handle authentication logic here
            return RedirectToAction("Index", "Home");
        }
        return View(model);
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Handle registration logic here
            return RedirectToAction("Login");
        }
        return View(model);
    }

    public IActionResult Logout()
    {
        // Handle logout logic here
        return RedirectToAction("Index", "Home");
    }
}

