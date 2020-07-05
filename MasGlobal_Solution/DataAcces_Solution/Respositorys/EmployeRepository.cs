using DataAcces_Solution.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DataAcces_Solution.Respositorys
{
    public class EmployeRepository : IEmployeRepository
    {
        private string baseURL = "http://masglobaltestapi.azurewebsites.net/";
        HttpClient client = new HttpClient();

        public Employe Get(int id)
        {
            var employe = new Employe();
            employe = Get().Where(e => e.Id == id).FirstOrDefault();
            return employe;
        }

        public List<Employe> Get()
        {
            List<Employe> employees = new List<Employe>();
            client.BaseAddress = new System.Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Employees").Result;
            if (response.IsSuccessStatusCode)
            {
                var empResponse = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<Employe>>(empResponse);
            }
            return employees;
        }
    }
}
