﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal :IEntityRepository<Employee>
    {
        bool CheckIdentityNumber(string identityNumber);
        List<EmployeeDto> GetEmployeeList();
        //izin günleri formu için arama kısmı için list
        List<OffDayEmployeeDto> GetEmployeeByOffDay();
    }
}
