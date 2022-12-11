using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RentalAsia
{
    [XmlRootAttribute("ListaFilmow", Namespace = "http://www.filmy.com", IsNullable = false)]
    public class ListMovies 
    {
        private List<IMovie> _movies = new List<IMovie>();

        public void Add(IMovie movie)
        {
            _movies.Add(movie);
        }

        public int Count { get { return _movies.Count; } }

        public IMovie this[int index]
            { get { return _movies[index]; } }

        public void RemoveAt(int index)
        {
            _movies.RemoveAt(index);
        }

        public void AddRange(IList<IMovie> movies)
        {
            _movies.AddRange(movies);
        }

        [XmlArray("Film")]
        public string[] Items
        {
            get
            {
                List<string> items = new List<string>();
                foreach (IMovie movie in _movies)
                {
                    items.Add(movie.GetTitle());
                }
                return items.ToArray();
            }

            set
            {

            }
        }
    }
}
