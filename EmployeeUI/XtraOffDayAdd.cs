using Business.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraOffDayAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IOffDayService _offDayService;
        public XtraEmployeeList employeeList;
        int employeeId = 0;

        public XtraOffDayAdd(IEmployeeService employeeService, IOffDayService offDayService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _offDayService = offDayService;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraOffDayAdd_Load(object sender, EventArgs e)
        {
            GetEmployeeList();
            txtStartDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtEndDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        void GetEmployeeList()
        {
            var result = _employeeService.GetEmployeeByOffDay();
            txtEmployee.Properties.DataSource = result;
            txtEmployee.Properties.DisplayMember = "Name";
        }

        private void txtEmployee_EditValueChanged(object sender, EventArgs e)
        {
            //içerisndeki veri değiştiyse bu metot çağırılır
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = txtEmployee.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;


                int rowHandle = view.FocusedRowHandle;
                // FocusedRowHandle değerini kullanarak diğer işlemleri burada gerçekleştirin
                string fieldName = "Id";
                object value = view.GetRowCellValue(rowHandle, fieldName);
                if (value == null)
                {
                    MessageBox.Show("seçilen personel Id'si alınamadı");
                    return;
                }
                employeeId = (int)value;
                MessageBox.Show("personel Id :" + employeeId);

            }
            catch (Exception error)
            {
                MessageBox.Show("Hata: " + error.Message);
                // Genel bir hata durumunda kullanıcıya bilgi vermek için bir mesaj kutusu gösterilebilir.
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var result = _offDayService.Add(employeeId,txtStartDate.Text,txtEndDate.Text);
            if (result)
            {
                employeeList.GetList();
                this.Close();
            }
        }
    }
}