using EMP.DAL;
using EMP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.BLL
{
    public class EmployeeMananger
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public void Add(Employee emp)
        {

            if (emp != null)
            {
                if (emp.Image != null)
                {
                    employeeRepository.Add(emp);
                    throw new Exception("Successfully Saved..");
                }
            }
            throw new Exception("Employee Empty");
        }
    }
}
