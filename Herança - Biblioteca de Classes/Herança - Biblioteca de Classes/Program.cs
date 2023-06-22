using System.Globalization;

namespace Herança___Biblioteca_de_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car MeuCarro = new Car();
            MeuCarro.Make = "BMW";
            MeuCarro.Model = "12351";
            MeuCarro.Color = "Preto";
            MeuCarro.Year = 2005;

            ImprimeDetalhesdoVeículo(MeuCarro);           

            Truck MeuTruck = new Truck();

            MeuTruck.Make = "Ford";
            MeuTruck.Model = "14";
            MeuTruck.Color = "Blue";
            MeuTruck.Year = 1999;
            MeuTruck.CapacidadeDeCarga = 1200;

            ImprimeDetalhesdoVeículo(MeuTruck);

            Console.ReadLine();


        }
        private static void ImprimeDetalhesdoVeículo(Vehicle veiculo)
        {
            Console.WriteLine("Esses são os detalhes do veículo: {0}", veiculo.Format());
        }
    }

    abstract class Vehicle 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } 
        public string Color { get; set; }

        public abstract string Format();

    }

    class Car : Vehicle
    {        
        public override string Format()
        {
            return String.Format("{0} - {1} - {2} - {3}",
            this.Make,
            this.Model,
            this.Year,
            this.Color);
        }   

    }

    sealed class Truck : Vehicle
    {
        public int CapacidadeDeCarga { get; set; }

        public override string Format()
        {
            return String.Format("{0} - {1} - {2} unidades de carga",
            this.Make,
            this.Model,          
            this.CapacidadeDeCarga);
        }
    }
}
