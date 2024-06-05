using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParProgrammeringAneelOgViktor
{
    public class Character
    {
        public string Name { get; private set; }
        public string House { get; private set; }
        public List<Items> Inventory { get; private set; } = new List<Items>();
        

        public string FullInfo => $"Hello my name is {Name}. I'm from house {House} and i Own{GetInventory()}";

        private string GetInventory()
        {
            var output = "";
            foreach (var item in Inventory)
            {
                output += $" {item.Name} {item.Type}";
            }
            return output;
        }

        public Character(string name, string house)
        {
            Name = name;
            House = house;
        }

        public void Trylleformel()
        {
            Console.Write("Write inn trylleformel: ");
            var input = Console.ReadLine();
            if (input == "vingardium leviosa")
            {
                Console.WriteLine("får en fjær til å fly");
            }else if (input == "hokus pokus")
            {
                Console.WriteLine("fyrer av fyrverkerier");
            }
            else
            {
                Console.WriteLine("This is not a trylleformel");
            }
        }
    }
}