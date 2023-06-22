using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Data;

//Exercício 1 : Escreva um programa que leia um arquivo de texto usando um StreamReader e conte o número de linhas no arquivo. Exiba o número total de linhas no console. 
// O resultado foi feito pulando linhas brancas e nulas

//StreamReader Leitor = new StreamReader("Texto.txt");

//int NumeroDeLinhas = 0;
//string linha = "";

//while ((linha = Leitor.ReadLine()) != null)
//{
// O ! nega o método, contando assim as que não sao nulas ou brancas
//    if (!string.IsNullOrWhiteSpace(linha))
//    {
//        NumeroDeLinhas++;
//    }



//}

//Leitor.Close();

//Console.WriteLine("O numero de linhas do arquivo é {0}", NumeroDeLinhas);

//Exercício 2:
//Escreva um programa que solicite ao usuário que digite uma série de números(separados por vírgulas) e, em seguida, calcule e exiba a soma desses números.

////
///Console.WriteLine("Insira uma série de números, separados por vírgula, para obter a soma");
////string x = Console.ReadLine();
////string[] y = x.Split(",");

////int [] NumeroConvertido = new int[y.Length];

////for (int i = 0; i < y.Length; i++)
////{
////    int.TryParse(y[i], out NumeroConvertido[i]);
////}

////Console.WriteLine("O resultado da soma dos números apresentados é: {0}", NumeroConvertido.Sum());

////Escreva um programa que solicite ao usuário que digite um número positivo e, em seguida, imprima todos os números inteiros de 1 até esse número.
//Console.WriteLine("Insira um número inteiro, para obter a lista de 1 até o mesmo");

//int x = int.Parse(Console.ReadLine());

//int y = 1;

//while (x >= y)
//{
//    Console.Write(" " + y);
//    y++;
//}

//////Crie um programa que solicite ao usuário que adivinhe um número de 1 a 100.
//////O programa deve gerar um número aleatório e informar se o palpite do usuário está muito alto, muito baixo ou correto. O loop while continua até que o usuário acerte o número.

////Console.WriteLine("Palpite um número de 1 a 100, e tente advinhar o número correto");            

////Random numeroAleatorio = new Random();
////int Numero = numeroAleatorio.Next(1, 101);
////int Palpite = 0;

////while (Palpite != Numero)
////{
////    Console.WriteLine("Digite seu palpite");
////    Palpite = int.Parse(Console.ReadLine());

////    if (Numero > Palpite)                                 
////    {
////        if (Numero - Palpite > 30)
////        {
////            Console.WriteLine("O palpite foi baixo. Tente novamente. Mas a diferença é maior que 30");
////        }
////        else if (Numero - Palpite > 10)
////        {
////            Console.WriteLine("O palpite foi baixo. Tente novamente. Mas a diferença é maior que 10");
////        }
////        else
////        {
////            Console.WriteLine("O palpite foi baixo. Tente novamente. A diferença é menor que 10.");
////        }
////    }
////    else if (Numero < Palpite)
////    {
////        if (Palpite - Numero < 30)
////        {
////            Console.WriteLine("O palpite foi alto. Tente novamente. Mas a diferença é menor que 30.");
////        }
////        else if (Palpite - Numero < 10)
////        {
////            Console.WriteLine("O palpite foi alto. Tente novamente. Mas a diferença é menor que 10.");
////        }
////        else
////        {
////            Console.WriteLine("O palpite foi alto. Tente novamente. A diferença é maior que 30.");
////        }
////    }


////}

////Console.WriteLine("Você acertou!, o número era: {0}", Palpite);

////Escreva um programa que solicite ao usuário que digite uma senha.O programa deve continuar solicitando a senha até que o usuário insira a senha correta.

//string SenhaInserida = "";
//string SenhaCorreta = "a1b2c3d4";

//Console.WriteLine("Insira a senha");

//while (SenhaInserida != SenhaCorreta)
//{               
//    SenhaInserida = Console.ReadLine();

