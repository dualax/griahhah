using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Media.Animation;
using System.Xaml;

namespace WpfApp1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            double y1_1, u1_1;
            int x1_1 = new Random().Next(0, 5);
            u1_1 = Math.Sin(x1_1);
            
            if (u1_1 + x1_1 > -0.5)
            {
                y1_1 = Math.Pow((2 * u1_1 + 1), 2) / 7 * Math.PI + x1_1;
            }
            else if (-0.5 >= u1_1 + x1_1 && u1_1 + x1_1 <= Math.Pow(10, -3))
            {
                y1_1 = Math.Cos((Math.Pow(2, u1_1))) - Math.Sin(u1_1 / 3);
            }
            else if (u1_1 + x1_1 > Math.Pow(10, -3))
            {
                y1_1 = Math.Log(u1_1 + x1_1) - Math.Pow(x1_1, 2) / 3.5 * x1_1;
            }
            double y1_2, u1_2;
            int x1_2 = new Random().Next(0, 5);

            u1_2 = Math.Cos(x1_2);

            if (u1_2 + x1_2 > -0.5)
            {
                y1_2 = Math.Pow((2 * u1_2 + 1), 2) / 7 * Math.PI + x1_2;
            }
            else if (-0.5 >= u1_2 + x1_2 && u1_2 + x1_2 <= Math.Pow(10, -3))
            {
                y1_2 = Math.Cos((Math.Pow(2, u1_2))) - Math.Sin(u1_2 / 3);
            }
            else if (u1_2 + x1_2 > Math.Pow(10, -3))
            {
                y1_2 = Math.Log(u1_2 + x1_2) - Math.Pow(x1_2, 2) / 3.5 * x1_2;
            }
            double y1_3, u1_3;

            int x1_3 = new Random().Next(0, 5);

            u1_3 = Math.Tan(x1_3);

            if (u1_3 + x1_3 > -0.5)
            {
                y1_3 = Math.Pow((2 * u1_3 + 1), 2) / 7 * Math.PI + x1_3;
            }
            else if (-0.5 >= u1_3 + x1_3 && u1_3 + x1_3 <= Math.Pow(10, -3))
            {
                y1_3 = Math.Cos((Math.Pow(2, u1_3))) - Math.Sin(u1_3 / 3);
            }
            else if (u1_3 + x1_3 > Math.Pow(10, -3))
            {
                y1_3 = Math.Log(u1_3 + x1_3) - Math.Pow(x1_3, 2) / 3.5 * x1_3;
            }
            MessageBox.Show($"y1_1 = {u1_1}");
            MessageBox.Show($"y1_2 = {u1_2}");
            MessageBox.Show($"y1_3 = {u1_3}");
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            double y2_1, b2_1, a2_1, z2_1;

            int x2_1 = new Random().Next(0, 5);
            int e2_1 = new Random().Next(0, 5);

            a2_1 = 0.4; b2_1 = 2.3; z2_1 = Math.Pow(2 * x2_1, e2_1);

            if (x2_1 > 3.5 * a2_1)
            {
                y2_1 = a2_1 * b2_1 * x2_1 - Math.Pow(Math.Cos(1), 2) * (z2_1 * x2_1);
            }
            else if ((3.5 * a2_1) <= x2_1 && x2_1 <= b2_1)
            {
                y2_1 = Math.Pow(2, (a2_1 - x2_1)) - Math.Log(z2_1 - x2_1);
            }
            else if (x2_1 > b2_1)
            {
                y2_1 = Math.Sqrt(b2_1 * x2_1 - a2_1 + z2_1 * Math.Pow(2, x2_1));

                double y2_2, b2_2, a2_2, z2_2;

                int x2_2 = new Random().Next(0, 5);
                int e2_2 = new Random().Next(0, 5);

                a2_2 = 0.2; b2_2 = 0.8; z2_2 = Math.Pow(x2_2, e2_2);

                if (x2_2 > 3.5 * a2_2)
                {
                    y2_2 = a2_2 * b2_2 * x2_2 - Math.Pow(Math.Cos(1), 2) * (z2_2 * x2_2);
                }
                else if ((3.5 * a2_2) <= x2_2 && x2_2 <= b2_2)
                {
                    y2_2 = Math.Pow(2, (a2_2 - x2_2)) - Math.Log(z2_2 - x2_2);
                }
                else if (x2_2 > b2_2)
                {
                    y2_2 = Math.Sqrt(b2_2 * x2_2 - a2_2 + z2_2 * Math.Pow(2, x2_2));

                    double y2_3, b2_3, a2_3, z2_3;

                    int x2_3 = new Random().Next(0, 5);
                    int e2_3 = new Random().Next(0, 5);

                    a2_3 = 0.7; b2_3 = 8.1; z2_3 = 0.8;

                    if (x2_3 > 3.5 * a2_3)
                    {
                        y2_3 = a2_3 * b2_3 * x2_3 - Math.Pow(Math.Cos(1), 2) * (z2_3 * x2_3);
                    }
                    else if ((3.5 * a2_3) <= x2_3 && x2_3 <= b2_3)
                    {
                        y2_3 = Math.Pow(2, (a2_3 - x2_3)) - Math.Log(z2_3 - x2_3);
                    }
                    else if (x2_3 > b2_3)
                    {
                        y2_3 = Math.Sqrt(b2_3 * x2_3 - a2_3 + z2_3 * Math.Pow(2, x2_3));
                    }
                    MessageBox.Show($"y2_1 = {a2_1},  {b2_1},  {z2_1}");
                    MessageBox.Show($"y2_2 = {a2_2},  {b2_2},  {z2_2}");
                    MessageBox.Show($"y2_3 = {a2_3},  {b2_3},  {z2_3}");
                }
            }
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            double y3_1, b3_1, m3_1, n3_1;

            int x3_1 = new Random().Next(0, 5);
            int e3_1 = new Random().Next(0, 5);
            b3_1 = -1.6; m3_1 = 0.9; n3_1 = -1.4;

            if (Math.Abs(b3_1 * m3_1) < Math.Pow(2, x3_1))
            {
                y3_1 = Math.Sin(b3_1 * m3_1 + Math.Cos(n3_1 * x3_1));
            }
            else if (Math.Abs(b3_1 * m3_1) < Math.Pow(2, x3_1))
            {
                y3_1 = Math.Cos(b3_1 * m3_1 - Math.Sin(n3_1 * x3_1));
            }
            else if (Math.Abs(b3_1 * m3_1) == Math.Pow(2, x3_1))
            {
                y3_1 = Math.Sqrt(Math.Pow((Math.Sin(e3_1)), x3_1)) + (Math.Sqrt(Math.Abs(b3_1 * m3_1 * x3_1)));
            }
            double y3_2, b3_2, m3_2, n3_2;

            int x3_2 = new Random().Next(0, 5);
            int e3_2 = new Random().Next(0, 5);

            b3_2 = 4.5; m3_2 = -2; n3_2 = 2.2;

            if (Math.Abs(b3_2 * m3_2) < Math.Pow(2, x3_2))
            {
                y3_2 = Math.Sin(b3_2 * m3_2 + Math.Cos(n3_2 * x3_2));
            }
            else if (Math.Abs(b3_2 * m3_2) < Math.Pow(2, x3_2))
            {
                y3_2 = Math.Cos(b3_2 * m3_2 - Math.Sin(n3_2 * x3_2));
            }
            else if (Math.Abs(b3_2 * m3_2) == Math.Pow(2, x3_2))
            {
                y3_1 = Math.Sqrt(Math.Pow((Math.Sin(e3_2)), x3_2)) + (Math.Sqrt(Math.Abs(b3_2 * m3_2 * x3_2)));
            }
            double y3_3, b3_3, m3_3, n3_3;

            int x3_3 = new Random().Next(0, 5);
            int e3_3 = new Random().Next(0, 5);

            b3_3 = -4.5; m3_3 = 0.5; n3_3 = -1.5;
            if (Math.Abs(b3_3 * m3_3) < Math.Pow(2, x3_3))
            {
                y3_3 = Math.Sin(b3_3 * m3_3 + Math.Cos(n3_3 * x3_3));
            }
            else if (Math.Abs(b3_3 * m3_3) < Math.Pow(2, x3_3))
            {
                y3_3 = Math.Cos(b3_3 * m3_3 - Math.Sin(n3_3 * x3_3));
            }
            else if (Math.Abs(b3_3 * m3_3) == Math.Pow(2, x3_3))
            {
                y3_3 = Math.Sqrt(Math.Pow((Math.Sin(e3_3)), x3_3)) + (Math.Sqrt(Math.Abs(b3_3 * m3_3 * x3_3)));
            }
            MessageBox.Show($"y3_1 = {b3_1},  {m3_1},  {n3_1}");
            MessageBox.Show($"y3_2 = {b3_2},  {m3_2},  {n3_2}");
            MessageBox.Show($"y3_3 = {b3_3},  {m3_3},  {n3_3}");
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            double y4_1, a4_1, b4_1, z4_1;

            int x4_1 = new Random().Next(0, 5);
            int e4_1 = new Random().Next(0, 5);

            a4_1 = 0.2; b4_1 = 0.5; z4_1 = Math.Pow(a4_1 * x4_1, e4_1);

            if (x4_1 < -Math.Log(a4_1))
            {
                y4_1 = a4_1 * Math.Pow(Math.Sin(2), x4_1) + (b4_1 * Math.Cos(z4_1 * x4_1));
            }
            else if (-Math.Log(a4_1) <= x4_1 && x4_1 <= b4_1)
            {
                y4_1 = Math.Pow(b4_1, a4_1) - Math.Cos(3) * (a4_1 + (z4_1 * x4_1));
            }
            else if (x4_1 > b4_1)
            {
                y4_1 = Math.Abs(2.5 * (Math.Pow(3, a4_1))) + Math.Pow((b4_1 - (z4_1 * Math.Pow(2, x4_1))), 6);
            }
            double y4_2, a4_2, b4_2, z4_2;

            int x4_2 = new Random().Next(0, 5);
            int e4_2 = new Random().Next(0, 5);

            a4_2 = 0.15; b4_2 = 0.2; z4_2 = Math.Pow(2 * a4_1 * x4_1, e4_1);

            if (x4_2 < -Math.Log(a4_2))
            {
                y4_2 = a4_2 * Math.Pow(Math.Sin(2), x4_2) + (b4_2 * Math.Cos(z4_2 * x4_2));
            }
            else if (-Math.Log(a4_2) <= x4_2 && x4_2 <= b4_2)
            {
                y4_2 = Math.Pow(b4_2, a4_2) - Math.Cos(3) * (a4_2 + (z4_2 * x4_2));
            }
            else if (x4_2 > b4_2)
            {
                y4_2 = Math.Abs(2.5 * (Math.Pow(3, a4_2))) + Math.Pow((b4_2 - (z4_2 * Math.Pow(2, x4_2))), 6);
            }
            double y4_3, a4_3, b4_3, z4_3;

            int x4_3 = new Random().Next(0, 5);
            int e4_3 = new Random().Next(0, 5);

            a4_3 = 0.9; b4_3 = 5; z4_3 = Math.Pow(2.5 * a4_3 * x4_3, e4_3);

            if (x4_3 < -Math.Log(a4_3))
            {
                y4_3 = a4_3 * Math.Pow(Math.Sin(2), x4_3) + (b4_3 * Math.Cos(z4_3 * x4_3));
            }
            else if (-Math.Log(a4_3) <= x4_3 && x4_3 <= b4_3)
            {
                y4_3 = Math.Pow(b4_3, a4_3) - Math.Cos(3) * (a4_3 + (z4_3 * x4_3));
            }
            else if (x4_3 > b4_3)
            {
                y4_3 = Math.Abs(2.5 * (Math.Pow(3, a4_3))) + Math.Pow((b4_3 - (z4_3 * Math.Pow(2, x4_3))), 6);
            }
            MessageBox.Show($"y4_1 = {a4_1},  {b4_1},  {z4_1}");
            MessageBox.Show($"y4_2 = {a4_2},  {b4_2},  {z4_2}");
            MessageBox.Show($"y4_3 = {a4_3},  {b4_3},  {z4_3}");
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            double a5_1, b5_1, c5_1, y5_1;

            int x5_1 = new Random().Next(0, 5);
            int e5_1 = new Random().Next(0, 5);

            a5_1 = 4.2; b5_1 = 5.3; c5_1 = 1.5;

            if (Math.Pow(a5_1 + b5_1, e5_1) > Math.Pow(2, x5_1))
            {
                y5_1 = (Math.Sin(Math.Pow(a5_1 + b5_1, e5_1)) + Math.Pow(2, x5_1));
            }
            else if (Math.Pow(a5_1 + b5_1, e5_1) == Math.Pow(x5_1, e5_1))
            {
                y5_1 = Math.Atan(a5_1 * b5_1 * c5_1) + Math.Sqrt(x5_1);
            }
            else if (Math.Pow(a5_1 + b5_1, e5_1) < Math.Pow(x5_1, e5_1))
            {
                y5_1 = Math.Cos(Math.Sqrt(Math.Abs(x5_1 + a5_1 * b5_1 * c5_1)));
            }
            double a5_2, b5_2, c5_2, y5;

            int x5_2 = new Random().Next(0, 5);
            int e5_2 = new Random().Next(0, 5);

            a5_2 = -0.35; b5_2 = 1.8; c5_2 = -1.8;

            if (Math.Pow(a5_2 + b5_2, e5_2) > Math.Pow(2, x5_2))
            {
                y5 = (Math.Sin(Math.Pow(a5_2 + b5_2, e5_2)) + Math.Pow(2, x5_2));
            }
            else if (Math.Pow(a5_2 + b5_2, e5_2) == Math.Pow(x5_2, e5_2))
            {
                y5 = Math.Atan(a5_2 * b5_2 * c5_2) + Math.Sqrt(x5_2);
            }
            else if (Math.Pow(a5_2 + b5_2, e5_2) < Math.Pow(x5_2, e5_2))
            {
                y5 = Math.Cos(Math.Sqrt(Math.Abs(x5_2 + a5_2 * b5_2 * c5_2)));
            }
            double a5_3, b5_3, c5_3, y5_3;

            int x5_3 = new Random().Next(0, 5);
            int e5_3 = new Random().Next(0, 5);

            a5_3 = 2.8; b5_3 = -0.6; c5_3 = 2.0;
            if (Math.Pow(a5_3 + b5_3, e5_2) > Math.Pow(2, x5_3))
            {
                y5 = (Math.Sin(Math.Pow(a5_3 + b5_3, e5_3)) + Math.Pow(2, x5_3));
            }
            else if (Math.Pow(a5_3 + b5_3, e5_3) == Math.Pow(x5_3, e5_3))
            {
                y5 = Math.Atan(a5_3 * b5_3 * c5_3) + Math.Sqrt(x5_3);
            }
            else if (Math.Pow(a5_3 + b5_3, e5_3) < Math.Pow(x5_3, e5_3))
            {
                y5 = Math.Cos(Math.Sqrt(Math.Abs(x5_2 + a5_3 * b5_3 * c5_3)));
            }
            MessageBox.Show($"y5_1 = {a5_1},  {b5_1},  {c5_1}");
            MessageBox.Show($"y5_2 = {a5_2},  {b5_2},  {c5_2}");
            MessageBox.Show($"y5_1 = {a5_3},  {b5_3},  {c5_3}");
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            double a6_1, b6_1, z6_1, y6_1;

            int x6_1 = new Random().Next(0, 5);
            int e6_1 = new Random().Next(0, 5);

            a6_1 = -5; b6_1 = 2.5; z6_1 = Math.Log(Math.Abs(Math.Pow(3, b6_1 * x6_1)));

            if (x6_1 < a6_1)
            {
                y6_1 = 2.8 * (Math.Pow(2, (Math.Sin(1) * a6_1 * x6_1 - a6_1 * b6_1 * Math.Pow(3, x6_1) * z6_1)));

            }
            else if (a6_1 <= x6_1 && x6_1 >= Math.Pow(2, b6_1))
            {
                y6_1 = z6_1 * Math.Cos(Math.Pow(2, (a6_1 * x6_1 + b6_1))) + (Math.Log(z6_1));
            }
            else if ((x6_1) > Math.Pow(2, b6_1))
            {
                y6_1 = Math.Pow(2.5 * a6_1 * x6_1, e6_1) + z6_1 * a6_1 * b6_1 * x6_1;
            }
            double a6_2, b6_2, z6_2, y6_2;

            int x6_2 = new Random().Next(0, 5);
            int e6_2 = new Random().Next(0, 5);

            a6_2 = 3; b6_2 = 5; z6_2 = Math.Log(Math.Abs(b6_2 * x6_2));

            if (x6_2 < a6_2)
            {
                y6_2 = 2.8 * (Math.Pow(2, (Math.Sin(1) * a6_2 * x6_2 - a6_2 * b6_2 * Math.Pow(3, x6_2) * z6_2)));

            }
            else if (a6_2 <= x6_2 && x6_2 >= Math.Pow(2, b6_2))
            {
                y6_2 = z6_2 * Math.Cos(Math.Pow(2, (a6_2 * x6_2 + b6_2))) + (Math.Log(z6_2));
            }
            else if ((x6_2) > Math.Pow(2, b6_2))
            {
                y6_2 = Math.Pow(2.5 * a6_2 * x6_2, e6_2) + z6_2 * a6_2 * b6_2 * x6_2;
            }
            double a6_3, b6_3, z6_3, y6_3;

            int x6_3 = new Random().Next(0, 5);
            int e6_3 = new Random().Next(0, 5);

            a6_3 = -10; b6_3 = 3; z6_3 = Math.Log(Math.Abs(Math.Pow(2, b6_3 * x6_3)));

            if (x6_3 < a6_3)
            {
                y6_3 = 2.8 * (Math.Pow(2, (Math.Sin(1) * a6_3 * x6_3 - a6_3 * b6_3 * Math.Pow(3, x6_3) * z6_3)));

            }
            else if (a6_3 <= x6_3 && x6_3 >= Math.Pow(2, b6_3))
            {
                y6_3 = z6_3 * Math.Cos(Math.Pow(2, (a6_3 * x6_3 + b6_3))) + (Math.Log(z6_3));
            }
            else if ((x6_3) > Math.Pow(2, b6_3))
            {
                y6_3 = Math.Pow(2.5 * a6_3 * x6_3, e6_3) + z6_3 * a6_3 * b6_3 * x6_3;
            }
            MessageBox.Show($"y6_1 = {a6_1},  {b6_1},  {z6_1}");
            MessageBox.Show($"y6_2 = {a6_2},  {b6_2},  {z6_2}");
            MessageBox.Show($"y6_3 = {a6_3},  {b6_3},  {z6_3}");
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            double a7_1, b7_1, c7_1, y7_1;

            int x7_1 = new Random().Next(0, 5);
            int e7_1 = new Random().Next(0, 5);

            a7_1 = 3.2; b7_1 = -0.7; c7_1 = 2.2;

            if (Math.Abs(1 - Math.Pow(2, x7_1)) == (a7_1 + c7_1))
            {
                y7_1 = x7_1 * Math.Pow(Math.Abs(b7_1 * c7_1), e7_1);
            }
            else if (Math.Abs(1 - Math.Pow(2, x7_1)) > (a7_1 + c7_1))
            {
                y7_1 = Math.Pow(2, Math.Sin(1)) * a7_1 * x7_1 + Math.Cos(b7_1 * c7_1);
            }
            else if (Math.Abs(1 - Math.Pow(2, x7_1)) > (a7_1 + c7_1))
            {
                y7_1 = Math.Sqrt(a7_1 * Math.Pow(4, b7_1) + Math.Pow(5, (Math.Sqrt(c7_1 * Math.Pow(2, x7_1)))));
            }
            double a7_2, b7_2, c7_2, y7_2;

            int x7_2 = new Random().Next(0, 5);
            int e7_2 = new Random().Next(0, 5);

            a7_2 = 10.5; b7_2 = -2.5; c7_2 = 5.6;

            if (Math.Abs(1 - Math.Pow(2, x7_2)) == (a7_2 + c7_2))
            {
                y7_2 = x7_2 * Math.Pow(Math.Abs(b7_2 * c7_2), e7_2);
            }
            else if (Math.Abs(1 - Math.Pow(2, x7_2)) > (a7_2 + c7_2))
            {
                y7_2 = Math.Pow(2, Math.Sin(1)) * a7_2 * x7_2 + Math.Cos(b7_2 * c7_2);
            }
            else if (Math.Abs(1 - Math.Pow(2, x7_2)) > (a7_2 + c7_2))
            {
                y7_2 = Math.Sqrt(a7_2 * Math.Pow(4, b7_2) + Math.Pow(5, (Math.Sqrt(c7_2 * Math.Pow(2, x7_2)))));
            }
            double a7_3, b7_3, c7_3, y7_3;

            int x7_3 = new Random().Next(0, 5);
            int e7_3 = new Random().Next(0, 5);

            a7_3 = 5.4; b7_3 = 3; c7_3 = 2.6;

            if (Math.Abs(1 - Math.Pow(2, x7_3)) == (a7_3 + c7_3))
            {
                y7_3 = x7_3 * Math.Pow(Math.Abs(b7_3 * c7_3), e7_3);
            }
            else if (Math.Abs(1 - Math.Pow(2, x7_3)) > (a7_3 + c7_3))
            {
                y7_3 = Math.Pow(2, Math.Sin(1)) * a7_3 * x7_3 + Math.Cos(b7_3 * c7_3);
            }
            else if (Math.Abs(1 - Math.Pow(2, x7_3)) > (a7_3 + c7_3))
            {
                y7_3 = Math.Sqrt(a7_3 * Math.Pow(4, b7_3) + Math.Pow(5, (Math.Sqrt(c7_3 * Math.Pow(2, x7_3)))));
            }
            MessageBox.Show($"y7_1 = {a7_1},  {b7_1},  {c7_1}");
            MessageBox.Show($"y7_2 = {a7_2},  {b7_2},  {c7_2}");
            MessageBox.Show($"y7_1 = {a7_3},  {b7_3},  {c7_3}");
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            double y8_1, k8_1, m8_1, n8_1;

            int x8_1 = new Random().Next(0, 5);
            int e8_1 = new Random().Next(0, 5);

            k8_1 = 3.1; m8_1 = 5.15; n8_1 = -1.15;

            if (Math.Pow(2, x8_1) > m8_1 + n8_1)
            {
                y8_1 = Math.Log(Math.Abs(m8_1 * x8_1 + n8_1));
            }
            else if (Math.Pow(2, x8_1) == m8_1 + n8_1)
            {
                y8_1 = Math.Pow(Math.Cos(m8_1 * x8_1 - n8_1), e8_1);
            }
            else if (Math.Pow(2, x8_1) < m8_1 + n8_1)
            {
                y8_1 = Math.Pow(2, Math.Sqrt(Math.Pow(2, k8_1) + Math.Pow(2, Math.Cos(1) * x8_1)));
            }
            double y8_2, k8_2, m8_2, n8_2;

            int x8_2 = new Random().Next(0, 5);
            int e8_2 = new Random().Next(0, 5);

            k8_2 = 0.78; m8_2 = -2.4; n8_2 = 4.26;

            if (Math.Pow(2, x8_2) > m8_2 + n8_2)
            {
                y8_2 = Math.Log(Math.Abs(m8_2 * x8_2 + n8_2));
            }
            else if (Math.Pow(2, x8_2) == m8_2 + n8_2)
            {
                y8_2 = Math.Pow(Math.Cos(m8_2 * x8_2 - n8_2), e8_2);
            }
            else if (Math.Pow(2, x8_2) < m8_2 + n8_2)
            {
                y8_2 = Math.Pow(2, Math.Sqrt(Math.Pow(2, k8_2) + Math.Pow(2, Math.Cos(1) * x8_2)));
            }
            double y8_3, k8_3, m8_3, n8_3;
            int x8_3 = new Random().Next(0, 5);
            int e8_3 = new Random().Next(0, 5);

            k8_3 = 1.1; m8_3 = 0.8; n8_3 = 0.41;

            if (Math.Pow(2, x8_3) > m8_3 + n8_3)
            {
                y8_3 = Math.Log(Math.Abs(m8_3 * x8_3 + n8_3));
            }
            else if (Math.Pow(2, x8_3) == m8_3 + n8_3)
            {
                y8_3 = Math.Pow(Math.Cos(m8_3 * x8_3 - n8_3), e8_3);
            }
            else if (Math.Pow(2, x8_3) < m8_3 + n8_3)
            {
                y8_3 = Math.Pow(2, Math.Sqrt(Math.Pow(2, k8_3) + Math.Pow(2, Math.Cos(1) * x8_3)));
            }
            MessageBox.Show($"y8_1 = {k8_1},  {m8_1},  {n8_1}");
            MessageBox.Show($"y8_2 = {k8_2},  {m8_2},  {n8_2}");
            MessageBox.Show($"y8_1 = {k8_3},  {m8_3},  {n8_3}");
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            double a9_1, b9_1, z9_1, y9_1;

            int x9_1 = new Random().Next(0, 5);
            int e9_1 = new Random().Next(0, 5);

            a9_1 = 1.2; b9_1 = 7.2; z9_1 = Math.Pow(x9_1, e9_1);

            if (x9_1 < Math.Pow(3, a9_1))
            {
                y9_1 = a9_1 * Math.Pow(2, Math.Sin(1)) * x9_1 + b9_1 * Math.Cos(z9_1 * x9_1 + a9_1);
            }
            else if (Math.Pow(3, a9_1) <= x9_1 && x9_1 <= b9_1)
            {
                y9_1 = (Math.Pow(2, a9_1 + b9_1 * x9_1)) - Math.Sin(a9_1 + z9_1 * x9_1);
            }
            else if (x9_1 > b9_1)
            {
                y9_1 = Math.Sqrt(x9_1 - (Math.Sin(b9_1 * x9_1 + z9_1)));
            }
            double a9_2, b9_2, z9_2, y9_2;

            int x9_2 = new Random().Next(0, 5);
            int e9_2 = new Random().Next(0, 5);

            a9_2 = -1.5; b9_2 = 3.2; z9_2 = Math.Pow(2 * x9_2, e9_2);

            if (x9_2 < Math.Pow(3, a9_2))
            {
                y9_2 = a9_2 * Math.Pow(2, Math.Sin(1)) * x9_2 + b9_2 * Math.Cos(z9_2 * x9_2 + a9_2);
            }
            else if (Math.Pow(3, a9_2) <= x9_2 && x9_2 <= b9_2)
            {
                y9_2 = (Math.Pow(2, a9_2 + b9_2 * x9_2)) - Math.Sin(a9_2 + z9_2 * x9_2);
            }
            else if (x9_2 > b9_2)
            {
                y9_2 = Math.Sqrt(x9_2 - (Math.Sin(b9_2 * x9_2 + z9_2)));
            }
            double a9_3, b9_3, z9_3, y9_3;

            int x9_3 = new Random().Next(0, 5);
            int e9_3 = new Random().Next(0, 5);
            a9_3 = 1.2; b9_3 = 7.2; z9_3 = Math.Pow(x9_3, e9_3);
            a9_3 = -1.5; b9_3 = 3.2; z9_3 = Math.Pow(2 * x9_3, e9_3);
            a9_3 = 1.7; b9_3 = 5.5; z9_3 = Math.Pow(3, e9_3);

            if (x9_3 < Math.Pow(3, a9_3))
            {
                y9_3 = a9_3 * Math.Pow(2, Math.Sin(1)) * x9_3 + b9_3 * Math.Cos(z9_3 * x9_3 + a9_3);
            }
            else if (Math.Pow(3, a9_3) <= x9_3 && x9_3 <= b9_3)
            {
                y9_3 = (Math.Pow(2, a9_3 + b9_3 * x9_3)) - Math.Sin(a9_3 + z9_3 * x9_3);
            }
            else if (x9_3 > b9_3)
            {
                y9_3 = Math.Sqrt(x9_3 - (Math.Sin(b9_3 * x9_3 + z9_3)));
            }
            MessageBox.Show($"y9_1 = {a9_1},  {b9_1},  {z9_1}");
            MessageBox.Show($"y9_2 = {a9_2},  {b9_2},  {z9_2}");
            MessageBox.Show($"y9_3 = {a9_3},  {b9_3},  {z9_3}");
        }

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            double a10_1, b10_1, c10_1, y10_1;

            int x10_1 = new Random().Next(0, 5);

            a10_1 = 0.1; b10_1 = 9.8; c10_1 = 11.12;

            if (Math.Log(a10_1) < x10_1)
            {
                y10_1 = Math.Pow(3, Math.Sqrt(Math.Pow(2, b10_1) + Math.Sqrt(Math.Abs(x10_1 + c10_1))));
            }
            else if (Math.Log(a10_1) == x10_1)
            {
                y10_1 = Math.Cos(x10_1 - b10_1 - c10_1);
            }
            else if ((Math.Log(a10_1) > x10_1))
            {
                y10_1 = Math.Sin(x10_1 + a10_1 - b10_1);
            }
            double a10_2, b10_2, c10_2, y10_2;

            int x10_2 = new Random().Next(0, 5);

            a10_2 = 10; b10_2 = 10.05; c10_2 = 6.2;

            if (Math.Log(a10_2) < x10_2)
            {
                y10_2 = Math.Pow(3, Math.Sqrt(Math.Pow(2, b10_2) + Math.Sqrt(Math.Abs(x10_2 + c10_2))));
            }
            else if (Math.Log(a10_2) == x10_2)
            {
                y10_2 = Math.Cos(x10_2 - b10_2 - c10_2);
            }
            else if ((Math.Log(a10_2) > x10_2))
            {
                y10_2 = Math.Sin(x10_2 + a10_2 - b10_2);
            }
            double a10_3, b10_3, c10_3, y10_3;

            int x10_3 = new Random().Next(0, 5);

            a10_3 = 100; b10_3 = 3.03; c10_3 = 7.12;

            if (Math.Log(a10_3) < x10_3)
            {
                y10_3 = Math.Pow(3, Math.Sqrt(Math.Pow(2, b10_3) + Math.Sqrt(Math.Abs(x10_3 + c10_3))));
            }
            else if (Math.Log(a10_3) == x10_3)
            {
                y10_3 = Math.Cos(x10_3 - b10_3 - c10_3);
            }
            else if ((Math.Log(a10_3) > x10_3))
            {
                y10_3 = Math.Sin(x10_3 + a10_3 - b10_3);
            }
            MessageBox.Show($"y7_1 = {a10_1},  {b10_1},  {c10_1}");
            MessageBox.Show($"y7_2 = {a10_2},  {b10_2},  {c10_2}");
            MessageBox.Show($"y7_1 = {a10_3},  {b10_3},  {c10_3}");
        }

        private void BthTask11_Click(object sender, RoutedEventArgs e)
        {
            double a11_1, b11_1, z11_1, y11_1;

            int x11_1 = new Random().Next(0, 5);
            int e11_1 = new Random().Next(0, 5);

            a11_1 = -1; b11_1 = 3.4; z11_1 = (Math.Pow(2, Math.Tan(b11_1 * x11_1)));

            if (x11_1 <= a11_1)
            {
                y11_1 = Math.Pow(a11_1 * x11_1, e11_1) - 3.5 * Math.Pow(2, Math.Cos(1)) * (z11_1 + b11_1 * x11_1);
            }
            else if (a11_1 <= x11_1 && x11_1 <= Math.Pow(3.5, b11_1))
            {
                y11_1 = a11_1 + Math.Log(Math.Abs(a11_1 + b11_1 * x11_1)) - 2 * x11_1;
            }
            else if (x11_1 > Math.Pow(3.5, b11_1))
            {
                y11_1 = a11_1 + Math.Pow(3.5, Math.Cos(1)) * (a11_1 + b11_1 * x11_1 * z11_1);
            }
            double a11_2, b11_2, z11_2, y11_2;

            int x11_2 = new Random().Next(0, 5);
            int e11_2 = new Random().Next(0, 5);

            a11_2 = -3.2; b11_2 = 5.5; z11_2 = (Math.Pow(2, Math.Tan(b11_2 * x11_2)));

            if (x11_2 <= a11_2)
            {
                y11_2 = Math.Pow(a11_2 * x11_2, e11_2) - 3.5 * Math.Pow(2, Math.Cos(1)) * (z11_2 + b11_2 * x11_2);
            }
            else if (a11_2 <= x11_2 && x11_2 <= Math.Pow(3.5, b11_2))
            {
                y11_2 = a11_2 + Math.Log(Math.Abs(a11_2 + b11_2 * x11_2)) - 2 * x11_2;
            }
            else if (x11_2 > Math.Pow(3.5, b11_2))
            {
                y11_2 = a11_2 + Math.Pow(3.5, Math.Cos(1)) * (a11_2 + b11_2 * x11_2 * z11_2);
            }
            double a11_3, b11_3, z11_3, y11_3;

            int x11_3 = new Random().Next(0, 5);
            int e11_3 = new Random().Next(0, 5);

            a11_3 = -5.2; b11_3 = 7.2; z11_3 = (Math.Pow(3, Math.Tan(b11_3 * x11_3)));

            if (x11_3 <= a11_3)
            {
                y11_3 = Math.Pow(a11_3 * x11_3, e11_3) - 3.5 * Math.Pow(2, Math.Cos(1)) * (z11_3 + b11_3 * x11_3);
            }
            else if (a11_3 <= x11_3 && x11_3 <= Math.Pow(3.5, b11_3))
            {
                y11_3 = a11_3 + Math.Log(Math.Abs(a11_3 + b11_3 * x11_3)) - 2 * x11_3;
            }
            else if (x11_3 > Math.Pow(3.5, b11_3))
            {
                y11_3 = a11_3 + Math.Pow(3.5, Math.Cos(1)) * (a11_3 + b11_3 * x11_3 * z11_3);
            }
            MessageBox.Show($"y11_1 = {a11_1},  {b11_1},  {z11_1}");
            MessageBox.Show($"y11_2 = {a11_2},  {b11_2},  {z11_2}");
            MessageBox.Show($"y11_1 = {a11_3},  {b11_3},  {z11_3}");
        }
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            double y12_1, k12_1, m12_1, n12_1;

            int x12_1 = new Random().Next(0, 5);
            int e12_1 = new Random().Next(0, 5);

            k12_1 = 4; m12_1 = -14.7; n12_1 = -0.6;

            if (3 * x12_1 > Math.Abs(m12_1 + n12_1))
            {
                y12_1 = Math.Log(Math.Abs(Math.Log(1) * Math.Abs(k12_1 * x12_1 + m12_1 * n12_1)));
            }
            else if (3 * x12_1 == Math.Abs(m12_1 + n12_1))
            {
                y12_1 = Math.Sin(k12_1 * m12_1 * x12_1) + Math.Sqrt(Math.Abs(n12_1 * x12_1));
            }
            else if (3 * x12_1 < Math.Abs(m12_1 + n12_1))
            {
                y12_1 = Math.Pow(Math.Cos(x12_1), e12_1) + Math.Pow(m12_1 + n12_1, e12_1);
            }
            double y12_2, k12_2, m12_2, n12_2;

            int x12_2 = new Random().Next(0, 5);
            int e12_2 = new Random().Next(0, 5);

            k12_2 = 3; m12_2 = 6.5; n12_2 = 3.15;

            if (3 * x12_2 > Math.Abs(m12_2 + n12_2))
            {
                y12_2 = Math.Log(Math.Abs(Math.Log(1) * Math.Abs(k12_2 * x12_2 + m12_2 * n12_2)));
            }
            else if (3 * x12_2 == Math.Abs(m12_2 + n12_2))
            {
                y12_2 = Math.Sin(k12_2 * m12_2 * x12_2) + Math.Sqrt(Math.Abs(n12_2 * x12_2));
            }
            else if (3 * x12_2 < Math.Abs(m12_2 + n12_2))
            {
                y12_2 = Math.Pow(Math.Cos(x12_2), e12_2) + Math.Pow(m12_2 + n12_2, e12_2);
            }
            double y12_3, k12_3, m12_3, n12_3;

            int x12_3 = new Random().Next(0, 5);
            int e12_3 = new Random().Next(0, 5);

            k12_3 = 5; m12_3 = -12; n12_3 = 0.45;

            if (3 * x12_3 > Math.Abs(m12_3 + n12_3))
            {
                y12_3 = Math.Log(Math.Abs(Math.Log(1) * Math.Abs(k12_3 * x12_3 + m12_3 * n12_3)));
            }
            else if (3 * x12_3 == Math.Abs(m12_3 + n12_3))
            {
                y12_3 = Math.Sin(k12_3 * m12_3 * x12_3) + Math.Sqrt(Math.Abs(n12_3 * x12_3));
            }
            else if (3 * x12_3 < Math.Abs(m12_3 + n12_3))
            {
                y12_3 = Math.Pow(Math.Cos(x12_3), e12_3) + Math.Pow(m12_3 + n12_3, e12_3);
            }
            MessageBox.Show($"y12_1 = {k12_1},  {m12_1},  {n12_1}");
            MessageBox.Show($"y12_2 = {k12_2},  {m12_2},  {n12_2}");
            MessageBox.Show($"y12_1 = {k12_3},  {m12_3},  {n12_3}");
        }

        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            double y13_1, k13_1, r13_1, s13_1;

            int x13_1 = new Random().Next(0, 5);
            int e13_1 = new Random().Next(0, 5);

            k13_1 = 1.33; r13_1 = 0.85; s13_1 = 3.5;

            if (Math.Cos(x13_1) == (Math.Cos(r13_1 * s13_1)))
            {
                y13_1 = Math.Pow(2, x13_1) * Math.Pow(2 * k13_1, e13_1) + Math.Log(Math.Abs(r13_1 * x13_1));
            }
            else if (Math.Cos(x13_1) > (Math.Cos(r13_1 * s13_1)))
            {
                y13_1 = Math.Pow(3, Math.Sqrt(Math.Pow(2, x13_1)));
            }
            else if (Math.Cos(x13_1) < (Math.Cos(r13_1 * s13_1)))
            {
                y13_1 = Math.Atan(k13_1 * x13_1 + r13_1 * s13_1);
            }
            double y13_2, k13_2, r13_2, s13_2;

            int x13_2 = new Random().Next(0, 5);
            int e13_2 = new Random().Next(0, 5);

            k13_2 = 0.9; r13_2 = 3.3; s13_2 = 1.2;

            if (Math.Cos(x13_2) == (Math.Cos(r13_2 * s13_2)))
            {
                y13_2 = Math.Pow(2, x13_2) * Math.Pow(2 * k13_2, e13_2) + Math.Log(Math.Abs(r13_2 * x13_2));
            }
            else if (Math.Cos(x13_2) > (Math.Cos(r13_2 * s13_2)))
            {
                y13_2 = Math.Pow(3, Math.Sqrt(Math.Pow(2, x13_2)));
            }
            else if (Math.Cos(x13_2) < (Math.Cos(r13_2 * s13_2)))
            {
                y13_2 = Math.Atan(k13_2 * x13_2 + r13_2 * s13_2);
            }
            double y13_3, k13_3, r13_3, s13_3;

            int x13_3 = new Random().Next(0, 5);
            int e13_3 = new Random().Next(0, 5);

            k13_3 = 1.57; r13_3 = 0.75; s13_3 = 2.15;
            if (Math.Cos(x13_3) == (Math.Cos(r13_3 * s13_3)))
            {
                y13_3 = Math.Pow(2, x13_3) * Math.Pow(2 * k13_3, e13_3) + Math.Log(Math.Abs(r13_3 * x13_3));
            }
            else if (Math.Cos(x13_3) > (Math.Cos(r13_3 * s13_3)))
            {
                y13_3 = Math.Pow(3, Math.Sqrt(Math.Pow(2, x13_3)));
            }
            else if (Math.Cos(x13_3) < (Math.Cos(r13_3 * s13_3)))
            {
                y13_3 = Math.Atan(k13_3 * x13_3 + r13_3 * s13_3);
            }
            MessageBox.Show($"y13_1 = {k13_1},  {r13_1},  {s13_1}");
            MessageBox.Show($"y13_2 = {k13_2},  {r13_2},  {s13_2}");
            MessageBox.Show($"y13_1 = {k13_3},  {r13_3},  {s13_3}");
        }

        private void BtnTask15_Click(object sender, RoutedEventArgs e)
        {
            double a15_1, b15_1, c15_1, y15_1;

            int x15_1 = new Random().Next(0, 5);
            int e15_1 = new Random().Next(0, 5);

            a15_1 = 3.5; b15_1 = -5.6; c15_1 = 2.5;

            if (Math.Abs(1 - Math.Pow(2, x15_1)) == a15_1 + c15_1)
            {
                y15_1 = Math.Sqrt(Math.Abs(a15_1 * x15_1 + Math.Pow(2, Math.Cos(1)) * Math.Pow(3, b15_1) * x15_1 + 5.1 * Math.Pow(2, c15_1)));
            }
            else if (Math.Abs(1 - Math.Pow(2, x15_1)) > a15_1 + c15_1)
            {
                y15_1 = Math.Pow(0.04 * x15_1, e15_1) + Math.Log(Math.Abs(Math.Pow(5, b15_1) * Math.Cos(1)));
            }
            else if (Math.Abs(1 - Math.Pow(2, x15_1)) < a15_1 + c15_1)
            {
                y15_1 = (Math.Pow(2, Math.Cos(1)) * (Math.Pow(3, b15_1) + Math.Pow(2, x15_1))) + Math.Log(Math.Abs(b15_1 * x15_1 - Math.Pow(2, a15_1)));
            }
            double a15_2, b15_2, c15_2, y15_2;

            int x15_2 = new Random().Next(0, 5);
            int e15_2 = new Random().Next(0, 5);

            a15_2 = 15.4; b15_2 = -5.6; c15_2 = 3.5;

            if (Math.Abs(1 - Math.Pow(2, x15_2)) == a15_2 + c15_2)
            {
                y15_2 = Math.Sqrt(Math.Abs(a15_2 * x15_2 + Math.Pow(2, Math.Cos(1)) * Math.Pow(3, b15_2) * x15_2 + 5.1 * Math.Pow(2, c15_2)));
            }
            else if (Math.Abs(1 - Math.Pow(2, x15_2)) > a15_2 + c15_2)
            {
                y15_2 = Math.Pow(0.04 * x15_2, e15_2) + Math.Log(Math.Abs(Math.Pow(5, b15_2) * Math.Cos(1)));
            }
            else if (Math.Abs(1 - Math.Pow(2, x15_2)) < a15_2 + c15_2)
            {
                y15_2 = (Math.Pow(2, Math.Cos(1)) * (Math.Pow(3, b15_2) + Math.Pow(2, x15_2))) + Math.Log(Math.Abs(b15_2 * x15_2 - Math.Pow(2, a15_2)));
            }
            double a15_3, b15_3, c15_3, y15_3;

            int x15_3 = new Random().Next(0, 5);
            int e15_3 = new Random().Next(0, 5);
           
            a15_3 = 5.1; b15_3 = 4; c15_3 = 2.7;

            if (Math.Abs(1 - Math.Pow(2, x15_3)) == a15_3 + c15_3)
            {
                y15_3 = Math.Sqrt(Math.Abs(a15_3 * x15_3 + Math.Pow(2, Math.Cos(1)) * Math.Pow(3, b15_3) * x15_3 + 5.1 * Math.Pow(2, c15_3)));
            }
            else if (Math.Abs(1 - Math.Pow(2, x15_3)) > a15_3 + c15_3)
            {
                y15_3 = Math.Pow(0.04 * x15_3, e15_3) + Math.Log(Math.Abs(Math.Pow(5, b15_3) * Math.Cos(1)));
            }
            else if (Math.Abs(1 - Math.Pow(2, x15_3)) < a15_3 + c15_3)
            {
                y15_3 = (Math.Pow(2, Math.Cos(1)) * (Math.Pow(3, b15_3) + Math.Pow(2, x15_3))) + Math.Log(Math.Abs(b15_3 * x15_3 - Math.Pow(2, a15_3)));
            }
            MessageBox.Show($"y15_1 = {b15_1},  {c15_1},  {a15_1}");
            MessageBox.Show($"y15_2 = {b15_2},  {c15_2},  {a15_2}");
            MessageBox.Show($"y15_1 = {b15_3},  {c15_3},  {a15_3}");
        }

        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            double a16_1, b16_1, z16_1, y16_1;

            int x16_1 = new Random().Next(0, 5);
            int e16_1 = new Random().Next(0, 5);

            a16_1 = 0.1; b16_1 = 0.5; z16_1 = (int)Math.Pow(2.5 * a16_1 * x16_1, e16_1);

            if (x16_1 <= a16_1)
            {
                y16_1 = 3.5 * Math.Pow(2, Math.Sin(1)) * Math.Pow(3, (b16_1 * x16_1 + z16_1)) - Math.Pow(3.5 * a16_1, e16_1);
            }
            else if (a16_1 < x16_1 && x16_1 <= Math.Pow(2.5, b16_1))
            {
                y16_1 = Math.Log(a16_1 + Math.Pow(3, x16_1) * x16_1) + a16_1;
            }
            else if (x16_1 > Math.Pow(2.5, b16_1))
            {
                y16_1 = Math.Pow(2, Math.Cos(1)) * (Math.Pow(b16_1, a16_1) + x16_1 * z16_1) + Math.Pow(2, a16_1);
            }
            double a16_2, b16_2, z16_2, y16_2;

            int x16_2 = new Random().Next(0, 5);
            int e16_2 = new Random().Next(0, 5);

            a16_2 = 1.2; b16_2 = 2.5; z16_2 = (int)Math.Pow(2.5 * a16_2 * x16_2, e16_2);

            if (x16_2 <= a16_2)
            {
                y16_2 = 3.5 * Math.Pow(2, Math.Sin(1)) * Math.Pow(3, (b16_2 * x16_2 + z16_2)) - Math.Pow(3.5 * a16_2, e16_2);
            }
            else if (a16_2 < x16_2 && x16_2 <= Math.Pow(2.5, b16_2))
            {
                y16_2 = Math.Log(a16_2 + Math.Pow(3, x16_2) * x16_2) + a16_2;
            }
            else if (x16_2 > Math.Pow(2.5, b16_2))
            {
                y16_2 = Math.Pow(2, Math.Cos(1)) * (Math.Pow(b16_2, a16_2) + x16_2 * z16_2) + Math.Pow(2, a16_2);
            }
            double a16_3, b16_3, z16_3, y16_3;

            int x16_3 = new Random().Next(0, 5);
            int e16_3 = new Random().Next(0, 5);

            a16_3 = 2.5; b16_3 = 1.2; z16_3 = (int)Math.Pow(2.5 * a16_3 * x16_3, e16_3);
            if (x16_3 <= a16_3)
            {
                y16_3 = 3.5 * Math.Pow(2, Math.Sin(1)) * Math.Pow(3, (b16_3 * x16_3 + z16_3)) - Math.Pow(3.5 * a16_3, e16_3);
            }
            else if (a16_3 < x16_3 && x16_3 <= Math.Pow(2.5, b16_3))
            {
                y16_3 = Math.Log(a16_3 + Math.Pow(3, x16_3) * x16_3) + a16_3;
            }
            else if (x16_3 > Math.Pow(2.5, b16_3))
            {
                y16_3 = Math.Pow(2, Math.Cos(1)) * (Math.Pow(b16_3, a16_3) + x16_3 * z16_3) + Math.Pow(2, a16_3);
            }
            MessageBox.Show($"y16_1 = {b16_1},  {z16_1},  {a16_1}");
            MessageBox.Show($"y16_2 = {b16_2},  {z16_2},  {a16_2}");
            MessageBox.Show($"y16_1 = {b16_3},  {z16_3},  {a16_3}");
        }

                private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            double a14_1, b14_1, z14_1, y14_1;

            int x14_1 = new Random().Next(0, 5);
            int e14_1 = new Random().Next(0, 5);

            a14_1 = 0.5; b14_1 = 4.5; z14_1 = Math.Pow(a14_1 * x14_1, e14_1);

            if (x14_1 <= 5 * a14_1)
            {
                y14_1 = 2.5 * Math.Pow(2, b14_1) + a14_1 * x14_1 - 4.5 * Math.Cos(x14_1 * z14_1);
            }
            else if (x14_1 > b14_1)
            {
                y14_1 = (Math.Pow(3, (Math.Pow(2, a14_1) - 5.4 * x14_1)) + (Math.Log(x14_1 * z14_1)));
            }
            else if (a14_1 < x14_1 && x14_1 <= b14_1)
            {
                y14_1 = Math.Sqrt(6.5 * Math.Pow(2, b14_1)) + (a14_1 - Math.Pow(3, x14_1) * z14_1);
            }
            double a14_2, b14_2, z14_2, y14_2;

            int x14_2 = new Random().Next(0, 5);
            int e14_2 = new Random().Next(0, 5);

            a14_2 = 0.5; b14_2 = 3.7; z14_2 = Math.Pow(2 * a14_2 * x14_2, e14_2);

            if (x14_2 <= 5 * a14_2)
            {
                y14_2 = 2.5 * Math.Pow(2, b14_2) + a14_2 * x14_2 - 4.5 * Math.Cos(x14_2 * z14_2);
            }
            else if (x14_2 > b14_2)
            {
                y14_2 = (Math.Pow(3, (Math.Pow(2, a14_2) - 5.4 * x14_2)) + (Math.Log(x14_2 * z14_2)));
            }
            else if (a14_2 < x14_2 && x14_2 <= b14_2)
            {
                y14_2 = Math.Sqrt(6.5 * Math.Pow(2, b14_2)) + (a14_2 - Math.Pow(3, x14_2) * z14_2);
            }
            double a14_3, b14_3, z14_3, y14_3;

            int x14_3 = new Random().Next(0, 5);
            int e14_3 = new Random().Next(0, 5);

            a14_3 = 0.5; b14_3 = 2.7; z14_3 = Math.Pow(2.5 * a14_3 * x14_3, e14_3);

            if (x14_3 <= 5 * a14_3)
            {
                y14_3 = 2.5 * Math.Pow(2, b14_3) + a14_3 * x14_3 - 4.5 * Math.Cos(x14_3 * z14_3);
            }
            else if (x14_3 > b14_3)
            {
                y14_3 = (Math.Pow(3, (Math.Pow(2, a14_3) - 5.4 * x14_3)) + (Math.Log(x14_3 * z14_3)));
            }
            else if (a14_3 < x14_3 && x14_3 <= b14_3)
            {
                y14_3 = Math.Sqrt(6.5 * Math.Pow(2, b14_3)) + (a14_3 - Math.Pow(3, x14_3) * z14_3);
            }
            MessageBox.Show($"y13_1 = {a14_1},  {b14_1},  {z14_1}");
            MessageBox.Show($"y13_2 = {a14_2},  {b14_2},  {z14_2}");
            MessageBox.Show($"y13_1 = {a14_3},  {b14_3},  {z14_3}");
        }

        private void BtnTask17_Click(object sender, RoutedEventArgs e)
        {
            double a17_1, b17_1, z17_1, y17_1;

            int x17_1 = new Random().Next(0, 5);
            int e17_1 = new Random().Next(0, 5);

            a17_1 = -1.2; b17_1 = 0.75;z17_1 = Math.Log(Math.Abs(Math.Tan(b17_1 * x17_1)));
            
            if (x17_1 <= a17_1)
            {
                y17_1 = a17_1 + Math.Sin(b17_1 * x17_1) + Math.Pow(2, Math.Cos(x17_1));
            }
            else if (a17_1 < x17_1 && x17_1 < Math.Log(b17_1))
            {
                y17_1 = Math.Abs(a17_1 + b17_1 * x17_1) + Math.Sin(z17_1 * x17_1);
            }
            else if (x17_1 <= Math.Log(b17_1))
            {
                y17_1 =  Math.Log(a17_1 + b17_1 * x17_1 + z17_1);
            }
            double a17_2, b17_2, z17_2, y17_2;

            int x17_2 = new Random().Next(0, 5);
            int e17_2 = new Random().Next(0, 5);
            
            a17_2 = 0.4; b17_2 = 2.4; z17_2 = Math.Log(Math.Abs(Math.Tan(b17_2 * x17_2)));
          
            if (x17_2 <= a17_2)
            {
                y17_2 = a17_2 + Math.Sin(b17_2 * x17_2) + Math.Pow(2, Math.Cos(x17_2));
            }
            else if (a17_2 < x17_2 && x17_2 < Math.Log(b17_2))
            {
                y17_2 = Math.Abs(a17_2 + b17_2 * x17_2) + Math.Sin(z17_2 * x17_2);
            }
            else if (x17_2 <= Math.Log(b17_2))
            {
                y17_2 = Math.Log(a17_2 + b17_2 * x17_2 + z17_2);
            }
            double a17_3, b17_3, z17_3, y17_3;

            int x17_3 = new Random().Next(0, 5);
            int e17_3 = new Random().Next(0, 5);
            a17_3 = -1.2; b17_3 = 0.75; z17_3 = Math.Log(Math.Abs(Math.Tan(b17_3 * x17_3)));
            a17_3 = 0.4; b17_3 = 2.4; z17_3 = Math.Log(Math.Abs(Math.Tan(b17_3 * x17_3)));
            a17_3 = 1.1; b17_3 = 6.1; z17_3 = Math.Log(Math.Abs(Math.Tan(b17_3 * x17_3)));
            if (x17_3 <= a17_3)
            {
                y17_3 = a17_3 + Math.Sin(b17_3 * x17_3) + Math.Pow(2, Math.Cos(x17_3));
            }
            else if (a17_3 < x17_3 && x17_3 < Math.Log(b17_3))
            {
                y17_3 = Math.Abs(a17_3 + b17_3 * x17_3) + Math.Sin(z17_3 * x17_3);
            }
            else if (x17_3 <= Math.Log(b17_3))
            {
                y17_3 = Math.Log(a17_3 + b17_3 * x17_3 + z17_3);
            }
            MessageBox.Show($"y17_1 = {a17_1},  {b17_1},  {z17_1}");
            MessageBox.Show($"y17_2 = {a17_2},  {b17_2},  {z17_2}");
            MessageBox.Show($"y17_1 = {a17_3},  {b17_3},  {z17_3}");
        }

        private void BtnTask18_Click(object sender, RoutedEventArgs e)
        {
            double a18_1, b18_1, z18_1, y18_1;

            int x18_1 = new Random().Next(0, 5);
            int e18_1 = new Random().Next(0, 5);

            a18_1 = 6; b18_1 = 3.2; z18_1 = Math.Pow(1.5*a18_1*x18_1, e18_1);
            
            if (x18_1 < -Math.Log(Math.Abs(a18_1)))
            {
                y18_1 = Math.Pow(3, (3.5 * a18_1 - 7.3 * b18_1 * x18_1 + Math.Sin(z18_1 * x18_1)));
            }
            else if (-Math.Log(Math.Abs(a18_1)) <= x18_1 && x18_1 < b18_1)
            {
                y18_1 = Math.Pow(b18_1, a18_1) - Math.Pow(3, Math.Cos(1) * (a18_1 + z18_1 * x18_1));
            }
            else if (x18_1>b18_1)
            {
                y18_1 = Math.Pow(b18_1, a18_1) - Math.Pow(3, Math.Cos(1)) * (a18_1 + z18_1 * x18_1);
            }
            double a18_2, b18_2, z18_2, y18_2;

            int x18_2 = new Random().Next(0, 5);
            int e18_2 = new Random().Next(0, 5);

            a18_2 = 3; b18_2 = 6; z18_2 = Math.Pow(1.5 * a18_2 * x18_2, e18_2);
            
            if (x18_2 < -Math.Log(Math.Abs(a18_2)))
            {
                y18_2 = Math.Pow(3, (3.5 * a18_2 - 7.3 * b18_2 * x18_2 + Math.Sin(z18_2 * x18_2)));
            }
            else if (-Math.Log(Math.Abs(a18_2)) <= x18_2 && x18_2 < b18_2)
            {
                y18_2 = Math.Pow(b18_2, a18_2) - Math.Pow(3, Math.Cos(1) * (a18_2 + z18_2 * x18_2));
            }
            else if (x18_2 > b18_2)
            {
                y18_2 = Math.Pow(b18_2, a18_2) - Math.Pow(3, Math.Cos(1)) * (a18_2 + z18_2 * x18_2);
            }
            double a18_3, b18_3, z18_3, y18_3;

            int x18_3 = new Random().Next(0, 5);
            int e18_3 = new Random().Next(0, 5);

            a18_3 = 2 / 7; b18_3 = 1.8; z18_3 = Math.Pow(1.5 * a18_3 * x18_3, e18_3);

            if (x18_3 < -Math.Log(Math.Abs(a18_3)))
            {
                y18_3 = Math.Pow(3, (3.5 * a18_3 - 7.3 * b18_3 * x18_3 + Math.Sin(z18_3 * x18_3)));
            }
            else if (-Math.Log(Math.Abs(a18_3)) <= x18_3 && x18_3 < b18_3)
            {
                y18_3 = Math.Pow(b18_3, a18_3) - Math.Pow(3, Math.Cos(1) * (a18_3 + z18_3 * x18_3));
            }
            else if (x18_3 > b18_3)
            {
                y18_3 = Math.Pow(b18_3, a18_3) - Math.Pow(3, Math.Cos(1)) * (a18_3 + z18_3 * x18_3);
            }
            MessageBox.Show($"y18_1 = {a18_1},  {b18_1},  {z18_1}");
            MessageBox.Show($"y18_2 = {a18_2},  {b18_2},  {z18_2}");
            MessageBox.Show($"y18_1 = {a18_3},  {b18_3},  {z18_3}");
        }

        private void BtnTask19_Click(object sender, RoutedEventArgs e)
        {
            double y19_1, a19_1, b19_1, c19_1;

            int x19_1 = new Random().Next(0, 5);

            a19_1 = 2.2; b19_1 = 2.4; c19_1 = Math.Log(Math.Abs(b19_1 * x19_1));
            if (x19_1 < a19_1)
            {
                y19_1 = c19_1 * Math.Pow(2, Math.Sin(b19_1 * x19_1) + b19_1 * Math.Log(c19_1 * x19_1 + a19_1));
            }
            else if (a19_1 <= x19_1 && x19_1 < b19_1)
            {
                y19_1 = a19_1 + Math.Log(b19_1 * x19_1) - Math.Pow(2, Math.Sin(1)) * a19_1 + c19_1 * x19_1;
            }
            else if (x19_1 >= b19_1)
            {
                y19_1 = Math.Sqrt(Math.Pow(2, Math.Cos(a19_1 + b19_1 * x19_1) + c19_1 * Math.Pow(2, x19_1)));
            }
            double y19_2, a19_2, b19_2, c19_2;

            int x19_2 = new Random().Next(0, 5);

            a19_2 = 2.2; b19_2 = 2.4; c19_2 = Math.Log(Math.Abs(b19_2 * x19_2));
            if (x19_2 < a19_2)
            {
                y19_2 = c19_2 * Math.Pow(2, Math.Sin(b19_2 * x19_2) + b19_2 * Math.Log(c19_2 * x19_2 + a19_2));
            }
            else if (a19_2 <= x19_2 && x19_2 < b19_2)
            {
                y19_2 = a19_2 + Math.Log(b19_2 * x19_2) - Math.Pow(2, Math.Sin(1)) * a19_2 + c19_2 * x19_2;
            }
            else if (x19_2 >= b19_2)
            {
                y19_2 = Math.Sqrt(Math.Pow(2, Math.Cos(a19_2 + b19_2 * x19_2) + c19_2 * Math.Pow(2, x19_2)));
            }
            double y19_3, a19_3, b19_3, c19_3;

            int x19_3 = new Random().Next(0, 5);

            a19_3 = 2.2; b19_3 = 2.4; c19_3 = Math.Log(Math.Abs(b19_3 * x19_3));
            if (x19_3 < a19_3)
            {
                y19_3 = c19_3 * Math.Pow(2, Math.Sin(b19_3 * x19_3) + b19_3 * Math.Log(c19_3 * x19_3 + a19_3));
            }
            else if (a19_3 <= x19_3 && x19_3 < b19_3)
            {
                y19_3 = a19_3 + Math.Log(b19_3 * x19_3) - Math.Pow(2, Math.Sin(1)) * a19_3 + c19_3 * x19_3;
            }
            else if (x19_3 >= b19_3)
            {
                y19_3 = Math.Sqrt(Math.Pow(2, Math.Cos(a19_3 + b19_3 * x19_3) + c19_3 * Math.Pow(2, x19_3)));
            }
            MessageBox.Show($"y19_1 = {a19_1},  {b19_1},  {c19_1}");
            MessageBox.Show($"y19_2 = {a19_2},  {b19_2},  {c19_2}");
            MessageBox.Show($"y19_3 = {a19_3},  {b19_3},  {c19_3}");
        }
    

        private void BtnTask20_Click(object sender, RoutedEventArgs e)
        {
            double y20_1, a20_1, b20_1, f20_1;

            int x20_1 = new Random().Next(0, 5);
            int e5 = new Random().Next(0, 5);

            a20_1 = 0.8; b20_1 = 2.4; f20_1 = Math.Pow(1.5 * a20_1 * x20_1, e5);
      
            if (x20_1 <= a20_1)
            {
                y20_1 = Math.Pow(a20_1 * x20_1, e5) + f20_1 * Math.Pow(5, Math.Cos(1) * b20_1 * x20_1);
            }
            else if (a20_1 < x20_1 && x20_1 <= Math.Pow(2, b20_1))
            {
                y20_1 = a20_1 + Math.Pow(2, Math.Cos(1) * b20_1 * x20_1 - Math.Log(f20_1 * x20_1));
            }
            else if (x20_1 > Math.Pow(2, b20_1))
            {
                y20_1 = Math.Pow(2, Math.Cos(1)) * a20_1 + b20_1 * x20_1;
            }
            double y20_2, a20_2, b20_2, f20_2;

            int x20_2 = new Random().Next(0, 5);
            int e6 = new Random().Next(0, 5);

            a20_2 = 1.2; b20_2 = 8.1; f20_2 = Math.Pow(2 * a20_2 * x20_2, e5);

            if (x20_2 <= a20_2)
            {
                y20_2 = Math.Pow(a20_2 * x20_2, e6) + f20_2 * Math.Pow(5, Math.Cos(1) * b20_2 * x20_2);
            }
            else if (a20_2 < x20_2 && x20_2 <= Math.Pow(2, b20_2))
            {
                y20_2 = a20_2 + Math.Pow(2, Math.Cos(1) * b20_2 * x20_2 - Math.Log(f20_2 * x20_2));
            }
            else if (x20_2 > Math.Pow(2, b20_2))
            {
                y20_2 = Math.Pow(2, Math.Cos(1)) * a20_2 + b20_2 * x20_2;
            }
            double y20_3, a20_3, b20_3, f20_3;

            int x20_3 = new Random().Next(0, 5);
            int e7 = new Random().Next(0, 5);

            a20_3 = 3.4; b20_3 = 8.1; f20_3 = Math.Pow(3 * a20_3 * x20_3, e5);

            if (x20_3 <= a20_3)
            {
                y20_3 = Math.Pow(a20_3 * x20_3, e6) + f20_3 * Math.Pow(5, Math.Cos(1) * b20_3 * x20_3);
            }
            else if (a20_3 < x20_3 && x20_3 <= Math.Pow(2, b20_3))
            {
                y20_3 = a20_3 + Math.Pow(2, Math.Cos(1) * b20_3 * x20_3 - Math.Log(f20_3 * x20_3));
            }
            else if (x20_3 > Math.Pow(2, b20_3))
            {
                y20_3 = Math.Pow(2, Math.Cos(1)) * a20_3 + b20_3 * x20_3;
            }
            MessageBox.Show($"y20_1 = {a20_1},  {b20_1},  {f20_1}");
            MessageBox.Show($"y20_2 = {a20_2},  {b20_2},  {f20_2}");
            MessageBox.Show($"y20_1 = {a20_3},  {b20_3},  {f20_3}");
        }


        private void BtnTask21_Click(object sender, RoutedEventArgs e, double z21_3)
        {
            double y21_1, a21_1, b21_1, z21_1;

            int x21_1 = new Random().Next(0, 5);

            a21_1 = 4.5; b21_1 = 8.4; z21_1 = Math.Tan(Math.Pow(2, b21_1 * x21_1));

            if (x21_1 <= a21_1)
            {
                y21_1 = a21_1 * Math.Pow(2, Math.Cos(1)) * b21_1 * Math.Sin(1) * z21_1 * x21_1;
            }
            else if (a21_1 < x21_1 && x21_1 <= 4.5 * b21_1)
            {
                y21_1 = a21_1 * Math.Tan(a21_1 * x21_1 + z21_1) + Math.Pow(2, Math.Sin(1)) * b21_1 * x21_1;
            }
            else if (x21_1 > 4.5 * b21_1)
            {
                y21_1 = Math.Log(a21_1 * x21_1 - b21_1) + Math.Pow(2, z21_1);
            }
            double y21_2, a21_2, b21_2, z21_2;

            int x21_2 = new Random().Next(0, 5);


            a21_2 = 8.2; b21_2 = 15.2; z21_2 = Math.Tan(Math.Pow(2, b21_2 * x21_2));

            if (x21_2 <= a21_2)
            {
                y21_2 = a21_2 * Math.Pow(2, Math.Cos(1)) * b21_2 * Math.Sin(1) * z21_2 * x21_2;
            }
            else if (a21_2 < x21_2 && x21_2 <= 4.5 * b21_2)
            {
                y21_2 = a21_2 * Math.Tan(a21_2 * x21_2 + z21_2) + Math.Pow(2, Math.Sin(1)) * b21_2 * x21_2;
            }
            else if (x21_2 > 4.5 * b21_2)
            {
                y21_2 = Math.Log(a21_2 * x21_2 - b21_2) + Math.Pow(2, z21_2);
            }
            double y21_3, a21_3, b21_3;

            int x21_3 = new Random().Next(0, 5);

            a21_3 = 1.7; b21_3 = 0.5; Math.Tan(b21_3 * Math.Pow(2, x21_3));
            if (x21_3 <= a21_3)
            {
                y21_3 = a21_3 * Math.Pow(2, Math.Cos(1)) * b21_3 * Math.Sin(1)  * x21_3;
            }
            else if (a21_3 < x21_3 && x21_3 <= 4.5 * b21_3)
            {
                y21_3 = a21_3 * Math.Tan(a21_3 * x21_3) + Math.Pow(2, Math.Sin(1)) * b21_3 * x21_3;
            }
            else if (x21_3 > 4.5 * b21_3)
            {
                y21_3 = Math.Log(a21_3 * x21_3 - b21_3) + Math.Pow(2, z21_3);
            }
            MessageBox.Show($"y21_1 = {a21_1},  {b21_1},  {z21_1}");
            MessageBox.Show($"y21_2 = {a21_2},  {b21_2},  {z21_2}");
            MessageBox.Show($"y21_1 = {a21_3},  {b21_3},  {z21_3}");
        }
    

        private void BtnTask22_Click(object sender, RoutedEventArgs e)
        {
            double y22_1, a22_1, b22_1, z22_1;
            int x22_1 = new Random().Next(0, 5);
            
            a22_1 = 0.3; b22_1 = 0.9; z22_1 = Math.Pow(2, Math.Sin(x22_1));

            if (x22_1 < a22_1)
            {
                y22_1 = a22_1 + b22_1 * x22_1 + Math.Pow(2, Math.Sin(1)) * z22_1 * Math.Pow(3.5, x22_1);
            }
            else if (a22_1 <= x22_1 && x22_1 <= Math.Pow(2, b22_1))
            {
                y22_1 = a22_1 * Math.Pow(2, x22_1) + b22_1 * Math.Pow(a22_1, z22_1) + Math.Pow(2, Math.Sin(1)) * z22_1 * x22_1;
            }
            else if (x22_1 <= Math.Pow(3, a22_1))
            {
                y22_1 = Math.Cos(a22_1 * x22_1 + b22_1) + Math.Log(Math.Abs(z22_1 * x22_1));
            }
            double y22_2, a22_2, b22_2, z22_2;
            int x22_2 = new Random().Next(0, 5);
            
            a22_2 = 4.3; b22_2 = 3.15; z22_2 = Math.Pow(3, Math.Sin(x22_2));

            if (x22_2 < a22_2)
            {
                y22_2 = a22_2 + b22_2 * x22_2 + Math.Pow(2, Math.Sin(1)) * z22_2 * Math.Pow(3.5, x22_2);
            }
            else if (a22_2 <= x22_2 && x22_2 <= Math.Pow(2, b22_2))
            {
                y22_2 = a22_2 * Math.Pow(2, x22_2) + b22_2 * Math.Pow(a22_2, z22_2) + Math.Pow(2, Math.Sin(1)) * z22_2 * x22_2;
            }
            else if (x22_2 <= Math.Pow(3, a22_2))
            {
                y22_2 = Math.Cos(a22_2 * x22_2 + b22_2) + Math.Log(Math.Abs(z22_2 * x22_2));
            }
            double y22_3, a22_3, b22_3, z22_3;
            int x22_3 = new Random().Next(0, 5);

            a22_3 = 6.5; b22_3 = 3.5; z22_3 = Math.Pow(2, Math.Sin(1)) * x22_3;

            if (x22_3 < a22_3)
            {
                y22_3 = a22_3 + b22_3 * x22_3 + Math.Pow(2, Math.Sin(1)) * z22_3 * Math.Pow(3.5, x22_3);
            }
            else if (a22_3 <= x22_3 && x22_3 <= Math.Pow(2, b22_3))
            {
                y22_3 = a22_3 * Math.Pow(2, x22_3) + b22_3 * Math.Pow(a22_3, z22_3) + Math.Pow(2, Math.Sin(1)) * z22_3 * x22_3;
            }
            else if (x22_3 <= Math.Pow(3, a22_3))
            {
                y22_3 = Math.Cos(a22_3 * x22_3 + b22_3) + Math.Log(Math.Abs(z22_3 * x22_3));
            }
            MessageBox.Show($"y22_1 = {a22_1},  {b22_1},  {z22_1}");
            MessageBox.Show($"y22_2 = {a22_2},  {b22_2},  {z22_2}");
            MessageBox.Show($"y22_3 = {a22_3},  {b22_3},  {z22_3}");
        }

        private void BtnTask23_Click(object sender, RoutedEventArgs e)
        {
            double y23_1, a23_1, b23_1, z23_1;

            int x23_1 = new Random().Next(0, 5);

            a23_1 = 1.5; b23_1 = 6.4; z23_1 = Math.Log(Math.Abs(b23_1 * Math.Pow(3, x23_1) + 1.5));

            if (Math.Pow(3, a23_1) < x23_1 && x23_1 <= b23_1)
            {
                y23_1 = Math.Log(Math.Abs(b23_1 * z23_1 * x23_1)) + z23_1 * Math.Pow(2.5, a23_1);
            }
            else if (x23_1 > b23_1)
            {
                y23_1 = a23_1 * Math.Pow(2, x23_1) + b23_1 * Math.Pow(a23_1, z23_1) + Math.Pow(2, Math.Sin(1)) * z23_1 * x23_1;
            }
            else if (x23_1 <= Math.Pow(3, a23_1))
            {
                y23_1 = Math.Cos(a23_1 * x23_1 + b23_1) + Math.Log(Math.Abs(z23_1 * x23_1));
            }
            double y23_2, a23_2, b23_2, z23_2;

            int x23_2 = new Random().Next(0, 5);


            a23_2 = 1.9; b23_2 = 8.6; z23_2 = Math.Log(Math.Abs(b23_2 * Math.Pow(3, x23_2) + 3));

            if (Math.Pow(3, a23_2) < x23_2 && x23_2 <= b23_2)
            {
                y23_2 = Math.Log(Math.Abs(b23_2 * z23_2 * x23_2)) + z23_2 * Math.Pow(2.5, a23_2);
            }
            else if (x23_2 > b23_2)
            {
                y23_2 = a23_2 * Math.Pow(2, x23_2) + b23_2 * Math.Pow(a23_2, z23_2) + Math.Pow(2, Math.Sin(1)) * z23_2 * x23_2;
            }
            else if (x23_2 <= Math.Pow(3, a23_2))
            {
                y23_2 = Math.Cos(a23_2 * x23_2 + b23_2) + Math.Log(Math.Abs(z23_2 * x23_2));
            }
            double y23_3, a23_3, b23_3, z23_3;

            int x23_3 = new Random().Next(0, 5);

            a23_3 = 0.6; b23_3 = 5.7; z23_3 = Math.Log(Math.Abs(b23_3 * Math.Pow(3, x23_3) + 1.8));

            if (Math.Pow(3, a23_3) < x23_3 && x23_3 <= b23_3)
            {
                y23_3 = Math.Log(Math.Abs(b23_3 * z23_3 * x23_3)) + z23_3 * Math.Pow(2.5, a23_3);
            }
            else if (x23_3 > b23_3)
            {
                y23_3 = a23_3 * Math.Pow(2, x23_3) + b23_3 * Math.Pow(a23_3, z23_3) + Math.Pow(2, Math.Sin(1)) * z23_3 * x23_3;
            }
            else if (x23_3 <= Math.Pow(3, a23_3))
            {
                y23_3 = Math.Cos(a23_3 * x23_3 + b23_3) + Math.Log(Math.Abs(z23_3 * x23_3));
            }
            MessageBox.Show($"y23_1 = {a23_1},  {b23_1},  {z23_1}");
            MessageBox.Show($"y23_2 = {a23_2},  {b23_2},  {z23_2}");
            MessageBox.Show($"y23_3 = {a23_3},  {b23_3},  {z23_3}");
        }

        private void BtnTask24_Click(object sender, RoutedEventArgs e)
        {
            double y24_1, a24_1, b24_1, z24_1;

            int x = new Random().Next(0, 5);
            int e1 = new Random().Next(0, 5);

            a24_1 = 8.7; b24_1 = 3.7; z24_1 = Math.Tan(b24_1 * x);

            if (x < a24_1)
            {
                y24_1 = x * Math.Pow(x, e1) + (z24_1 + 7.7 * a24_1 * b24_1 * x);
            }
            else if (a24_1 <= x && x <= Math.Pow(2, b24_1))
            {
                y24_1 = Math.Tan(a24_1 * x + z24_1) + Math.Pow(2, Math.Cos(b24_1 * x));
            }
            else if (x > Math.Pow(2, b24_1))
            {
                y24_1 = Math.Log(Math.Pow(2, Math.Sin(1)) * (a24_1 + b24_1 * x + z24_1 * Math.Pow(2, x)));
            }
            double y24_2, a24_2, b24_2, z24_2;

            int x24_2 = new Random().Next(0, 5);
            int e2 = new Random().Next(0, 5);

            a24_2 = 9.3; b24_2 = 3.5; z24_2 = Math.Tan(a24_2 * b24_2 * x);

            if (x < a24_2)
            {
                y24_2 = x * Math.Pow(x, e2) + (z24_2 + 7.7 * a24_2 * b24_2 * x);
            }
            else if (a24_2 <= x && x <= Math.Pow(2, b24_2))
            {
                y24_2 = Math.Tan(a24_2 * x + z24_2) + Math.Pow(2, Math.Cos(b24_2 * x));
            }
            else if (x > Math.Pow(2, b24_2))
            {
                y24_2 = Math.Log(Math.Pow(2, Math.Sin(1)) * (a24_2 + b24_2 * x + z24_2 * Math.Pow(2, x)));
            }
            double y24_3, a24_3, b24_3, z24_3;

            int x24_3 = new Random().Next(0, 5);
            int e3 = new Random().Next(0, 5);

            a24_3 = 2.1; b24_3 = 5.7; z24_3 = Math.Tan(Math.Pow(2, b24_3) * x);

            if (x < a24_3)
            {
                y24_3 = x * Math.Pow(x, e2) + (z24_3 + 7.7 * a24_3 * b24_3 * x);
            }
            else if (a24_3 <= x && x <= Math.Pow(2, b24_3))
            {
                y24_3 = Math.Tan(a24_3 * x + z24_3) + Math.Pow(2, Math.Cos(b24_3 * x));
            }
            else if (x > Math.Pow(2, b24_3))
            {
                y24_3 = Math.Log(Math.Pow(2, Math.Sin(1)) * (a24_3 + b24_3 * x + z24_3 * Math.Pow(2, x)));
            }
            MessageBox.Show($"y24_1 = {a24_1},  {b24_1},  {z24_1}");
            MessageBox.Show($"y24_2 = {a24_2},  {b24_2},  {z24_2}");
            MessageBox.Show($"y24_1 = {a24_3},  {b24_3},  {z24_3}");
        }

        private void BtnTask25_Click(object sender, RoutedEventArgs e)
        {
            double a25_1, b25_1, z25_1, y25_1;

            int x25_1 = new Random().Next(0, 5);

            a25_1 = 1.5; b25_1 = 5.7; z25_1 = Math.Log(Math.Abs(Math.Tan(b25_1 * x25_1)));
            
            if (x25_1 < a25_1)
            {
                y25_1 = a25_1 + z25_1 + Math.Pow(2, Math.Cos(1)) * Math.Pow(3, b25_1 * x25_1);
            }
            else if (a25_1 <= x25_1 && x25_1 <= b25_1)
            {
                y25_1 = a25_1 + Math.Pow(2, Math.Sin(1)) * Math.Pow(2, b25_1) + Math.Log(z25_1 * x25_1);
            }
            else if (x25_1 > b25_1)
            {
                y25_1 = Math.Pow(3, Math.Sqrt(0.3 * b25_1 + Math.Sqrt(Math.Abs(a25_1 - Math.Pow(2, z25_1) - Math.Cos(x25_1)))));
            }
            double a25_2, b25_2, z25_2, y25_2;

            int x25_2 = new Random().Next(0, 5);
   
            a25_2 = 3.7; b25_2 = 8.4; z25_2 = Math.Log(Math.Abs(Math.Tan(b25_2 * x25_2)));

            if (x25_2 < a25_2)
            {
                y25_2 = a25_2 + z25_2 + Math.Pow(2, Math.Cos(1)) * Math.Pow(3, b25_2 * x25_2);
            }
            else if (a25_2 <= x25_2 && x25_2 <= b25_2)
            {
                y25_2 = a25_2 + Math.Pow(2, Math.Sin(1)) * Math.Pow(2, b25_2) + Math.Log(z25_2 * x25_2);
            }
            else if (x25_2 > b25_2)
            {
                y25_2 = Math.Pow(3, Math.Sqrt(0.3 * b25_2 + Math.Sqrt(Math.Abs(a25_2 - Math.Pow(2, z25_2) - Math.Cos(x25_2)))));
            }
            double a25_3, b25_3, z25_3, y25_3;

            int x25_3 = new Random().Next(0, 5);

            a25_3 = 4.4; b25_3 = 5.6; z25_3 = Math.Log(Math.Abs(Math.Tan(b25_3 * x25_3)));

            if (x25_3 < a25_3)
            {
                y25_3 = a25_3 + z25_3 + Math.Pow(2, Math.Cos(1)) * Math.Pow(3, b25_3 * x25_3);
            }
            else if (a25_3 <= x25_3 && x25_3 <= b25_3)
            {
                y25_3 = a25_3 + Math.Pow(2, Math.Sin(1)) * Math.Pow(2, b25_3) + Math.Log(z25_3 * x25_3);
            }
            else if (x25_3 > b25_3)
            {
                y25_3 = Math.Pow(3, Math.Sqrt(0.3 * b25_3 + Math.Sqrt(Math.Abs(a25_3 - Math.Pow(2, z25_3) - Math.Cos(x25_3)))));
            }
            MessageBox.Show($"y25_1 = {a25_1},  {b25_1},  {z25_1}");
            MessageBox.Show($"y25_2 = {a25_2},  {b25_2},  {z25_2}");
            MessageBox.Show($"y25_1 = {a25_3},  {b25_3},  {z25_3}");
        }

        private void BtnTask26_Click(object sender, RoutedEventArgs e)
        {
            double z26_1, y26_1;

            int x26_1 = new Random().Next(0, 5);
            int e26_1 = new Random().Next(0, 5);

            z26_1 = Math.Pow(3, Math.Asin(x26_1));
            
            if (z26_1 > -0.5)
            {
                y26_1 = Math.Pow(2, (2 * z26_1 + 1)) / 3.71 - Math.Pow(2, x26_1);
            }
            else if (-0.5<=z26_1&&z26_1<=Math.Pow(-5, 10))
            {
                y26_1 = Math.Pow(3, Math.Sin(1)) * z26_1 - Math.Sin(z26_1 / 3 * Math.PI);
            }
            else if (z26_1>Math.Pow(-3, 10))
            {
                y26_1 = Math.Tan(z26_1 + x26_1) - Math.Pow(x26_1, e26_1) / 3.5 * x26_1;
            }
            double z26_2, y26_2;

            int x26_2 = new Random().Next(0, 5);
            int e26_2 = new Random().Next(0, 5);
          
            z26_2 = Math.Pow(3, Math.Acos(1)) * x26_2;
           
            if (z26_2 > -0.5)
            {
                y26_2 = Math.Pow(2, (2 * z26_2 + 1)) / 3.71 - Math.Pow(2, x26_2);
            }
            else if (-0.5 <= z26_2 && z26_2 <= Math.Pow(-5, 10))
            {
                y26_2 = Math.Pow(3, Math.Sin(1)) * z26_2 - Math.Sin(z26_2 / 3 * Math.PI);
            }
            else if (z26_2 > Math.Pow(-3, 10))
            {
                y26_2 = Math.Tan(z26_2 + x26_2) - Math.Pow(x26_2, e26_2) / 3.5 * x26_2;
            }
            double z26_3, y26_3;

            int x26_3 = new Random().Next(0, 5);
            int e26_3 = new Random().Next(0, 5);
            
            z26_3 = Math.Tan(x26_3);

            if (z26_3 > -0.5)
            {
                y26_3 = Math.Pow(2, (2 * z26_3 + 1)) / 3.71 - Math.Pow(2, x26_3);
            }
            else if (-0.5 <= z26_3 && z26_3 <= Math.Pow(-5, 10))
            {
                y26_3 = Math.Pow(3, Math.Sin(1)) * z26_3 - Math.Sin(z26_3 / 3 * Math.PI);
            }
            else if (z26_3 > Math.Pow(-3, 10))
            {
                y26_3 = Math.Tan(z26_3 + x26_3) - Math.Pow(x26_3, e26_3) / 3.5 * x26_3;
            }
            MessageBox.Show($"y26_1 = {z26_1}");
            MessageBox.Show($"y26_2 = {z26_2}");
            MessageBox.Show($"y26_1 = {z26_3}");
        }

        private void BtnTask27_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTask28_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTask29_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTask30_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}





