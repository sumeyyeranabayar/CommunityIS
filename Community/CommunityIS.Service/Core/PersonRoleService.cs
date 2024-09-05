using CommunityIS.Service.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{
    public class PersonRoleService : IPersonRoleService
    {
        protected  CommunityContext _context;
        public PersonRoleService(CommunityContext context)
        {
            _context = context;
        }

        public void AddPersonRole(PersonRole personRole)   //
        {
            _context.PersonRoles.Add(personRole);
            _context.SaveChanges();
        }

        public void DeletePersonRole(int personId, int roleId)  //
        {
            var personRole = _context.PersonRoles
                                    .FirstOrDefault(pr => pr.PersonId == personId && pr.RoleId == roleId);
            if (personRole != null)
            {
                _context.PersonRoles.Remove(personRole);
                _context.SaveChanges();
            }
        }

        public void UpdatePersonRole(int personId, int roleId, int communityId, PersonRole updatedPersonRole)
        {
            var personRole = _context.PersonRoles
                                    .FirstOrDefault(pr => pr.PersonId == personId && pr.RoleId == roleId);
            if (personRole != null)
            {
                personRole.CommunityId = updatedPersonRole.CommunityId;
                personRole.IsActive = updatedPersonRole.IsActive;
                _context.SaveChanges();
            }
        }

        public PersonRole GetPersonRoleByIds(int personId, int roleId)
        {
            return _context.PersonRoles
                           .FirstOrDefault(pr => pr.PersonId == personId && pr.RoleId == roleId);
        }

        public List<PersonRole> GetPersonRolesByPersonId(int personId)   //
        {
            return _context.PersonRoles
                .Include(pr => pr.Role)
                .Include(pr => pr.Community)
                .Where(pr => pr.PersonId == personId)
                .ToList();
        }

        public List<Role> GetRolesByPersonId(int personId)
        {
            return _context.PersonRoles
                           .Where(pr => pr.PersonId == personId)
                           .Select(pr => pr.Role)
                           .ToList();
        }

        public List<Person> GetPeopleByRoleId(int roleId)
        {
            return _context.PersonRoles
                           .Where(pr => pr.RoleId == roleId)
                           .Select(pr => pr.Person)
                           .ToList();
        }

        public void UpdatePersonRole(PersonRole personRole)
        {
            _context.PersonRoles.Update(personRole);
            _context.SaveChanges();
        }

        public void UpdatePerson(Person person, PersonRole personRole)
        {
            _context.People.Update(person);

            var existingPersonRole = _context.PersonRoles
                                              .FirstOrDefault(pr => pr.PersonId == person.PersonId && pr.RoleId == personRole.RoleId);

            if (existingPersonRole != null)
            {
                existingPersonRole.CommunityId = personRole.CommunityId;
                existingPersonRole.IsActive = personRole.IsActive;
                _context.PersonRoles.Update(existingPersonRole);
            }
            else
            {
                _context.PersonRoles.Add(personRole);
            }

            _context.SaveChanges();
        }

        public void UpdatePersonRole(int personId, int roleId, int communityId, bool isActive)  //
        {
            var personRole = _context.PersonRoles.FirstOrDefault(pr => pr.PersonId == personId && pr.RoleId == roleId);
            if (personRole != null)
            {
                personRole.CommunityId = communityId;
                personRole.IsActive = isActive;
                _context.SaveChanges();
            }
        }

        public List<PersonRole> GetAllPersonRoles()  //
        {
            return _context.PersonRoles.Include(pr => pr.Person)
                                       .Include(pr => pr.Role)
                                       .Include(pr => pr.Community)
                                       .ToList();
        }

    }

    public interface IPersonRoleService
    {
        void AddPersonRole(PersonRole personRole);  //
        void DeletePersonRole(int personId, int roleId);  //
        public void UpdatePersonRole(int personId, int roleId, int communityId, bool isActive);   //
        PersonRole GetPersonRoleByIds(int personId, int roleId);
        List<PersonRole> GetPersonRolesByPersonId(int personId);
        List<Role> GetRolesByPersonId(int personId);
        List<Person> GetPeopleByRoleId(int roleId);
        void UpdatePersonRole(PersonRole personRole);
        void UpdatePerson(Person person, PersonRole personRole);
        public List<PersonRole> GetAllPersonRoles();   //
    }
}