//    if (SenhaInserida != SenhaCorreta)
//        Console.WriteLine("A senha inserida está incorreta. Insira novamente");

//}

//Console.WriteLine("A senha inserida está correta");

//Crie um programa que solicite ao usuário que digite um número.O programa deve imprimir a tabuada desse número usando um loop while.

////tabuada classica
///Console.WriteLine("Insira um número para obter sua tabuada");
////int x = int.Parse(Console.ReadLine());

////Console.WriteLine("A tabuada de x é:");

////for (int i = 1; i < 10; i++)
////{
////    int y = x * i;
////    Console.WriteLine(y);

////}

//////tabuada com loop while
//Console.WriteLine("Insira um número para obter sua tabuada");
//int x = int.Parse(Console.ReadLine());

//Console.WriteLine("A tabuada de {0} é:", x);
//int i = 1;

//while ( i < 11)
//{
//    Console.WriteLine("{0} x {1} = {2}", x, i, x * i);
//    i++;
//}

//////Crie um programa que solicite ao usuário que digite um número positivo.
//////O programa deve calcular e exibir a soma de todos os números pares de 1 até o número fornecido usando um loop while;

////Console.WriteLine("Insira um número positivo, para obter a soma de todos os números pares anteriores");

////int x = int.Parse(Console.ReadLine());
////double soma = 0;
////int i = 1;

////while (i <= x) 
////{                

////    if (i % 2 == 0)
////    {
////        soma += i;

////    }
////    i++;
////}

////Console.WriteLine(" A soma dos pares anteriores de {0} é {1}.", x, soma);
///

////Escreva um programa que solicite ao usuário que digite uma frase.O programa deve contar e exibir o número de vogais na frase usando um loop while.

//Console.WriteLine("Insira uma frase e obtenha o número de vogais");
//string Frase = Console.ReadLine().ToLower();            
//char[] vogais = { 'a','e', 'i', 'o', 'u' };
//int i = 0;

//char[] fraseEmLetras = Frase.ToCharArray();

//int j = 0;

//while ( j < fraseEmLetras.Length)
//{
//    if (vogais.Contains(fraseEmLetras[j]))
//    {
//        i++;
//    }

//    j++;
//}
//Console.WriteLine("O número de vogais da frase é: " +  i);

////Exercício 6:
////Escreva um programa que leia um arquivo de texto contendo uma lista de nomes e suas respectivas idades
////(um nome e idade por linha, separados por vírgula). Calcule e exiba a idade média das pessoas no arquivo.

//StreamReader Leitor = new StreamReader("Texto.txt");

//Console.WriteLine(Leitor.ReadLine());

//string Linha = "";
//int SomaDasIdades = 0;
//int ContadorDeLinha = 0;

//while ((Linha = Leitor.ReadLine()) != null)
//{

//    string[] Separador = Linha.Split(',');
//    string nome = Separador[0];
//    int Idade = int.Parse(Separador[1]);

//    Console.WriteLine($"{nome}, {Idade}");

//    SomaDasIdades += Idade;

//    ContadorDeLinha++;
//}

//Leitor.Close();

//double Média = (double)SomaDasIdades / (double)ContadorDeLinha;

//Console.WriteLine("Além disso, a média das idades é " + Média);

//Exercício 7: Escreva um programa que solicite ao usuário que
//digite uma string e,
//em seguida, inverta a string usando um loop while.
//Exiba a string invertida no console.

//Console.WriteLine("Insira um texto e receba o texto invertido");
//string Texto = Console.ReadLine();

//char[] TextoD = Texto.ToCharArray();

//char[] TextoInvertido = TextoD.Reverse().ToArray();

//string TextoInvertido2 = new string(TextoInvertido);

//Console.WriteLine("O texto apresentado em ordem inversa é:");
//Console.WriteLine(TextoInvertido2);

//Console.WriteLine("Insira um texto e receba o texto invertido");

