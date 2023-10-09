using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Operations
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public  double PerformOperation(double operand1, double operand2, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return operand1 + operand2;
                case Operation.Subtract:
                    return operand1 - operand2;
                case Operation.Multiply:
                    return operand1 * operand2;
                case Operation.Divide:
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Некорректная операция");
            }
        }

        public  void Operating(int i)
        {
            Operation operation;
            Console.WriteLine("Ведите 1 число ");
            var Number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите 2 число ");
            var Number2 = double.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    operation = Operation.Add;
                    double result1 = PerformOperation(Number1, Number2, operation);
                    Console.WriteLine(result1);
                    break;
                case 2:
                    operation = Operation.Subtract;
                    double resul2 = PerformOperation(Number1, Number2, operation);
                    Console.WriteLine(resul2);

                    break;

                case 3:
                    operation = Operation.Multiply;
                    double result3 = PerformOperation(Number1, Number2, operation);
                    Console.WriteLine(result3);


                    break;
                case 4:
                    operation = Operation.Divide;
                    double result4 = PerformOperation(Number1, Number2, operation);
                    Console.WriteLine(result4);
                    break;
            }
        }

        /// <summary>
        ///  Выводит в консоль информацию об операциях 
        /// </summary>
        public  void PrintOperating()
        {
            Console.WriteLine("Operation.Add  =1 ");
            Console.WriteLine("Operation.Subtract= 2");
            Console.WriteLine(" Operation.Multiply = 3");
            Console.WriteLine(" Operation.Divide#FFFF00 =4");

        }
    }
}
