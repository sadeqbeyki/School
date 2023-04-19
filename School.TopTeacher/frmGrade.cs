using Microsoft.EntityFrameworkCore;
using School.TopTeacher.Models;
using School.TopTeacher.Persistance;

namespace School.TopTeacher;

public partial class frmGrade : Form
{
    public frmGrade()
    {
        InitializeComponent();

        using var db = new SchoolDbContext();

        var subjects = db.Subjects.ToList();
        cbSubjectName.DataSource = subjects;
        cbSubjectName.DisplayMember = "Name";
        cbSubjectName.ValueMember = "Id";

        var students = db.Students.ToList();
        cbStudentName.DataSource = students;
        cbStudentName.DisplayMember = "FullName";
        cbStudentName.ValueMember = "Id";

        dgGrade.AutoGenerateColumns = true;

        var grades = db.Grades.Select(g => new
        {
            StudentName = g.Student.FullName,
            SubjectName = g.Subject.Name,
            GradeValue = g.Value.ToString()
        }).ToList();

        dgGrade.DataSource = grades;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        using var db = new SchoolDbContext();

        var selectedSubject = (Subject)cbSubjectName.SelectedItem;
        var selectedStudent = (Student)cbStudentName.SelectedItem;

        var grade = new Grade
        {
            SubjectId = selectedSubject.Id,
            StudentId = selectedStudent.Id,
            Value = float.Parse(tbValue.Text)
        };

        db.Grades.Add(grade);
        db.SaveChanges();

        MessageBox.Show("نمره موردنظر به دانش آموز اختصاص داده شد");
    }

}