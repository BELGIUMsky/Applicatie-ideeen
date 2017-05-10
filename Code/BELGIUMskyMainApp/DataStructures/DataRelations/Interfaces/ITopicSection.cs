using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataRelations.Interfaces
{
    public interface ITopicSection
    {
        string Id { get; set; }       // contains numberOf2Digits, creationDatetime
        string TopicId { get; set; }
    }
}
