using System.Collections.Generic;
using Bussines_Solution.DTO;
using Bussines_Solution.DTO.Mapping;
using DataAcces_Solution.Entities;
using DataAcces_Solution.Respositorys;

namespace Bussines_Solution.DomainService
{
    public class EmployeDomainService : IEmployeDomainService
    {
        private readonly IEmployeRepository _employeRepository;

        public EmployeDomainService(IEmployeRepository employeRepository)
        {
            _employeRepository = employeRepository;
        }

        public EmployeeDto GetById(int id)
        {
            var employe = _employeRepository.Get(id);
            if (employe == null)
            {
                return null;
            }
            var employeDto = employe.Map();
           
            return employeDto;
        }

        public EmployeeAnualSalaryDto GetByIdWithAnualSalary(int id)
        {
            var employe = _employeRepository.Get(id);
            if (employe == null)
            {
                return null;
            }
            var employeDto = employe.MapAddAnualSalary();

            return employeDto;
        }

        public List<EmployeeDto> Get()
        {
            var employees = _employeRepository.Get();
            if (employees == null)
            {
                return null;
            }
            var employeesDto = employees.Map();
  
            return employeesDto;
        }

        public List<EmployeeAnualSalaryDto> GetWithAnualSalary()
        {
            var employees = _employeRepository.Get();
            if (employees == null)
            {
                return null;
            }
            var employeesDto = employees.MapAddAnualSalary();

            return employeesDto;
        }


      
      
    }
}
