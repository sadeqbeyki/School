
using School.TopTeacher.Persistance;
using System.Data;


using C1.Win.Chart;
using C1.Chart;
using School.TopTeacher.Models;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace School.TopTeacher
{
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();


        }

        public void DrawChartA()
        {
            // Set the chart axis titles
            flexChart.AxisX.Title = "Student Name";
            flexChart.AxisY.Title = "Grade Value";

            using var db = new SchoolDbContext();
            var studentGrades = db.Grades
                .Include(g => g.Student)
                .Include(g => g.Subject)
                .OrderByDescending(g => g.Value)
                .ToList();

            var studentGroups = studentGrades.GroupBy(g => g.Student);

            foreach (var group in studentGroups)
            {
                var studentName = group.Key.FullName;

                var series = new Series
                {
                    Binding = "Value",
                    Name = studentName
                };

                flexChart.Series.Add(series);

                var studentSeries = new List<Series>();

                foreach (var grade in group)
                {
                    var subjectName = grade.Subject.Name;
                    var value = grade.Value;

                    var seriesB = new Series
                    {
                        Name = subjectName,
                        Binding = value.ToString()
                    };


                    studentSeries.Add(seriesB);
                }

                series.DataSource = studentSeries;
            }

            flexChart.ChartType = ChartType.Column;

        }

        private void DrawChartB()
        {
            using var db = new SchoolDbContext();
            List<Grade> studentGrades = db.Grades.Include(g => g.Student).OrderByDescending(g => g.Value).ToList();
            // Set the chart axis titles
            flexChart.AxisX.Title = "Student Name";
            flexChart.AxisY.Title = "Grade Value";

            flexChart.DataSource = studentGrades;

            flexChart.BindingX = "Student.FullName";
            flexChart.ChartType = ChartType.Column;
            flexChart.Series.Clear();

            var series = new Series
            {
                Binding = "Value",
                Name = "Student"
            };

            flexChart.Series.Add(series);
        }

        public void TopStudent()
        {
            using var db = new SchoolDbContext(); var students = db.Students
                .Include(s => s.Grades)
                .ThenInclude(g => g.Subject)
                .ToList();

            var bestStudent = students
                .OrderByDescending(s => s.Grades.Sum(g => g.Value))
                .FirstOrDefault();

            if (bestStudent != null)
            {
                var chartData = bestStudent.Grades.Select(g => new { Subject = g.Subject.Name, Value = g.Value });

                flexChart.DataSource = chartData;
                flexChart.BindingX = "Subject";
                flexChart.Series.Clear();

                var series = new Series
                {
                    Binding = "Value",
                    Name = bestStudent.FullName
                };

                flexChart.Series.Add(series);
            }

        }

        public void TopGradeSum()
        {
            // Set the chart axis titles
            flexChart.AxisX.Title = "Student Name";
            flexChart.AxisY.Title = "Grade Value";

            using var db = new SchoolDbContext();
            var topStudents = db.Grades
                .Include(g => g.Student)
                .GroupBy(g => g.Student)
                .Select(g => new { Student = g.Key, TotalGrade = g.Sum(x => x.Value) })
                .OrderByDescending(g => g.TotalGrade)
                .Take(10)
                .ToList();

            var series = new Series
            {
                Binding = "TotalGrade",
                Name = "Top Students"
            };

            var dataSource = new List<object>();

            foreach (var student in topStudents)
            {
                dataSource.Add(new { StudentName = student.Student.FullName, TotalGrade = student.TotalGrade });
            }

            series.DataSource = dataSource;

            flexChart.Series.Clear();
            flexChart.Series.Add(series);
            flexChart.ChartType = ChartType.Column;
        }

        public void TopStudentGradeSum()
        {
            using var db = new SchoolDbContext();
            var topGrades = db.Grades
                .OrderByDescending(g => g.Value)
                .Take(5) // تعداد دلخواه بالاترین نمرات
                .Include(g => g.Student) // اضافه کردن اطلاعات دانش آموز
                .Include(g => g.Subject) // اضافه کردن اطلاعات درس
                .ToList();

            // ساخت یک لیست از نمرات و نام دانش آموز مربوط به آن‌ها
            var topGradeData = topGrades
                .Select(g => new { StudentName = g.Student.FullName, GradeValue = g.Value })
                .ToList();

            // تنظیمات نمودار
            flexChart.AxisX.Title = "Student Name";
            flexChart.AxisY.Title = "Grade Value";

            flexChart.DataSource = topGradeData;
            flexChart.BindingX = "StudentName";
            flexChart.Binding = "GradeValue";

            flexChart.ChartType = ChartType.Column;

        }

        private void selectChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectChart.SelectedItem.ToString())
            {
                case "نمرات برترین دانش آموز":
                    TopStudent();
                    break;
                case "بالاترین مجموع نمرات":
                    TopGradeSum();
                    break;
                case "براساس مجموع نمرات":
                    TopStudentGradeSum();
                    break;
                default:
                    break;
            }
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            selectChart.Items.Add("نمرات برترین دانش آموز");
            selectChart.Items.Add("بالاترین مجموع نمرات");
            selectChart.Items.Add("براساس مجموع نمرات");

        }
    }
}
