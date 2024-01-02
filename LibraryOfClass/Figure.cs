using System;


namespace LibraryOfClass
{

    /// <summary>
    /// Класс, служащий для создания объекта типа окружность.
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        private double radius;

        /// <summary>
        /// Переменная для хранения координат центра окружности.
        /// </summary>
        public Point center = new Point();

        /// <summary>
        /// Конструктор для создания пустой окружности.
        /// </summary>
        public Figure()
        {
            this.radius = 0;
            this.center.x = 0;
            this.center.y = 0;
        }

        /// <summary>
        /// Конструктор для создания окружности с известными радиусом и координатами.
        /// </summary>
        public Figure(double radius, Point center)
        {
            this.radius = radius;
            this.center = center;
        }

        /// <summary>
        /// Метод для нахождения площади круга.
        /// </summary>
        public void Square()
        {
            double square = 0;
            square = 3.14 * radius * radius;
            Console.WriteLine($"Площадь круга равна: {square}");
        }

        /// <summary>
        /// Метод для нахождения длины окружности круга.
        /// </summary>
        public void Perimeter()
        {
            double perimeter = 2 * 3.14 * radius;
            Console.WriteLine($"Периметр круга равен: {perimeter}");
        }

        /// <summary>
        /// Метод для проверки существования круга.
        /// </summary>
        public bool IsExist()
        {
            bool isExist = false;
            if (radius > 0)
            {
                isExist = true;
            }
            return isExist;
        }

        /// <summary>
        /// Метод для проверки принадлежности точки к оркужности.
        /// </summary>
        public void IsContain(Point A, Point B)
        {
            if (radius >= Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y)))
                Console.WriteLine("Точка принадлежит.\n");
            else Console.WriteLine("Точка не принадлежит.\n");
        }

    }
}
