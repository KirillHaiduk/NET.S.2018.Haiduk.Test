using Task5.Solution;

namespace Task5
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract string ToHtml();

        public abstract string ToPlainText();

        public abstract string ToLaTeX();

        public void Converter(DocumentPartVisitor visitor)
        {
            visitor.DynamicVisit(this);
        }
    }
}
