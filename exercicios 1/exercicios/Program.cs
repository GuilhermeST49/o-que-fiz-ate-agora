using System.Runtime.InteropServices;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 1:
Crie um programa em C# que declare uma variável do tipo inteiro chamada numero e atribua a ela um valor inteiro de sua escolha. 
            Em seguida, exiba o valor dessa variável no console.
Exercício 2:
Crie um programa em C# que declare duas variáveis do tipo double chamadas num1 e num2 e atribua a elas valores decimais de sua escolha. 
           Em seguida, calcule a soma desses números e exiba o resultado no console.

Exercício 3:
Crie um programa em C# que declare uma variável do tipo string chamada nome e atribua a ela o seu nome. 
            Em seguida, exiba a mensagem "Olá, [nome]!" no console, substituindo [nome] pelo valor da variável.

Exercício 4:
Crie um programa em C# que declare uma variável do tipo bool chamada isSunny e atribua a ela o valor true ou false, dependendo se está ensolarado ou não. 
            Em seguida, exiba a mensagem "O dia está ensolarado?" seguida pelo valor da variável no console.

Exercício 5:
Crie um programa em C# que solicite ao usuário que insira um número inteiro e armazene-o em uma variável chamada entrada. 
            Em seguida, exiba a mensagem "O número digitado foi: [entrada]" no console, substituindo [entrada] pelo valor inserido pelo usuário.

Exercício 6:
Crie um programa em C# que declare uma variável do tipo char chamada letra e atribua a ela uma letra do alfabeto. 
            Em seguida, exiba a mensagem "A letra escolhida foi: [letra]" no console, substituindo [letra] pelo valor da variável.

Exercício 7:
Crie um programa em C# que declare uma variável do tipo decimal chamada preco e atribua a ela o valor de um produto.
            Em seguida, exiba a mensagem "O preço do produto é R$ [preco]" no console, substituindo [preco] pelo valor da variável.
            */

            //int numero = 5;
            //Console.WriteLine(numero);

            //Console.ReadLine();

            //double num1 = 1.5;
            //double num2 = 2.7;
            //double soma = num1 + num2;
            //Console.WriteLine(soma);

            //string nome = "Guilherme";
            //Console.WriteLine("Olá," + nome);

            //bool isSunny = true;

            //Console.WriteLine("O dia está ensolarado?" + isSunny);

            //Console.WriteLine("Insira um numero inteiro"); 
            //*var entrada = Console.ReadLine(); ou*/ int entrada = int.Parse(Console.ReadLine());
            //Console.WriteLine("O número digitado foi " + entrada);


            //char letra = 'a';
            //Console.WriteLine("A letra escolhida foi:" + letra);

            //decimal preco = 1.2;
            //Console.WriteLine(" O preço do produto é " + preco);


            ////exercício 1
            ///Console.WriteLine("Escreve dois números inteiros");
            ////int x = int.Parse(Console.ReadLine());
            ////int y = int.Parse(Console.ReadLine());
            ////int soma = x + y;
            ////Console.WriteLine("A soma dos números é:" + soma);

            ////exercício 2
            ///for (int x = 0; x <= 100; x++)
            ///{
            ///    if (x % 2 != 0)
            ///        continue;

            ///    else
            ///      Console.WriteLine(x);

            ///}

            ////outra forma de resposta do ex2
            ///for (int x = 2; x <= 100; x += 2)
            ///{
            ///    Console.WriteLine(x);
            ///}

            //ARRAY EXERCICIO 3
            //Console.WriteLine("Escreve 5 valores inteiros, aperte Enter após cada número");

            //int[] x = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //}

            //var média = x.Average();

            //Console.WriteLine(média);

            ////exercicio 4Console.WriteLine("Escreve 7 valores inteiros, aperte Enter após cada número");

            //int[] x = new int[7];

            //for (int i = 0; i < 7; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());

            //}

            //var Maior = x.Max();

            //Console.WriteLine("o numéro de maior valor é" + Maior);

            //exercicio 5
            //Console.WriteLine("Escreve um número inteiro");
            //int x = int.Parse(Console.ReadLine());
            //string y = Convert.ToString(x, 2);

            //Console.WriteLine(y);

            //Console.WriteLine("Escreve quantos números da Sequência Fibonacci devem ser exibidos");
            //int x = int.Parse(Console.ReadLine());

            //int PrimeiroTermo = 0;
            //int SegundoTermo = 1;

            //Console.WriteLine("Os números da Sequência são: ");

            //for (int i = 0; i < x; i++)
            //{
            //    Console.Write(PrimeiroTermo + " ");
            //    int ProximoTermo = PrimeiroTermo + SegundoTermo;
            //    primeiroTermo = segundoTermo;
            //    segundoTermo = proximoTermo;
            //}

            //Console.ReadLine();

            ///ex 8
            /// Console.WriteLine("Digite um número de para obter a tabela de multiplicação do mesmo");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Os múltiplos do número apresentado são: ");

            //for (int y = 1; y <= 10; y++) 
            //{
            //    int resultado = x * y;
            //    Console.WriteLine(resultado);

            //}

            ////Exercicio dos primos
            ///Console.WriteLine("Insira um número inteiro");
            ////int x = int.Parse(Console.ReadLine());

            ////bool ePrimo = true;

            ////if (x < 2)
            ////{
            ////    ePrimo = false;
            ////}
            ////else
            ////{
            ////    for (int i = 2; i < x; i++)
            ////    {
            ////        if (x % i == 0) 
            ////        ePrimo = false;
            ////        break;
            ////    }
            ////}

            ////if (ePrimo == true)
            ////    Console.WriteLine("O número apresentado é Primo");

            ////else if (ePrimo == false)
            ////    Console.WriteLine("O número apresentado não é Primo");

            // obter a array reversa
            // Console.WriteLine("Digite 5 números inteiros");
            // int[] x = new int[5];


            // for (int i = 0; i < 5; i++)
            // {
            //     x[i] = int.Parse(Console.ReadLine());
            // }

            //Array.Reverse(x);
            //Console.WriteLine("Os números digitados em ordem reversa são: ");

            // foreach (int y in x)
            // {
            //     Console.WriteLine(y);
            // }

            ////Console.WriteLine("Digite 5 números inteiros para obter a média, o maior e o menor valor");

            ////int[] x = new int[5];

            ////for (int i = 0; i < 5; i++)
            ////{
            ////    x[i] = int.Parse(Console.ReadLine());
            ////}

            ////double y = x.Average();
            ////double z = x.Max();
            ////double t = x.Min();

            ////Console.WriteLine("A média, o maior e menor valor da sequência são: " + y + " " + z + " " + t);

          
        }

        void PrintNumber () 
        { 
            Random numberGen = new Random();
            int number = numberGen.Next(0,10);
            Console.WriteLine(number);
        }
    }
    
}

