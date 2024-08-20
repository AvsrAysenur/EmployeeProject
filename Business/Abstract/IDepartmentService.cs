using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        bool Add(Department department); 
        void Delete(Department department); 
        bool Update(Department department);
        bool StatusChange(Department department);
        Department Get(int id);
        int GetDepartmentId(String departmentName);
        
        List<Department>GetList();
        List<DepartmentDto> GetListEmployeeCount();
        List<Department> GetListWithStatusTrue();
    }
}
