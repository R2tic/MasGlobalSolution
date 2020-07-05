using DataAcces_Solution.Entities;
using System.Collections.Generic;

namespace Bussines_Solution.DTO.Mapping
{
    public static class EmployeeAnualSalaryExtensionMapping
    {
        public static EmployeeAnualSalaryDto MapAddAnualSalary(this Employe entity)
        {
            double AnualSalaryCalc = GetAnualSalary(entity);
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
                AnualSalary = AnualSalaryCalc
            };
           
            return dto;
        }

        public static Employe MapAddAnualSalary(this EmployeeAnualSalaryDto dto)
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
        public static List<EmployeeAnualSalaryDto> MapAddAnualSalary(this List<Employe> entities)
        {
            var employeeDtos = new List<EmployeeAnualSalaryDto>();
            foreach (var ent in entities)
            {
                employeeDtos.Add(ent.MapAddAnualSalary());
            }
            return employeeDtos;
        }

    private static double GetAnualSalary( Employe entity)
       {
          
            switch (entity.ContractTypeName)
            {
                case "HourlySalaryEmployee": return 120 * entity.HourlySalary * 12;
                case "MonthlySalaryEmployee": return entity.MonthlySalary * 12;
                default: return 0;
            }
        }




    }
}
