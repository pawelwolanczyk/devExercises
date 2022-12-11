using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RentalAsia.MovieExporter
{
    public class XMLMovieExporter : IMovieExporter
    {
        public void Export(ListMovies movies)
        {
            FileStream fs = new FileStream("C:\\Source\\Movies.xml", FileMode.OpenOrCreate);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ListMovies));
            xmlSerializer.Serialize(fs, movies);
        }
    }
}
