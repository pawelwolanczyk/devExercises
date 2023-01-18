using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental.Movies;
using System.Data.SqlTypes;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;
using VideoRental.Users;

namespace VideoRental.RentalManagement
{
    public class RentalMovies : List<IMovie>, IXmlSerializable
    {
        public IMovie Find(string movieTitle)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Title == movieTitle)
                {
                    return this[i];
                }
            }

            return null;
        }

        public List<string> GetAllMovies()
        {
            List<string> allMovies = new List<string>();
            foreach (IMovie movie in this)
            {
                allMovies.Add(movie.Title);
            }

            return allMovies;
        }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (IMovie movie in this)
            {
                XmlSerializer movieSerializer = new XmlSerializer(Type.GetType(movie.GetType().FullName));
                movieSerializer.Serialize(writer, movie); 
            }
        }
    }
}
