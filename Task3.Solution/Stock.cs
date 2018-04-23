using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution;

namespace Task3
{
    public class Stock
    {
        private StockInfo stocksInfo;

        public delegate void StockEventHandler(object sender, StockEventArgs e);
        
        public event StockEventHandler ChangeCurrency = delegate { };

        public Stock()
        {            
            stocksInfo = new StockInfo();
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnChangeCurrency(this, new StockEventArgs(stocksInfo.Euro, stocksInfo.USD));
        }

        protected virtual void OnChangeCurrency(object sender, StockEventArgs e) => ChangeCurrency?.Invoke(sender, e);
    }
}
