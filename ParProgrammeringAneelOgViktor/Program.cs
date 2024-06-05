namespace ParProgrammeringAneelOgViktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harry = new Character("harry", "griffindor");
            harry.Inventory.Add(new Items("phoenix feather", "wand"));
            harry.Inventory.Add(new Items("headwig", "Pet"));

            var magicshop = new MagicShop();
            magicshop.ShopMenu();
            Console.WriteLine(harry.FullInfo);
            Console.ReadLine();
        }
    }
}
