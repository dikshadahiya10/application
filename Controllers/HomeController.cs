using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using application.Models;
using application.Entities;

namespace application.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
       [HttpPost]

public IActionResult Login()
{
   
   return RedirectToAction("Index","Home");
}


    
[Authorize("Read")]
public IActionResult Read()
{
    return View();
}
[Authorize("Write")]
public IActionResult Edit()
{
    return View();
}
    public IActionResult Privacy()
    {
        return View();
    }

      public IActionResult registration()
    {
        return View();
    }
      public IActionResult Employee()
    {
        using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmplyeeDetails.ToList();
            // var emplist=context.Forms.Where(x=>x.EmpId==3).FirstOrDefault();
        }
        return View();
    }
      public IActionResult AddEmployee(UserModel employeeModel)
    {
        using (var context=new EmployeeDBContext())
        {
        //     EmployeeModel employee=new EmployeeModel();
            // employee.FirstName=employeeModel.FirstName;
            // employee.Name=employeeModel.Name;
            // employee.Email=employeeModel.Email;
            // employee.Password=employeeModel.Password;
            // employee.ConfirmPassword=employee.ConfirmPassword;
            // employee.Contact=employeeModel.Contact;
            // context.Forms.Add(employee);
            // context.SaveChanges();
        }
        return RedirectToAction(actionName: "Index", controllerName: "Home");
        // return View();
    }
    public IActionResult Index()
    {
    //     
      using (var context=new EmployeeDBContext())
        {
            var employeeList=context.EmplyeeDetails.ToList();
             return View(employeeList);
        }}
}
 