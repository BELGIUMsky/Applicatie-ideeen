using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDesign.Interfaces
{
    public interface IUserInfo : IIndex
    {
        int UserId { get; set; }
    }
}
