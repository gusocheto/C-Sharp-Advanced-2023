namespace CarManufacturer

{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car("BMW", "X3", 2006, 500, 300);
            
            car.Drive(5);
            Console.WriteLine(car.WhoAmI());

        }
    }
}