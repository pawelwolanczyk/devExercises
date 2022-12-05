using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RentalAsia
{
    public interface IMovie // : ISerializable
    {
        string GetTitle();
        bool Rent(DateTime Start, DateTime endTime);
        bool IsAvailable();
    }
}
