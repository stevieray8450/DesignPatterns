using System.Collections.Generic;

namespace Iterator
{
    public class NYPaperIterator : IIterator
    {
        private List<string> _reporters;
        private int _current;

        public NYPaperIterator(List<string> reporters)
        {
            _reporters = reporters;
            _current = 0;
        }

        public void First()
        {
            _current = 0;
        }

        public string Next()
        {
            return _reporters[_current++];
        }

        public bool IsDone()
        {
            return _current >= _reporters.Count;
        }

        public string CurrentItem()
        {
            return _reporters[_current];
        }
    }
}