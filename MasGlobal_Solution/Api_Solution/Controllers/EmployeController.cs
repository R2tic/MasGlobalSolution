using System.Web.Http;
using Bussines_Solution.DTO;

namespace Api_Solution.Controllers
{
   
    public class EmployeController : ApiController
    {

        private readonly IEmployeDomainService _employeDomainService;

        public EmployeController(IEmployeDomainService employeDomainService)
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
            var employ = _employeDomainService.GetById(id);
            if (employ == null)
            {
                return NotFound();
            }
            return Ok(employ);
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var employees = _employeDomainService.Get();
            if (employees == null)
            {
                return NotFound();
            }
            return Ok(employees);
        }
    }
}
