using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Enumeration;
using static System.Windows.Forms.AxHost;

namespace Kalkulator
{
    public partial class Form2 : Form
    {

        string function = "";
        double userInput = 0.0;
        double angle = 0.0;
        public Form2(string trigonom,double inp, double deg)
        {
            InitializeComponent();
            string val = trigonom;
            double input = inp;
            double degree = deg;
            function = val;
            angle = degree;
            userInput = input;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);
            PointF ox1 = new PointF(20, panel1.Height / 2);
            PointF ox2 = new PointF(panel1.Width, panel1.Height / 2);
            PointF oy1 = new PointF(20, panel1.Height);
            PointF oy2 = new PointF(20, 0.0F);
            e.Graphics.DrawLine(blackPen, ox1, ox2);
            e.Graphics.DrawLine(blackPen, oy1, oy2);
            Font axisFont = new Font("Segoe UI Light", 10);
            SolidBrush background = new SolidBrush(Color.Orange);
            Pen orangePen = new Pen(Color.Orange);
            Font axisnNamesFont = new Font("Segoe UI Light", 15);
            RectangleF userInputv = new RectangleF(20+(float)(userInput * 100), (panel1.Height / 2) - (float)(angle * 200), 15, 15);
            PointF oxText = new PointF(panel1.Width - 30, panel1.Height / 2 - 35);
            PointF oyText = new PointF(panel1.Width/2 -460, panel1.Height / 2 - 280);
            e.Graphics.DrawString("0X", axisnNamesFont, Brushes.Black, oxText);
            e.Graphics.DrawString("0Y", axisnNamesFont, Brushes.Black, oyText);

