using CommunityIS.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{
    public class RoleService : IRoleService
    {
        protected CommunityContext _context;

        public RoleService(CommunityContext context)
        {
            _context = context;
        }

        public void AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(int roleId)
        {
            var role = _context.Roles.Find(roleId);

            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }

        public Role GetRoleById(int roleId)
        {
            var role = _context.Roles.Find(roleId);
            return role;
        }

        public List<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }
    }

    interface IRoleService 
    {
        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(int roleId);
        Role GetRoleById(int roleId);
        List<Role> GetAllRoles();
    }
}
