using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    internal class StreamingMovie : IMovie
    {
        string _title;

        public StreamingMovie(string Title)
        {
            _title = Title;
        }
        public string Title => _title;

        public bool IsAvailable => true;

        public bool Rent(DateTime Start, DateTime endTime)
        {
            return true;
        }
    }
}
