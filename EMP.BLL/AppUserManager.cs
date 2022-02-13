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
       
         AppUserRepository appUserRepository=new AppUserRepository();
        public bool Add(AppUser appUser)
        {
            if (appUser !=null)
            {
                if (appUser.Image !=null)
                {
                    appUserRepository.Add(appUser);
                    throw new Exception("Successfully Saved.." + "UserId: " + appUser.AppUserId + " " + "Password: " + appUser.Password);
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

       
        public List<AppUser> getCurrentUser(AppUser appUser)
        {
            List<AppUser> appUsersList = new List<AppUser>();
            if (appUser !=null)
            {
                DataTable dataTable = new DataTable();
                dataTable= appUserRepository.Data(appUser);
                foreach (DataRow dr in dataTable.Rows)
                {
                    appUser.Image = dr["Image"].ToString();
                    appUser.AppUserId = dr["AppUserId"].ToString();
                    appUsersList.Add(appUser);
                }
            }
            return appUsersList;
        }
    }
}
