namespace New_5_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для рассчета факториала (до 27 включительно): ");
            var num = decimal.Parse(Console.ReadLine());
            var num2 = num;
            Factorial(num);
            Console.WriteLine("Факториал числа {0}: {1}", num2,Factorial(num));
            Console.ReadKey();
        }
        static decimal Factorial(decimal x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        
    }
}