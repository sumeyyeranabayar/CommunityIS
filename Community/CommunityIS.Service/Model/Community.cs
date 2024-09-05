using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class Community
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public List<PersonRole> PersonRoles { get; set; }
        public List<Event> Events { get; set; }

    }
}
