using System.Text;

namespace Лабораторна_робота__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b;
            try
            {
                Console.Write("Введіть першу сторону прямокутника: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введіть другу сторону прямокутника: ");
                b = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(a,b);
                rectangle.Print();
                if(rectangle.Correct())
                {
                    Console.WriteLine("S = " + rectangle.Area());
                    Console.WriteLine("P = " + rectangle.Perimeter());
                }
                else
                {
                    Console.WriteLine("Такого прямокутника не існує!");
                }
            }
            catch 
            {
                Console.WriteLine("Помилка!!!");
            }
        }
    }
    class Rectangle
    {
        private readonly double a, b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public bool Correct()
        {
            return (a > 0 && b > 0);
        }
        public double Area()
        {
            return a * b;
        }
        public double Perimeter()
        {
            return (a + b) * 2;
        }
        public void Print()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}