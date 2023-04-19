using School.TopTeacher.Models;
using School.TopTeacher.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.TopTeacher
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new SchoolDbContext();

            var student = new Student
            {
                FullName = tbFullName.Text,
                NationalCode = tbNationalCode.Text,
            };

            db.Students.Add(student);
            db.SaveChanges();

            MessageBox.Show("ثبت موفق دانش آموز.");
        }
    }
}
