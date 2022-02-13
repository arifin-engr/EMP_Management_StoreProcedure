using EMP.BLL;
using EMP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP.UI.EmployeeUI
{
    public partial class MainForm : Form
    {
        AppUserManager UserManager = new AppUserManager();
       
        public MainForm()
        {
            InitializeComponent();
            getUser();
        }

        void getUser()
        {
            string ImagePath = "";
            string uId = "";
            foreach (var item in LoginForm.getCureentActiveUser())
            {
                ImagePath = item.Image;
                uId = item.AppUserId;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = ImagePath;
            string pp = openFileDialog.FileName;
            UserpictureBox.ImageLocation = pp;
            linkLabel1.Text = uId;
        }



        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
