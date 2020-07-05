using Bussines_Solution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Solution.Controllers
{
    public class EmployeesWithAnualSalaryController : ApiController
    {
        private readonly IEmployeDomainService _employeDomainService;

        public EmployeesWithAnualSalaryController(IEmployeDomainService employeDomainService)
        {
            _employeDomainService = employeDomainService;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var employ = _employeDomainService.GetByIdWithAnualSalary(id);
            if (employ == null)
            {
                return NotFound();
            }
            return Ok(employ);
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var employees = _employeDomainService.GetWithAnualSalary();
            if (employees == null)
            {
                return NotFound();
            }
            return Ok(employees);
        }
    }
}
