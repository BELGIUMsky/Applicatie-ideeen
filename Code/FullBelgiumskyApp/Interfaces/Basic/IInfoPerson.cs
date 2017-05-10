using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Basic
{
    public interface IInfoPerson : IIndex
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
