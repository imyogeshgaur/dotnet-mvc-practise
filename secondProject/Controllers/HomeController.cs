using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using secondProject.Models;

namespace secondProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Register()
    {
        
        return View();
    }
    
    [HttpPost]

    public string PostData(){
        string firstName = Request.Form["firstName"];
        string middleName = Request.Form["middleName"];
        string lastName = Request.Form["lastName"];

       return "First Name is : "+ firstName +" Middle Name is : " + middleName +" Last Name is : " + lastName;
    }
}
