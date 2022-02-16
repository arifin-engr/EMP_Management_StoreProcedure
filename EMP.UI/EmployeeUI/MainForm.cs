using EMP.BLL;
using EMP.Model;
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
    public partial class MainForm : Form
    {
        AppUserManager UserManager = new AppUserManager();
        EmployeeMananger employeeMananger = new EmployeeMananger();
        static int  empID;
       
        public MainForm()
        {
            InitializeComponent();
           
            getAllEmp();
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
            this.Hide();
            AddEmploye addEmploye = new AddEmploye();
            addEmploye.Show();
        }

        void getAllEmp()
        {
            DataTable dataTable = new DataTable();
            dataTable= employeeMananger.getAllEmp();
            gv_emp.DataSource = dataTable;

            //edit button

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.HeaderText = "Action";
            editButton.Name = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Text = "Edit";
            
            editButton.Width = 60;
            if (gv_emp.Columns.Contains(editButton.Name = "Edit"))
            {

            }
            else
            {
                gv_emp.Columns.Add(editButton);
            }
           

            //delete button

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.FlatStyle = FlatStyle.System;
            
            deleteButton.HeaderText = "Action";
            deleteButton.Name = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            deleteButton.Width = 60;
            if (gv_emp.Columns.Contains(deleteButton.Name = "Delete"))
            {

            }
            else
            {
                gv_emp.Columns.Add(deleteButton);
            }

            
        }

        private void Link_Logout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void gv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
                empID = Convert.ToInt32(gv_emp.Rows[e.RowIndex].Cells[2].Value.ToString());
               
              
              ////string path= ConvertImageToBase64((byte[])gv_emp.CurrentRow.Cells[9].Value)
              //  MemoryStream memoryStream = new MemoryStream((byte[])gv_emp.CurrentRow.Cells[9].Value);
              //pictureBox1.Image = Image.FromStream(memoryStream);
                UpdateEmployee updateEmployee = new UpdateEmployee();
                this.Hide();
                updateEmployee.Show();
            }
        }

        
        public static int getempId()
        {
           
            int id=empID;
            return id;
        }

       
    }
}
