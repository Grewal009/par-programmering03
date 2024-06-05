using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParProgrammeringAneelOgViktor
{
    public class MagicShop
    {
        public List<Items> Inventory { get; private set; }

        public MagicShop()
        {
            Inventory = new List<Items>()
            {
                new Items("føniks", "wand"),
                new Items("unikorn", "wand"),
                new Items("Troll", "wand"),
                new Items("ugle", "pet"),
                new Items("rotte", "pet"),
                new Items("katt", "pet")
            };
        }

        public int ShopMenu()
        {
            var count = 0;
            var isValidNumber = false;
            int output;

            Console.WriteLine("Hello what do you want to buy?");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{count}. {item.Name} {item.Type}");
                count++;
            }

            do
            {
                Console.Write("Press the number of the item you wanna buy: ");
                var userInput = Console.ReadLine();
                isValidNumber = int.TryParse(userInput, out output);
                //Console.WriteLine(output);
            } while (!isValidNumber || output >= Inventory.Count || output < 0); //always check opposite conditions

            return output;
        }

        public Items BuyItem(int choice)
        {
            Items output = new Items();
            switch (choice)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    output = Inventory[choice];
                    //Inventory.Remove(output);
                    Inventory.RemoveAt(choice);
                    break;
                default:
                    ShopMenu();
                    break;
            }

            return output;
        }
    }
}