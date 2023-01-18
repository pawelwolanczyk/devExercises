using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using VideoRental.Users;
using System.IO;
using VideoRental.RentalManagement;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace VideoRental.Serializable
{
    public class SerializeToXml
    {
        //public void SerializeListUsersNormalToXml()
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(RentalMovies));
        //    using (Stream fs = new FileStream("ListUsers.xml", FileMode.OpenOrCreate))
        //    {  
        //        serializer.Serialize(fs, );
        //    }
        //}


        //Muszę wiedzieć co chcę importować do xml 
        //Gdzie chcę to importować
        //Klasa musi być publiczna
        //Mogą to byś propertys 
        //Klasę którą chcę seriazlizować muszę dodać do niej [Serializable]
    }

}
