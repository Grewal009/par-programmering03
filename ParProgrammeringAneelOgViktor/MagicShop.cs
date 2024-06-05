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

        //public int ShopMenu()
        //{
        //    var count = 0;
        //    var isValidNumber = false;
        //    int output;

        //    Console.WriteLine("Hello what do you want to buy?");
        //    foreach (var item in Inventory)
        //    {
        //        Console.WriteLine($"{count}. {item.Name} {item.Type}");
        //        count++;
        //    }

        //    do
        //    {
        //        Console.Write("Press the number of the item you wanna buy: ");
        //        var userInput = Console.ReadLine();
        //        isValidNumber = int.TryParse(userInput, out output);
        //        Console.WriteLine(output);
        //    } while (!isValidNumber && output >= Inventory.Count && output < 0);

        //    return output;
        //}

        //public Items BuyItem(int choice)
        //{
        //    switch (choice)
        //    {
        //        case 1:
        //            return Inventory[choice];
        //            break;
        //        case 2:
        //    }
        //}
    }
}
