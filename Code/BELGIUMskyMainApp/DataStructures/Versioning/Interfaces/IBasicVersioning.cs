using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Versioning.Interfaces
{
    /// <summary>
    /// Basic versioning interface
    /// </summary>
    public interface IBasicVersioning
    {
        /// <summary>
        /// Date/Time current item/entry was created
        /// </summary>
        DateTime CreationDate { get; set; }

        /// <summary>
        /// Date/Time current item/entry was last updated
        /// </summary>
        DateTime LastUpdatedDate { get; set; }

        /// <summary>
        /// Date/Time when current item/entry was marked for deletion
        /// </summary>
        DateTime? MarkedForDeletionDate { get; set; }
    }
}
