using System;
using System.Collections.Generic;
using System.IO;
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
        public string Title => _title;

        public bool IsAvailable => true;

        public bool Rent(DateTime Start, DateTime endTime)
        {
            return true;
        }

        public int CompareTo(object obj)
        {
            if (obj is IMovie)
            {
                IMovie movie = (IMovie)obj;
                return this.Title.CompareTo(movie.Title);
            }
            else
                throw new InvalidDataException();
        }
    }
}
