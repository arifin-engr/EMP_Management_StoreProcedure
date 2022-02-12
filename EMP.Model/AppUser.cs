using EMP.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP.Model
{
   public class AppUser: Person
    {
        
        public AppUser(int Id, string AppUserId, string Password, string firstName, string middleName, string lastName, string Email, string PhoneNo, string gender,string Address, string Image): base(firstName, middleName, lastName, Email, PhoneNo, gender,Address, Image)
        {
            this.Id = Id;
            this.AppUserId = AppUserId;
            this.Password = Password;
        }
        public AppUser()
        {

        }
        

        public int Id { get; set; }
        public string AppUserId { get; set; }
        public string Password { get; set; }

        

    }
}
