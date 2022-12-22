using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrzejRental.RentalUtils
{
    internal class StreamingMovie : IMovie
    {
        string _title;

        public StreamingMovie(string Title)
        {
            _title = Title;
        }
        public string GetTitle()
        {
            return _title;
        }

        public bool IsAvailable()
        {
            return true;
        }

        public bool Rent(DateTime Start, DateTime endTime)
        {
            return true;
        }
    }
}
