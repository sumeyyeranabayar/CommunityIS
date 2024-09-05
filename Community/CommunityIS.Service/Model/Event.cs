using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string? Description { get; set; }
        public DateTime EventDate { get; set; }
        public int CommunityId { get; set; }
        public Community Community { get; set; }
    }
}
