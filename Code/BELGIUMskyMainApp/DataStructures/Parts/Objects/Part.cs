using DataStructures.Parts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Parts.Objects
{
    public class Part : IPart
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<IPart> Parents { get; set; }
        public virtual ICollection<IPart> Children { get; set; }

    #region Versioning Variables
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public DateTime? MarkedForDeletionDate { get; set; }
    #endregion

        public Part() { }
    }
}
