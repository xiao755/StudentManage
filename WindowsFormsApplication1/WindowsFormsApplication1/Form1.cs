using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private List<string> objListStudent = new List<string>();//定义list
        private List<string> objlistquery = new List<string>();//query list
        private string filename = string.Empty;
        private string PhotoName = string.Empty;//记录上传图片的文件路径
        private int actionflag = 0;

        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
        }

        //控件事件
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//根据姓名查询
        {
            objlistquery.Clear();
            foreach (string item in objListStudent)
            {
                if (item.Contains(textBox2.Text))
                    objlistquery.Add(item);
            }
            dgvstudent.Rows.Clear();
            loaddatetodategrid(objlistquery);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//根据手机号码查询
        {
            objlistquery.Clear();
            foreach (string item in objListStudent)
            {
                if (item.Contains(textBox3.Text))
                    objlistquery.Add(item);
            }
            dgvstudent.Rows.Clear();
            loaddatetodategrid(objlistquery);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvstudent.CurrentRow.Selected == false)
            {
                MessageBox.Show("删除数据前必须要选中某一行！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            { 
             DialogResult result=  MessageBox .Show ("您确定要删除学生【学号："+dgvstudent .CurrentRow .Cells[0].Value .ToString ()+"姓名"+dgvstudent .CurrentRow .Cells[1].Value .ToString ()+"】信息吗？","系统提示",MessageBoxButtons .YesNo ,MessageBoxIcon .Question );

            if (result ==DialogResult .Yes )
                {
                    string currentstudent = getstudentnum(dgvstudent.CurrentRow.Cells[0].Value.ToString());
                    foreach (string item in objListStudent)
                    {
                        if (item.Equals(currentstudent))//比较是否相等
                        {
                            objListStudent.Remove(item);
                            dgvstudent.Rows.Clear();
                            loaddatetodategrid(objListStudent);

                            MessageBox.Show("学生信息删除成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    }
                
                }
                
            }
          
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            disablebutton();
            txtnumber.Enabled = true;
            txtnumber.Text = string.Empty;
            txtname.Text = string.Empty;
            rbman.Checked = true;
            dtpbirthday.Text = DateTime.Now.ToString();
            txtmobile.Text = string.Empty;
            txtemail.Text = string .Empty ;
            txtaddress.Text = string.Empty;
            pbphoto.BackgroundImage = null;
            txtnumber.Focus();
            actionflag = 1;


        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumber.Text))
            {
                MessageBox.Show("学号不能为空！","系统消息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (!Input.IsNumber(txtnumber.Text))
            {
                MessageBox.Show("学号必须为数字！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Input.IsNumberLength(txtnumber.Text))
            {
                MessageBox.Show("学号为95开头6位数字！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Validate() == false) return;
            else 
            {
                string photopath = string.Empty;
                if (PhotoName != string.Empty)//保存图片
                {
                    Random objrandom = new Random();
                    photopath = ".\\image\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + objrandom.Next(0, 100).ToString("00") + PhotoName.Substring(PhotoName.Length - 4);//图片路径
                    Bitmap bitmap = new Bitmap(pbphoto.BackgroundImage);
                    bitmap.Save(photopath, pbphoto.BackgroundImage.RawFormat);//参数 保存路径，图片格式(这个命令不会自己创建文件夹，需要自己创建文件夹！)
                    bitmap.Dispose();
                }
                //组合数据，添加到list
                string sno = txtnumber.Text.Trim();
                string sname = txtname.Text.Trim();
                string sex = rbman.Checked == true ? "男" : "女";
                string birthday = dtpbirthday.Text;
                string mobile = txtmobile.Text;
                string email = txtemail.Text;
                string homeaddress = txtaddress.Text;
                string photo = photopath;
                string currentstudent = sno + "," + sname + "," + sex + "," + birthday + "," + mobile + "," + email + "," + homeaddress + "," + photo;

                switch (actionflag)
                { 
                    case 1://添加
                        objListStudent.Add(currentstudent);
                        dgvstudent.Rows.Clear();
                        loaddatetodategrid(objListStudent);
                        MessageBox.Show("学生信息添加成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        enablebutton();
                        break;
                    case 2:
                        for (int i = 0; i < objListStudent.Count; i++)
                        {
                            if (objListStudent[i].StartsWith(sno))
                            {
                                objListStudent.RemoveAt (i);
                                objListStudent.Insert(i, currentstudent);
                                dgvstudent.Rows.Clear();
                                loaddatetodategrid(objListStudent );
                                break;
                            }
                        }
                        MessageBox.Show("学生信息修改成功！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        enablebutton();
                            break;
                    default :
                        break;
                }
            }
        }
        private void btncancle_Click(object sender, EventArgs e)
        {
            enablebutton();
        }
        private void btnimportdata_Click(object sender, EventArgs e)
        {
            dgvstudent.Rows.Clear();
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "csv文件（*.csv）|*.csv|TXT文件(*.txt)|*.txt";
            if (openfile.ShowDialog() == DialogResult.OK)
                filename = openfile.FileName;
            try
            {
                //读取文件
                objListStudent = Readfiletolist(filename);//list型数据
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取文件出现错误，具体错误如下：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //【3】把list数据展示在表格框中
            loaddatetodategrid(objListStudent);
            //【4】展示明细在下面
            string currentsnum = dgvstudent.Rows[0].Cells[0].Value.ToString();
            string[] currentdetail = getstudentnum(currentsnum).Split(',');
            loaddaretodetall(currentdetail[0], currentdetail[1], currentdetail[2], currentdetail[3], currentdetail[4], currentdetail[5], currentdetail[6], null);
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string currentsnum = dgvstudent.CurrentRow.Cells[0].Value.ToString();
            string[] currentdetail = getstudentnum(currentsnum).Split(',');
            if (currentdetail[0] != string.Empty)
            {
                if (currentdetail.Length == 7)
                    loaddaretodetall(currentdetail[0], currentdetail[1], currentdetail[2], currentdetail[3], currentdetail[4], currentdetail[5], currentdetail[6], string.Empty);
                if (currentdetail.Length == 8)
                    loaddaretodetall(currentdetail[0], currentdetail[1], currentdetail[2], currentdetail[3], currentdetail[4], currentdetail[5], currentdetail[6], currentdetail[7]);
            }

            Student.ListToStudent(currentdetail);//类方法
            Form2 tiaochu = new Form2();//调出窗口2
            tiaochu.Show();
            //tiaochu.Form(objListStudent[0]);
        }
        private void dgvstudent_SelectionChanged(object sender, EventArgs e)
        {
            string currentsnum = dgvstudent.CurrentRow.Cells[0].Value.ToString();
            string[] currentdetail = getstudentnum(currentsnum).Split(',');
            if(currentdetail [0]!=string .Empty)
            {
                if(currentdetail.Length==7)
                    loaddaretodetall(currentdetail[0], currentdetail[1], currentdetail[2], currentdetail[3], currentdetail[4], currentdetail[5], currentdetail[6], string.Empty);
                if (currentdetail.Length == 8)
                    loaddaretodetall(currentdetail[0], currentdetail[1], currentdetail[2], currentdetail[3], currentdetail[4], currentdetail[5], currentdetail[6], currentdetail[7]);
            }
                //if (dgvstudent.CurrentRow.Selected == false) return;
            //else
            //{

            //    string currentsnum = dgvstudent.CurrentRow.Cells[0].Value.ToString();
            //    string[] currentdetail = getstudentnum(currentsnum).Split(',');
            //    loaddaretodetall(currentdetail[0], currentdetail[1], currentdetail[2], currentdetail[3], currentdetail[4], currentdetail[5], currentdetail[6], null);



            //}
        }//点击行展现详细数据在下面
        private void btnmodify_Click(object sender, EventArgs e)
        {
            disablebutton();
            txtnumber.Enabled = false;
            txtname.Focus();
            actionflag = 2;


        }
        private void txtquerynum_TextChanged(object sender, EventArgs e)
        {
            objlistquery.Clear();
            foreach (string item in objListStudent)
            {
                if (item.StartsWith(txtquerynum.Text))
                    objlistquery.Add(item);

            }
            dgvstudent.Rows.Clear();
            loaddatetodategrid(objlistquery);
        }//根据学号查询
        /***********************************自定义方法************************************/
        private List<string> Readfiletolist(string filepath)//读取字符串并以list方式返回结果
        {
            List<string> objlist = new List<string>();
            string line = string.Empty;
            try
            {
                StreamReader file = new StreamReader(filepath, Encoding.Default);//连续读取文件类

                while ((line = file.ReadLine()) != null)//读取每一行,以换行符分割
                {
                    objlist.Add(line);//把每一行添加到list list类
                }
                file.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objlist;
        }
        private void loaddatetodategrid(List<string> objlist)//把list展示在表格中
        {
            foreach (string item in objlist)//依次读取list每一行数据，数组读取命令
            {
                string[] studentarray = item.Split(',');
                DataGridViewRow row = new DataGridViewRow();//表格类
                row.CreateCells(dgvstudent);
                row.Cells[0].Value = studentarray[0];//一行第一个单元格 cell第几个单元格
                row.Cells[1].Value = studentarray[1];
                row.Cells[2].Value = studentarray[2];
                row.Cells[3].Value = studentarray[3];
                row.Cells[4].Value = studentarray[4];
                dgvstudent.Rows.Add(row);//添加表格类的一行内容
            }
        }
        private void loaddaretodetall(string sno, string sname, string sex, string birthday, string mobile, string email, string homeaddress, string photo)//展示明细
        {
            txtnumber.Text = sno;
            txtname.Text = sname;
            if (sex == "男")
                rbman.Checked = true;
            else rbfemale.Checked = true;
            dtpbirthday.Text = birthday;
            txtmobile.Text = mobile;
            txtemail.Text = email;
            txtaddress.Text = homeaddress;
            if (photo == null || photo == string.Empty) pbphoto.BackgroundImage = null;
            else pbphoto.BackgroundImage = Image.FromFile(photo);

        }
        private string getstudentnum(string sno)
        {
            string currentstudent = string.Empty;
            foreach (string item in objListStudent)
            {
                if (item.StartsWith(sno))
                {
                    currentstudent = item;
                    break;
                }
            }
            return currentstudent;
        }//根据学号返回list指定行
        private void disablebutton()
        {
            btnadd.Enabled = false;
            btnimportdata.Enabled = false;
            btnmodify.Enabled = false;
            btndelete.Enabled = false;
            groupBox2.Enabled = true;
        }//禁用按钮
        private void enablebutton()
        {
            btnadd.Enabled = true ;
            btnimportdata.Enabled = true ;
            btnmodify.Enabled = true ;
            btndelete.Enabled = true ;
            groupBox2.Enabled = false ;
        }//启用按钮
        private new bool Validate()
        {
            bool b = true;

            //学号不能为空
            if (string.IsNullOrWhiteSpace(txtnumber.Text))
            {
                MessageBox.Show("学号不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnumber.Focus();
               b=false ;
            }
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("姓名不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
                b=false ;
            }
            if (actionflag == 1)
            {
                if (getstudentnum(txtnumber.Text.Trim()) != string .Empty )
                {
                    MessageBox.Show("该学号已经存在，请重新输入学号！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnumber.Focus();
                        b=false ;
                }
            }
            return b;
        }

        private void button5_Click(object sender, EventArgs e)//选择图片展示在PictureBox中
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "图片|*.png;*.jpg;*.bmp";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                PhotoName = openfile.FileName;
                pbphoto.BackgroundImage = Image.FromFile(openfile.FileName);
            }
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            if (!Input.IsNumber(txtnumber.Text))
                txtnumber.Text = null;
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (!Input.IsChinese(txtname.Text))
                txtname.Text = null;
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (filename != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("是否保存提交的信息？", "系统消息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    File.WriteAllText(filename, string.Empty);//写入空文件
                    StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
                    foreach (string item in objListStudent)
                    {
                        streamWriter.WriteLine(item);//写入文件 保存信息
                    }
                    streamWriter.Close();//释放资源
                    MessageBox.Show("保存完毕！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                if (dialogResult == DialogResult.No)
                    Close();
            }
            else
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtquerynum.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
        }
    }












    }

