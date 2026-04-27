namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task
            int SmallRoomPrice = 25;
            int LargeRoomPrice = 35;
            decimal TaxRate = 0.06m;

            int NumSmallCarpets, NumLargeCarpets;


            Console.WriteLine("welcome to our carpet cleaning sevice");
            Console.WriteLine("please enter the number of rooms you would to clean ");
            Console.WriteLine();

            Console.WriteLine("number of small carpets...");
            NumSmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number of large carpets...");
            NumLargeCarpets = Convert.ToInt32(Console.ReadLine());

            decimal Cost = (NumLargeCarpets * LargeRoomPrice) + (NumSmallCarpets * SmallRoomPrice);
            decimal Tax = Cost * TaxRate;
            decimal Total = Cost + Tax;

            Console.WriteLine();
            Console.WriteLine("price list...");
            Console.WriteLine($"price per small room: {SmallRoomPrice:c}");
            Console.WriteLine($"price per large room: {LargeRoomPrice:c}");
            Console.WriteLine($"tax rate is :{TaxRate:p}");

            Console.WriteLine();
            Console.WriteLine($"cost : {Cost:c} ");
            Console.WriteLine($"tax : {Tax:c}  ");

            Console.WriteLine();
            Console.WriteLine("================================== ");

            Console.WriteLine();
            Console.WriteLine($"total estimate: {Total:c}");
            Console.WriteLine("this estimate is valid for 30 days");
            Console.WriteLine("have a nice day :) ");

            #endregion







        }
    }
}
