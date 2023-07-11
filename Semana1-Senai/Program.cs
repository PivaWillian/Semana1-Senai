using System.Runtime.CompilerServices;

namespace Semana1_Senai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio9();
            //Inputs input = new Inputs();
            //Calculos calculo = new Calculos();
            //int num1, num2;
            //string nome;

            //Console.WriteLine("Informe a operação desejada: ");
            //string op = Console.ReadLine().ToLower();
            //switch (op)
            //{
            //    case "+": num1 = input.EntradaNumerica();
            //        num2 = input.EntradaNumerica();
            //        calculo.Soma(num1, num2);
            //        break;
            //    case "i": num1 = input.EntradaNumerica();
            //        calculo.ParOuImpar(num1);
            //        break;
            //    case "m": num1 = input.EntradaNumerica();
            //        nome = input.EntradaAlfabetica();
            //        Console.WriteLine($"O paciente {nome}:\n");
            //        calculo.Maioridade(num1);
            //        break;
            //    case "c":
            //        Console.WriteLine("Informe a marca do carro");
            //        string? Marca = Console.ReadLine();
            //        Console.WriteLine("Informe o modelo do carro");
            //        string? Modelo = Console.ReadLine();
            //        Console.WriteLine("Informe a km do carro");
            //        num1 = Int32.Parse(Console.ReadLine());
            //        string texto = num1 > 10000 ? $"O carro {Marca} {Modelo} precisa de revisão": $"O carro {Marca} {Modelo} não precisa de revisão";
            //        Console.WriteLine(texto);
            //        break;
            //    default: Console.WriteLine("Operação selecionada erroneamente");
            //        break;
            //}
        }

        private static void Exercicio9()
        {
            int qtdade, soma = 0;
            Console.WriteLine("de quantos números gostaria de fazer a média?");
            int.TryParse(Console.ReadLine(), out qtdade);
            int[] nums = new int[qtdade];
            for (int i = 0; i < qtdade; i++)
            {
                Console.WriteLine("Informe número para a soma");
                int.TryParse(Console.ReadLine(), out nums[i]);
                soma += nums[i];
            }
            double resultado = (double)soma / qtdade;
            Console.WriteLine(resultado);
        }

        private static void Exercicio8()
        {
            int[] nums = new int[5];
            int bigger = 0;
            Console.WriteLine("Informe cinco números inteiros:");
            for(int i = 0; i < nums.Length; i++) 
            {
                int.TryParse(Console.ReadLine(), out nums[i]);
                if (nums[i] > bigger)
                {
                    bigger = nums[i];
                }
            }
            Console.WriteLine(bigger);


        }

        private static void Exercicio7()
        {
            int num;
            do
            {
                Console.WriteLine("Informe um número inteiro positivo");
                Int32.TryParse(Console.ReadLine(), out num);
                if(num <= 0)
                    Console.WriteLine("Error");
            } while (num <= 0);
            
            
            for (int i = 0; i < num; i = i + 2) 
            {
                Console.WriteLine(i);
            }
        }

        private static void Exercicio6()
        {
            string frases = "A linguagem de programação C# é muito poderosa";
            string[] palavras = frases.Split(" ");
            Console.WriteLine(palavras[7]);
        }

        static void Exercicio5()
        {
            int[] nums = new int[4];
            Console.WriteLine("Por favor informe 4 números");
            for(int i = 0; i<4; i++) 
            {
                nums[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]}\n");
            }
        }
    }

    class Inputs
    {
        public int num1, num2;
        public string nome;
        public int EntradaNumerica()
        {
            Console.WriteLine("Informe o valor que será usado pela operação");
            num1 = Int32.Parse(Console.ReadLine());
            return num1;
        }
        
        public string EntradaAlfabetica()
        {
            Console.WriteLine("Por favor informe seu nome");
            nome = Console.ReadLine();
            return nome;
        }
    }

    class Calculos
    {
        public void Soma(int num1, int num2)
        {
            Console.WriteLine($"O resultado é: {num1 + num2}");
        }

        public void ParOuImpar(int num)
        {
            if ((num & 1) == 1)
            {
                Console.WriteLine("Número é ímpar");
            }
            else
            {
                Console.WriteLine("Número é par");
            }
        }

        public void Maioridade(int num1)
        {
            if (num1 < 18)
            {
                Console.WriteLine("Não é de maior");
            }
            else if (num1 > 60)
            {
                Console.WriteLine("É idoso");
            }
            else
                Console.WriteLine("É adulto");
        }
    }
}