using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    class ConvertVisitor : DocumentPartVisitor
    {
        private ITextConverter converter;

        public ConvertVisitor(ITextConverter textConverter)
        {
            converter = textConverter;
        }

        public string ConvertedString { get; private set; }

        protected override void Visit(BoldText boldText)
        {
            ConvertedString = converter.Convert(boldText);
        }

        protected override void Visit(Hyperlink hyperlink)
        {
            ConvertedString = converter.Convert(hyperlink);
        }

        protected override void Visit(PlainText plainText)
        {
            ConvertedString = converter.Convert(plainText);
        }
    }
}
