namespace Figure
{
    /// <summary>
    /// Класс описывающий пирамиду
    /// </summary>
    public class Pyrapid : FigureBase
    {
        /// <summary>
        /// Площадь основания пирамиды
        /// </summary>
        private double _pyramidBase;
        /// <summary>
        /// Высота
        /// </summary>
        private double _heigth;
        /// <summary>
        /// Свойство площади основания пирамиды
        /// </summary>
        public double PyramidBase
        {
            get
            {
                return _pyramidBase;
            }
            set
            {
                _pyramidBase = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свойство высоты пирамиды
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                _heigth = Validation.MeasurementValidation(value);
            }
        }
        /// <summary>
        /// Свойство объем и её расчет
        /// </summary>
        public override double Volume
        {
            get
            {
                return (_pyramidBase * _heigth) / 3;
            }
        }
        /// <summary>
        /// Конструктор пирамида
        /// </summary>
        /// <param name="pyramidBase">Площадь Основание пирамиды</param>
        /// <param name="heigth">Высота</param>
        public Pyrapid(double pyramidBase, double heigth)
        {
            Heigth = heigth;
            PyramidBase = pyramidBase;
        }
    }
}
