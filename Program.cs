namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car();
            Car mySecondCar = new Car();

            // Första bilen
            myFirstCar.Company = "Dodge";
            myFirstCar.Color = "Black";
            myFirstCar.Year = 1982;
            myFirstCar.HorsePower = 1500;
            myFirstCar.Gears = 6;
            myFirstCar.EngineOn = true;
            myFirstCar.TypeOfEngine = Car.EngineType.Gasoline;
            myFirstCar.MaxSpeed = 320;

            // Andra bilen
            mySecondCar.Company = "Volvo";
            mySecondCar.Color = "Red";
            mySecondCar.Year = 1987;
            mySecondCar.HorsePower = 600;
            mySecondCar.Gears = 5;
            mySecondCar.EngineOn = true;
            mySecondCar.TypeOfEngine = Car.EngineType.Diesel;
            mySecondCar.MaxSpeed = 280;

            // Kalla på metoder
            myFirstCar.ShowInfo();
            myFirstCar.Drive();

            mySecondCar.ShowInfo();
            mySecondCar.Drive();
        }
    }
}
