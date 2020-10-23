namespace Figure
{
    /// <summary>
    /// Класс описывающий параллелепипед
    /// </summary>
    public class Parallelepiped : FigureBase
    {
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;
        /// <summary>
        /// Длина
        /// </summary>
        private double _length;
        /// <summary>
        /// Высота
        /// </summary>
        private double _height;
        /// <summary>
        /// Свойство Ширины
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свтойство Длины
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свойство Высоты
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свтойство площади и ее расчет
        /// </summary>
        public override double Volume
        {
            get
            {
                return _width * _length*_height;
            }
        }
        /// <summary>
        /// Конструктор Параллелепипеда
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длина</param>
        /// <param name="height">Высота</param>
        public Parallelepiped(double width, double length, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}
