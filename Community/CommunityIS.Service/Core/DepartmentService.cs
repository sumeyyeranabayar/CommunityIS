using CommunityIS.Service.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{
    public class DepartmentService : IDerpartmentService
    {
        protected CommunityContext _context;

        public DepartmentService(CommunityContext context)
        {
            _context = context;
        }

        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void DeleteDepartment(int departmentId)
        {
            var department = _context.Departments.Find(departmentId);

            if(department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }

        public List<Department> GetAllDepartments()  
        {
            return _context.Departments
                       .Include(d => d.Faculty)
                       .ToList();

            
        }

        public Department GetDepartmentById(int departmentId)
        {
            var department = _context.Departments.Find(departmentId);
            return department;
        }

        public void UpdateDepartment(Department department)  
        {
            _context.Departments.Update(department); 
            _context.SaveChanges();
        }

        
    }

    interface IDerpartmentService
    {
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int departmentId);
        Department GetDepartmentById(int departmentId);
        List<Department> GetAllDepartments();
    }
}
