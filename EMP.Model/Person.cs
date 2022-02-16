using EMP.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        

        public Person(string firstName, string middleName, string lastName, string Email, string PhoneNo, string gender, string Address) : this()
        {
           
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Email = Email;
            this.PhoneNo = PhoneNo;
            this.Gender = gender;
            this.Address = Address;
            
           
        }
        public Person()
        {
            this.FullName = getFullName();
        }
       
        public string getFullName()
        {
            return FirstName + " " + " " + MiddleName + " " + LastName;
        }
    }
}
