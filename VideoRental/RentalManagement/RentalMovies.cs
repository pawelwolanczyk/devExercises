﻿using System;
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
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
        }

        public void WriteXml(XmlWriter writer)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(String.Empty, String.Empty);

            foreach (IMovie movie in this)
            {
                XmlSerializer movieSerializer = new XmlSerializer(movie.GetType());
                movieSerializer.Serialize(writer, movie, ns);
            }
        }
    }
}
