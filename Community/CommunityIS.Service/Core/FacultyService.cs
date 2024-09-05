using CommunityIS.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{
    public class FacultyService : IFacultyService
    {
        protected CommunityContext _context;

        public FacultyService(CommunityContext context)
        {
            _context = context;
        }

        public void AddFaculty(Faculty faculty)
        {
            _context.Faculties.Add(faculty);
            _context.SaveChanges();
        }

        public void DeleteFaculty(int facultyId)
        {
            var faculty = _context.Faculties.Find(facultyId);
            
            if (faculty != null)
            {
                _context.Faculties.Remove(faculty);
                _context.SaveChanges();
            }
        }

        public List<Faculty> GetAllFaculties()
        {
            return _context.Faculties.ToList();
        }

        public Faculty GetFacultyById(int facultyId)
        {
            var faculty = _context.Faculties.Find(facultyId);
            return faculty;
        }

        public void UpdateFaculty(Faculty faculty)
        {
            _context.Faculties.Update(faculty);
            _context.SaveChanges();
        }
    }

    interface IFacultyService
    {
        void AddFaculty(Faculty faculty);
        void UpdateFaculty(Faculty faculty);
        void DeleteFaculty(int facultyId);
        Faculty GetFacultyById(int facultyId);
        List<Faculty> GetAllFaculties();
    }
}
