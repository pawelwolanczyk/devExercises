using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
     public class StreamingMovie : IMovie
    {
        string _title;
        public string GetTitle()
        {
            return _title;
        }
        public bool Rent(DateTime Start, DateTime endTime)
        {
            return true;
        }

        public virtual bool IsAvailable()
        {
            return true;
        }
        public StreamingMovie(string title)
        {
            _title = title;
        }
    }
}
