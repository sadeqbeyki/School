namespace School.TopTeacher
{
    partial class frmGrade
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cbSubjectName = new ComboBox();
            lblSubjectName = new Label();
            cbStudentName = new ComboBox();
            label3 = new Label();
            tbValue = new TextBox();
            btnSave = new Button();
            dgGrade = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StudentId = new DataGridViewTextBoxColumn();
            SubjectId = new DataGridViewTextBoxColumn();
            GradeValue = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            gradeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 77);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "نام دانش آموز";
            // 
            // cbSubjectName
            // 
            cbSubjectName.FormattingEnabled = true;
            cbSubjectName.Location = new Point(318, 33);
            cbSubjectName.Name = "cbSubjectName";
            cbSubjectName.Size = new Size(181, 23);
            cbSubjectName.TabIndex = 8;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(547, 33);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(48, 15);
            lblSubjectName.TabIndex = 9;
            lblSubjectName.Text = "نام درس";
            // 
            // cbStudentName
            // 
            cbStudentName.FormattingEnabled = true;
            cbStudentName.Location = new Point(247, 77);
            cbStudentName.Name = "cbStudentName";
            cbStudentName.Size = new Size(252, 23);
            cbStudentName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 121);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "نمره";
            // 
            // tbValue
            // 
            tbValue.Location = new Point(338, 121);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(161, 23);
            tbValue.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(247, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgGrade
            // 
            dgGrade.AutoGenerateColumns = false;
            dgGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGrade.Columns.AddRange(new DataGridViewColumn[] { Id, StudentId, SubjectId, GradeValue, StudentName, SubjectName });
            dgGrade.DataSource = gradeBindingSource;
            dgGrade.Location = new Point(48, 179);
            dgGrade.Name = "dgGrade";
            dgGrade.RowTemplate.Height = 25;
            dgGrade.Size = new Size(548, 150);
            dgGrade.TabIndex = 14;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ردیف";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // StudentId
            // 
            StudentId.DataPropertyName = "StudentId";
            StudentId.HeaderText = "StudentId";
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            StudentId.Visible = false;
            // 
            // SubjectId
            // 
            SubjectId.DataPropertyName = "SubjectId";
            SubjectId.HeaderText = "SubjectId";
            SubjectId.Name = "SubjectId";
            SubjectId.ReadOnly = true;
            SubjectId.Visible = false;
            // 
            // GradeValue
            // 
            GradeValue.DataPropertyName = "Value";
            GradeValue.HeaderText = "نمره";
            GradeValue.Name = "GradeValue";
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "Student";
            StudentName.HeaderText = "دانش آموز";
            StudentName.Name = "StudentName";
            // 
            // SubjectName
            // 
            SubjectName.DataPropertyName = "Subject";
            SubjectName.HeaderText = "نام درس";
            SubjectName.Name = "SubjectName";
            // 
            // gradeBindingSource
            // 
            gradeBindingSource.DataSource = typeof(Models.Grade);
            // 
            // frmGrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 361);
            Controls.Add(dgGrade);
            Controls.Add(btnSave);
            Controls.Add(tbValue);
            Controls.Add(label3);
            Controls.Add(cbStudentName);
            Controls.Add(lblSubjectName);
            Controls.Add(cbSubjectName);
            Controls.Add(label1);
            Name = "frmGrade";
            RightToLeft = RightToLeft.Yes;
            Text = "افزودن نمره";
            ((System.ComponentModel.ISupportInitialize)dgGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cbSubjectName;
        private Label lblSubjectName;
        private ComboBox cbStudentName;
        private Label label3;
        private TextBox tbValue;
        private Button btnSave;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridView dgGrade;
        private BindingSource gradeBindingSource;
        private DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn GradeValue;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn SubjectName;
    }
}