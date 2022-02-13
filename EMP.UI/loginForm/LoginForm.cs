using EMP.BLL;
using EMP.Model;
using EMP.UI.EmployeeUI;
using EMP.UI.Registraion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP.UI
{
    public  partial class LoginForm : Form
    {
        AppUserManager UserManager = new AppUserManager();
         static string ImagePath = "";
        static string UserID = "";
       static List<AppUser> appUsersList = new List<AppUser>();

        public LoginForm()
        {
            InitializeComponent();
        }
       
        public static List<AppUser> getCureentActiveUser()
        {
            List<AppUser> currentUser = new List<AppUser>();

            currentUser=appUsersList;

            return appUsersList;
        }
       

        private void btn_go_registration_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                AppUser appUser = new AppUser();
                appUser.AppUserId = txt_UserID.Text;
                appUser.Password = txt_passWord.Text;
                UserManager.CheckUser(appUser);
                appUsersList = UserManager.getCurrentUser(appUser);
                Login();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        void Login()
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
        
    }
}
