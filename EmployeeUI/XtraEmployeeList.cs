using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DevExpress.XtraEditors;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraEmployeeList : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IOffDayService _offDayService;

        public XtraEmployeeList(IEmployeeService employeeService, IDepartmentService departmentService, IOffDayService offDayService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _departmentService = departmentService;
            _offDayService = offDayService;
        }

        private void XtraEmployeeList_Load(object sender, EventArgs e)
        {
            GetList();
        }
        public void GetList()
        {
            var employeeList = _employeeService.GetEmployeeList();

            var employees = _employeeService.GetAll().Where(e => e.Status != "isten ayrıldı").ToList();

            foreach (var item in employees)
            {
                String date = DateTime.Now.ToShortDateString();
                var result = _offDayService.GetEmployeeOffDayByDate(item.Id, Convert.ToDateTime(date));
                if (result!=null)
                {
                    item.Status = "İzinli";
                    _employeeService.UpdateList(item);
                }
                else
                {
                    item.Status = "calisiyor";
                    _employeeService.UpdateList(item);
                }
            }
            gCEmployeeList.DataSource = employeeList.ToList().Where(e => e.Status == "calisiyor").ToList();

            var departmentList = _departmentService.GetListEmployeeCount();
            gCDepartmentList.DataSource = departmentList;
            
            //.Trim() baltaki ve sondaki fazla boşlukları siler. 
            int employee = employeeList.Where(e => e.Status.Trim() == "calisiyor").Count(); 
            int off = employeeList.Where(e => e.Status.Trim() == "İzinli").Count();
            int dismiss = employeeList.Where(e => e.Status.Trim() == "isten ayrıldı").Count();
            btnEmployee.Text = "Çalışan: " + employee;
            btnOff.Text = "İzinli: " + off;
            btnDismiss.Text = "Ayrılan: " + dismiss;

            lblActiveList.Text = "Çalışan Listesi";
            gridView1.Columns[7].Visible = false;// işten ayrılma tarihi
            gridView1.Columns[8].Visible = false;//ayrılma sebebi
            gridView1.Columns[9].Visible = true;//güncelle
            gridView1.Columns[10].Visible = true;// işten çıkart
            gridView1.Columns[11].Visible = true;//sil 
            gridView1.Columns[12].Visible = false;//işe tekrar al


        }
        void GetOffEmployeeList()
        {
            var employeeList = _employeeService.GetEmployeeList().Where(e => e.Status == "İzinli").ToList();
            gCEmployeeList.DataSource = employeeList;

            lblActiveList.Text = "İzinli Listesi";

            gridView1.Columns[8].Visible = false;//ayrılma sebebi
            gridView1.Columns[7].Visible = false;// işten ayrılma tarihi
            gridView1.Columns[9].Visible = true;//güncelle
            gridView1.Columns[10].Visible = true;// işten çıkart
            gridView1.Columns[11].Visible = true;//sil 
            gridView1.Columns[12].Visible = false;//işe tekrar al
        }
        void GetDismissEmployeeList()
        {
            var employeeList = _employeeService.GetEmployeeList().Where(e => e.Status == "isten ayrıldı").ToList();
            gCEmployeeList.DataSource = employeeList;
            lblActiveList.Text = "Ayrılanlar Listesi";

            gridView1.Columns[7].Visible = true;// işten ayrılma tarihi
            gridView1.Columns[8].Visible = true;//ayrılma sebebi
            gridView1.Columns[9].Visible = false;//güncelle
            gridView1.Columns[10].Visible = false;// işten çıkart
            gridView1.Columns[11].Visible = false;//sil 
            gridView1.Columns[12].Visible = true;//işe tekrar al

        }

        private void repositoryBtnEdit_Click(object sender, EventArgs e)
        {
            //if ((gridView1.GetFocusedRow() as EmployeeDto).Status == "isten ayrıldı")
            //{
            //    MessageBox.Show("işten ayrılmış personel güncellenemez", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;
            XtraEmployeeUpdate employeeUpdate;
            employeeUpdate = new XtraEmployeeUpdate(_employeeService, _departmentService);
            employeeUpdate.employeeList = this;
            employeeUpdate.Show();
            employeeUpdate.Get(id);
        }

        private void repositoryItemBtnDelete_Click(object sender, EventArgs e)
        {
            //if ((gridView1.GetFocusedRow() as EmployeeDto).Status == "isten ayrıldı")
            //{
            //    MessageBox.Show("işten ayrılmış personel silinemez", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (MessageBox.Show($"{(gridView1.GetFocusedRow() as EmployeeDto).Name} personelini silmek istiyor musunuz?", "sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _employeeService.Get((gridView1.GetFocusedRow() as EmployeeDto).Id);
                _employeeService.Delete(result);
                MessageBox.Show("Personeli başarıyla silindi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetList();
            }
        }

        private void gCEmployeeList_Click(object sender, EventArgs e)
        {

        }

        private void repositoryBtnEmployeeQuit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if ((gridView1.GetFocusedRow() as EmployeeDto).Status == "isten ayrıldı")
            //{
            //    MessageBox.Show("işten ayrılmış personel tekrar çıkarılamaz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;

            XtraEmployeeQuit employeeQuit;
            employeeQuit = new XtraEmployeeQuit(_employeeService);
            employeeQuit.employeeList = this;
            employeeQuit.Show();
            employeeQuit.Get(id);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            GetOffEmployeeList();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            GetDismissEmployeeList();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void repositoryBtnRehired_Click(object sender, EventArgs e)
        {
            XtraReHired reHired;
            reHired = new XtraReHired(_employeeService);
            reHired.employeeList = this;
            reHired.Show();

            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;
            reHired.employeeId = id;
        }
    }
}