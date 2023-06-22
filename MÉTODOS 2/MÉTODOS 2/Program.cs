using System.ComponentModel;
using System.Linq;

namespace MÉTODOS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaVogais();


        }







        // escrever um método que conte o número de palavras em uma sentença

        //static int Contador()
        //{
        //    Console.WriteLine("Escreva uma frase");
        //    string x = Console.ReadLine();
        //    int resultado = x.Split(' ').Length;
        //    Console.WriteLine("O número de palavras dessa frase é " + resultado);
        //    return resultado;

        //    ///////// EXECUÇÃO DO CONTADOR NO MAIN
        //    //int resultado = Contador();
        //    //int Multi = resultado * 5;
        //    //Console.WriteLine("o número de palavras da frase vezes 5 é: " + Multi);

        //}

        //static int SomadeNumeros() 
        //{
        //    Console.WriteLine("Escreva dois números inteiros");
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());
        //    int Soma = x + y;
        //    Console.WriteLine("A soma dos números apresentados é: " + Soma);
        //    return Soma;
        //}

        //////static bool IsEven()
        //////{
        //////    Console.WriteLine("Insira um número para descobrir se ele é par ou ímpar");
        //////    int x = int.Parse(Console.ReadLine());

        //////    if (x % 2 == 0)
        //////    {

        //////        return true;
        //////    }
        //////    else
        //////    {

        //////        return false;
        //////    }

        //////    RESPOSTA NO MAIN 
        //////        bool verdade = IsEven();
        //////    {
        //////        if (verdade)
        //////        {
        //////            Console.WriteLine("é parrrrrrrrrrrrr");
        //////        }
        //////        else
        //////            Console.WriteLine("é ímparrrrrrrrrr");
        //////    }

        //static double CalculeMédia()
        //{
        //    int[] x = new int[5];
        //    Console.WriteLine("Digite 5 números para obter a média dos mesmos");

        //    int resposta1 = int.Parse(Console.ReadLine());
        //    int resposta2 = int.Parse(Console.ReadLine());
        //    int resposta3 = int.Parse(Console.ReadLine());
        //    int resposta4 = int.Parse(Console.ReadLine());
        //    int resposta5 = int.Parse(Console.ReadLine());

        //    double média = ((resposta1 + resposta2 + resposta3 + resposta4 + resposta5) / 5);
        //    Console.WriteLine("A média dos valores apresentados é: " + média);
        //    return média;
        //}
        //

        //static void CalculeMédia()
        //{
        //    Console.WriteLine("Digite os números, dando espaço entre eles, para obter a média dos mesmos");

        //    var x = Console.ReadLine();
        //    var y = x.Split(' ');

        //    int soma = 0;
        //    int z = 0;
        //    double média = 0;

        //    for (int i = 0; i < y.Length; i++)
        //    {

        //        int.TryParse(y[i], out z);

        //        soma += z;


        //        média = soma / y.Length;

        //    }

        //    Console.WriteLine("O resultado da média do valores fornecidos foram: " + média);


        //}

        //static bool VerificaPrimo()
        //{
        //    Console.WriteLine("Insira um número inteiro para descobrir se o mesmo é primo ou não");
        //    int x = int.Parse(Console.ReadLine());

        //    if (x < 2)
        //    {
        //        Console.WriteLine("O número não é primo");
        //        return false;
        //    }

        //    for (int i = 2; i < x; i++)
        //    {
        //        if (x % i == 0)
        //        {
        //            Console.WriteLine("O número não é primo");
        //            return false;
        //        }                

        //    }

        //    Console.WriteLine("O número é primo");
        //    return true;

        //}

        //static void CalculaPotencia()
        //{
        //    Console.WriteLine("Insira dois números inteiros, o primeiro, o número, e o segundo, o exponente para obter a potência");
        //    var x = Console.ReadLine();
        //    var y = x.Split(' ');

        //    if  (y.Length != 2 ) 
        //    {
        //        Console.WriteLine("Inválido. Insira apenas dois números.");
        //        return;
        //    }

        //    int NumeroBase; int Exponente;

        //    bool Conversao1 = int.TryParse(y[0], out NumeroBase);
        //    bool Conversao2 = int.TryParse(y[1], out Exponente);

        //    if ( Conversao1 == false || Conversao2 == false)
        //    {
        //        Console.WriteLine("Inválido. Insira apenas números inteiros");
        //    }

        //    double Potencia = Math.Pow(NumeroBase, Exponente);

        //    Console.WriteLine("A potência é: " + Potencia);

        //}

        // Escreva um método em C# chamado "OrdenaArray" que recebe um array de números inteiros como parâmetro e retorna o mesmo array ordenado em ordem crescente.

        //static void OrdenaArray()
        //{
        //    Console.WriteLine("Insira diversos números inteiros para que seja colocado em ordem crescente");
        //    string x = Console.ReadLine();
        //    string[] y = x.Split(' ');

        //    int[] NovaArray = new int[y.Length];

        //    for (int i = 0; i < y.Length; i++)
        //    {
        //        NovaArray[i] = int.Parse(y[i]);
        //    }

        //    Array.Sort(NovaArray);

        //    Console.WriteLine("A sequência em ordem crescente é:");

        //    foreach (int Valor in NovaArray) 
        //    {
        //        Console.WriteLine(Valor);
        //    }


        //}

        ////Escreva um método em C# chamado "ContaVogais" que recebe uma string como parâmetro e retorna o número de vogais presentes na string.

            static void ContaVogais ()
        {
            Console.WriteLine("Insira um texto, para obter o número de vogais");

            string Texto = Console.ReadLine().ToLower();
            string vogais = "aeiouáéíóúàèìòùãõâêîôûäëïöü";

            int ContadordeVogal = 0;
            foreach (char Letra in Texto)
            {
                if (vogais.Contains(Letra))
                {
                    ContadordeVogal++;
                }
            }

            Console.WriteLine("O número de vogais do texto é ");
            Console.WriteLine(ContadordeVogal);
            
        }

        


    }
}