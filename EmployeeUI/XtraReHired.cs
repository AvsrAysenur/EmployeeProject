using Business.Abstract;
using DevExpress.XtraEditors;
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
    public partial class XtraReHired : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;

        public XtraEmployeeList employeeList;
        public int employeeId = 0;


        public XtraReHired(IEmployeeService employeeService)
        {
            InitializeComponent();
           _employeeService = employeeService;
        }

        private void XtraReHired_Load(object sender, EventArgs e)
        {
            txtStartingDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("personeli işe almak istiyor musunuz?","işe al?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _employeeService.Get(employeeId);
                result.EndingDate = null;
                result.ReasonOfLeaving = null;
                result.Status = "calisiyor";
                result.StartingDate = Convert.ToDateTime(txtStartingDate.Text);
                _employeeService.ReHired(result);

                employeeList.GetList();
                this.Close();
            }
        }
    }
}