using System;
namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple : ");
            int apple = int.Parse(Console.ReadLine());

            Console.Write("Enter the total price of the apple(s): ");
            double totalPrice = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total price for {apple} piece(s) of apple: {totalPrice}");

            int convertedPrice = (int)totalPrice;

            Console.WriteLine($"Original price: {totalPrice}");
            Console.WriteLine($"Converted price: {convertedPrice}");

        }
    }
}
