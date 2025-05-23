using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution.fahrzeuge
{
    public abstract class Luftfahrzeug
    {
        public string Hersteller { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
        private int _Sitzplaetze;
        public int Sitzplaetze
        {
            get => _Sitzplaetze;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Die Anzahl der Sitzplätze darf nicht negativ sein.");
                }
                _Sitzplaetze = value;
            }
        }


        // virtual: kann in abgeleiteten Klassen überschrieben werden => polymorphie ==> virtual
        // virtual in abgeleiteten Klassen mit ' override ' überschreiben
        // new: erlaubt die Definition einer neuen Methode mit dem gleichen Namen in der abgeleiteten Klasse
        // new Methoden sind nicht polymoph 
        public virtual void starten()
        {
            Console.WriteLine("Das Luftfahrzeug startet.");
        }

        public abstract void fliegen();

        public virtual void landen()
        {
            Console.WriteLine("Das Luftfahrzeug landet.");
        }
    }
    public class Flugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; } = 1;
        public double Hoechstgeschwindigkeit { get; set; } = 0;

        public override void starten()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Das Flugzeug landet.");
        }

        public override void fliegen()
        {
            Console.WriteLine("Das Flugzeug fliegt...");
        }
    }
    public class Hubschrauber : Luftfahrzeug
    {
        public double RotorDurchmesser { get; set; }
        public double Maximalgeschwindigkeit { get; set; }


        public override void starten()
        {
            Console.WriteLine("Der Hubschrauber startet.");
        }
 

        public override void fliegen()
        {
            Console.WriteLine("Der Hubschrauber fliegt...");
        }

        public override void landen()
        {
            Console.WriteLine("Der Hubschrauber landet.");
        }
    }
    public class Segelflugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; }
        public double Gleitverhaeltnis { get; set; }
        public override void starten()
        {
            Console.WriteLine("Das Segelflugzeug startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Das Segelflugzeug landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Das Segelflugzeug fliegt...");
        }
    }
    public class Motorsegler : Luftfahrzeug
    {
        public double Motorleistung { get; set; }
        public double Spannweite { get; internal set; }
        public int Hoechstgeschwindigkeit { get; internal set; }

        public override void starten()
        {
            Console.WriteLine("Der Motorsegler startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Der Motorsegler landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Der Motorsegler fliegt...");
        }
    }

    public class Zeppelin : Luftfahrzeug
    {
        public double Volumen { get; set; }
        public double Tragflaeche { get; set; }
        public override void starten()
        {
            Console.WriteLine("Der Zeppelin startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Der Zeppelin landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Der Zeppelin fliegt...");
        }
    }

    public class Drohne : Luftfahrzeug
    {
        public double Reichweite { get; set; }
        public double Traglast { get; set; }
        public int MaximaleFlughöhe { get; internal set; }
        public int Flugzeit { get; internal set; }

        public override void starten()
        {
            Console.WriteLine("Die Drohne startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Die Drohne landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Die Drohne fliegt...");
        }


    }
    
    public class Heißluftballon : Luftfahrzeug
    {
        public double Volumen { get; set; }
        public double Tragflaeche { get; set; }
        public override void starten()
        {
            Console.WriteLine("Der Heißluftballon startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Der Heißluftballon landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Der Heißluftballon fliegt...");
        }


    }

    public class Luftschiff : Luftfahrzeug
    {
        public double Volumen { get; set; }
        public double Tragflaeche { get; set; }
        public override void starten()
        {
            Console.WriteLine("Das Luftschiff startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Das Luftschiff landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Das Luftschiff fliegt...");
        }
    }

    public class Ultraleichtflugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; }
        public double Maximalgeschwindigkeit { get; set; }
        public new void starten()
        {
            Console.WriteLine("Das Ultraleichtflugzeug startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Das Ultraleichtflugzeug landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Das Ultraleichtflugzeug fliegt...");
        }
    }

    public class Wasserflugzeug : Luftfahrzeug
    {
        public double Tragflaeche { get; set; }
        public double Maximalgeschwindigkeit { get; set; }
        public new void starten()
        {
            Console.WriteLine("Das Wasserflugzeug startet.");
        }
        public override void landen()
        {
            Console.WriteLine("Das Wasserflugzeug landet.");
        }
        public override void fliegen()
        {
            Console.WriteLine("Das Wasserflugzeug fliegt...");
        }

        public class Kampfjet : Luftfahrzeug
        {
            public double Maximalgeschwindigkeit { get; set; }
            public double Bewaffnung { get; set; }            
            public double Maxhöhe { get; set; }



            public override void starten()
            {
                Console.WriteLine("Der Kampfjet startet.");
            }


            public override void fliegen()
            {
                Console.WriteLine("Der Kampfjet fliegt...");
            }
        }

    }



}