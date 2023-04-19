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
    public partial class frmCource : Form
    {
        public frmCource()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var db = new SchoolDbContext();

            var course = new Course
            {
                Name = tbName.Text,
                Year = float.Parse(tbYear.Text),
                Duration = tbDuration.Text,
                Description = tbDescription.Text
            };

            db.Courses.Add(course);
            db.SaveChanges();

            MessageBox.Show("ثبت موفق دوره آموزشی.");
        }
    }
}
