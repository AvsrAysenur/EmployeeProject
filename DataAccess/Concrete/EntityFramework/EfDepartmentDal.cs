using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRespositoryBase<Department, EmployeeDbContext>, IDepartmentDal
    {
        //public void Add(Department department)
        //{
        //    using(var context=new EmployeeDbContext())
        //    { 
        //        context.Departments.Add(department);
        //        context.SaveChanges();
        //    }
        //}

        public bool CheckDepartmentUses(int departmentId)
        {
            using (var context= new EmployeeDbContext())
            {
                var result = context.Employees.Where(e => e.DepartmentId == departmentId);
                return (result.Count() > 0 ? false : true);
            }
        }

        //public void Delete(Department department)
        //{
        //    using (var context = new EmployeeDbContext())
        //    {
        //        context.Departments.Remove(department);
        //        context.SaveChanges();
        //    }
        //}

        //public Department Get(int id)
        //{
        //    using (var context = new EmployeeDbContext())
        //    {
        //        var result= context.Departments.Where(c=> c.Id ==id).FirstOrDefault();
        //        return result;
        //    }
        //}

        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = from department in context.Departments
                             select new Department
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 Status = department.Status
                             };
                return result.ToList();
            }
        }

        public List<DepartmentDto> GetListEmployeeCount()
        {
            using (var context= new EmployeeDbContext())
            {
                var result = from department in context.Departments
                             select new DepartmentDto
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 EmployeeCount = context.Employees.Where(e => e.DepartmentId == department.Id && e.Status != "isten ayrıldı").Count()
                             };
                return result.ToList();
            }
        }

        public List<Department> GetListWithStatusTrue()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = from department in context.Departments
                             where department.Status==true
                             select new Department
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 Status = department.Status
                             };
                return result.ToList();
            }
        }

        public void StatusChange(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                if (department.Status)
                {
                    department.Status = false;
                }
                else
                {
                    department.Status = true;
                }
                context.Departments.Update(department);
                context.SaveChanges();
            }
        }

    }
}
