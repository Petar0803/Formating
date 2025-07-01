namespace Formating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            double[] doubles = { 1.237, 2.4876, 3.5, 4.01234 }; // Плаваща запетая, дробно число

            List<String> formatted = doubles.Select(
              d => string.Format("{0:F3}", d)
            ).ToList();

            formatted.ForEach(Console.WriteLine);

        }
    }
}