namespace LAB03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите вторую сторону: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите третью сторону: ");
            double c = double.Parse(Console.ReadLine());

            double P = a + b + c;
            Console.WriteLine($"Периметр: {P}");

            double p = P / 2;
            
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь: {S:F2}");
        }
    }
}
