using StartUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Family
    {

        private List<Person> people;
        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
         => People.OrderByDescending(x => x.Age).First();
            
        
    }
}
