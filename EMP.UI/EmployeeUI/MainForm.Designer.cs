
namespace EMP.UI.EmployeeUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AllAppUser = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_AllEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserpictureBox = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_AllAppUser);
            this.panel1.Controls.Add(this.btn_addEmployee);
            this.panel1.Controls.Add(this.btn_AllEmployee);
            this.panel1.Location = new System.Drawing.Point(23, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 436);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(14, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_AllAppUser
            // 
            this.btn_AllAppUser.BackColor = System.Drawing.Color.Purple;
            this.btn_AllAppUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AllAppUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AllAppUser.Location = new System.Drawing.Point(14, 184);
            this.btn_AllAppUser.Name = "btn_AllAppUser";
            this.btn_AllAppUser.Size = new System.Drawing.Size(237, 50);
            this.btn_AllAppUser.TabIndex = 2;
            this.btn_AllAppUser.Text = "All AppUser";
            this.btn_AllAppUser.UseVisualStyleBackColor = false;
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.Purple;
            this.btn_addEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addEmployee.Location = new System.Drawing.Point(14, 104);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(237, 50);
            this.btn_addEmployee.TabIndex = 1;
            this.btn_addEmployee.Text = "Add New Employee";
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_AllEmployee
            // 
            this.btn_AllEmployee.BackColor = System.Drawing.Color.Purple;
            this.btn_AllEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AllEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AllEmployee.Location = new System.Drawing.Point(14, 27);
            this.btn_AllEmployee.Name = "btn_AllEmployee";
            this.btn_AllEmployee.Size = new System.Drawing.Size(237, 50);
            this.btn_AllEmployee.TabIndex = 0;
            this.btn_AllEmployee.Text = "All Employee";
            this.btn_AllEmployee.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.UserpictureBox);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 68);
            this.panel2.TabIndex = 2;
            
            // 
            // UserpictureBox
            // 
            this.UserpictureBox.Location = new System.Drawing.Point(1094, 12);
            this.UserpictureBox.Name = "UserpictureBox";
            this.UserpictureBox.Size = new System.Drawing.Size(58, 50);
            this.UserpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserpictureBox.TabIndex = 4;
            this.UserpictureBox.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(1005, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 21);
            this.linkLabel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMP.UI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(452, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1229, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AllEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UserpictureBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AllAppUser;
    }
}