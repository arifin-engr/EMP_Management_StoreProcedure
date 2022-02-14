using EMP.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Model
{
   public  class Employee: Person
    {
        public Employee(string Designation, string firstName, string middleName, string lastName, string Email, string PhoneNo, string gender,string Address, string Image) : base(firstName, middleName, lastName, Email, PhoneNo, gender,Address, Image)
        {
            this.Designation = Designation;
        }
        public Employee()
        {

        }

        public int Id { get; set; }
       
        public string Designation { get; set; }
       
      
    }

    
    
}