            if (function == "sin")
            {   
                e.Graphics.DrawEllipse(orangePen,userInputv);
                e.Graphics.FillEllipse( background, userInputv);
                for (float i = 1; i <= 360; i++)
                {
                    double x = Math.Sin(i * (Math.PI) / 180);
                    float value2 = (float)x;

                    if (i == 1)
                    {
                        PointF point1 = new PointF(20, panel1.Height / 2);
                        PointF point2 = new PointF(20 + (float)(i * (Math.PI) / 180) * 100, (panel1.Height / 2) - value2 * 200);
                        e.Graphics.DrawLine(blackPen, point1, point2);
                    }
                    else
                    {

                        double y = Math.Sin((i - 1) * (Math.PI) / 180);
                        float value1 = (float)y;
                        PointF point1 = new PointF(20 + (float)((i - 1) * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value1 * 200));
                        PointF point2 = new PointF(20 + (float)(i * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value2 * 200));
                        e.Graphics.DrawLine(blackPen, point1, point2);


                    }
                    for (float j = 0; j <= 8; j++)
                    {
                        PointF axis_ox1 = new PointF(20 + (float)((j * 45) * (Math.PI) / 180) * 100, panel1.Height / 2);
                        PointF axis_ox2 = new PointF(20 + (float)((j * 45) * (Math.PI) / 180) * 100, (panel1.Height / 2) + 20);
                        e.Graphics.DrawLine(blackPen, axis_ox1, axis_ox2);
                        e.Graphics.DrawString((j * 45 / 180).ToString() + "\u03A0", axisFont, Brushes.Blue, axis_ox2);
                    }
                    for (double k = -3; k <= 0; k++)
                    {
                        PointF axis_oy1 = new PointF(20, (panel1.Height / 2) - (float)(200 * Math.Cos(k / 3 * Math.PI)));
                        PointF axis_oy2 = new PointF(0.0F, (panel1.Height / 2) - (float)(200 * Math.Cos(k / 3 * Math.PI)));
                        e.Graphics.DrawLine(blackPen, axis_oy1, axis_oy2);
                        e.Graphics.DrawString((Math.Cos(k/3*Math.PI)).ToString("F", CultureInfo.CreateSpecificCulture("en-CA")), axisFont, Brushes.Blue, axis_oy2);
                    }
                }
            }
            else if (function == "cos")
            {
                e.Graphics.DrawEllipse(orangePen, userInputv);
                e.Graphics.FillEllipse(background, userInputv);
                for (float i = 1; i <= 360; i++)
                {
                    double x = Math.Cos(i * (Math.PI) / 180);
                    float value2 = (float)x;

                    if (i == 1)
                    {
                        PointF point1 = new PointF(20, panel1.Height / 2);
                        PointF point2 = new PointF(20 + (float)(i * (Math.PI) / 180) * 100, (panel1.Height / 2) - value2 * 200);
                        e.Graphics.DrawLine(blackPen, point1, point2);
                    }
                    else
                    {

                        double y = Math.Cos((i - 1) * (Math.PI) / 180);
                        float value1 = (float)y;
                        PointF point1 = new PointF(20 + (float)((i - 1) * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value1 * 200));
                        PointF point2 = new PointF(20 + (float)(i * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value2 * 200));
                        e.Graphics.DrawLine(blackPen, point1, point2);


                    }
                    for (float j = 0; j <= 8; j++)
                    {
                        PointF axis_ox1 = new PointF(20 + (float)((j * 45) * (Math.PI) / 180) * 100, panel1.Height / 2);
                        PointF axis_ox2 = new PointF(20 + (float)((j * 45) * (Math.PI) / 180) * 100, (panel1.Height / 2) + 20);
                        e.Graphics.DrawLine(blackPen, axis_ox1, axis_ox2);
                        e.Graphics.DrawString((j * 45 / 180).ToString() + "\u03A0", axisFont, Brushes.Blue, axis_ox2);
                    }
                    for (double k = -3; k <= 0; k++)
                    {
                        PointF axis_oy1 = new PointF(20, (panel1.Height / 2) - (float)(200 * Math.Cos(k / 3 * Math.PI)));
                        PointF axis_oy2 = new PointF(0.0F, (panel1.Height / 2) - (float)(200 * Math.Cos(k / 3 * Math.PI)));
                        e.Graphics.DrawLine(blackPen, axis_oy1, axis_oy2);
                        e.Graphics.DrawString((Math.Cos(k/3*Math.PI)).ToString("F", CultureInfo.CreateSpecificCulture("en-CA")), axisFont, Brushes.Blue, axis_oy2);
                    }
                }
            }
            else if (function == "tan")
            {
                e.Graphics.DrawEllipse(orangePen, userInputv);
                e.Graphics.FillEllipse(background, userInputv);
                Pen redPen = new Pen(Color.Red);
                PointF max1 = new PointF(20+(float)((90 * (Math.PI) / 180) * 100), 0.0F);
                PointF max2 = new PointF(20 + (float)((90 * (Math.PI) / 180) * 100), 0.0F + panel1.Height);
                PointF max3 = new PointF(20 + (float)(270 * (Math.PI) / 180) * 100, 0.0F);
                PointF max4 = new PointF(20 + (float)(270 * (Math.PI) / 180) * 100, 0.0F + panel1.Height);
                e.Graphics.DrawLine(redPen, max1, max2);
                e.Graphics.DrawLine(redPen, max3, max4);
                for (float i = 1; i < 90; i++)
                {
                    double x = Math.Tan(i * (Math.PI) / 180);
                    float value2 = (float)x;

                    if (i == 1)
                    {
                        PointF point1 = new PointF(20, panel1.Height / 2);
                        PointF point2 = new PointF(20 + (float)(i * (Math.PI) / 180) * 100, (panel1.Height / 2) - value2 * 200);
                        e.Graphics.DrawLine(blackPen, point1, point2);
                    }
                    else
                    {

                        double y = Math.Tan((i - 1) * (Math.PI) / 180);
                        float value1 = (float)y;
                        PointF point1 = new PointF(20 + (float)((i - 1) * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value1 * 200));
                        PointF point2 = new PointF(20 + (float)(i * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value2 * 200));
                        e.Graphics.DrawLine(blackPen, point1, point2);


                    }
                    for (float j = 0; j <= 8; j++)
                      {
                          PointF axis_ox1 = new PointF(20 + (float)((j * 45) * (Math.PI) / 180) * 100, panel1.Height / 2);
                          PointF axis_ox2 = new PointF(20 + (float)((j * 45) * (Math.PI) / 180) * 100, (panel1.Height / 2) + 20);
                          e.Graphics.DrawLine(blackPen, axis_ox1, axis_ox2);
                          e.Graphics.DrawString((j * 45 / 180).ToString() + "\u03A0", axisFont, Brushes.Blue, axis_ox2);
                      }
                }
                for (float l = 91; l < 270;l++)
                {
                    double x = Math.Tan(l * (Math.PI) / 180);
                    float value2 = (float)x;
                    
                    if (l == 91)
                    {
                        PointF point1 = new PointF(20, panel1.Height / 2);
                        PointF point2 = new PointF(20 + (float)(l * (Math.PI) / 180) * 100, (panel1.Height / 2) - value2 * 200);
                        e.Graphics.DrawLine(blackPen, point1, point2);
                    }
                    else
                    {

                        double y = Math.Tan((l - 1) * (Math.PI) / 180);
                        float value1 = (float)y;
                        PointF point1 = new PointF(20 + (float)((l - 1) * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value1 * 200));
                        PointF point2 = new PointF(20 + (float)(l * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value2 * 200));
                        e.Graphics.DrawLine(blackPen, point1, point2);


                    }
                    int b = -1;
                    for (float k = 3; k <= 5; k++)
                    {
                        PointF axis_oy1 = new PointF(20, (panel1.Height / 2) - (float)(200*Math.Tan(k / 4 * Math.PI)));
                        PointF axis_oy2 = new PointF(0.0F, (panel1.Height / 2) - (float)(200*Math.Tan(k /4 * Math.PI)));
                        e.Graphics.DrawLine(blackPen, axis_oy1, axis_oy2);
                        e.Graphics.DrawString((b).ToString(), axisFont, Brushes.Blue, axis_oy2);
                        b=b+1;
                    }
                }
                for (float m = 271; m < 360; m++)
                {
                    double x = Math.Tan(m * (Math.PI) / 180);
                    float value2 = (float)x;

                    if (m == 271)
                    {
                        PointF point1 = new PointF(20, panel1.Height / 2);
                        PointF point2 = new PointF(20 + (float)(m * (Math.PI) / 180) * 100, (panel1.Height / 2) - value2 * 200);
                        e.Graphics.DrawLine(blackPen, point1, point2);
                    }
                    else
                    {

                        double y = Math.Tan((m - 1) * (Math.PI) / 180);
                        float value1 = (float)y;
                        PointF point1 = new PointF(20 + (float)((m - 1) * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value1 * 200));
                        PointF point2 = new PointF(20 + (float)(m * (Math.PI) / 180) * 100, ((panel1.Height / 2) - value2 * 200));
                        e.Graphics.DrawLine(blackPen, point1, point2);


                    }
                }
            }


        }
    }
}
            

