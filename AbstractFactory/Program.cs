namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("At first you go to the");

            ActionInShop(new FoodFactory());

            Console.WriteLine("------------------------");

            Console.WriteLine("After that you go to the");

            ActionInShop(new CarFactory());
        }

        static void ActionInShop(IAbstractFactory factory)
        {
            var shop = factory.CreateBuilding();
            
            var product = factory.CreateProduct();

            shop.DisplayName();

            Console.WriteLine("You see:");

            product.DisplayName();

            Console.WriteLine($"And it's cost {product.GetPrice()}");
        }
    }
}