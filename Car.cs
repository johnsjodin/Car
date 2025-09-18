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
        public EngineType TypeOfEngine;
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
            Console.WriteLine("\n\nVroom vrrroooom!!");
        }

        public enum EngineType
        {
            Electric,
            Gasoline,
            Diesel,
            Hybrid
        }
    }
}
