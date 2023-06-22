// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine("Please type something and press the Enter key");
//string userValue;
//userValue = Console.ReadLine();
//Console.WriteLine("You typed:" + userValue);

//Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
//string userValue = Console.ReadLine();
//if (userValue == "1")
//{
//    Console.WriteLine("You won a new car!");
//    Console.ReadLine();
//}

//else if (userValue == "2")
//{
//    Console.WriteLine("You won a new boat!");
//    Console.ReadLine();
//}

//else if (userValue == "3")
//{
//    Console.WriteLine("You won a new bike!");
//    Console.ReadLine();
//}

//else 
//{
//    Console.WriteLine("Sorry, we didn't undestand. Perdeu!");
//    Console.ReadLine(); }

Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
string userValue = Console.ReadLine();

////string message = "";

////if (userValue == "1")

////    message = "You won a new car!";

////else if (userValue == "2")

////    message = "You won a new boat!";

////else if (userValue == "3")

////    message ="You won a new bike!";

////else

////    message = "Sorry, we didn't undestand. Perdeu!";

////Console.WriteLine(message);

//string message = (userValue == "1") ? "boat" : "strand of lint;";
//Console.WriteLine("You won a {0}", message);

//Console.ReadLine();

if (userValue =="1")
{ Console.WriteLine("You won a Boat"); 
}

else
{
    Console.WriteLine("You won a strand of lint");
}