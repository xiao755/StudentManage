using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //禁用控件
            txtnum.Enabled = false;
            txtname.Enabled = false;
            txtmobile.Enabled = false;
            txthomeaddress.Enabled = false;
            txtemail.Enabled = false;
            rbfemale.Enabled = false;
            rbfemale.Enabled = false;
            dtpbirthday.Enabled = false;
            pbcurrentstudent.Enabled = false;
            //赋值
            txtnum.Text = Student.Sno;
            txtname.Text = Student.Sname;
            txtmobile.Text = Student.Mobile;
            txthomeaddress.Text = Student.Homeaddress;
            txtemail.Text = Student.Email;
            rbmale.Enabled = false;
            rbfemale.Enabled = false;
            if (Student.Sex == "男")
                rbmale.Checked = true;
            else rbfemale.Checked = true;
            dtpbirthday.Text = Student.Birthday;
            if(!string.IsNullOrWhiteSpace(Student.Photo))
                pbcurrentstudent.BackgroundImage = Image.FromFile(Student.Photo);
        }

        //public Form2() : this()
        //{
        //    txtnum.Enabled = false;
        //    txtnum.Text = Sno;
        //}

        //public void Form(string Sno)
        //{
        //    txtnum.Enabled = false;
        //    txtnum.Text = Sno;
        //}

        private void label1_Click(object sender, EventArgs e)
        {
            txtnum.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
