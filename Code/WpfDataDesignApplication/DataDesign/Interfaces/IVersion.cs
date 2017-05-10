using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDesign.Interfaces
{
    public interface IVersion : IIndex
    {
    #region Variables
        DateTime CreatedDate { get; set; }
        DateTime LastUpdatedDate { get; set; }
        DateTime? MarkedForDeletionDate { get; set; }
        int UserInfoId { get; set; }
    #endregion

    #region Virtual Variables
        IUserInfo UserInfo { get; }
    #endregion
    }
}
