using Interfaces.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Categorizing
{
    public interface ICategoryRelations : IBasicInfo
    {
        int ParentCategoryId { get; set; }
        int ChildCategoryId { get; set; }
    }
}
