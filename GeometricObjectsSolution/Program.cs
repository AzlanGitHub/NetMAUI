// See https://aka.ms/new-console-template for more information
using GeometricObjectsSolution.geometric;
using GeometricObjectsSolution.fahrzeuge;
using static System.Console;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       // TestCircle();
        //TestCerchio();
        TestFahrzeug();
    }

    public static void TestFahrzeug()
    {
        // Testfälle für Luftfahrzeug und seine Unterklassen
        Luftfahrzeug flugzeug = new Flugzeug();
        
        flugzeug.Hersteller = "Airbus";
        flugzeug.Modell = "A320";
        flugzeug.Baujahr = 2010;
        flugzeug.Sitzplaetze = 180;

        ((Flugzeug)flugzeug).Spannweite = 35.8;
        ((Flugzeug)flugzeug).Hoechstgeschwindigkeit = 940;

        Luftfahrzeug hubschrauber = new Hubschrauber();
        hubschrauber.Hersteller = "Eurocopter";
        hubschrauber.Modell = "EC135";
        hubschrauber.Baujahr = 2005;
        hubschrauber.Sitzplaetze = 6;

        ((Hubschrauber)hubschrauber).RotorDurchmesser = 10.2;
        ((Hubschrauber)hubschrauber).Maximalgeschwindigkeit = 350;
       

        Luftfahrzeug drohne = new Drohne();
        drohne.Hersteller = "DJI";
        drohne.Modell = "Mavic Pro";
        drohne.Baujahr = 2018;
        drohne.Sitzplaetze = 0; 
        ((Drohne)drohne).MaximaleFlughöhe = 100; // in Metern
        ((Drohne)drohne).Flugzeit = 30; // in Minuten

        Luftfahrzeug segelmotor = new Motorsegler ();
        segelmotor.Hersteller = "Piper";
        segelmotor.Modell = "PA-28";
        segelmotor.Baujahr = 2015;
        segelmotor.Sitzplaetze = 4;
        ((Motorsegler)segelmotor).Spannweite = 11.4;
        ((Motorsegler)segelmotor).Hoechstgeschwindigkeit = 200;

        Luftfahrzeug segelflugzeugt = new Segelflugzeug();
        segelflugzeugt.Hersteller = "Grob";
        segelflugzeugt.Modell = "G-109";
        segelflugzeugt.Baujahr = 2012;

        List<Luftfahrzeug> fahrzeuge = new List<Luftfahrzeug>();
        fahrzeuge.Add(flugzeug);
        fahrzeuge.Add(hubschrauber);
        fahrzeuge.Add(drohne);
        fahrzeuge.Add(segelmotor);
        
        foreach (Luftfahrzeug luftfahrzeug in fahrzeuge)
        {
            luftfahrzeug.starten();
            luftfahrzeug.fliegen();
            luftfahrzeug.landen();
            DoSomething(luftfahrzeug);

        }

        // Konvertierung von Luftfahrzeug zu Flugzeug
        Luftfahrzeug luftflugzeug2 = new Flugzeug();
        Flugzeug flg1 = (Flugzeug)luftflugzeug2;
        Flugzeug flg2 = luftflugzeug2 as Flugzeug;
        Flugzeug flg3 = flg1;



    }

    public static void DoSomething(Luftfahrzeug lfzg)
    {
       if(lfzg != null)
        {
            if (lfzg is Flugzeug)
                Console.WriteLine($"Spannweite: {((Flugzeug)lfzg).Spannweite}");
            else if (lfzg is Hubschrauber)
                Console.WriteLine($"Rotor Durchmesser: {((Hubschrauber)lfzg).RotorDurchmesser}");
            else if (lfzg is Drohne)
                Console.WriteLine($"Maximale Flughöhe: {((Drohne)lfzg).MaximaleFlughöhe}");
            else if (lfzg is Motorsegler)
                Console.WriteLine($"Spannweite: {((Motorsegler)lfzg).Spannweite}");
            else if (lfzg is Segelflugzeug)
                Console.WriteLine($"Segelflugzeug: {lfzg.Modell}");
        }
        else
        {
            WriteLine("Das Luftfahrzeug ist null.");
        }
    }

    #region test circle
    private static void TestCircle()
    {
        Circle.Print();
        // Testfälle
        // vergleichen von Kreisen mit gleichem Radius
        Circle kreis1 = new Circle(0, 0, 10);
        Circle kreis2 = new Circle(0, 0, 10);

        //Console.WriteLine(kreis1.Equals(kreis2)); // true
        WriteLine($"kreis1.Radius == kreis2.Radius <=> {kreis1.Radius == kreis2.Radius}"); // true
        WriteLine($"kreis1.Bigger(kreis2) => {kreis1.Bigger(kreis2)}"); // 0 = false
        WriteLine($"kreis2.Bigger(kreis1) => {kreis2.Bigger(kreis1)}"); // 0 = false
        WriteLine($"kreis1.Radius.Equals(kreis2.Radius) => {kreis1.Radius.Equals(kreis2.Radius)}"); // true

        // vergleich von kreisen mit unterschiedlichem Radius
        Circle kreis3 = new Circle(0, 0, 20);
        Circle kreis4 = new Circle(0, 0, 40);

        WriteLine($"kreis4.Bigger(kreis3) => {kreis4.Bigger(kreis3)}"); // 1 = true
        WriteLine(kreis3.Bigger(kreis4)); // -1 = false
        WriteLine(kreis3.Radius == kreis4.Radius); // false
        WriteLine($"kreis3.Radius.Equals(kreis4.Radius => {kreis3.Radius.Equals(kreis4.Radius)}"); // false

        // Kreise mit gleichem Radius vergleichen mit der Compare-Methode

        WriteLine(Circle.Compare(kreis1, kreis2)); // 0 = false
        WriteLine(Circle.Compare(kreis3, kreis4)); // -1 = false

    }
    #endregion

    #region test Cerchio
    private static void TestCerchio()
    {
        //Cerchio = Circle = Kreis
        // Raggio = radius
        Cerchio cerchio1 = new Cerchio(0, 0, 10);
        Cerchio cerchio2 = new Cerchio(0, 0, 10);
        WriteLine($"cerchio1.Raggio == cerchio2.Raggio <=> {cerchio1.Raggio == cerchio2.Raggio}"); // true
        WriteLine($"cerchio1.Bigger(cerchio2) => {cerchio1.Bigger(cerchio2)}"); // 0 = false
        WriteLine($"cerchio2.Bigger(cerchio1) => {cerchio2.Bigger(cerchio1)}"); // 0 = false
        WriteLine($"cerchio1.Raggio.Equals(cerchio2.Raggio) => {cerchio1.Raggio.Equals(cerchio2.Raggio)}"); // true
        // vergleich von cerchi mit unterschiedlichem Raggio(it)=Radius(de)
        Cerchio cerchio3 = new Cerchio(0, 0, 20);
        Cerchio cerchio4 = new Cerchio(0, 0, 40);
        WriteLine($"cerchio4.Bigger(cerchio3) => {cerchio4.Bigger(cerchio3)}"); // 1 = true
        WriteLine(cerchio3.Bigger(cerchio4)); // -1 = false
        WriteLine(cerchio3.Raggio == cerchio4.Raggio); // false
        WriteLine($"cerchio3.Raggio.Equals(cerchio4.Raggio => {cerchio3.Raggio.Equals(cerchio4.Raggio)}"); // false
        // Kreise mit gleichem Radius vergleichen mit der Compare-Methode
        WriteLine(Cerchio.Compare(cerchio1, cerchio2)); // 0 = false
        WriteLine(Cerchio.Compare(cerchio3, cerchio4)); // -1 = false
    }
    #endregion
}