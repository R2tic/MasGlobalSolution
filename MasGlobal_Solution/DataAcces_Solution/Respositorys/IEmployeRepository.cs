using DataAcces_Solution.Entities;
using System.Collections.Generic;

namespace DataAcces_Solution.Respositorys
{
    public interface IEmployeRepository
    {
        Employe Get(int id);
        List<Employe> Get();
    }
}
