using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stringssss
{ //while e streamreader
    internal class Program
    {
        static void Main(string[] args)
        {
            //String X = "Go to your c:\drive";
            //string X = "My \"so called\" life";
            //String X = "What if i need \n a new life?";

            //string X = string.Format("{0}!", "Bonzai");

            //string X = string.Format("Produza: {0} (Modelo:{1})", "BMW", "76E18");

            //string X = string.Format("{0:c}", 123.45);

            //string X = string.Format("{0:n}", 123456789);

            //string X = string.Format("{0:p}", 123);

            //string X = string.Format("Phone number: {0:(###) ####-###}", 1234567890);

            //string X = "";

            //for (int i = 0; i < 100; i++)
            //{
            //    X = X + "--" + i.ToString();

            //}

            //StringBuilder X = new StringBuilder();

            //for (int i = 0; i < 100; i++)
            //{
            //    X.Append("--");
            //    X.Append(i.ToString());
            //}

            string X = " Esse verão foi muito louco ";

            //X = X.Substring(3, 15);
            //X = X.ToUpper();
            //X = X.Replace(" ", "--");
            X = String.Format("Length before: {0} -- After: {1}",
                X.Length, X.Trim().Length);
                
            Console.WriteLine(X);
            Console.ReadLine();

            
        }
    }
}