
using EMP.BLL;
using EMP.Model;
using EMP.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP.UI.Registraion
{
    public partial class RegForm : Form
    {

        AppUserManager appUserManager = new AppUserManager(); 
        public RegForm()
        {
            InitializeComponent();
            gender_comboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            
                OpenFileDialog openFileDialog = new OpenFileDialog();
              //  openFileDialog.Filter = "jpg files(*.jpg)|*jpg| PNG files(*.png)|*.png| All files(*.*)|*.*|";
                openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    image_.ImageLocation = imageLocation;
                }
            
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string imagePath = image_.ImageLocation;
            string imageFileName = image_.Name+"_"+ txt_FirstName.Text+"_"+txt_lastName.Text;
            

            string mailAddress = txt_email.Text; 
            var mail = new MailAddress(mailAddress);

            string UserId = "";
            Random rnd = new Random();
            UserId = mail.User + rnd.Next(10, 200);
            try
            {
                AppUser appUser = new AppUser() { FirstName = txt_FirstName.Text, MiddleName = txt_middleName.Text, LastName = txt_lastName.Text, Email = txt_email.Text, AppUserId = UserId,Password=txt_Password.Text, PhoneNo = txt_phone.Text, Gender = gender_comboBox.SelectedItem.ToString(), Address = txt_Address.Text, Image = imagePath };

                
                appUserManager.Add(appUser);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
