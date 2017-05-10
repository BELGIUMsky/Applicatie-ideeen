using DataStructures.Versioning.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Parts.Interfaces
{
    /// <summary>
    /// Link to a source object
    /// </summary>
    public interface ISource : IBasicVersioning
    {
        /// <summary>
        /// Index
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Link to the sourcetype of this item/entry
        /// tip: use the parts table
        /// </summary>
        int TypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }
    }
}
