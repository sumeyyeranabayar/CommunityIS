using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public List<Person> People { get; set; }

    }
}
