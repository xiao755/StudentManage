using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 画数据图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series Strength = new Series("力量");
            Series Speed = new Series("速度");

            Strength.ChartType = SeriesChartType.Line;
            Strength.IsValueShownAsLabel = true ;
            Strength.Color = System.Drawing.Color.Black;

            Speed.ChartType = SeriesChartType.Spline;
            Speed.IsValueShownAsLabel = true;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = true;
            chart1.ChartAreas[0].AxisX.Title = "英雄";
            chart1.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.Crimson;

            chart1.ChartAreas[0].AxisY.Title = "属性";
            chart1.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.Crimson;
            chart1.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Horizontal;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


            Strength.LegendText = "力气";
            Strength.Points.AddXY("A", "90");
            Strength.Points.AddXY("B", "88");
            Strength.Points.AddXY("C", "60");
            Strength.Points.AddXY("D", "93");
            Strength.Points.AddXY("E", "79");
            Strength.Points.AddXY("F", "85");
            Strength.Points.AddXY("G", "100");

            Speed.Points.AddXY("A", "120");
            Speed.Points.AddXY("B", "133");
            Speed.Points.AddXY("C", "100");
            Speed.Points.AddXY("D", "98");
            Speed.Points.AddXY("E", "126");
            Speed.Points.AddXY("F", "89");

            //把series添加到chart上
            chart1.Series.Add(Speed);
            chart1.Series.Add(Strength);
        }
    }
//    public class CreateImage
//    {
//        public void CreateImage()
//        {
//            int height = 480, width = 700;
//            Bitmap image = new Bitmap(width, height);
//            Graphics g = Graphics.FromImage(image);

//            try
//            {
//                //清空图片背景色
//                g.Clear(Color.White);

//                Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
//                Font font1 = new System.Drawing.Font("宋体", 20, FontStyle.Regular);
//                Font font2 = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
//                LinearGradientBrush brush = new LinearGradientBrush(
//                new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.Blue, 1.2f, true);
//                g.FillRectangle(Brushes.AliceBlue, 0, 0, width, height);
//                Brush brush1 = new SolidBrush(Color.Blue);
//                Brush brush2 = new SolidBrush(Color.SaddleBrown);

//                g.DrawString(this.ddlTaget.SelectedItem.Text + " " + this.ddlYear.SelectedItem.Text +
//                " 成绩统计折线图", font1, brush1, new PointF(85, 30));
//                //画图片的边框线
//                g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);

//                Pen mypen = new Pen(brush, 1);
//                Pen mypen2 = new Pen(Color.Red, 2);
//                //绘制线条
//                //绘制纵向线条
//                int x = 60;
//                for (int i = 0; i < 8; i++)
//                {
//                    g.DrawLine(mypen, x, 80, x, 340);
//                    x = x + 80;
//                }
//                Pen mypen1 = new Pen(Color.Blue, 3);
//                x = 60;
//                g.DrawLine(mypen1, x, 82, x, 340);

//                //绘制横向线条
//                int y = 106;
//                for (int i = 0; i < 10; i++)
//                {
//                    g.DrawLine(mypen, 60, y, 620, y);
//                    y = y + 26;
//                }
//                // y = 106;
//                g.DrawLine(mypen1, 60, y - 26, 620, y - 26);

//                //x轴
//                String[] n = { "第一期", "第二期", "第三期", "第四期", "上半年", "下半年", "全年统计" };
//                x = 45;
//                for (int i = 0; i < 7; i++)
//                {
//                    g.DrawString(n[i].ToString(), font, Brushes.Red, x, 348); //设置文字内容及输出位置
//                    x = x + 77;
//                }

//                //y轴
//                String[] m = { "220人", " 200人", " 175人", "150人", " 125人", " 100人", " 75人", " 50人",
//" 25人"};
//                y = 100;
//                for (int i = 0; i < 9; i++)
//                {
//                    g.DrawString(m[i].ToString(), font, Brushes.Red, 10, y); //设置文字内容及输出位置
//                    y = y + 26;
//                }

//                int[] Count1 = new int[7];
//                int[] Count2 = new int[7];

//                SqlConnection Con = new SqlConnection("Server=(Local);Database=committeeTraining;Uid=sa;Pwd=eesoft");
//                Con.Open();
//                string cmdtxt2 = "SELECT * FROM ##Count where Company='" + this.ddlTaget.SelectedItem.Text.Trim() + "'";
//                SqlDataAdapter da = new SqlDataAdapter(cmdtxt2, Con);
//                DataSet ds = new DataSet();
//                da.Fill(ds);

//                //报名人数
//                Count1[0] = Convert.ToInt32(ds.Tables[0].Rows[0]["count1"].ToString());
//                Count1[1] = Convert.ToInt32(ds.Tables[0].Rows[0]["count3"].ToString());
//                Count1[2] = Convert.ToInt32(ds.Tables[0].Rows[0]["count5"].ToString());
//                Count1[3] = Convert.ToInt32(ds.Tables[0].Rows[0]["count7"].ToString());

