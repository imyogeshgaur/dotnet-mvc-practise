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

    public IActionResult Success()
    {
        return View();
    }

    [HttpPost]

    public ActionResult PostData(){
        string? firstName = Request.Form["firstName"];
        string? middleName = Request.Form["middleName"];
        string? lastName = Request.Form["lastName"];

        if(ModelState.IsValid){
            return View("Success");
        }
        return View("Success");
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
