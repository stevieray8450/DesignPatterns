namespace Iterator
{
    public class LAPaper : INewspaper
    {
        private string[] _reporters;
        public LAPaper()
        {
            _reporters = new[] 
            {
                "Ronald Smith",
                "Danny Glover",
                "Yolanda Adams",
                "Jerry Straight",
                "Rhonda Lime"
            };
        }

        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}