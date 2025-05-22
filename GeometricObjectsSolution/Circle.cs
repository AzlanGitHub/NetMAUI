using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class Circle
    {
        //Objektvariablen
        // Cirle kreis;

        // kreis = new Circle();
        // Circle kreis = new Circle();
        // Circle kreis1, kreis2, kreis3;
        // Circle kreis1, kreis2, kreis3 = new Circle();
        private double _YCoordinate;
        public double YCoordinate
        {
            get { return _YCoordinate; }
            set { _YCoordinate = value; }
        }
        private double _XCoordinate;
        public double XCoordinate
        {
            get { return _XCoordinate; }
            set { _XCoordinate = value; }
        }
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Der Radius muss größer als 0 sein!");
                    
                }
                _Radius = value; 
            }
        }

        public double GetPerimeter()
        {
                       return 2 * Math.PI * Radius;
        }

        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        public Circle(double xCoordinate, double yCoordinate, double radius)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Radius = radius;
        }

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public  int Bigger(Circle kreis)
        {
            if(Radius > kreis.Radius)
                return 1;
            else if (Radius < kreis.Radius)
                return -1;
            else
                return 0;
        }

        public static int Compare(Circle kreis1, Circle kreis2)
        {
            if (kreis1.Radius > kreis2.Radius)
                return 1;
            else if (kreis1.Radius < kreis2.Radius)
                return -1;
            else
                return 0;
        }

        public static void Print()
        {
            Circle kreis = new Circle(0, 0, 5);
            Console.WriteLine($"Der Umfang des Kreises beträgt: {kreis.GetPerimeter()}");
            Console.WriteLine($"Die Fläche des Kreises beträgt: {kreis.GetArea()}");
            int height = 10;
            Console.WriteLine($"Das Volumen des Kreises beträgt: {kreis.GetArea()*height}");
            //Console.WriteLine(args[0]);
           // Console.WriteLine(args[1]);
        }
    }
}
