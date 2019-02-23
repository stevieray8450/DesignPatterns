using System.Collections.Generic;

namespace Iterator
{
    public class NYPaper : INewspaper
    {
        private List<string> _reporters;

        public NYPaper()
        {
            _reporters = new List<string> 
            {
                "Susanna Lee",
                "Paul Randy",
                "Kim Fields",
                "Sky Taylor",
                "Whoose Goldstein"
            };
        }

        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}