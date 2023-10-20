using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }

        public List<Shoe> Shoes { get; set; }

        public int Count => Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if(Shoes.Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }
            else
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        }

        public int RemoveShoes(string material)
        {
            int count = 0;
            foreach(Shoe shoe in Shoes)
            {
                if(shoe.Material == material)
                {
                    Shoes.Remove(shoe);
                    count++;
                }
            }
            return count;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<string> shoes = new List<string>();
            foreach(Shoe shoe in Shoes)
            {
                if (shoe.Type == type)
                {
                    shoes.Add(type);
                }
            }
            return shoes;
        }
    }
}
