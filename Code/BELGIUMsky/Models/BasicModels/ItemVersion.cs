using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELGIUMsky.Models.BasicModels
{
    public class ItemVersion : Index
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public ItemVersion() : base() { }

        public ItemVersion(DateTime creationDate, DateTime lastUpdatedDate, int id) : base(id)
        {
            this.CreationDate = creationDate;
            this.LastUpdatedDate = lastUpdatedDate;
        }
    }
}
