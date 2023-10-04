using RawData;

List<Car> cars = new();
int count = int.Parse(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    string[] properties = Console.ReadLine().Split(" ").ToArray();
    Car car = new(properties[0], int.Parse(properties[1]), int.Parse(properties[2]), int.Parse(properties[3]), properties[4], double.Parse(properties[5]), int.Parse(properties[6]), double.Parse(properties[7]), int.Parse(properties[8]), double.Parse(properties[9]), int.Parse(properties[10]), double.Parse(properties[11]), int.Parse(properties[12]));
    cars.Add(car);
}
string command = Console.ReadLine();

string[] filterCarModels;

if (command == "fragile")
{
    filterCarModels = cars.Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Preasure < 1)).Select(c => c.Model).ToArray();
}
else
{
    filterCarModels = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).Select(c => c.Model).ToArray();
}

Console.WriteLine($"{string.Join(Environment.NewLine, filterCarModels)}");