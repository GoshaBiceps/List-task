using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List__task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SumCommand = "sum";
            const string ExitCommand = "exit";

            List<int> numbers = new List<int>();
            string userInput;
            bool isWorkProgram = true;

            while (isWorkProgram)
            {
                Console.WriteLine("1.Для добавления числа в массив просто введите число.");
                Console.WriteLine($"2.Введите команду, {SumCommand} для сложения всех чисел массива.");
                Console.WriteLine($"3.Введите команду, {ExitCommand} для выхода из программы.");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case SumCommand:
                        ShowSum(numbers);
                        break;

                    case ExitCommand:
                        isWorkProgram = false;
                        break;

                    default:
                        AddNumber(userInput,numbers);
                        break;
                }
            }
        }
        
        static void ShowSum(List<int> numbers)
        {
            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма всех чисел:{sum}");
        }

        static void AddNumber( string userInput, List<int> numbers)
        {
            if(int.TryParse(userInput, out int currentNumber))
            {
                numbers.Add(currentNumber);
            }
        }
    }
}
