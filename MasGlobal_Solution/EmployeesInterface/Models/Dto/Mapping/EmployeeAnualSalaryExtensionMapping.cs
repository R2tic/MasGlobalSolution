using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesInterface.Models.Dto.Mapping
{
    public static class EmployeeAnualSalaryExtensionMapping
    {
        public static EmployeeAnualSalaryDto Map(this Employee entity)
        {
            var dto = new EmployeeAnualSalaryDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                ContractTypeName = entity.ContractTypeName,
                RoleId = entity.RoleId,
                RoleName = entity.RoleName,
                RoleDescription = entity.RoleDescription,
                HourlySalary = entity.HourlySalary,
                MonthlySalary = entity.MonthlySalary,
                AnualSalary=entity.AnualSalary
             
            };
            return dto;
        }

        public static Employee Map(this EmployeeAnualSalaryDto dto)
        {
            var entity = new Employee()
            {
                Id = dto.Id,
                Name = dto.Name,
                ContractTypeName = dto.ContractTypeName,
                RoleId = dto.RoleId,
                RoleName = dto.RoleName,
                RoleDescription = dto.RoleDescription,
                HourlySalary = dto.HourlySalary,
                MonthlySalary = dto.MonthlySalary,
                AnualSalary = dto.AnualSalary
            };
            return entity;
        }
        public static List<EmployeeAnualSalaryDto> Map(this List<Employee> entities)
        {
            var employeeDtos = new List<EmployeeAnualSalaryDto>();
            foreach (var ent in entities)
            {
                employeeDtos.Add(ent.Map());
            }
            return employeeDtos;
        }
    }
}