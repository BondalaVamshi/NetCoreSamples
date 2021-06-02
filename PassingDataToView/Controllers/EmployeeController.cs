using Microsoft.AspNetCore.Mvc;
using PassingDataToView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingDataToView.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult DetailsViewData()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewData["Employee"] = model; //Returning Employee class type
            ViewData["PageTitle"] = "Employee Detaile"; //Returning String datatype
            return View();
        }
    }
}
