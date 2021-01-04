using System;
using System.Collections.Generic;
using System.Drawing;

namespace GraphColoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Side> side = new List<Side>();
            List<Point> points = new List<Point>();

            points.Add(new Point("RR"));
            points.Add(new Point("AM"));
            points.Add(new Point("AC"));
            points.Add(new Point("RO"));
            points.Add(new Point("AP"));
            points.Add(new Point("PA"));
            points.Add(new Point("MA"));
            points.Add(new Point("TO"));
            points.Add(new Point("PI"));
            points.Add(new Point("CE"));
            points.Add(new Point("RN"));
            points.Add(new Point("PB"));
            points.Add(new Point("PE"));
            points.Add(new Point("AL"));
            points.Add(new Point("SE"));
            points.Add(new Point("BA"));
            points.Add(new Point("MT"));
            points.Add(new Point("GO"));
            points.Add(new Point("MS"));
            points.Add(new Point("MG"));
            points.Add(new Point("ES"));
            points.Add(new Point("RJ"));
            points.Add(new Point("SP"));
            points.Add(new Point("PR"));
            points.Add(new Point("SC"));
            points.Add(new Point("RS"));

            side.Add(new Side(points.Find(x => x.Name == "RR"), points.Find(x => x.Name == "PA")));
            side.Add(new Side(points.Find(x => x.Name == "RR"), points.Find(x => x.Name == "AM")));
            side.Add(new Side(points.Find(x => x.Name == "AP"), points.Find(x => x.Name == "PA")));
            side.Add(new Side(points.Find(x => x.Name == "AC"), points.Find(x => x.Name == "AM")));
            side.Add(new Side(points.Find(x => x.Name == "AC"), points.Find(x => x.Name == "RO")));
            side.Add(new Side(points.Find(x => x.Name == "AM"), points.Find(x => x.Name == "RO")));
            side.Add(new Side(points.Find(x => x.Name == "AM"), points.Find(x => x.Name == "PA")));
            side.Add(new Side(points.Find(x => x.Name == "AM"), points.Find(x => x.Name == "MT")));
            side.Add(new Side(points.Find(x => x.Name == "RO"), points.Find(x => x.Name == "MT")));
            side.Add(new Side(points.Find(x => x.Name == "MT"), points.Find(x => x.Name == "PA")));
            side.Add(new Side(points.Find(x => x.Name == "TO"), points.Find(x => x.Name == "PA")));
            side.Add(new Side(points.Find(x => x.Name == "MT"), points.Find(x => x.Name == "TO")));
            side.Add(new Side(points.Find(x => x.Name == "MA"), points.Find(x => x.Name == "PA")));
            side.Add(new Side(points.Find(x => x.Name == "PI"), points.Find(x => x.Name == "MA")));
            side.Add(new Side(points.Find(x => x.Name == "MA"), points.Find(x => x.Name == "TO")));
            side.Add(new Side(points.Find(x => x.Name == "PI"), points.Find(x => x.Name == "TO")));
            side.Add(new Side(points.Find(x => x.Name == "TO"), points.Find(x => x.Name == "GO")));
            side.Add(new Side(points.Find(x => x.Name == "TO"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "PI"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "PE"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "AL"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "SE"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "GO"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "MG"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "ES"), points.Find(x => x.Name == "BA")));
            side.Add(new Side(points.Find(x => x.Name == "PI"), points.Find(x => x.Name == "CE")));
            side.Add(new Side(points.Find(x => x.Name == "CE"), points.Find(x => x.Name == "RN")));
            side.Add(new Side(points.Find(x => x.Name == "CE"), points.Find(x => x.Name == "PB")));
            side.Add(new Side(points.Find(x => x.Name == "RN"), points.Find(x => x.Name == "PB")));
            side.Add(new Side(points.Find(x => x.Name == "CE"), points.Find(x => x.Name == "PE")));
            side.Add(new Side(points.Find(x => x.Name == "PI"), points.Find(x => x.Name == "PE")));
            side.Add(new Side(points.Find(x => x.Name == "PE"), points.Find(x => x.Name == "AL")));
            side.Add(new Side(points.Find(x => x.Name == "PE"), points.Find(x => x.Name == "PB")));
            side.Add(new Side(points.Find(x => x.Name == "AL"), points.Find(x => x.Name == "SE")));
            side.Add(new Side(points.Find(x => x.Name == "MT"), points.Find(x => x.Name == "GO")));
            side.Add(new Side(points.Find(x => x.Name == "MT"), points.Find(x => x.Name == "MS")));
            side.Add(new Side(points.Find(x => x.Name == "GO"), points.Find(x => x.Name == "MS")));
            side.Add(new Side(points.Find(x => x.Name == "GO"), points.Find(x => x.Name == "MG")));
            side.Add(new Side(points.Find(x => x.Name == "MS"), points.Find(x => x.Name == "MG")));
            side.Add(new Side(points.Find(x => x.Name == "SP"), points.Find(x => x.Name == "MG")));
            side.Add(new Side(points.Find(x => x.Name == "RJ"), points.Find(x => x.Name == "MG")));
            side.Add(new Side(points.Find(x => x.Name == "ES"), points.Find(x => x.Name == "MG")));
            side.Add(new Side(points.Find(x => x.Name == "ES"), points.Find(x => x.Name == "RJ")));
            side.Add(new Side(points.Find(x => x.Name == "RJ"), points.Find(x => x.Name == "SP")));
            side.Add(new Side(points.Find(x => x.Name == "MS"), points.Find(x => x.Name == "SP")));
            side.Add(new Side(points.Find(x => x.Name == "MS"), points.Find(x => x.Name == "PR")));
            side.Add(new Side(points.Find(x => x.Name == "SP"), points.Find(x => x.Name == "PR")));
            side.Add(new Side(points.Find(x => x.Name == "PR"), points.Find(x => x.Name == "SC")));
            side.Add(new Side(points.Find(x => x.Name == "SC"), points.Find(x => x.Name == "RS")));

            List<Point> pointsSorted = new List<Point>(points);
            List<Color> colors = new List<Color>();
            colors.Add(Color.Crimson);
            colors.Add(Color.Cyan);
            colors.Add(Color.LightGreen);
            colors.Add(Color.Yellow);
            colors.Add(Color.Fuchsia);
            colors.Add(Color.Brown);
            colors.Add(Color.Coral);
            colors.Add(Color.ForestGreen);
            colors.Add(Color.BlueViolet);
            colors.Add(Color.Lavender);
            colors.Add(Color.White);

            foreach (Point point in pointsSorted)
            {
                point.Grau = side.FindAll(x => (x.Point1 == point) || (x.Point2 == point)).Count;
                point.C = Color.White;
            }
            
            pointsSorted.Sort((point1, point2) => point2.Grau.CompareTo(point1.Grau));
            
            int indexColor = 0;
            Point firstPoint = null;
            bool finish = false;
            while (!finish)
            {
                finish = true;

                firstPoint = null;

                foreach (Point point in pointsSorted)
                {

                    if (point.C == Color.White)
                    {
                        if (firstPoint == null)
                        {
                            point.C = colors[indexColor];
                            firstPoint = point;
                        }
                        else
                        {
                            Side ar1 = side.Find(x => (x.Point1 == point) && (x.Point2.C == firstPoint.C));
                            Side ar2 = side.Find(x => (x.Point1.C == firstPoint.C) && (x.Point2 == point));
                            if ((ar1 == null) && (ar2 == null))
                            {
                                point.C = colors[indexColor];
                            }
                            else
                            {
                                finish = false;
                            }
                        }
                    }
                }
                if (indexColor < 10)
                {
                    indexColor++;
                }
                else
                {
                    indexColor = 10;
                    finish = true;
                }
            }
            foreach (var k in pointsSorted)
            {
                Console.WriteLine(k.Name+" "+k.C+" "+k.Grau);
            }
            foreach (var k in side)
            {
                Console.WriteLine(k);
            }
        }
    }
}
