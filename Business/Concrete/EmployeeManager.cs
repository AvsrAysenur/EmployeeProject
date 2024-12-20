﻿using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public bool Add(Employee employee)
        {
            bool validation = ValidationTool.Validate(new EmployeeValidator(), employee);
            if (validation)
            {
                var result = _employeeDal.CheckIdentityNumber(employee.IdentityNumber);
                if (!result)
                {
                    MessageBox.Show("bu T.C. numarası daha önce kullanılmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
                _employeeDal.Add(employee);
                MessageBox.Show("personel başarı ile eklendi","başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public Employee Get(int id)
        {
            return _employeeDal.Get(e=> e.Id == id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public List<OffDayEmployeeDto> GetEmployeeByOffDay()
        {
            return _employeeDal.GetEmployeeByOffDay();
        }

        public List<EmployeeDto> GetEmployeeList()
        {
            return _employeeDal.GetEmployeeList();
        }

        public void QuitJob(Employee employee)
        {
            _employeeDal.Update(employee);
            MessageBox.Show("personel başarı ile işten çıkarıldı", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ReHired(Employee employee)
        {
            _employeeDal.Update(employee);
            MessageBox.Show("personel girişi başarı ile gerçekleşti", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Update(Employee employee)
        {
            bool validation = ValidationTool.Validate(new EmployeeValidator(), employee);
            if (validation)
            {
                var findEmployee = _employeeDal.Get(i => i.Id == employee.Id);
                var result =true;
                if (findEmployee.IdentityNumber != employee.IdentityNumber)
                {
                     result = _employeeDal.CheckIdentityNumber(employee.IdentityNumber);
                    if (!result)
                    {
                        MessageBox.Show("bu T.C. numarası daha önce kullanılmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
  
                _employeeDal.Update(employee);
                MessageBox.Show("personel başarı ile güncellendi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public void UpdateList(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
