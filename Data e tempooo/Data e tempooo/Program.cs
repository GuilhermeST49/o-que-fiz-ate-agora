namespace Data_e_tempooo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime x = DateTime.Now;

            //Console.WriteLine(x.ToString());

            //Console.WriteLine(x.ToShortDateString());
            //Console.WriteLine(x.ToShortTimeString());

            //Console.WriteLine(x.ToLongDateString());
            //Console.WriteLine(x.ToLongTimeString());

            //Console.WriteLine(x.AddDays(3).ToLongDateString());

            //Console.WriteLine(x.AddHours(3).ToShortTimeString());

            //Console.WriteLine(x.AddDays(-3).ToShortDateString());

            //Console.WriteLine(x.Month.ToString());

            //DateTime MeuAniversario = new DateTime(1969, 12, 7);
            //Console.WriteLine(MeuAniversario.ToShortDateString());

            DateTime Aniversario = DateTime.Parse("04/09/1999");
            TimeSpan Idade = DateTime.Now.Subtract(Aniversario);
            Console.WriteLine(Idade.TotalSeconds);

            Console.ReadLine();
        }
    }
} 