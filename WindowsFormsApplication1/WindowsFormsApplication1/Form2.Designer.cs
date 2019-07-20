namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpbirthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthomeaddress = new System.Windows.Forms.TextBox();
            this.pbcurrentstudent = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbcurrentstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(100, 60);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 21);
            this.txtnum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 106);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别：";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(85, 150);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(35, 16);
            this.rbmale.TabIndex = 2;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "男";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(137, 150);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(35, 16);
            this.rbfemale.TabIndex = 2;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "女";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "出生日期：";
            // 
            // dtpbirthday
            // 
            this.dtpbirthday.Location = new System.Drawing.Point(109, 183);
            this.dtpbirthday.Name = "dtpbirthday";
            this.dtpbirthday.Size = new System.Drawing.Size(200, 21);
            this.dtpbirthday.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "手机号码：";
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(109, 225);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(100, 21);
            this.txtmobile.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "邮箱地址：";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(109, 265);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(360, 21);
            this.txtemail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "家庭地址:";
            // 
            // txthomeaddress
            // 
            this.txthomeaddress.Location = new System.Drawing.Point(109, 304);
            this.txthomeaddress.Name = "txthomeaddress";
            this.txthomeaddress.Size = new System.Drawing.Size(360, 21);
            this.txthomeaddress.TabIndex = 1;
            // 
            // pbcurrentstudent
            // 
            this.pbcurrentstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbcurrentstudent.Location = new System.Drawing.Point(340, 68);
            this.pbcurrentstudent.Name = "pbcurrentstudent";
            this.pbcurrentstudent.Size = new System.Drawing.Size(174, 174);
            this.pbcurrentstudent.TabIndex = 4;
            this.pbcurrentstudent.TabStop = false;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(3, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 3);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "学生信息管理系统>>学生信息查看";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(3, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(542, 3);
            this.label10.TabIndex = 5;
            this.label10.Text = "label8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(548, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbcurrentstudent);
            this.Controls.Add(this.dtpbirthday);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txthomeaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcurrentstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpbirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthomeaddress;
        private System.Windows.Forms.PictureBox pbcurrentstudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}