using System;

namespace Task3.Solution
{
    public class StockEventArgs : EventArgs
    {
        private int euro;
        private int usd;

        public StockEventArgs(int euro, int usd)
        {
            this.euro = euro;
            this.usd = usd;
        }

        public int Euro => euro;
        public int USD => usd;
    }
}
