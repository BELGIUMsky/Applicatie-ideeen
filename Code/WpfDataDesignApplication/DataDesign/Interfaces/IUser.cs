using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDesign.Interfaces
{
    public interface IUser : IIndex
    {
    #region Variables
        string Email { get; set; }
        string UserName { get; set; }
    #endregion

    #region Virtual Variables
        ICollection<IUserInfo> AuthorInfo { get; set; }
    #endregion
    }
}
