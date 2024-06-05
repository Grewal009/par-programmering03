namespace ParProgrammeringAneelOgViktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harry = new Character("harry", "griffindor");

            var magicshop = new MagicShop();
            
            Console.WriteLine(harry.FullInfo);
            harry.Inventory.Add(magicshop.BuyItem(magicshop.ShopMenu()));
            Console.WriteLine(harry.FullInfo);
            
            harry.Trylleformel();
            magicshop.ShopMenu();
            Console.ReadLine();
            
        }
    }
}