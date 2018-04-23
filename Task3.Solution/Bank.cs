using System;
using Task3.Solution;

namespace Task3
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;            
        }

        public void Register(Stock stock)
        {
            stock.ChangeCurrency += StockChangeCurrency;
        }

        public void StopTrade(Stock stock)
        {
            stock.ChangeCurrency -= StockChangeCurrency;
        }

        private void StockChangeCurrency(object sender, StockEventArgs e)
        {
            if (e.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, e.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, e.Euro);
        }
    }
}
