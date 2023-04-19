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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var db = new SchoolDbContext();

            var subject = new Subject
            {
                Name = tbSubjectName.Text
            };

            db.Subjects.Add(subject);
            db.SaveChanges();

            MessageBox.Show("ثبت موفق درس.");
        }
    }
}
