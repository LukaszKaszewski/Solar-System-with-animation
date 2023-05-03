using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Laby_05_solar_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread watek;
        Graphics grafika1;
        Graphics fG;
        Bitmap btm;

        bool rysunek = true;

        // orbit radius
        float rad1 = 5.7909f;
        float rad2 = 10.8209f;
        float rad3 = 14.9598f;
        float rad4 = 22.7937f;
        float rad5 = 77.8412f;
        float rad6 = 142.6725f;
        float rad7 = 287.0972f;
        float rad8 = 449.8253f;

        private void Form1_Load(object sender, EventArgs e)
        {
            btm = new Bitmap(1920, 1080);
            grafika1 = Graphics.FromImage(btm);
            fG = CreateGraphics();
            watek = new Thread(Draw);
            watek.IsBackground = true;
            watek.Start();
        }

        public void Draw()
        {
            // movement of the entire model along the X axis
            int moveX = 400;

            // Sun
            Pen sun_pen = new Pen(Brushes.Yellow, 2);

            // location, size, center of all simulation
            RectangleF sun_area = new RectangleF(950 + moveX, 530, 5, 5);

            float angle1 = 0.0f;
            float angle2 = 0.0f;
            float angle3 = 0.0f;
            float angle4 = 0.0f;
            float angle5 = 0.0f;
            float angle6 = 0.0f;
            float angle7 = 0.0f;
            float angle8 = 0.0f;

            float sunPosX = 952.5f + moveX;
            float sunPosY = 532.5f;

            // center of the planets
            PointF org1 = new PointF(rad1, rad1);
            PointF org2 = new PointF(rad2, rad2);
            PointF org3 = new PointF(rad3, rad3);
            PointF org4 = new PointF(rad4, rad4);
            PointF org5 = new PointF(rad5, rad5);
            PointF org6 = new PointF(rad6, rad6);
            PointF org7 = new PointF(rad7, rad7);
            PointF org8 = new PointF(rad8, rad8);

            float position1x = sunPosX - rad1;
            float position1y = sunPosY - rad1;
            float position2x = sunPosX - rad2;
            float position2y = sunPosY - rad2;
            float position3x = sunPosX - rad3;
            float position3y = sunPosY - rad3;
            float position4x = sunPosX - rad4;
            float position4y = sunPosY - rad4;
            float position5x = sunPosX - rad5;
            float position5y = sunPosY - rad5;
            float position6x = sunPosX - rad6;
            float position6y = sunPosY - rad6;
            float position7x = sunPosX - rad7;
            float position7y = sunPosY - rad7;
            float position8x = sunPosX - rad8;
            float position8y = sunPosY - rad8;

            // planet color
            Pen pen1 = new Pen(Brushes.SkyBlue, 1.0f);
            Pen pen2 = new Pen(Brushes.DarkSalmon, 1.0f);
            Pen pen3 = new Pen(Brushes.Gainsboro, 1.0f);
            Pen pen4 = new Pen(Brushes.GreenYellow, 1.0f);
            Pen pen5 = new Pen(Brushes.Azure, 1.0f);
            Pen pen6 = new Pen(Brushes.MediumVioletRed, 1.0f);
            Pen pen7 = new Pen(Brushes.AliceBlue, 1.0f);
            Pen pen8 = new Pen(Brushes.DarkSeaGreen, 1.0f);

            // orbit
            RectangleF area1 = new RectangleF(position1x, position1y, rad1 * 2, rad1 * 2);
            RectangleF area2 = new RectangleF(position2x, position2y, rad2 * 2, rad2 * 2);
            RectangleF area3 = new RectangleF(position3x, position3y, rad3 * 2, rad3 * 2);
            RectangleF area4 = new RectangleF(position4x, position4y, rad4 * 2, rad4 * 2);
            RectangleF area5 = new RectangleF(position5x, position5y, rad5 * 2, rad5 * 2);
            RectangleF area6 = new RectangleF(position6x, position6y, rad6 * 2, rad6 * 2);
            RectangleF area7 = new RectangleF(position7x, position7y, rad7 * 2, rad7 * 2);
            RectangleF area8 = new RectangleF(position8x, position8y, rad8 * 2, rad8 * 2);

            // an attempt to show the differences in the size of the planets, but not enough space
            /*RectangleF circle1 = new RectangleF(0, 0, 0.48f, 0.48f); // rozmiar malego kola
            RectangleF circle2 = new RectangleF(0, 0, 1.21f, 1.21f);
            RectangleF circle3 = new RectangleF(0, 0, 1.28f, 1.28f);
            RectangleF circle4 = new RectangleF(0, 0, 0.68f, 0.68f);
            RectangleF circle5 = new RectangleF(0, 0, 14.2f, 14.2f);
            RectangleF circle6 = new RectangleF(0, 0, 12, 12);
            RectangleF circle7 = new RectangleF(0, 0, 5.1f, 5.1f);
            RectangleF circle8 = new RectangleF(0, 0, 4.9f, 4.9f);*/

            // planet size - all
            int planetSize = 6;
            RectangleF circle1 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle2 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle3 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle4 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle5 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle6 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle7 = new RectangleF(0, 0, planetSize, planetSize);
            RectangleF circle8 = new RectangleF(0, 0, planetSize, planetSize);

            PointF loc1 = PointF.Empty;
            PointF loc2 = PointF.Empty;
            PointF loc3 = PointF.Empty;
            PointF loc4 = PointF.Empty;
            PointF loc5 = PointF.Empty;
            PointF loc6 = PointF.Empty;
            PointF loc7 = PointF.Empty;
            PointF loc8 = PointF.Empty;
            PointF img = new PointF(0, 0);

            fG.Clear(Color.Black);

            while (rysunek)
            {
                grafika1.Clear(Color.DarkBlue);

                // big circle, orbit
                grafika1.DrawEllipse(sun_pen, sun_area);
                grafika1.DrawEllipse(pen1, area1);
                grafika1.DrawEllipse(pen2, area2);
                grafika1.DrawEllipse(pen3, area3);
                grafika1.DrawEllipse(pen4, area4);
                grafika1.DrawEllipse(pen5, area5);
                grafika1.DrawEllipse(pen6, area6);
                grafika1.DrawEllipse(pen7, area7);
                grafika1.DrawEllipse(pen8, area8);
                loc1 = CirclePoint(rad1, angle1, org1);
                loc2 = CirclePoint(rad2, angle2, org2);
                loc3 = CirclePoint(rad3, angle3, org3);
                loc4 = CirclePoint(rad4, angle4, org4);
                loc5 = CirclePoint(rad5, angle5, org5);
                loc6 = CirclePoint(rad6, angle6, org6);
                loc7 = CirclePoint(rad7, angle7, org7);
                loc8 = CirclePoint(rad8, angle8, org8);

                circle1.X = loc1.X - (circle1.Width / 2) + area1.X;
                circle1.Y = loc1.Y - (circle1.Height / 2) + area1.Y;
                circle2.X = loc2.X - (circle2.Width / 2) + area2.X;
                circle2.Y = loc2.Y - (circle2.Height / 2) + area2.Y;
                circle3.X = loc3.X - (circle3.Width / 2) + area3.X;
                circle3.Y = loc3.Y - (circle3.Height / 2) + area3.Y;
                circle4.X = loc4.X - (circle4.Width / 2) + area4.X;
                circle4.Y = loc4.Y - (circle4.Height / 2) + area4.Y;
                circle5.X = loc5.X - (circle5.Width / 2) + area5.X;
                circle5.Y = loc5.Y - (circle5.Height / 2) + area5.Y;
                circle6.X = loc6.X - (circle6.Width / 2) + area6.X;
                circle6.Y = loc6.Y - (circle6.Height / 2) + area6.Y;
                circle7.X = loc7.X - (circle7.Width / 2) + area7.X;
                circle7.Y = loc7.Y - (circle7.Height / 2) + area7.Y;
                circle8.X = loc8.X - (circle8.Width / 2) + area8.X;
                circle8.Y = loc8.Y - (circle8.Height / 2) + area8.Y;

                // a rectangle bounded by a pair of coordinates
                grafika1.DrawEllipse(pen1, circle1);
                grafika1.DrawEllipse(pen2, circle2);
                grafika1.DrawEllipse(pen3, circle3);
                grafika1.DrawEllipse(pen4, circle4);
                grafika1.DrawEllipse(pen5, circle5);
                grafika1.DrawEllipse(pen6, circle6);
                grafika1.DrawEllipse(pen7, circle7);
                grafika1.DrawEllipse(pen8, circle8);
                fG.DrawImage(btm, img);

                // the change in the speed of all the planets relative to each other
                int planetspeed = 25;

                if (angle1 < 360)
                {
                    angle1 += planetspeed / 0.88f;
                }
                else
                {
                    angle1 = 0;
                }

                if (angle2 < 360)
                {
                    angle2 += planetspeed / 2.25f;
                }
                else
                {
                    angle2 = 0;
                }

                if (angle3 < 360)
                {
                    angle3 += planetspeed / 3.65f;
                }
                else
                {
                    angle3 = 0;
                }

                if (angle4 < 360)
                {
                    angle4 += planetspeed / 6.87f;
                }
                else
                {
                    angle4 = 0;
                }

                if (angle5 < 360)
                {
                    angle5 += planetspeed / 43.33f;
                }
                else
                {
                    angle5 = 0;
                }

                if (angle6 < 360)
                {
                    angle6 += planetspeed / 107.56f;
                }
                else
                {
                    angle6 = 0;
                }

                if (angle7 < 360)
                {
                    angle7 += planetspeed / 307.07f;
                }
                else
                {
                    angle7 = 0;
                }

                if (angle8 < 360)
                {
                    angle8 += planetspeed / 602.23f;
                }
                else
                {
                    angle8 = 0;
                }
            }

        }

        public PointF CirclePoint(float radius, float angleInDegrees, PointF origin)
        {
            float x = (float)(radius * Math.Cos(angleInDegrees * Math.PI / 180F)) + origin.X;
            float y = (float)(radius * Math.Sin(angleInDegrees * Math.PI / 180F)) + origin.Y;

            return new PointF(x, y);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        // chart - distance
        private void Chart1_Click(object sender, EventArgs e)
        {
            SolarSystem.Series["[km]"].Points.Add(rad1 * 10000000);
            SolarSystem.Series["[km]"].Points[0].Color = Color.SkyBlue;
            SolarSystem.Series["[km]"].Points[0].AxisLabel = "Mercury";

            SolarSystem.Series["[km]"].Points.Add(rad2 * 10000000);
            SolarSystem.Series["[km]"].Points[1].Color = Color.DarkSalmon;
            SolarSystem.Series["[km]"].Points[1].AxisLabel = "Venus";

            SolarSystem.Series["[km]"].Points.Add(rad3 * 10000000);
            SolarSystem.Series["[km]"].Points[2].Color = Color.Gainsboro;
            SolarSystem.Series["[km]"].Points[2].AxisLabel = "Earth";

            SolarSystem.Series["[km]"].Points.Add(rad4 * 10000000);
            SolarSystem.Series["[km]"].Points[3].Color = Color.GreenYellow;
            SolarSystem.Series["[km]"].Points[3].AxisLabel = "Mars";

            SolarSystem.Series["[km]"].Points.Add(rad5 * 10000000);
            SolarSystem.Series["[km]"].Points[4].Color = Color.Azure;
            SolarSystem.Series["[km]"].Points[4].AxisLabel = "Jupiter";

            SolarSystem.Series["[km]"].Points.Add(rad6 * 10000000);
            SolarSystem.Series["[km]"].Points[5].Color = Color.MediumVioletRed;
            SolarSystem.Series["[km]"].Points[5].AxisLabel = "Saturn";

            SolarSystem.Series["[km]"].Points.Add(rad7 * 10000000);
            SolarSystem.Series["[km]"].Points[6].Color = Color.AliceBlue;
            SolarSystem.Series["[km]"].Points[6].AxisLabel = "Uran";

            SolarSystem.Series["[km]"].Points.Add(rad8 * 10000000);
            SolarSystem.Series["[km]"].Points[7].Color = Color.DarkSeaGreen;
            SolarSystem.Series["[km]"].Points[7].AxisLabel = "Neptune";
        }

        // chart - days
        private void chart1_Click_1(object sender, EventArgs e)
        {
            SolarDays.Series["[days]"].Points.Add(87.96f);
            SolarDays.Series["[days]"].Points[0].Color = Color.SkyBlue;
            SolarDays.Series["[days]"].Points[0].AxisLabel = "Mercury";

            SolarDays.Series["[days]"].Points.Add(224.7f);
            SolarDays.Series["[days]"].Points[1].Color = Color.DarkSalmon;
            SolarDays.Series["[days]"].Points[1].AxisLabel = "Venus";

            SolarDays.Series["[days]"].Points.Add(365.25f);
            SolarDays.Series["[days]"].Points[2].Color = Color.Gainsboro;
            SolarDays.Series["[days]"].Points[2].AxisLabel = "Earth";

            SolarDays.Series["[days]"].Points.Add(686.96f);
            SolarDays.Series["[days]"].Points[3].Color = Color.GreenYellow;
            SolarDays.Series["[days]"].Points[3].AxisLabel = "Mars";

            SolarDays.Series["[days]"].Points.Add(4333.28f);
            SolarDays.Series["[days]"].Points[4].Color = Color.Azure;
            SolarDays.Series["[days]"].Points[4].AxisLabel = "Jupiter";

            SolarDays.Series["[days]"].Points.Add(10756.2f);
            SolarDays.Series["[days]"].Points[5].Color = Color.MediumVioletRed;
            SolarDays.Series["[days]"].Points[5].AxisLabel = "Saturn";

            SolarDays.Series["[days]"].Points.Add(30707.49f);
            SolarDays.Series["[days]"].Points[6].Color = Color.AliceBlue;
            SolarDays.Series["[days]"].Points[6].AxisLabel = "Uran";

            SolarDays.Series["[days]"].Points.Add(60223.35f);
            SolarDays.Series["[days]"].Points[7].Color = Color.DarkSeaGreen;
            SolarDays.Series["[days]"].Points[7].AxisLabel = "Neptune";
        }
    }
}
