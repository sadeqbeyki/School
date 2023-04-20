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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var db = new SchoolDbContext();

            var teacher = new Teacher
            {
                FullName = tbName.Text,
                PersonnelNumber = tbPersonnelNumber.Text,
            };

            db.Teachers.Add(teacher);
            db.SaveChanges();

            MessageBox.Show("ثبت موفق آموزگار.");
        }
    }
}
