using System;

namespace Figure
{
    /// <summary>
    /// Класс описывающий шар
    /// </summary>
    public class Ball : FigureBase
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double _radius;

        /// <summary>
        /// Свойство Радиуса
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = Validation.MeasurementValidation(value);
            }
        }

        /// <summary>
        /// Свтойство объема и ее расчет
        /// </summary>
        public override double Volume
        {
            get
            {
                return (Math.Pow(_radius, 3) * Math.PI*4)/3;
            }
        }

        /// <summary>
        /// Конструктор Шар
        /// </summary>
        /// <param name="radius">радиус</param>
        public Ball(double radius)
        {
            Radius = radius;
        }
    }
}
