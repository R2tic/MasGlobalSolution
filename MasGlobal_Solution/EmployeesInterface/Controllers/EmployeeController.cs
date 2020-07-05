using EmployeesInterface.Models.Dto;
using EmployeesInterface.Models.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EmployeesInterface.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IDomainServices _employeDomainService;
        public EmployeeController(IDomainServices employeDomainService)
        {
            _employeDomainService = employeDomainService;
        }
        public ActionResult Index()
        {
            var employees = _employeDomainService.Get();
            return View();
        }
        public ActionResult Employees()
        {
            var employees = _employeDomainService.Get();

            return View("employeesList", employees);
        }
        public ActionResult EmployeeById(int id)
        {
            var employee = _employeDomainService.GetById(id);
            return View("employeesList", employee);
        }
    }
}
