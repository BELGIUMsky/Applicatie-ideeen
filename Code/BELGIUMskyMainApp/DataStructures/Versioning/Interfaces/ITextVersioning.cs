using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Versioning.Interfaces
{
    /// <summary>
    /// Basic Text Versioning item
    /// </summary>
    public interface ITextVersioning : IBasicVersioning
    {
        /// <summary>
        /// Text
        /// </summary>
        string Text { get; set; }
    }
}
