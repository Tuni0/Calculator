using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Kalkulator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }


        public void drawButton_Click(object sender, EventArgs e)
        {
            string a = textBoxA.Text.ToString();
            string b = textBoxB.Text.ToString();
            string c = textBoxC.Text.ToString();

            Graphics g = panel2.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);
            Pen redPen = new Pen(Color.Red);
            SolidBrush background = new SolidBrush(Color.Black);
            SolidBrush background2 = new SolidBrush(Color.Red);
            Font pointsFont = new Font("Segoe UI Light", 8,FontStyle.Bold);
            Font axisFont = new Font("Segoe UI Light", 5);
            Font axisnNamesFont = new Font("Segoe UI Light", 15);
            PointF ox1 = new PointF(0.0F, panel2.Height / 2);
            PointF ox2 = new PointF(panel2.Width, panel2.Height / 2);
            PointF oy1 = new PointF(panel2.Width / 2, panel2.Height);
            PointF oy2 = new PointF(panel2.Width / 2, 0.0F);
            PointF oxText = new PointF(panel2.Width -30, panel2.Height/2-35);
            PointF oyText = new PointF(panel2.Width / 2-45,panel2.Height/2 - 160);
            g.DrawString("0X", axisnNamesFont, Brushes.Black, oxText);
            g.DrawString("0Y", axisnNamesFont, Brushes.Black, oyText);
            g.DrawLine(blackPen, ox1, ox2);
            g.DrawLine(blackPen, oy1, oy2);
            double av = Convert.ToDouble(a);
            double bv = Convert.ToDouble(b);
            double cv = Convert.ToDouble(c);
            double delta = Math.Pow(bv, 2) - 4 * (av * cv);

            if (delta < 0)
            {
                MessageBox.Show("Brak miejsc zerowych");
            }
            else if (delta == 0)
            {
                double x0 = (-bv / 2 * av);
                MessageBox.Show("Miejsce zerowe w: " + x0.ToString());
                RectangleF x00 = new RectangleF((panel2.Width / 2) + (float)(-bv / 2 * av), (panel2.Height / 2),5,5);
                PointF x000=new PointF((panel2.Width / 2) + (float)(-bv / 2 * av)-20, (panel2.Height / 2));
                g.DrawEllipse(blackPen, x00);
                g.FillEllipse(background, x00);
                g.DrawString("x0", pointsFont, Brushes.Black, x000);
            }
            else if (delta > 0)
            {
                double x1 = (-bv - Math.Sqrt(delta) / 2 * av) * 10;
                double x2 = (-bv + Math.Sqrt(delta) / 2 * av) * 10;
                MessageBox.Show("Miejsca zerowe w: " + x1.ToString() + "i: " + x2.ToString());
                RectangleF x01 = new RectangleF((panel2.Width / 2) + (float)((-bv - Math.Sqrt(delta)) / (2 * av))*20, (panel2.Height / 2), 5, 5);
                RectangleF x02 = new RectangleF((panel2.Width / 2) + (float)((-bv + Math.Sqrt(delta)) / (2 * av))*20, (panel2.Height / 2), 5, 5);
                PointF x001 = new PointF((panel2.Width / 2) + (float)((-bv - Math.Sqrt(delta)) / (2 * av)) * 20 , (panel2.Height / 2)-20*20);
                PointF x002 = new PointF((panel2.Width / 2) + (float)((-bv + Math.Sqrt(delta)) / (2 * av)) * 20 , (panel2.Height / 2) - 20*20);
                g.DrawEllipse(blackPen, x01);
                g.FillEllipse(background, x01);
                g.DrawString("x1", pointsFont, Brushes.Black, x001);
                g.DrawEllipse(blackPen, x02);
                g.FillEllipse(background, x02);
                g.DrawString("x2", pointsFont, Brushes.Black, x002);

            }

            float p = (float)(-bv / (2 * av));
            float q = (float)(-delta /( 4 * av));
            RectangleF w = new RectangleF((panel2.Width / 2) + p*20, panel2.Height / 2 - q * 20, 5,5);
            PointF wW = new PointF((panel2.Width / 2) + p * 20, panel2.Height / 2 - q * 20 + 20);
            g.DrawEllipse(redPen, w);
            g.FillEllipse(background2, w);
            g.DrawString("W(p,q)", pointsFont, Brushes.Red, wW);

                for (float i = (-100); i <= 100; i++)
                {
                    PointF point1 = new PointF((panel2.Width / 2) + (i - 1)*20, panel2.Height / 2 - (float)(av * (i - 1) * (i - 1) + bv * (i - 1) + cv)*20);
                    PointF point2 = new PointF((panel2.Width / 2) + i*20, panel2.Height / 2 - (float)(av * i * i + bv * i + cv)*20);
                    g.DrawLine(blackPen, point1, point2);

                }
            for (float j =(-100); j <= 100; j++)
            {
                PointF axis_ox1 = new PointF(panel2.Width/2+j*20, panel2.Height / 2);
                PointF axis_ox2 = new PointF(panel2.Width / 2 + j*20, (panel2.Height / 2) + 20);
                g.DrawLine(blackPen, axis_ox1, axis_ox2);
                g.DrawString((j).ToString() , axisFont, Brushes.Black, axis_ox2);
            }
            for (float k = (-100); k <= 100; k++)
            {
                PointF axis_ox1 = new PointF(panel2.Width / 2 , panel2.Height / 2 -k*20);
                PointF axis_ox2 = new PointF(panel2.Width / 2 -20, (panel2.Height / 2) - k*20);
                g.DrawLine(blackPen, axis_ox1, axis_ox2);
                g.DrawString((k).ToString(), axisFont, Brushes.Black, axis_ox2);
            }

        }
    }
}


       
  


