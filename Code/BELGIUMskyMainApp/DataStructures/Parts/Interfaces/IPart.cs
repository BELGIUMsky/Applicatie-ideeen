using DataStructures.Versioning.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Parts.Interfaces
{
    public interface IPart : IBasicVersioning
    {
        /// <summary>
        /// Index
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Name of the Part
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// List of Parent Parts
        /// tip: use the virtual keyword
        /// </summary>
        ICollection<IPart> Parents { get; set; }

        /// <summary>
        /// List of Child Parts
        /// tip: use the virtual keyword
        /// </summary>
        ICollection<IPart> Children { get; set; }
    }
}
