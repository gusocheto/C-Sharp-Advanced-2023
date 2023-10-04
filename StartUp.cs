using DefiningClasses;
using StartUp;

Family family = new Family();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] nameAndAge = Console.ReadLine().Split(" ");
    string name = nameAndAge[0];
    int age = int.Parse(nameAndAge[1]);
    Person person = new Person(name, age);
    family.AddMember(person);
}
Person[] filteredPeople = family.People
                .FindAll(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToArray();

foreach (Person person in filteredPeople)
{
    Console.WriteLine(person);
}
    

