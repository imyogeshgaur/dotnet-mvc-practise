using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstProject.Models;


namespace firstProject.Controllers;

public class HomeController : Controller
{
    public string Name()
    {
        return "My name is Yogesh";
    }

    public string EmployeeProfile(int id){
        if(id==1){
            return  "Employee 1 Data";
        }else{
            return "No Data ";
        }
    }

    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    public ViewResult Privacy(){
        return View();
    }
    public ViewResult About(){
        return View();
    }

    [HttpGet]
    public IActionResult Form()
    {
        
        return View();
    }

    public ActionResult Employee(){
        var data = GetEmployeeData();
        return View(data);
    }

    public Employee GetEmployeeData(){
        return new Employee()
        {
            employeeId=101,
            employeeName="Ramesh",
            employeeSalary = 1001.322F
        };
    }
}
