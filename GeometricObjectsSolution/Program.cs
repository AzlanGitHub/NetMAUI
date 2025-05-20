// See https://aka.ms/new-console-template for more information
using GeometricObjectsSolution;
using static System.Console;

Circle.Print();
// vergleichen von Kreisen mit gleichem Radius
Circle kreis1 = new Circle(0, 0, 10);
Circle kreis2 = new Circle(0, 0, 10);

//Console.WriteLine(kreis1.Equals(kreis2)); // true
Console.WriteLine(kreis1.Radius == kreis2.Radius); // true
Console.WriteLine(kreis1.Bigger(kreis2)); // 0 = false

// vergleich von kreisen mit unterschiedlichem Radius
Circle kreis3 = new Circle(0, 0, 20);
Circle kreis4 = new Circle(0, 0, 40);

WriteLine(kreis4.Bigger(kreis3)); // 1 = true
WriteLine(kreis3.Bigger(kreis4)); // -1 = false
WriteLine(kreis3.Radius == kreis4.Radius); // false
WriteLine(kreis3.Radius.Equals(kreis4.Radius)); // false
