using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace VideoRental.Movies
{
    public class BluRayMovie : MoviePhisical, IXmlSerializable
    {
        public BluRayMovie(string title, int number_of_copies) : base(title, number_of_copies)
        {

        }

        public BluRayMovie() : base(string.Empty, 0)
        {
            
        }

        public string MovieTitle
        {
            get
            {
                return Title;
            }
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
           
        }
    }
}
