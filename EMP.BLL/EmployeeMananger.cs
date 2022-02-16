using EMP.DAL;
using EMP.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable getAllEmp()
        {
            DataTable dataTable = new DataTable();
           dataTable=  employeeRepository.getAll();
            return dataTable;
        }

        public DataTable getById(int id)
        {
            DataTable dataTable = new DataTable();
            if (id >0)
            {
              dataTable=  employeeRepository.getById(id);
            }
            return dataTable;
        }
    }
}
