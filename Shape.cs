namespace DmitryKulik_MindBoxClassLibrary
{
    /// <summary>
    /// Интерфейс для работы с геометрическими фигурами
    /// </summary>
    public interface Shape
    {
        /// <summary>
        /// Посчитать площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры в виде числа</returns>
        double Area();
    }
}