namespace School.TopTeacher
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbCourceSubject = new GroupBox();
            cbCourseCS = new ComboBox();
            cbSubjectCS = new ComboBox();
            btnSaveCS = new Button();
            label2 = new Label();
            label1 = new Label();
            gbTeacherSubject = new GroupBox();
            cbTeacherTS = new ComboBox();
            cbSubjectTS = new ComboBox();
            btnSaveTS = new Button();
            label4 = new Label();
            label3 = new Label();
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            افزودندانشآموزToolStripMenuItem = new ToolStripMenuItem();
            mnuAddGrade = new ToolStripMenuItem();
            mnuAddStudent = new ToolStripMenuItem();
            افزودنآموزگارToolStripMenuItem = new ToolStripMenuItem();
            mnuAddSubject = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuAddCourse = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuFindTop = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            gbCourceSubject.SuspendLayout();
            gbTeacherSubject.SuspendLayout();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // gbCourceSubject
            // 
            gbCourceSubject.Controls.Add(cbCourseCS);
            gbCourceSubject.Controls.Add(cbSubjectCS);
            gbCourceSubject.Controls.Add(btnSaveCS);
            gbCourceSubject.Controls.Add(label2);
            gbCourceSubject.Controls.Add(label1);
            gbCourceSubject.Location = new Point(46, 121);
            gbCourceSubject.Name = "gbCourceSubject";
            gbCourceSubject.Size = new Size(491, 144);
            gbCourceSubject.TabIndex = 19;
            gbCourceSubject.TabStop = false;
            gbCourceSubject.Text = "ارتباط درس با دوره آموزشی";
            // 
            // cbCourseCS
            // 
            cbCourseCS.FormattingEnabled = true;
            cbCourseCS.Location = new Point(31, 60);
            cbCourseCS.Name = "cbCourseCS";
            cbCourseCS.Size = new Size(177, 23);
            cbCourseCS.TabIndex = 8;
            // 
            // cbSubjectCS
            // 
            cbSubjectCS.FormattingEnabled = true;
            cbSubjectCS.Location = new Point(225, 60);
            cbSubjectCS.Name = "cbSubjectCS";
            cbSubjectCS.Size = new Size(170, 23);
            cbSubjectCS.TabIndex = 7;
            // 
            // btnSaveCS
            // 
            btnSaveCS.Location = new Point(31, 89);
            btnSaveCS.Name = "btnSaveCS";
            btnSaveCS.Size = new Size(75, 23);
            btnSaveCS.TabIndex = 6;
            btnSaveCS.Text = "ذخیره";
            btnSaveCS.UseVisualStyleBackColor = true;
            btnSaveCS.Click += btnSaveCS_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 42);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "نام دوره آموزشی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 42);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "نام درس";
            // 
            // gbTeacherSubject
            // 
            gbTeacherSubject.Controls.Add(cbTeacherTS);
            gbTeacherSubject.Controls.Add(cbSubjectTS);
            gbTeacherSubject.Controls.Add(btnSaveTS);
            gbTeacherSubject.Controls.Add(label4);
            gbTeacherSubject.Controls.Add(label3);
            gbTeacherSubject.Location = new Point(46, 283);
            gbTeacherSubject.Name = "gbTeacherSubject";
            gbTeacherSubject.Size = new Size(491, 144);
            gbTeacherSubject.TabIndex = 20;
            gbTeacherSubject.TabStop = false;
            gbTeacherSubject.Text = "ارتباط درس با آموزگار";
            // 
            // cbTeacherTS
            // 
            cbTeacherTS.FormattingEnabled = true;
            cbTeacherTS.Location = new Point(31, 61);
            cbTeacherTS.Name = "cbTeacherTS";
            cbTeacherTS.Size = new Size(177, 23);
            cbTeacherTS.TabIndex = 9;
            // 
            // cbSubjectTS
            // 
            cbSubjectTS.FormattingEnabled = true;
            cbSubjectTS.Location = new Point(225, 61);
            cbSubjectTS.Name = "cbSubjectTS";
            cbSubjectTS.Size = new Size(170, 23);
            cbSubjectTS.TabIndex = 8;
            // 
            // btnSaveTS
            // 
            btnSaveTS.Location = new Point(31, 90);
            btnSaveTS.Name = "btnSaveTS";
            btnSaveTS.Size = new Size(75, 23);
            btnSaveTS.TabIndex = 7;
            btnSaveTS.Text = "ذخیره";
            btnSaveTS.UseVisualStyleBackColor = true;
            btnSaveTS.Click += btnSaveTS_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 43);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "نام آموزگار";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 43);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "نام درس";
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(584, 24);
            mainMenu.TabIndex = 21;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 20);
            fileToolStripMenuItem.Text = "&فایل";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "خروج";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { افزودندانشآموزToolStripMenuItem, افزودنآموزگارToolStripMenuItem, mnuAddSubject, toolStripSeparator3, mnuAddCourse, toolStripSeparator1, mnuFindTop });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(77, 20);
            toolsToolStripMenuItem.Text = "&امور آموزش";
            // 
            // افزودندانشآموزToolStripMenuItem
            // 
            افزودندانشآموزToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAddGrade, mnuAddStudent });
            افزودندانشآموزToolStripMenuItem.Name = "افزودندانشآموزToolStripMenuItem";
            افزودندانشآموزToolStripMenuItem.Size = new Size(172, 22);
            افزودندانشآموزToolStripMenuItem.Text = "امور دانش آموزان";
            // 
            // mnuAddGrade
            // 
            mnuAddGrade.Name = "mnuAddGrade";
            mnuAddGrade.Size = new Size(161, 22);
            mnuAddGrade.Text = "اختصاص نمره";
            mnuAddGrade.Click += mnuAddGrade_Click;
            // 
            // mnuAddStudent
            // 
            mnuAddStudent.Name = "mnuAddStudent";
            mnuAddStudent.Size = new Size(161, 22);
            mnuAddStudent.Text = "افزودن دانش آموز";
            mnuAddStudent.Click += mnuAddStudent_Click;
            // 
            // افزودنآموزگارToolStripMenuItem
            // 
            افزودنآموزگارToolStripMenuItem.Name = "افزودنآموزگارToolStripMenuItem";
            افزودنآموزگارToolStripMenuItem.Size = new Size(172, 22);
            افزودنآموزگارToolStripMenuItem.Text = "افزودن آموزگار";
            افزودنآموزگارToolStripMenuItem.Click += mnuAddTeacher_Click;
            // 
            // mnuAddSubject
            // 
            mnuAddSubject.Name = "mnuAddSubject";
            mnuAddSubject.Size = new Size(172, 22);
            mnuAddSubject.Text = "افزودن درس";
            mnuAddSubject.Click += mnuAddSubject_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(169, 6);
            // 
            // mnuAddCourse
            // 
            mnuAddCourse.Name = "mnuAddCourse";
            mnuAddCourse.Size = new Size(172, 22);
            mnuAddCourse.Text = "افزودن دوره آموزشی";
            mnuAddCourse.Click += mnuAddCourse_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(169, 6);
            // 
            // mnuFindTop
            // 
            mnuFindTop.Name = "mnuFindTop";
            mnuFindTop.Size = new Size(172, 22);
            mnuFindTop.Text = "یافتن معلم نمونه";
            mnuFindTop.Click += mnuFindTop_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(48, 20);
            helpToolStripMenuItem.Text = "&راهنما";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "درباره ما...";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(584, 474);
            Controls.Add(gbTeacherSubject);
            Controls.Add(gbCourceSubject);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            Text = "مدرسه";
            gbCourceSubject.ResumeLayout(false);
            gbCourceSubject.PerformLayout();
            gbTeacherSubject.ResumeLayout(false);
            gbTeacherSubject.PerformLayout();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbCourceSubject;
        private Button btnSaveCS;
        private Label label2;
        private Label label1;
        private GroupBox gbTeacherSubject;
        private Button btnSaveTS;
        private Label label4;
        private Label label3;
        private ComboBox cbCourseCS;
        private ComboBox cbSubjectCS;
        private ComboBox cbTeacherTS;
        private ComboBox cbSubjectTS;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem افزودندانشآموزToolStripMenuItem;
        private ToolStripMenuItem mnuAddGrade;
        private ToolStripMenuItem افزودنآموزگارToolStripMenuItem;
        private ToolStripMenuItem mnuAddSubject;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuAddCourse;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem mnuAddStudent;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuFindTop;
    }
}