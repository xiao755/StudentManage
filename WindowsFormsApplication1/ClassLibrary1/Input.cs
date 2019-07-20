using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibrary1//using的是命名空间
{
    public static class Input//正则表达式类，限制输入
    {
        public static bool IsNumber(string txt)
        {
            Regex regex = new Regex(@"^[0-9]*$");//加@是为了让编译器认为这个是正则表达式 数字
            return regex.IsMatch(txt);
        }
        public static bool IsNumberLength(string txt)
        {
            Regex regex = new Regex(@"^[9][5]\d{4}$");//95开头 6位 数字
            return regex.IsMatch(txt);
        }
        public static bool IsChinese(string txt)
        {
            Regex regex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");//加@是为了让编译器认为这个是正则表达式 中文
            return regex.IsMatch(txt);
        }
    }
    public static class Student
    {
        public static string Sno { get; set; }
        public static string Sname { get; set; }
        public static string Sex { get; set; }
        public static string Birthday { get; set; }
        public static string Mobile { get; set; }
        public static string Email { get; set; }
        public static string Homeaddress { get; set; }
        public static string Photo { get; set; }
        public static void ListToStudent(string[] ListStudent)
        {
            
            Sno = ListStudent[0];
            Sname = ListStudent[1];
            Sex = ListStudent[2];
            Birthday = ListStudent[3];
            Mobile = ListStudent[4];
            Email = ListStudent[5];
            Homeaddress = ListStudent[6];
            if (ListStudent.Length == 8)
                Photo = ListStudent[7];
            else
                Photo = string.Empty;
        }
    }
}
