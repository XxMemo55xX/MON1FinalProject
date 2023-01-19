using Microsoft.AspNetCore.Mvc;
using PueroApp.Models;
using PueroApp.Services;

namespace PueroApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index(string query)
        {
            var list = _employeeService.GetEmployees(query);
            return View(list);
        }
        [HttpGet]
        public IActionResult CreateEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmp(Employee newEmployee)
        {
            _employeeService.InsertEmployee(newEmployee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteEmp(string query)
        {
            var list = _employeeService.GetEmployees(query);
            return View(list);
        }

        [HttpPost]
        public IActionResult DeleteEmp(EmployeeId employeeId)
        {
            _employeeService.RemoveEmployee(employeeId);
            return RedirectToAction("Index");
        }
    }
}
