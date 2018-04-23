using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    class ConvertVisitor : DocumentPartVisitor
    {
        public string ConvertedString { get; private set; }

        protected override void Visit(BoldText boldText)
        {
            ConvertedString = boldText.Text;
        }

        protected override void Visit(Hyperlink hyperlink)
        {
            ConvertedString = hyperlink.Url + hyperlink.Text;
        }

        protected override void Visit(PlainText plainText)
        {
            ConvertedString = plainText.Text;
        }
    }
}
