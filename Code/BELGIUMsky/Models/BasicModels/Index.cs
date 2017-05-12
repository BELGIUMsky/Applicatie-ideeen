using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BELGIUMsky.Models.BasicModels
{
    public class Index
    {
        public int Id { get; set; }

        public Index() { }

        public Index(int id)
        {
            this.Id = id;
        }
    }
}
