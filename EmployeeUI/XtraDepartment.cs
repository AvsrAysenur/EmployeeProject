using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
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
    public partial class XtraDepartment : DevExpress.XtraEditors.XtraForm
    {
        private readonly IDepartmentService _departmentService;
        int _id;

        public XtraDepartment(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Vazgeç")
            {
                Clear();
            }
            else
            {

            }
            this.Close();
        }

        private void XtraDepartment_Load(object sender, EventArgs e)
        {
            Getlist();
        }
        void Getlist()
        {
            var result = _departmentService.GetList();
            gC1.DataSource = result;
        }
        void Clear()
        {
            txtDepartmentName.Text = "";
            btnClose.Text = "Kapat";
            btnSave.Text = "Kaydet";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Güncellleme işlemi
            if (btnSave.Text == "Güncelle")
            {
                var findDepartment = _departmentService.Get(_id);
                findDepartment.Name = txtDepartmentName.Text.ToLower();
                var result = _departmentService.Update(findDepartment);
                if (result)
                {

                    Getlist();
                    Clear();

                }
            }
            else
            {

                // Kaydet işlemi 
                Department department = new Department
                {
                    Name = txtDepartmentName.Text.ToLower(),
                    Status = true
                };
                var result = _departmentService.Add(department);
                if (result)
                {

                    Getlist();
                    Clear();
                }

            }


        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($" {(gridView1.GetFocusedRow() as Department).Name}bölümünü silmek istiyor musunuz", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var department = (gridView1.GetFocusedRow() as Department);
                _departmentService.Delete(department);
                Getlist();
            }
        }

        private void repositoryBtnEdit_Click(object sender, EventArgs e)
        {
            _id = (gridView1.GetFocusedRow() as Department).Id;
            string name = (gridView1.GetFocusedRow() as Department).Name;
            txtDepartmentName.Text = name;
            btnSave.Text = "Güncelle";
            btnClose.Text = "Vazgeç";
        }

        private void repositoryBtnStatusChange_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($" {(gridView1.GetFocusedRow() as Department).Name} bölümünün durumunu değiştirmek istiyor musunuz", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var department = (gridView1.GetFocusedRow() as Department);
                _departmentService.StatusChange(department);
                Getlist();
            }
        }
    }
}