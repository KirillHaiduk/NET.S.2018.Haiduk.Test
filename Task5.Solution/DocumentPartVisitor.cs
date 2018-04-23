using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public abstract class DocumentPartVisitor
    {
        public void DynamicVisit(DocumentPart documentPart) => Visit((dynamic)documentPart);
        protected abstract void Visit(BoldText boldText);
        protected abstract void Visit(Hyperlink hyperlink);
        protected abstract void Visit(PlainText plainText);
    }
}
