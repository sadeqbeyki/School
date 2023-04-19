using Microsoft.EntityFrameworkCore;
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
    public partial class FindTop : Form
    {
        public FindTop()
        {
            InitializeComponent();
        }

        private void btnFindSG_Click(object sender, EventArgs e)
        {
            SchoolDbContext db = new SchoolDbContext();


            // دروسی را که دانش‌آموزان آن را گرفته‌اند را با همراهی نمرات آن‌ها برمی‌گرداند.
            var grades = db.Grades
                .Where(g => g.Subject.CourseSubjects.Any(cs => cs.Course.Year == float.Parse(tbYear.Text)))
                .Include(g => g.Subject)
                .Include(g => g.Student)
                .ToList();



            // برای هر معلم، بهترین نمره‌ای که دانش‌آموزانش گرفته‌اند را برمی‌گرداند.
            var top = grades
                .GroupBy(g => g.Subject.TeacherSubjects.FirstOrDefault()?.Teacher)
                .Select(g => new
                {
                    Teacher = g.Key,
                    BestGrade = g.OrderByDescending(g => g.Value).FirstOrDefault()
                }).ToList();
            //.Where(g => g.Teacher != null && g.BestGrade != null)
            //.ToList();

            dgTopTeachers.DataSource = top;

            // نتایج را چاپ می‌کند.
            //foreach (var result in top)
            //{
            //    Console.WriteLine($"Teacher: {result.Teacher.Name} - Best Grade: {result.BestGrade.Value} - Student: {result.BestGrade.Student.FullName} - Subject: {result.BestGrade.Subject.Name}");
            //}
        }
    }
}
