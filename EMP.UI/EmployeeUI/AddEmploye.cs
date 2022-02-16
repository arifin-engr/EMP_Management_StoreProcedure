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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP.UI.EmployeeUI
{
    public partial class AddEmploye : Form
    {
        EmployeeMananger employeeMananger = new EmployeeMananger();
        public AddEmploye()
        {
            InitializeComponent();
            gender_comboBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btn_backtoView_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txt_FirstName.Clear();
            txt_middleName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_Designation.Clear();
            txt_Address.Clear();
            txt_phone.Clear();
            image_.Image = null;
            gender_comboBox.Text = "--select--";
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            //  openFileDialog.Filter = "jpg files(*.jpg)|*jpg| PNG files(*.png)|*.png| All files(*.*)|*.*|";
            openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName;
                image_.ImageLocation = imageLocation;
            }


        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string imagePath = image_.ImageLocation;
            string imageFileName = image_.Name + "_" + txt_FirstName.Text + "_" + txt_lastName.Text;
            FileStream fileStream = new FileStream(imagePath,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] images = binaryReader.ReadBytes((int)fileStream.Length);
            try
            {

                Employee emp = new Employee() { Designation = txt_Designation.Text, FirstName = txt_FirstName.Text, MiddleName = txt_middleName.Text, LastName = txt_lastName.Text, Email = txt_email.Text, PhoneNo = txt_phone.Text, Gender = gender_comboBox.SelectedItem.ToString(), Address = txt_Address.Text, Image = images };


                employeeMananger.Add(emp);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                clear();
            }

        }

       
    }
}
