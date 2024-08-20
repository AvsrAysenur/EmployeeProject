using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOffDayDal : EfEntityRespositoryBase<OffDay, EmployeeDbContext>, IOffDayDal
    {
        public List<OffDayDto> GetEmployeeOffDays(int employeeId)
        {
            using (var context =new EmployeeDbContext())
            {
                var result = from offday in context.OffDays
                             join employee in context.Employees on offday.EmployeeId equals employee.Id
                             where offday.EmployeeId == employeeId
                             select new OffDayDto
                             {
                                 Id = offday.Id,
                                 EmployeeId = offday.Id,
                                 Date = offday.Date,
                                 Name = employee.Name
                             };
                return result.OrderByDescending(o =>o.Date).ToList();
            }
        }

        
    }
}
