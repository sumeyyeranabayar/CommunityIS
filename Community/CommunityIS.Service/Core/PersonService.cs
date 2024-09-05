using CommunityIS.Service.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{

    public class PersonService : IPersonService
    {
        protected CommunityContext _context;

        public PersonService(CommunityContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)   //
        {
            _context.People.Add(person);
            _context.SaveChanges();
        }

        public void DeletePerson(int personId)   //
        {
            var person = _context.People.Find(personId);

            if (person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }
        }

        public List<Person> GetAllPeople()   //
        {
            return _context.People
                   .Include(p => p.PersonRoles)
                   .ThenInclude(pr => pr.Role)
                   .Include(p => p.PersonRoles)
                   .ThenInclude(pr => pr.Community)
                   .Include(p => p.Department) 
                   .ToList();
        }



        public Person GetPersonById(int personId)   //
        {
            var person = _context.People.Find(personId);
            return person;
        }

        public void UpdatePerson(Person person)
        {
            _context.People.Update(person);
            _context.SaveChanges();
        }

        public void UpdatePerson(Person person, PersonRole personRole)
        {
            // Kişiyi güncelle
            _context.People.Update(person);

            // Mevcut PersonRole bilgilerini bul ve güncelle
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
                // Eğer mevcut PersonRole yoksa, yenisini ekle
                _context.PersonRoles.Add(personRole);
            }

            // Değişiklikleri kaydet
            _context.SaveChanges();
        }
    }

    interface IPersonService
    {
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void UpdatePerson(Person person, PersonRole personRole);
        void DeletePerson(int personId);
        Person GetPersonById(int personId);
        List<Person> GetAllPeople();
    }
}
