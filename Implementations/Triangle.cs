using System;
using DmitryKulik_MindBoxClassLibrary.Interfaces;

namespace DmitryKulik_MindBoxClassLibrary.Implementations
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        
        /// <summary>
        /// Рассчитать площадь треугольника по трём сторонам с помощью формулы Герона
        /// </summary>
        /// <returns>Площадь треугольника в виде числа</returns>
        public double Area()
        {
            if (A < 0 || B < 0 || C < 0)
                throw new ArgumentException("Длина стороны не может быть меньше нуля");
            
            // Периметр треугольника
            var perimetr = (A + B + C) / 2;
            
            return Math.Sqrt(perimetr * (perimetr - A) * (perimetr - B) * (perimetr - C));
        }

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным по теореме Пифагора
        /// </summary>
        /// <returns>true - треугольник прямоугольный, false - треугольник не прямоугольный</returns>
        /// <remarks>Так как не факт, что стороны A, B, C будут заданы именно как стороны A, B, C,
        /// то необходимо проверять по теореме Пифагора так, чтобы учесть, что каждая сторона может быть
        /// не под своим именем</remarks>
        public bool IsRectangular()
        {
            if (A < 0 || B < 0 || C < 0)
                throw new ArgumentException("Длина стороны не может быть меньше нуля");
            
            if (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
                return true;
            if (Math.Pow(A, 2) == Math.Pow(C, 2) + Math.Pow(B, 2))
                return true;
            return Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
        }
    }
}