using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Olá amigo dev! Tudo bem? Meu nome é CALCULEISHOw!");
            Console.WriteLine("Qual é o seu nome?");
            string name = Console.ReadLine();
            Console.WriteLine("Tudo bem " + name + ", agora qual operação matemática você deseja realizar?");

            Menu();
            Soma();
            Subtracao();
            Divisao();
            Multiplicacao();
        }
        static void Menu()
        {
            // Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|       1. Soma +             |");
            Console.WriteLine("|       2. Subtração -        |");
            Console.WriteLine("|       3. Divisão /          |");
            Console.WriteLine("|       4. Multiplicação X    |");
            Console.WriteLine("|       5. SAIR               |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Selecione a opção desejada...");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {

            Console.WriteLine("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 / num2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

    }
}