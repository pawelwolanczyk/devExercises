using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Movies
{
    public class StreamingMovie : IMovie
    {
        string _title;

        public StreamingMovie(string Title)
        {
            _title = Title;
        }

        public StreamingMovie() 
        { 

        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public bool IsAvailable
        {
            get { return true; }
            set { }
        }

        public bool Rent(DateTime Start, DateTime endTime)
        {
            return true;
        }
    }
}
