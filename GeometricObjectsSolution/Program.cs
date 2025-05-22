// See https://aka.ms/new-console-template for more information
using GeometricObjectsSolution;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        TestCircle();
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