//string Texto = Console.ReadLine();

//while (Texto != null)
//{
//    char[] DivisaodoTexto = Texto.ToCharArray();
//    Array.Reverse(DivisaodoTexto);
//    string TextoInverso = new string(DivisaodoTexto);

//    Console.WriteLine(DivisaodoTexto);

//    Console.WriteLine("Caso queira, insira outro texto:");
//    Texto = Console.ReadLine();
//}

//Exercício 5:
//Escreva um programa que gere a sequência de Fibonacci
//até um número fornecido.
//Solicite ao usuário que digite um número e,
//em seguida, exiba a sequência de Fibonacci até esse número.
//Use um loop while para gerar a sequência.

//Console.WriteLine("Insira um número e obtenha a sequência de Fibonacci até o respectivo número");
//int NumeroRecebido = int.Parse(Console.ReadLine());

//int PrimeiroNumero = 0;
//int SegundoNumero = 1;
//int ProximoNumero = PrimeiroNumero + SegundoNumero;

//Console.WriteLine("A sequência Fibonacci é:");

//Console.WriteLine(PrimeiroNumero);
//Console.WriteLine(SegundoNumero);

//while ( ProximoNumero <= NumeroRecebido )
//{
//    Console.WriteLine(ProximoNumero);

//    PrimeiroNumero = SegundoNumero;
//    SegundoNumero = ProximoNumero;
//    ProximoNumero = PrimeiroNumero + SegundoNumero;

//}

//streamreader e datatime

//Leitura de Planilha usando streamreader

////string Local = @"C:\Users\guilh\Downloads\PlanilhaPosições.csv";


////if (File.Exists(Local))
////{ 
////    StreamReader Planilha = new StreamReader(Local);

////    string Linha = "";
////    Planilha.ReadLine();

////    while ((Linha = Planilha.ReadLine()) != null)
////    {
////        string[] PartesDaLinha = Linha.Split(',');
////        string Nome = PartesDaLinha[0];
////        int Idade = int.Parse(PartesDaLinha[1]);
////        string Posição = PartesDaLinha[2];

////        Console.WriteLine($"{Nome}, tem {Idade} e atua como {Posição}");
////    }
////    Console.WriteLine("Leitura do arquivo CSV concluída!");
////} 
////else
////{
////    Console.WriteLine("O arquivo CSV não foi encontrado.");
////}


//Console.WriteLine("Escreve duas datas diferentes para obter a diferença, use o formato 00/00/0000");
//Console.WriteLine("Primeiro insira a primeira data");

//DateTime x = DateTime.Parse(Console.ReadLine());

//Console.WriteLine("Agora insira a segunda data");

//DateTime y = DateTime.Parse(Console.ReadLine());

//TimeSpan Subtração = x - y;

//Console.WriteLine("A diferença entre as datas é de " + Subtração.TotalDays + "dias ");

//Console.WriteLine("Insira uma data, no formato dd/MM/yyyy");

//string x = Console.ReadLine();

//DateTime DataInserida;

//DateTime DiadeHoje = DateTime.Now;

//if (DateTime.TryParse(x, out DataInserida))
//{
//    if (DiadeHoje > DataInserida)
//    {
//        Console.WriteLine("O dia inserido está no passado");
//    }
//    else if (DiadeHoje < DataInserida)
//    {
//        Console.WriteLine("O dia inserido está no futuro");
//    }
//}
//else
//{
//    Console.WriteLine("O formato inserido é inválido");
//}

//Verifique se o ano inserido é bi sexto
//Eles possuem 366 dias e acontecem em anos divisíveis por quatro,
//exceto quando terminados em 00.

Console.WriteLine("Insira um ano");
string x = Console.ReadLine();

int Ano = int.Parse(x);

if (DateTime.IsLeapYear(Ano))
{
    
        Console.WriteLine("O ano inserido é bissexto.");
}
    else
    {
        Console.WriteLine("O ano inserido não é bissexto.");
    }

