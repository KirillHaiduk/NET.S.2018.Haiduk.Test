using System;

namespace Task3.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock(10, 20);
            var bank = new Bank("Some Bank");
            var broker = new Broker("Some Broker");
            bank.Register(stock);
            broker.Register(stock);
            stock.Market();
            Console.ReadLine();
        }
    }
}
