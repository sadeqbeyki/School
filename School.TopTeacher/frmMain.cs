using School.TopTeacher.Models;
using School.TopTeacher.Persistance;

namespace School.TopTeacher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            using var db = new SchoolDbContext();

            //CourseSubjects
            var subjects = db.Subjects.ToList();
            cbSubjectCS.DataSource = subjects;
            cbSubjectCS.DisplayMember = "Name";
            cbSubjectCS.ValueMember = "Id";

            var courses = db.Courses.ToList();
            cbCourseCS.DataSource = courses;
            cbCourseCS.DisplayMember = "Name";
            cbCourseCS.ValueMember = "Id";

            //TeacherSubjects
            cbSubjectTS.DataSource = subjects;
            cbSubjectTS.DisplayMember = "Name";
            cbSubjectTS.ValueMember = "Id";

            var teachers = db.Teachers.ToList();
            cbTeacherTS.DataSource = teachers;
            cbTeacherTS.DisplayMember = "FullName";
            cbTeacherTS.ValueMember = "Id";


        }


        private void btnSaveCS_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new SchoolDbContext();

                var course = db.Courses.Find(cbCourseCS.SelectedValue);

                var subject = db.Subjects.Find(cbSubjectCS.SelectedValue);

                var courseSubject = new CourseSubject { Course = course, Subject = subject };

                db.CourseSubject.Add(courseSubject);
                db.SaveChanges();
                MessageBox.Show("Done!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("افزودن مورد تکرای امکانپذیر نیست");

            }

        }

        private void btnSaveTS_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new SchoolDbContext();

                var subject = db.Subjects.Find(cbSubjectTS.SelectedValue);
                var teacher = db.Teachers.Find(cbTeacherTS.SelectedValue);


                var teacherSubject = new TeacherSubject { Teacher = teacher, Subject = subject };

                db.TeacherSubject.Add(teacherSubject);
                db.SaveChanges();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mnuAddCourse_Click(object sender, EventArgs e)
        {
            frmCource cource = new frmCource();
            cource.ShowDialog();
        }

        private void mnuAddStudent_Click(object sender, EventArgs e)
        {
            frmStudent student = new frmStudent();
            student.ShowDialog();
        }

        private void mnuAddGrade_Click(object sender, EventArgs e)
        {
            frmGrade grade = new frmGrade();
            grade.ShowDialog();
        }

        private void mnuAddTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher teacher = new frmTeacher();
            teacher.ShowDialog();
        }

        private void mnuAddSubject_Click(object sender, EventArgs e)
        {
            frmSubject subject = new frmSubject();
            subject.ShowDialog();
        }

        private void mnuFindTop_Click(object sender, EventArgs e)
        {
            FindTop findTop = new FindTop();
            findTop.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Close();
        }
    }
}
