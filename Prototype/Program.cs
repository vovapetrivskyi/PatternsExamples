namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original object:");

            Record record = new Record();
            record.Message = "Original message";
            record.Number = 3;

            record.DisplayInfo();

            Console.WriteLine("Clonning...");

            Thread.Sleep(1000);

            Record copyRecord = record.Clone() as Record;

            copyRecord.DisplayInfo();

            Console.WriteLine("Edit clonned product fields");

            copyRecord.Message = "Coppied message";
            copyRecord.Number = 7;

            Console.WriteLine("Original object:");
            record.DisplayInfo();

            Console.WriteLine("Copy of the object");
            copyRecord.DisplayInfo();

            Console.WriteLine("-----------------------------");

            Record recordNew = record;

            recordNew.Message = "New message";
            recordNew.Number = 33;

            Console.WriteLine("New object withou clonning but with assign");
            Console.WriteLine("Original object:");
            record.DisplayInfo();

            Console.WriteLine("New object");
            recordNew.DisplayInfo();
        }
    }
}