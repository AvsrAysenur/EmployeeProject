using Business.Abstract;
using DevExpress.XtraEditors;
using Entities.Concrete;
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
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        private readonly IOffDayService _offDayService;
        public XtraEmployeeList employeeList;
        public XtraHome(IDepartmentService departmentService, IEmployeeService employeeService, IOffDayService offDayService)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;
            _offDayService = offDayService;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetEmployeeListForm();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDepartment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraDepartment department;
            department = new XtraDepartment(_departmentService);
            // department.MdiParent = this;
            department.Show();
        }


        private void XtraHome_Load(object sender, EventArgs e)
        {
            GetEmployeeListForm();
        }
        void GetEmployeeListForm()
        {
            if (employeeList == null || employeeList.IsDisposed)
            {
                employeeList = new XtraEmployeeList(_employeeService, _departmentService,_offDayService);
                employeeList.MdiParent = this;
                employeeList.Show();
            }
            else
            {
                employeeList.Focus();
            }
        }
        private void btnEmployeeAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraEmployeeAdd employee;
            employee = new XtraEmployeeAdd(_departmentService, _employeeService);
            employee.employeeList = employeeList;
            employee.Show();
        }

        private void btnOffDayAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraOffDayAdd offDayAdd;
            offDayAdd = new XtraOffDayAdd (_employeeService , _offDayService);
            offDayAdd.employeeList = employeeList;
            offDayAdd.Show();
        }
    }

}