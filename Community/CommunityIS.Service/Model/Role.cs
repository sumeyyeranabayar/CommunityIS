﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<PersonRole> PersonRoles { get; set; }
    }

}
