using hr_erp.Application;
using hr_erp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hr_erp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DepartmentService _departmentService;
        private readonly EmployeeService _employeeService;

        public HomeController(DepartmentService departmentService, EmployeeService employeeService, ILogger<HomeController> logger)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new();
            var departments = _departmentService.GetDepartments();
            indexViewModel.DepartmentsCount = departments!.Count();
            foreach (var item in departments!)
            {
                indexViewModel.VacancyCount += item.Positions!.Count();
                indexViewModel.PermanentVacsCount += item.Positions!.Where(i => i.Busy.Equals(true)).Count();
                indexViewModel.TemporaryVacsCount += item.Positions!.Where(i => i.Busy.Equals(false)).Count();
            }
            var employees = _employeeService.GetEmployees();
            indexViewModel.EmployeesCount = employees!.Count();
            indexViewModel.PermanentEmpsCount = employees!.Where(e => e.Permanent.Equals(true)).Count();
            indexViewModel.TemporaryEmpsCount = employees!.Where(e => e.Permanent.Equals(false)).Count();
            return View(indexViewModel);
        }

        public IActionResult Employees()
        {
            var employees = _employeeService.GetEmployees();
            return View(employees);
        }

        public IActionResult Employee(int id)
        {
            var employee = _employeeService.GetEmployee(id);
            return View(employee);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}