using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using redwings.Models;

namespace redwings.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }
  [HttpGet]
    public IActionResult login()
    {
        return View();
    }

    public IActionResult validate(string email, string password)
    {
        Console.WriteLine("Validating User credentials.... ");

        if (email == "pravinkadam21998@gmail.com" && password == "Ronaldo@07")
        {
            Console.WriteLine("successfull validation of user..... ");
            Console.WriteLine("Redirecting to welcome..... ");
            return Redirect("/Auth/Welcome");

        }
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }
     public IActionResult SignUp()
    {
        
       return Redirect("/Auth/Register");
    }
}
