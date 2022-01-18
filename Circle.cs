using System;

namespace DmitryKulik_MindBoxClassLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        /// <summary>
        /// Рассчитать площадь круга по радиусу
        /// </summary>
        /// <returns>Площадь круга в виде числа</returns>
        public double Area()
        {
            if (Radius < 0)
                throw new ArgumentException("Радиус должен быть больше нуля");
            
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}