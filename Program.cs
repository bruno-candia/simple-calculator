using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------");
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: 
                    Console.Clear();
                    System.Environment.Exit(0); 
                break;
                default:
                    Console.WriteLine("Valor invalido.");
                    Console.WriteLine("Tente Novamente!");
                    Console.ReadKey();
                    Menu();
                break;
            }
        }

        static void Soma()
        {
            Console.Clear(); //Limpar a tela do console
            Console.WriteLine("SOMA");

            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue + secondValue;

            Console.WriteLine($"Soma: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");

            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue - secondValue;

            Console.WriteLine($"Subtração: {result}");
            Console.ReadKey(); 
            Menu();     
        }
    
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");

            Console.Write("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue / secondValue;

            Console.WriteLine($"Divisão: {result}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO");

            Console.Write("Primeiro Valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue * secondValue;

            Console.WriteLine($"Divisão {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
