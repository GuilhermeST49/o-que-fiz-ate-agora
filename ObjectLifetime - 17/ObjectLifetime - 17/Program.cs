namespace ObjectLifetime___17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MeuCarro = new Car();

            //set properties

            Car MeuOutroCarro = MeuCarro;

            Car TerceiroCarro = new Car("Ford", "Ram", 2021, "Azul");

            MeuCarro = null;
            MeuOutroCarro = null;

            Car.Método();
        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make,  string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        //public Car(string someOtherInputParameter, string model, int year, string color)
        //{
        //    this.Make = someOtherInputParameter;
        //    this.Model = model;
        //    this.Year = year;
        //    this.Color = color;
        //}

        public static void Método()
        { 
        }
    }

















}