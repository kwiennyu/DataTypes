namespace DataTypes;

class DataTypesProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name: Quenie Fritz Indencio ");
        Console.Write("Section: BSCS2-1AA ");

    Console.WriteLine("\nEnter the pieces of apple: ");
        int pieces;
        pieces = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter total price of " + pieces + " apple(s)");
    double price;
    price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The total price of " +pieces + " is" +price);
        Console.WriteLine("The value of original price is " +price);

    double a = price;
    int b = (int)price;
Console.WriteLine("The value of the converted price is " +b);
Console.Write("\nPress any key to exit...");
Console.ReadKey();

    }
}
