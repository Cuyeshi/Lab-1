using System;
using System.Threading;
using LibraryOfClass;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread.Sleep(1000);
            Console.WriteLine("Приветствую!");
            Console.WriteLine("\nЛабораторная работа №1");
            Thread.Sleep(2000);
            Console.Clear();

            Figure figure = new Figure(); // Создание переменной типа Figure.
            Point point = new Point(); // Создание переменной типа Point.
            Point center = new Point();
            double radius;

            Console.Write("Введите x точки:");
            point.x = Program.ReadDouble();
            Console.Write("\nВведите y точки:");
            point.y = Program.ReadDouble();
            Console.Write("\nВведите радиус круга:");
            radius = Program.ReadDouble();
            Console.WriteLine("\n");

            figure = new Figure(radius, center); // Создание фигуры с заданными радиусом и координатами окружности

            if (figure.IsExist()) // Проверка на существование фигуры.
            {
                Console.Write("\nВведите x центра окружности:");
                center.x = Program.ReadDouble();
                Console.Write("\nВведите y центра окружности:");
                center.y = Program.ReadDouble();

                bool isRun = figure.IsExist();

                while (isRun) // Консольное меню.
                {
                    Console.WriteLine("\nВыберите действие:");
                    Console.WriteLine("1 - Найти площадь фигуры;");
                    Console.WriteLine("2 - Найти периметр фигуры;");
                    Console.WriteLine("3 - Проверить принадлежность точки к фигуре;");
                    Console.WriteLine("0 - Выход из программы;\n");
                    switch (Program.ReadDouble())
                    {
                        case 1:
                            Console.WriteLine("\n");
                            figure.Square();  // Метод вычисления площади фигуры.
                            break;

                        case 2:
                            Console.WriteLine("\n");
                            figure.Perimeter(); // Методы вычисления периметра фигуры.
                            break;

                        case 3:
                            Console.WriteLine("\n");
                            figure.IsContain(point, center); // Метод определения нахождения точки внутри и на границе фигуры.
                            break;

                        case 0:
                            isRun = false; // Выход из программы.
                            break;

                        default:
                            Console.WriteLine("Некорректный выбор функции!");
                            break;
                    }
                }
            }
            else Console.WriteLine("Невозможно создать круг, так как его радиус меньше или равен нулю.");

            Console.WriteLine("Программа окончена.");
            Console.ReadKey();
        }

        /// <summary> 
        /// Метод для проверки вводимых данных на корректность. 
        /// </summary> 
        /// <returns></returns> 
        public static double ReadDouble()
        {
            string numeral = Console.ReadLine();
            double value;
            while (!Double.TryParse(numeral, out value))
            {
                Console.WriteLine("\nВведённые данные не подходят. Введите корректное значение: ");
                numeral = Console.ReadLine();
            }
            return value;
        }
    }
}
