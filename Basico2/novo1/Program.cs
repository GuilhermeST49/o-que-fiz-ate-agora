// See https://aka.ms/new-console-template for more information

o código que verifica se o número 15 é divisível por 3 ou por 4

int a = 15;

if (a % 3 == 0)
{
    Console.WriteLine(" 15 é divisível por 3");
}
else
{
    Console.WriteLine(" 15 não é divisível por 3");
}

if (a % 4 == 0)
{
    Console.WriteLine("15 é divisível por 4");
}
else
    Console.WriteLine(" 15 não é divisível por 4");

Console.ReadLine();



for (int divisorde3e4 = 0; divisorde3e4 < 31; divisorde3e4++)
{
    if (divisorde3e4 % 3 == 0 || divisorde3e4 % 4 == 0)
        Console.WriteLine(divisorde3e4 + " é divisor de 3 ou 4");

}

//for (int i = 0; i < 10; i++)
//{
//    //Console.WriteLine(i.ToString()); 

//    if (i == 7)
//    {
//        Console.WriteLine("Found seven!");
//        break;
//    }
//}









Console.ReadLine();

