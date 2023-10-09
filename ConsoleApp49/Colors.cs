using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Colors
    {
        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Cyan,
            Magenta
        }

        public  string GetColorHexCode(Color color)
        {
            switch (color)
            {
                case Color.Red:
                    return "#FF0000";
                case Color.Green:
                    return "#00FF00";
                case Color.Blue:
                    return "#0000FF";
                case Color.Yellow:
                    return "#FFFF00";
                case Color.Cyan:
                    return "#00FFFF";
                case Color.Magenta:
                    return "#FF00FF";
                default:
                    return "Некорректный цвет";
            }
        }


        public  void Colorss(int d)
        {

            Color color;
            switch (d)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    color = Color.Red;
                    var Color1 = GetColorHexCode(color);
                    Console.WriteLine(Color1);
                    Console.ForegroundColor = ConsoleColor.Gray;

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;

                    color = Color.Green;

                    var Color2 = GetColorHexCode(color);
                    Console.WriteLine(Color2);

                    Console.ForegroundColor = ConsoleColor.Gray;

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;

                    color = Color.Blue;


                    var Color3 = GetColorHexCode(color);
                    Console.WriteLine(Color3);

                    Console.ForegroundColor = ConsoleColor.Gray;

                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    color = Color.Yellow;
                    var Color4 = GetColorHexCode(color);
                    Console.WriteLine(Color4);
                    Console.ForegroundColor = ConsoleColor.Gray;


                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    color = Color.Cyan;
                    var Color5 = GetColorHexCode(color);
                    Console.WriteLine(Color5);
                    Console.ForegroundColor = ConsoleColor.Gray;


                    break;
                case 6:

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    color = Color.Magenta;

                    var Color6 = GetColorHexCode(color);

                    Console.WriteLine(Color6);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Некорректный цвет ");
                    break;
            }
        }



            /// <summary>
            /// Выводит в консоль информацию
            /// </summary>
            public  void PrintColors()
            {
                Console.WriteLine("Color.Red #FF0000  =1 ");
                Console.WriteLine("Color.Green #00FF00 = 2");
                Console.WriteLine("Color.Blue  #0000FF  = 3");
                Console.WriteLine("Color.Yellow #FFFF00 =4");
                Console.WriteLine("Color.Cyan  #00FFFF  5");
                Console.WriteLine("Color.Magenta #FF00FF =6");
            }

        }

    }

