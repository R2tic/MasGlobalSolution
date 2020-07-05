using EmployeesInterface.Models.Dto;
using System.Collections.Generic;

namespace EmployeesInterface.Models.Services
{
    public interface IDomainServices
    {
        List<EmployeeAnualSalaryDto> Get();
        List<EmployeeAnualSalaryDto> GetById(int id);
    }
}
