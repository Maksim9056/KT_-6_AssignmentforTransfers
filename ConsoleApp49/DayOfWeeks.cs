using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class DayOfWeeks
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public  void PrintDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Некорректный день недели");
                    break;
            }
        }



            public  void Неделя(int d)
            {
                switch (d)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        DayOfWeek Monday = DayOfWeek.Monday;
                        PrintDayOfWeek(Monday);

                        break;
                    case 2:
                        Console.WriteLine("Вторник");
                        DayOfWeek Tuesday = DayOfWeek.Tuesday;

                        PrintDayOfWeek(Tuesday);

                        break;
                    case 3:
                        Console.WriteLine("Среда");
                        DayOfWeek Wednesday = DayOfWeek.Wednesday;

                        PrintDayOfWeek(Wednesday);

                        break;
                    case 4:
                        DayOfWeek Thursday = DayOfWeek.Thursday;
                        PrintDayOfWeek(Thursday);

                        Console.WriteLine("Четверг");
                        break;
                    case 5:
                        DayOfWeek Friday = DayOfWeek.Friday;

                        Console.WriteLine("Пятница");
                        PrintDayOfWeek(Friday);

                        break;
                    case 6:
                        DayOfWeek Saturday = DayOfWeek.Saturday;
                        PrintDayOfWeek(Saturday);

                        Console.WriteLine("Суббота");

                        break;
                    case 7:
                        DayOfWeek Sunday = DayOfWeek.Sunday;

                        PrintDayOfWeek(Sunday);

                        break;
                    default:

                        Console.WriteLine("Некорректный день недели");
                        break;
                }
            }

        /// <summary>
        ///Выводит в консоль информацию  Дни недели 
        /// </summary>
        public  void Print()
        {
            Console.WriteLine("Понедельник = 1");
            Console.WriteLine("Вторник =2");
            Console.WriteLine("Среда =3 ");
            Console.WriteLine("Четверг=4");
            Console.WriteLine("Пятница =5");
            Console.WriteLine("Суббота =6");
            Console.WriteLine("Воскресенье =7");
        }

    }
}
