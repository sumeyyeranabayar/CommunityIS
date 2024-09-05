using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class Person
    {
        public int PersonId { get; set; }

        [MaxLength(150)]
        public string NameSurname { get; set; }
        public string Email { get; set;}

        [MaxLength(20)]
        public string Tel { get; set; }
        public int DepartmentId {  get; set; }  
        public Department Department { get; set; }
        public List<PersonRole> PersonRoles { get; set; }

    }
}
