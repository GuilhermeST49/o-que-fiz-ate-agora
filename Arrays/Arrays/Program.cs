// See https://aka.ms/new-console-template for more information



//int[] numbers = new int[5];

//numbers[0] = 4;
//numbers[1] = 8;
//numbers[2] = 15;
//numbers[3] = 16;
//numbers[4] = 23;

//Console.WriteLine(numbers.Length);


//Console.WriteLine(numbers[1].ToString());

//Console.ReadLine();



////int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

////Console.WriteLine(numbers[1]);
////Console.ReadLine();




//////string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

//////foreach (string name in names)
//////{
//////    Console.WriteLine(name);

//////}
//////Console.ReadLine();


////////////string zig = "You can get what you want of life" +
////////////    "if you help enough other people get what they want.";

////////////char[] charArray = zig.ToCharArray();
////////////Array.Reverse(charArray);

////////////foreach (char zigChar in charArray)
////////////    Console.Write(zigChar);

////////////Console.ReadLine();
///


// Escreva um programa em C# que some todos os números de 1 a 100,
// pulando os múltiplos de 3

int somade1a100 = 0;

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0) continue;

    somade1a100 += + i;

  
}

Console.WriteLine(somade1a100);

Console.ReadLine();
