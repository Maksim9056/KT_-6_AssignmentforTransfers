using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApp49
{
    internal class Program
    {


        ///1. Напишите перечисление DayOfWeek, которое содержит значения для дней недели:
        //Monday, Tuesday, Wednesday, Thursday, Friday, Saturday и Sunday.
        //Затем напишите метод, который принимает на вход значение этого перечисления и выводит на консоль соответствующий день недели на русском языке.
        //2. Напишите перечисление Color, которое содержит значения для цветов: Red, Green, Blue, Yellow, Cyan и Magenta.
        //Затем напишите метод, который принимает на вход значение этого перечисления и возвращает его шестнадцатеричный код в виде строки.
        //3. Напишите перечисление Operation, которое содержит значения для арифметических операций: Add, Subtract, Multiply и Divide.
        //Затем напишите метод, который принимает на вход два числа и значение этого перечисления и возвращает результат выполнения соответствующей операции над числами.
        static void Main(string[] args)
        {
            DayOfWeeks dayOfWeeks = new DayOfWeeks();
            dayOfWeeks.Print();
            int d = int.Parse(Console.ReadLine());
            dayOfWeeks. Неделя(d);

            Colors colors = new Colors();
            colors.PrintColors();
            int Color = int.Parse(Console.ReadLine());
            colors.Colorss(Color);

            Operations operations = new Operations();
            operations. PrintOperating();
            int i = int.Parse(Console.ReadLine());
            operations.Operating(i);
        }
    }
}