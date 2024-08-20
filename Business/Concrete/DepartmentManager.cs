using FluentValidation.Results;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns;
using Entities.Concrete.Dtos;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public bool Add(Department department)
        {
            bool validation = ValidationTool.Validate(new DepartmentValidator(), department);
            if (validation)
            { 
            _departmentDal.Add(department);
            MessageBox.Show("bölüm başarı ile eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
            }
            return false;
        }

        public void Delete(Department department)
        {
            var result = _departmentDal.CheckDepartmentUses(department.Id);
            if (!result)
            {
                MessageBox.Show("bu bölüme atanmış personeller olduğundan bölüm silinemiyor","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _departmentDal.Delete(department);
        }

        public Department Get(int id)
        {
            return _departmentDal.Get(g=>g.Id==id);
        }

        public int GetDepartmentId(string departmentName)
        {
            return _departmentDal.GetList().Where(d => d.Name == departmentName).Select(s => s.Id).FirstOrDefault();
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetList();
        }

        public List<DepartmentDto> GetListEmployeeCount()
        {
            return _departmentDal.GetListEmployeeCount();
        }

        public List<Department> GetListWithStatusTrue()
        {
            return _departmentDal.GetListWithStatusTrue();
        }

        public bool StatusChange(Department department)
        {
            _departmentDal.StatusChange(department);
            MessageBox.Show("Durum güncelleme işlemi başarılıyla gerçekleşti", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool Update(Department department)
        {
            bool validation = ValidationTool.Validate(new DepartmentValidator(), department);
            if (validation)
            {
                _departmentDal.Update(department);
                MessageBox.Show("güncelleme işlemi başarılıyla gerçekleşti", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;

            //DepartmentValidator validationRules = new DepartmentValidator();
            //ValidationResult validationResult = validationRules.Validate(department);
            //IList<ValidationFailure> failures = validationResult.Errors;
            //if (validationResult.IsValid)
            //{
            //    foreach (ValidationFailure failure in failures)
            //    {
            //        MessageBox.Show(failure.ErrorMessage, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    return false;
            //}
            //else
            //{
                
            //}



        }
    }
}
