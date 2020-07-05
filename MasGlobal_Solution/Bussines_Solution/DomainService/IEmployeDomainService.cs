using DataAcces_Solution.Entities;
using System.Collections.Generic;

namespace Bussines_Solution.DTO
{
    public interface IEmployeDomainService
    {
        EmployeeDto GetById(int id);
        EmployeeAnualSalaryDto GetByIdWithAnualSalary(int id);
        List<EmployeeDto> Get();
        List<EmployeeAnualSalaryDto> GetWithAnualSalary();

      
    }
}
