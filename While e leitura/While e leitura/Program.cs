namespace While_e_leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader myReader = new StreamReader("TextFile1.txt");
            string line = "";
             
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();
        }
    }
}