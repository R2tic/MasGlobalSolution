using EmployeesInterface.Models.Dto;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EmployeesInterface.Models.Services
{
    public class DomainServices:IDomainServices
    {
        private string baseURL = "http://localhost:61533";
        HttpClient client = new HttpClient();
        public List<EmployeeAnualSalaryDto> Get()
        {
            List<EmployeeAnualSalaryDto> employees = new List<EmployeeAnualSalaryDto>();
            client.BaseAddress = new System.Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/api/EmployeesWithAnualSalary").Result;
            if (response.IsSuccessStatusCode)
            {
                var empResponse = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<EmployeeAnualSalaryDto>>(empResponse);
            }
            return employees;
        }
        public List<EmployeeAnualSalaryDto> GetById(int id)
        {
            List<EmployeeAnualSalaryDto> employeeList = new List<EmployeeAnualSalaryDto>();
            EmployeeAnualSalaryDto employee = new EmployeeAnualSalaryDto();
            client.BaseAddress = new System.Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/api/EmployeesWithAnualSalary/"+id).Result;
            if (response.IsSuccessStatusCode)
            {
                var empResponse = response.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<EmployeeAnualSalaryDto>(empResponse);
                employeeList.Add(employee);
            }
           
            return employeeList;
        }
    }
}