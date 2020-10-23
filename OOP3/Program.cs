using System;
using System.Text;
using Figure;

namespace OOP3
{
    /// <summary>
    /// Основной класс программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Тестирование программы
        /// </summary>
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Расчет объема фигуры");
            Console.WriteLine("\nВыберите тип фигуры:\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("1 - Пирамида;");
                    Console.WriteLine("2 - Параллелепипед;");
                    Console.WriteLine("3 - Шар;");
                    Console.WriteLine("4 - Выход");
                    var keyMenu = Console.ReadLine();
                    switch (keyMenu)
                    {
                        case "1":
                        {
                            GetInfo(new Pyrapid
                                (GetCorrectDouble("Введите площадь основания:"),
                                GetCorrectDouble("Введите высоту пирамиды:")));
                            break;
                        }
                        case "2":
                        {
                            GetInfo(new Parallelepiped(GetCorrectDouble("Введите высоту параллелепипеда:"), 
                                GetCorrectDouble("Введите ширину " +
                                    "параллелепипеда:"), GetCorrectDouble("Введите длину параллелепипеда")));
                            break;
                        }
                        case "3":
                        {
                            GetInfo(new Ball
                                (GetCorrectDouble("Радиус шара:")));
                            break;
                        }
                        case "4":
                        {
                            Environment.Exit(0);
                            break;
                        }
                        default:
                            Console.WriteLine("Ошибка! " +
                                "Команда не существует.");
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        /// <summary>
        /// Проверка на наличие букв
        /// </summary>
        /// /// <returns>Проверенное введенное измерение</returns>
        private static double GetCorrectDouble(string message)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    return Validation.MeasurementValidation
                        (Convert.ToDouble(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Ошибка!" +
                        " Введите положительное число.");
                }
            }
        }

        /// <summary>
        /// Вывод рассчитанной площади в консоль
        /// </summary>
        private static void GetInfo(FigureBase figureBase)
        {
            Console.WriteLine($"Объем фигуры = {figureBase.Volume}\n");
        }
    }
}
