using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру для расчёта площади:");
            Console.WriteLine("1. Круг");
            Console.WriteLine("2. Прямоугольник");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введите радиус: ");
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle();
                Console.WriteLine($"Площадь круга: {circle.CalculateArea(radius)}");
            }
            else if (choice == "2")
            {
                Console.Write("Введите ширину: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Введите высоту: ");
                double height = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle();
                Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea(width, height)}");
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
            }

        }
    }
}
