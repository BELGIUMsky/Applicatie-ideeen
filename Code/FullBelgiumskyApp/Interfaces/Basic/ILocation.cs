using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Basic
{
    public interface ILocation : IIndex
    {
        string StreetName { get; set; }
        int HouseNumber { get; set; }
        int PostalCode { get; set; }
        string City { get; set; }
    }
}
