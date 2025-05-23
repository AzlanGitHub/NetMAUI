using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution.geometric
{
    public class GraphicCircle : Circle
    {
        // x = XCoordinate 
        // y = YCoordinate
        // r = Radius
        // Konstruktorverkettung in der Verbung.
        // base(x, y, r) ruft den Konstruktor der Basisklasse auf und übergibt die Parameter x, y und r weiter.
        
        public GraphicCircle() : base(0,0,0) { }
        public GraphicCircle(double r) : base(0, 0, r) { }
        public GraphicCircle(double x, double y, double r) : base(x, y, r)
        {
             
        }
    }
}
