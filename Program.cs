namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Första bilen
            //myFirstCar.Company = "Dodge";
            //myFirstCar.Color = "Black";
            //myFirstCar.Year = 1982;
            //myFirstCar.HorsePower = 1500;
            //myFirstCar.Gears = 6;
            //myFirstCar.EngineOn = true;
            //myFirstCar.TypeOfEngine = Engine.EngineType.Gasoline;
            //myFirstCar.MaxSpeed = 320;
            Car myFirstCar = new Car("Dodge", "Black", 1982, 1500, 6, true, Engine.EngineType.Gasoline, 320);

            // Andra bilen
            //mySecondCar.Company = "Volvo";
            //mySecondCar.Color = "Red";
            //mySecondCar.Year = 1987;
            //mySecondCar.HorsePower = 600;
            //mySecondCar.Gears = 5;
            //mySecondCar.EngineOn = true;
            //mySecondCar.TypeOfEngine = Engine.EngineType.Diesel;
            //mySecondCar.MaxSpeed = 280;
            Car mySecondCar = new Car("Volvo", "Red", 1987, 600, 5, true, Engine.EngineType.Diesel, 280);

            // Kalla på metoder
            myFirstCar.ShowInfo();
            myFirstCar.Drive();

            mySecondCar.ShowInfo();
            mySecondCar.Drive();

            myFirstCar.Fuel();
            mySecondCar.Fuel();

            Console.WriteLine();
            myFirstCar.IsFasterThan(mySecondCar);
        }
    }
}
