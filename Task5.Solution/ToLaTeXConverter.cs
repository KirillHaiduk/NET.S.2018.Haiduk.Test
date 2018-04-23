using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class ToLaTeXConverter : ITextConverter
    {
        public string Convert(DocumentPart part) => part.ToLaTeX();
    }
}
