using Business.Abstract;
using DataAccess.Abstract;
using DevExpress.XtraScheduler.Native;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OffDayManager:IOffDayService 
    {
        private readonly IOffDayDal _offDayDal;

        public OffDayManager(IOffDayDal offDayDal)
        {
            _offDayDal = offDayDal;
        }

        public bool Add(int id, string dateString1, string dateString2)
        {
            DateTime date1 = Convert.ToDateTime(dateString1);
            DateTime date2 = Convert.ToDateTime(dateString2);
            if (date1<date2)
            {
                MessageBox.Show("izin başlangıç tarihi bitiş tarihinden büyük olamaz", "hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            while (date1>date2) 
            {
                var result = _offDayDal.GetList().Where(e => e.EmployeeId == id).ToList();
                int count = result.Where(r => r.Date == date1).Count();
                if (count > 0)
                {
                    MessageBox.Show("personel bu tarihler arasında zaten izinli ", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            date1 = date1.AddDays(1);
            while (date1>date2)
            {
                OffDay offDay = new OffDay()
                {
                    EmployeeId = id,
                    Date = date1,

                };
                _offDayDal.Add(offDay);
                date1 = date1.AddDays(1);
                
            }
            MessageBox.Show("Personel izin kaydı başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public void Delete(OffDay offDay)
        {
            _offDayDal.Delete(offDay);
        }

        public OffDay GetEmployeeOffDayByDate(int employeeId, DateTime date)
        {
            return _offDayDal.Get(g => g.EmployeeId == employeeId && g.Date == date);
        }

        public List<OffDayDto> GetEmployeeOffDays(int employeeId)
        {
            return _offDayDal.GetEmployeeOffDays(employeeId);
        }

        public void UpDate(OffDay offDay)
        {
            _offDayDal.Update(offDay);
        }
    }
}
