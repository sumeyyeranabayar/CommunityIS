using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class PersonRole
    {
        public int PersonId { get; set; }
        public int RoleId  { get; set; }
        public int CommunityId {  get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public Person Person { get; set; }
        public Role Role { get; set; }
        public Community Community { get; set; }
    }
}
