namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquerynum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimportdata = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.rbman = new System.Windows.Forms.RadioButton();
            this.dtpbirthday = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pbphoto = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtquerynum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Location = new System.Drawing.Point(297, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息查询";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(509, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 26);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "手机号码：";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(280, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtquerynum
            // 
            this.txtquerynum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtquerynum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtquerynum.Location = new System.Drawing.Point(78, 31);
            this.txtquerynum.Name = "txtquerynum";
            this.txtquerynum.Size = new System.Drawing.Size(130, 26);
            this.txtquerynum.TabIndex = 1;
            this.txtquerynum.TextChanged += new System.EventHandler(this.txtquerynum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvstudent
            // 
            this.dgvstudent.AllowUserToAddRows = false;
            this.dgvstudent.AllowUserToDeleteRows = false;
            this.dgvstudent.AllowUserToResizeRows = false;
            this.dgvstudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvstudent.EnableHeadersVisualStyles = false;
            this.dgvstudent.Location = new System.Drawing.Point(298, 145);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowHeadersVisible = false;
            this.dgvstudent.RowTemplate.Height = 23;
            this.dgvstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstudent.Size = new System.Drawing.Size(638, 248);
            this.dgvstudent.TabIndex = 2;
            this.dgvstudent.SelectionChanged += new System.EventHandler(this.dgvstudent_SelectionChanged);
            this.dgvstudent.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出生日期";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "手机号码";
            this.Column5.Name = "Column5";
            // 
            // btnimportdata
            // 
            this.btnimportdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnimportdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimportdata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnimportdata.Location = new System.Drawing.Point(968, 155);
            this.btnimportdata.Name = "btnimportdata";
            this.btnimportdata.Size = new System.Drawing.Size(82, 28);
            this.btnimportdata.TabIndex = 3;
            this.btnimportdata.Text = "导入数据";
            this.btnimportdata.UseVisualStyleBackColor = false;
            this.btnimportdata.Click += new System.EventHandler(this.btnimportdata_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Location = new System.Drawing.Point(968, 221);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(82, 28);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmodify.Location = new System.Drawing.Point(968, 287);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(82, 28);
            this.btnmodify.TabIndex = 3;
            this.btnmodify.Text = "修改";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Location = new System.Drawing.Point(968, 353);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(82, 28);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbfemale);
            this.groupBox2.Controls.Add(this.btncancle);
            this.groupBox2.Controls.Add(this.btnsubmit);
            this.groupBox2.Controls.Add(this.rbman);
            this.groupBox2.Controls.Add(this.dtpbirthday);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtmobile);
            this.groupBox2.Controls.Add(this.txtnumber);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.pbphoto);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(297, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生明细信息";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(206, 57);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(35, 16);
            this.rbfemale.TabIndex = 4;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "女";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncancle.Location = new System.Drawing.Point(671, 80);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(82, 28);
            this.btncancle.TabIndex = 10;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsubmit.Location = new System.Drawing.Point(671, 14);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(82, 28);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "提交";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // rbman
            // 
            this.rbman.AutoSize = true;
            this.rbman.Location = new System.Drawing.Point(165, 57);
            this.rbman.Name = "rbman";
            this.rbman.Size = new System.Drawing.Size(35, 16);
            this.rbman.TabIndex = 3;
            this.rbman.TabStop = true;
            this.rbman.Text = "男";
            this.rbman.UseVisualStyleBackColor = true;
            // 
            // dtpbirthday
            // 
            this.dtpbirthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpbirthday.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpbirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbirthday.Location = new System.Drawing.Point(538, 24);
            this.dtpbirthday.Name = "dtpbirthday";
            this.dtpbirthday.Size = new System.Drawing.Size(125, 21);
            this.dtpbirthday.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtemail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtemail.Location = new System.Drawing.Point(474, 56);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(120, 21);
            this.txtemail.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtaddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtaddress.Location = new System.Drawing.Point(198, 87);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(441, 21);
            this.txtaddress.TabIndex = 7;
            // 
            // txtmobile
            // 
            this.txtmobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtmobile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmobile.Location = new System.Drawing.Point(290, 55);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(120, 21);
            this.txtmobile.TabIndex = 5;
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtnumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnumber.Location = new System.Drawing.Point(164, 24);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(120, 21);
            this.txtnumber.TabIndex = 0;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(29, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 22);
            this.button5.TabIndex = 8;
            this.button5.Text = "选择";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pbphoto
            // 
            this.pbphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbphoto.Location = new System.Drawing.Point(13, 24);
            this.pbphoto.Name = "pbphoto";
            this.pbphoto.Size = new System.Drawing.Size(92, 84);
            this.pbphoto.TabIndex = 0;
            this.pbphoto.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtname.Location = new System.Drawing.Point(332, 24);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(120, 21);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "出生日期：";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "邮箱：";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "家庭住址：";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名：";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "电话：";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "性别：";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "学号：";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(1053, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 3;
            this.button8.Text = "× ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1085, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnimportdata);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtquerynum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnimportdata;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbphoto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbman;
        private System.Windows.Forms.DateTimePicker dtpbirthday;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button button8;
    }
}

