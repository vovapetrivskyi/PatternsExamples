namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory = new AppleFactory();

            CallMethods(factory);

            factory = new PotatoFactory();

            CallMethods(factory);
        }

        static void CallMethods(ProductFactory factory)
        {
            factory.DisplayInformationAboutProduct();

            Console.WriteLine(factory.GetProductType());
        }
    }
}