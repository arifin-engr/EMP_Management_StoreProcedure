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
   public class AppUserManager
    {
        // private readonly AppUser AppUser;
         AppUserRepository appUserRepository=new AppUserRepository();
        public bool Add(AppUser appUser)
        {
            if (appUser !=null)
            {
                if (appUser.Image !=null)
                {
                    appUserRepository.Add(appUser);
                    throw new Exception("Successfully Saved");
                }
            }
            throw new Exception("AppUser Empty");

            
        }

        public void CheckUser(AppUser appUser)
        {
            if (appUser !=null)
            {
                if (appUser.AppUserId !=null && appUser.Password !=null)
                {
                    DataTable dataTable = new DataTable();
                    dataTable= appUserRepository.Data(appUser);
                    if (dataTable.Rows.Count>0)
                    {
                        
                        return;
                    }
                    else
                    {
                        throw new Exception("Incorrect User or Password...!");
                    }


                }
                
                
            }
            else
            {
                throw new Exception("invalid input");
            }
            
        }

        
    }
}
