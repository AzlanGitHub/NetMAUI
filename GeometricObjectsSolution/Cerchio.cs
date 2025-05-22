using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    /// <summary> 
    /// Cerchio = Circle
    /// Represents a circle in a 2D coordinate system.
    /// </summary>
    public class Cerchio
    {
      
       
        #region  Konstructors
        public Cerchio() : this(0,0,0) { }
        public Cerchio(double x, double y, double raggio) 
        {
            XCoordinate = x;
            YCoordinate = y;
            Raggio = raggio;
        }
        public Cerchio(double raggio) : this(0, 0, raggio) { }
        #endregion

        #region Fields(Properties)
        private double _Raggio;
        public double Raggio
        {
            get { return _Raggio; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Der Radius darf nicht negativ sein.");
                }
                _Raggio = value;
            }
        }

        public double XCoordinate { get;  set; }
        public double YCoordinate { get; set; }
        #endregion

        #region methods
        public double Area()
        {
            return Math.PI * Math.Pow(Raggio, 2);
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Raggio;
        }
        public int Bigger(Cerchio cerchio)
        {
            if (Raggio > cerchio.Raggio)
            {
                return 1; 
            }
            else if (Raggio < cerchio.Raggio)
            {
                return -1;  
            }
            else
            {
                // both circles are equal in size
                return 0; 
               
            }
        }
        
        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }
        public void MoveTo(double x, double y, double raggio)
        {
            // raggio = radius
            XCoordinate = x;
            YCoordinate = y;
            Raggio = raggio;
        }
        public static double GetArea(double raggio)
        {
            return Math.PI * Math.Pow(raggio, 2);
        }
        public static double GetPerimeter(double raggio)
        {
            return 2 * Math.PI * raggio;
        }
        public static int Compare(Cerchio cerchio1, Cerchio cerchio2)
        {
            if (cerchio1.Raggio > cerchio2.Raggio)
                return 1; // cerchio1 is bigger
            else if (cerchio1.Raggio < cerchio2.Raggio)
            
                return -1; // cerchio2 is bigger
            else
                return 0; // both circles are equal in size
           
        }
        public static int Bigger(Cerchio cerchio1, Cerchio cerchio2)
        {
            return Compare(cerchio1, cerchio2);
        }


        #endregion




    }
}