//                Count1[6] = Convert.ToInt32(ds.Tables[0].Rows[0]["count9"].ToString()); //全年

//                Count1[4] = Count1[0] + Count1[1];
//                Count1[5] = Count1[2] + Count1[3];


//                Count2[0] = Convert.ToInt32(ds.Tables[0].Rows[0]["count2"].ToString());
//                Count2[1] = Convert.ToInt32(ds.Tables[0].Rows[0]["count4"].ToString());
//                Count2[2] = Convert.ToInt32(ds.Tables[0].Rows[0]["count6"].ToString());
//                Count2[3] = Convert.ToInt32(ds.Tables[0].Rows[0]["count8"].ToString());

//                Count2[6] = Convert.ToInt32(ds.Tables[0].Rows[0]["count10"].ToString()); //全年

//                Count2[4] = Count2[0] + Count2[1];
//                Count2[5] = Count2[2] + Count2[3];


//                //显示折线效果
//                Font font3 = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
//                SolidBrush mybrush = new SolidBrush(Color.Red);
//                Point[] points1 = new Point[7];
//                points1[0].X = 60; points1[0].Y = 340 - Count1[0]; //从106纵坐标开始, 到(0, 0)坐标时
//                points1[1].X = 140; points1[1].Y = 340 - Count1[1];
//                points1[2].X = 220; points1[2].Y = 340 - Count1[2];
//                points1[3].X = 300; points1[3].Y = 340 - Count1[3];

//                points1[4].X = 380; points1[4].Y = 340 - Count1[4];
//                points1[5].X = 460; points1[5].Y = 340 - Count1[5];

//                points1[6].X = 540; points1[6].Y = 340 - Count1[6];
//                g.DrawLines(mypen2, points1); //绘制折线

//                //绘制数字
//                g.DrawString(Count1[0].ToString(), font3, Brushes.Red, 58, points1[0].Y - 20);
//                g.DrawString(Count1[1].ToString(), font3, Brushes.Red, 138, points1[1].Y - 20);
//                g.DrawString(Count1[2].ToString(), font3, Brushes.Red, 218, points1[2].Y - 20);
//                g.DrawString(Count1[3].ToString(), font3, Brushes.Red, 298, points1[3].Y - 20);

//                g.DrawString(Count1[4].ToString(), font3, Brushes.Red, 378, points1[4].Y - 20);
//                g.DrawString(Count1[5].ToString(), font3, Brushes.Red, 458, points1[5].Y - 20);

//                g.DrawString(Count1[6].ToString(), font3, Brushes.Red, 538, points1[6].Y - 20);

//                Pen mypen3 = new Pen(Color.Green, 2);
//                Point[] points2 = new Point[7];
//                points2[0].X = 60; points2[0].Y = 340 - Count2[0];
//                points2[1].X = 140; points2[1].Y = 340 - Count2[1];
//                points2[2].X = 220; points2[2].Y = 340 - Count2[2];
//                points2[3].X = 300; points2[3].Y = 340 - Count2[3];

//                points2[4].X = 380; points2[4].Y = 340 - Count2[4];
//                points2[5].X = 460; points2[5].Y = 340 - Count2[5];

//                points2[6].X = 540; points2[6].Y = 340 - Count2[6];
//                g.DrawLines(mypen3, points2); //绘制折线

//                //绘制通过人数
//                g.DrawString(Count2[0].ToString(), font3, Brushes.Green, 61, points2[0].Y - 15);
//                g.DrawString(Count2[1].ToString(), font3, Brushes.Green, 131, points2[1].Y - 15);
//                g.DrawString(Count2[2].ToString(), font3, Brushes.Green, 221, points2[2].Y - 15);
//                g.DrawString(Count2[3].ToString(), font3, Brushes.Green, 301, points2[3].Y - 15);

//                g.DrawString(Count2[4].ToString(), font3, Brushes.Green, 381, points2[4].Y - 15);
//                g.DrawString(Count2[5].ToString(), font3, Brushes.Green, 461, points2[5].Y - 15);

//                g.DrawString(Count2[6].ToString(), font3, Brushes.Green, 541, points2[6].Y - 15);

//                //绘制标识
//                g.DrawRectangle(new Pen(Brushes.Red), 180, 390, 250, 50); //绘制范围框
//                g.FillRectangle(Brushes.Red, 270, 402, 20, 10); //绘制小矩形
//                g.DrawString("报名人数", font2, Brushes.Red, 292, 400);

//                g.FillRectangle(Brushes.Green, 270, 422, 20, 10);
//                g.DrawString("通过人数", font2, Brushes.Green, 292, 420);

//                System.IO.MemoryStream ms = new System.IO.MemoryStream();
//                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
//                Response.ClearContent();
//                Response.ContentType = "image/Jpeg";
//                Response.BinaryWrite(ms.ToArray());
//            }
//            finally
//            {
//                g.Dispose();
//                image.Dispose();
//            }
//        }

//    }
   
}
