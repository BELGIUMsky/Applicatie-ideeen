using Interfaces.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Categorizing
{
    public interface ICategory : IBasicInfo
    {
        string Name { get; set; }
    }
}
