using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
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
            if (e.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, e.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, e.USD);
        }
    }
}
