using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity, List<Child> registry)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; private set; }
        public List<Child> Registry { get; private set; }

        public bool AddChild(Child child)
        {
            
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveChild(string childFullName) =>
            Registry.Remove(Registry.FirstOrDefault(v => v.FirstName + " " + v.LastName == childFullName));

        public int ChildrenCount()
        {
            return Registry.Count;
        }

        public Child GetChild(string childFullName)
        {
            if (Registry.Contains(Registry.FirstOrDefault(x => x.FirstName + " " + x.LastName == childFullName)))
            {
                return Registry.FirstOrDefault(x => x.FirstName + " " + x.LastName == childFullName);
            }
            else
            {
                return null;
            }
            
        }

        public string RegistryReport()
        {
            var sortedChildren = this.Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Registered children in {this.Name}:");

            foreach (var child in sortedChildren)
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
