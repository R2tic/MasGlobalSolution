using DataAcces_Solution.Entities;
using System.Collections.Generic;

namespace Bussines_Solution.DTO.Mapping
{
    public static class EmployeExtensionsMapping
    {
        public static EmployeeDto Map(this Employe entity)
        {
            var dto = new EmployeeDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                ContractTypeName = entity.ContractTypeName,
                RoleId = entity.RoleId,
                RoleName = entity.RoleName,
                RoleDescription = entity.RoleDescription,
                HourlySalary = entity.HourlySalary,
                MonthlySalary = entity.MonthlySalary
            };
            return dto;
        }

        public static Employe Map(this EmployeeDto dto)
        {
            var entity = new Employe()
            {
                Id = dto.Id,
                Name = dto.Name,
                ContractTypeName = dto.ContractTypeName,
                RoleId = dto.RoleId,
                RoleName = dto.RoleName,
                RoleDescription = dto.RoleDescription,
                HourlySalary = dto.HourlySalary,
                MonthlySalary = dto.MonthlySalary
            };
            return entity;
        }
        public static List<EmployeeDto> Map(this List<Employe> entities)
        {
            var employeeDtos = new List<EmployeeDto>();
            foreach (var ent in entities)
            {
                employeeDtos.Add(ent.Map());
            }
            return employeeDtos;
        }

    }
}
