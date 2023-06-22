namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MyNewCar = new Car();

            MyNewCar.Make = "Oldsmobile";
            MyNewCar.Model = "Cutlas Supreme";
            MyNewCar.Year = 1986;
            MyNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}",
                MyNewCar.Make, MyNewCar.Model, MyNewCar.Color);

            //double marketValueOfCar = DetermineMarketValue(MyNewCar);

            Console.WriteLine("Car's value: {0:C}", MyNewCar.DetermineMarketValue());

            Console.ReadLine();
        }

        private static double DetermineMarketValue(Car carro)
        {
            double carValue = 100.0;

            return carValue;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double CarValue = 100.0;

            if (this.Year > 1990)
            {
                CarValue = 1000.0;
            }
            else
                CarValue = 2000.0;

            return CarValue;
        }
    }



}