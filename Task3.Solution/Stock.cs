using System;
using Task3.Solution;

namespace Task3
{
    public class Stock
    {
        public int USD { get; private set; }

        public int Euro { get; private set; }

        public delegate void StockEventHandler(object sender, StockEventArgs e);
        
        public event StockEventHandler ChangeCurrency = delegate { };

        public Stock(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }

        public void Market()
        {
            Random rnd = new Random();
            this.USD = rnd.Next(20, 40);
            this.Euro = rnd.Next(30, 50);
            OnChangeCurrency(this, new StockEventArgs(this.Euro, this.USD));
        }

        protected virtual void OnChangeCurrency(object sender, StockEventArgs e) => ChangeCurrency?.Invoke(sender, e);
    }
}
