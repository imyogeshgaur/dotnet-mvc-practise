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
    
    public IActionResult Details()
    {
        var detaisOfUser = GetData();
        return View(detaisOfUser);
    }

    [HttpPost]

    public string PostData(){
        string? firstName = Request.Form["firstName"];
        string? middleName = Request.Form["middleName"];
        string? lastName = Request.Form["lastName"];

       return "First Name is : "+ firstName +" Middle Name is : " + middleName +" Last Name is : " + lastName;
    }

    [HttpGet]

    public UserModel GetData(){
        return new UserModel(){
            firstName = "Yogesh",
            middleName = "",
            lastName = "Gaur"
        };
    }
    
}
