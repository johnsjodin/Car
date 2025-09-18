namespace Car
{
    internal class Car
    {
        public string Company;
        public string Color;
        public int Year;
        public int HorsePower;
        public int Gears;
        public bool EngineOn;
        public Engine.EngineType TypeOfEngine;
        public int MaxSpeed;

        public void ShowInfo()
        {
            Console.WriteLine($"Märke: {Company}");
            Console.WriteLine($"Färg: {Color}");
            Console.WriteLine($"Årsmodell: {Year}");
            Console.WriteLine($"Hästkrafter: {HorsePower}");
            Console.WriteLine($"Växlar: {Gears}");
            Console.WriteLine($"Motor igång: {EngineOn}");
        }

        public void Drive()
        {
            Console.WriteLine($"\nVroom vrrroooom!! {Company} susar iväg!\n");
        }

        public void Fuel()
        {
            switch (TypeOfEngine)
            {
                case Engine.EngineType.Electric:
                    Console.WriteLine($"{Company} laddas.");
                    break;
                case Engine.EngineType.Gasoline:
                    Console.WriteLine($"{Company} tankas med bensin.");
                    break;
                case Engine.EngineType.Diesel:
                    Console.WriteLine($"{Company} tankas med diesel.");
                    break;
                case Engine.EngineType.Hybrid:
                    Console.WriteLine($"{Company} tankas med både bensin och el.");
                    break;
                default:
                    Console.WriteLine("Okänt bränsle.");
                    break;
            }
        }

        public void IsFasterThan(Car otherCar)
        {
            if (otherCar == null) return;
            if (this.MaxSpeed > otherCar.MaxSpeed)
            {
                Console.WriteLine($"{this.Company} är snabbare än {otherCar.Company}");
            }
            else if (this.MaxSpeed < otherCar.MaxSpeed)
            {
                Console.WriteLine($"{otherCar.Company} är snabbare än {this.Company}");
            }
            else
            {
                Console.WriteLine($"{this.Company} och {otherCar.Company} har samma maxhastighet");
            }
        }
    }
}
