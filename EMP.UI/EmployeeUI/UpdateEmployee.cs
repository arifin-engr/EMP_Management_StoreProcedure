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
    public partial class UpdateEmployee : Form
    {
        EmployeeMananger employeeMananger = new EmployeeMananger();
        public UpdateEmployee()
        {
            InitializeComponent();
            gender_comboBox.DataSource = Enum.GetValues(typeof(Gender));
            getData();
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();

        }

        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        void getData()
        {

            int Id=MainForm.getempId();

            DataTable dataTable = new DataTable();
            dataTable = employeeMananger.getById(Id);
            foreach (DataRow dr in dataTable.Rows)
            {
                txt_Address.Text = dr["Address"].ToString();
                txt_Designation.Text = dr["Designation"].ToString();
                txt_email.Text = dr["Email"].ToString();
                txt_phone.Text = dr["PhoneNo"].ToString();

                gender_comboBox.Text = dr["Gender"].ToString();
                image_box.Image = Image.FromStream(new MemoryStream((byte[])dr["Image"]));
               
            }
            
            Employee employee = new Employee();
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

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
                image_box.ImageLocation = imageLocation;
            }
        }
    }
}
