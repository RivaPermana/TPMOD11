using AljabarLibraries2;
class Program
{
    public static void Main(string[] args)
    {
        AkarPersaKuad akarPersamaanKuadrat = new AkarPersaKuad();
        Console.WriteLine("Input  : {1, -3, -10}");

        akarPersamaanKuadrat.SolveQuadraticEquation(1, -3, -10);
        Console.WriteLine("");
        Console.WriteLine("Input  : {2, -3}");
        Hasilkuadrat hasilkuadrat = new Hasilkuadrat();

        hasilkuadrat.olahHasilKuadrat(2, -3);
    }
}