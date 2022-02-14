using EMP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.DAL
{
   public interface IEmployeeRepository
    {
        public void Add(Employee employee);
        public void getAll();
        public void getById(int ?id);
        public void Update(Employee employee);
        public void Delete(int? id);
    }
}
