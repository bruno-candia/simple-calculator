using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static float Operations(
            EOperators operation,
            float firstValue,
            float secondValue
        )
        {
            switch((int)operation){
                case 1: return firstValue + secondValue;
                case 2: return firstValue - secondValue;
                case 3: return firstValue / secondValue;
                case 4: return firstValue * secondValue;
                default: return 0;
            }
        }

        static void Calculator(EOperators operation)
        {
            string name = operation.ToString();
            Console.Clear(); //Limpar a tela do console
            Console.WriteLine(name.ToUpper());

            Console.Write("First Value: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Second Value: ");
            float secondValue = float.Parse(Console.ReadLine());

            // Operations calculates the result based on the chosen arithmetic operation
            float result = Operations(operation, firstValue, secondValue);

            Console.WriteLine($"{char.ToUpper(name[0]) + name.Substring(1)}: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Menu(){
            // Recupera uma matriz dos nomes do tipo EOperators
            var Operators = Enum.GetNames(typeof(EOperators));

            Console.Clear();
            Console.WriteLine("=== SIMPLE CALCULATOR ===");
            Console.WriteLine("Options: ");

            // It loops through the enum values and print the names
            for(int i=1 ; i < Operators.Length + 1; i++)
            {
                Console.WriteLine($"{i} - {char.ToUpper(Operators[i - 1][0]) + Operators[i - 1].Substring(1)}");
            }

            Console.WriteLine("-----------------------");
            Console.Write("Select an option: ");

            // Assigning the value inputed by the user to the operation variable with Parse conversion to short and then explicit conversion to EOperators
            EOperators operation = (EOperators)short.Parse(Console.ReadLine());

            switch((int)operation){
                case 1: Calculator(operation); break;
                case 2: Calculator(operation); break;
                case 3: Calculator(operation); break;
                case 4: Calculator(operation); break;
                case 5: 
                    Console.WriteLine("See you later!");
                    Console.ReadKey();
                    Console.Clear();
                    System.Environment.Exit(0); 
                break;
                default:
                    Console.WriteLine("Invalid Value");
                    Console.WriteLine("Try Again!");
                    Console.ReadKey();
                    Menu();
                break;
            }
        }
    }

    // Arithmetic operators enum type
    enum EOperators
    {
        sum = 1,
        subtraction = 2,
        division = 3,
        multiplication = 4,
        exit = 5
    }
}
