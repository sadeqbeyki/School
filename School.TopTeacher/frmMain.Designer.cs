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
            یافتندانشآموزنمونهToolStripMenuItem = new ToolStripMenuItem();
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
            gbCourceSubject.Location = new Point(66, 202);
            gbCourceSubject.Margin = new Padding(4, 5, 4, 5);
            gbCourceSubject.Name = "gbCourceSubject";
            gbCourceSubject.Padding = new Padding(4, 5, 4, 5);
            gbCourceSubject.Size = new Size(701, 240);
            gbCourceSubject.TabIndex = 19;
            gbCourceSubject.TabStop = false;
            gbCourceSubject.Text = "ارتباط درس با دوره آموزشی";
            // 
            // cbCourseCS
            // 
            cbCourseCS.FormattingEnabled = true;
            cbCourseCS.Location = new Point(44, 100);
            cbCourseCS.Margin = new Padding(4, 5, 4, 5);
            cbCourseCS.Name = "cbCourseCS";
            cbCourseCS.Size = new Size(251, 33);
            cbCourseCS.TabIndex = 8;
            // 
            // cbSubjectCS
            // 
            cbSubjectCS.FormattingEnabled = true;
            cbSubjectCS.Location = new Point(321, 100);
            cbSubjectCS.Margin = new Padding(4, 5, 4, 5);
            cbSubjectCS.Name = "cbSubjectCS";
            cbSubjectCS.Size = new Size(241, 33);
            cbSubjectCS.TabIndex = 7;
            // 
            // btnSaveCS
            // 
            btnSaveCS.Location = new Point(44, 148);
            btnSaveCS.Margin = new Padding(4, 5, 4, 5);
            btnSaveCS.Name = "btnSaveCS";
            btnSaveCS.Size = new Size(107, 38);
            btnSaveCS.TabIndex = 6;
            btnSaveCS.Text = "ذخیره";
            btnSaveCS.UseVisualStyleBackColor = true;
            btnSaveCS.Click += btnSaveCS_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 3;
            label2.Text = "نام دوره آموزشی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
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
            gbTeacherSubject.Location = new Point(66, 472);
            gbTeacherSubject.Margin = new Padding(4, 5, 4, 5);
            gbTeacherSubject.Name = "gbTeacherSubject";
            gbTeacherSubject.Padding = new Padding(4, 5, 4, 5);
            gbTeacherSubject.Size = new Size(701, 240);
            gbTeacherSubject.TabIndex = 20;
            gbTeacherSubject.TabStop = false;
            gbTeacherSubject.Text = "ارتباط درس با آموزگار";
            // 
            // cbTeacherTS
            // 
            cbTeacherTS.FormattingEnabled = true;
            cbTeacherTS.Location = new Point(44, 102);
            cbTeacherTS.Margin = new Padding(4, 5, 4, 5);
            cbTeacherTS.Name = "cbTeacherTS";
            cbTeacherTS.Size = new Size(251, 33);
            cbTeacherTS.TabIndex = 9;
            // 
            // cbSubjectTS
            // 
            cbSubjectTS.FormattingEnabled = true;
            cbSubjectTS.Location = new Point(321, 102);
            cbSubjectTS.Margin = new Padding(4, 5, 4, 5);
            cbSubjectTS.Name = "cbSubjectTS";
            cbSubjectTS.Size = new Size(241, 33);
            cbSubjectTS.TabIndex = 8;
            // 
            // btnSaveTS
            // 
            btnSaveTS.Location = new Point(44, 150);
            btnSaveTS.Margin = new Padding(4, 5, 4, 5);
            btnSaveTS.Name = "btnSaveTS";
            btnSaveTS.Size = new Size(107, 38);
            btnSaveTS.TabIndex = 7;
            btnSaveTS.Text = "ذخیره";
            btnSaveTS.UseVisualStyleBackColor = true;
            btnSaveTS.Click += btnSaveTS_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 5;
            label4.Text = "نام آموزگار";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 4;
            label3.Text = "نام درس";
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(24, 24);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(9, 3, 0, 3);
            mainMenu.Size = new Size(834, 35);
            mainMenu.TabIndex = 21;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(60, 29);
            fileToolStripMenuItem.Text = "&فایل";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(153, 34);
            exitToolStripMenuItem.Text = "خروج";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { افزودندانشآموزToolStripMenuItem, افزودنآموزگارToolStripMenuItem, mnuAddSubject, toolStripSeparator3, mnuAddCourse, toolStripSeparator1, یافتندانشآموزنمونهToolStripMenuItem, mnuFindTop });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(118, 29);
            toolsToolStripMenuItem.Text = "&امور آموزش";
            // 
            // افزودندانشآموزToolStripMenuItem
            // 
            افزودندانشآموزToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAddGrade, mnuAddStudent });
            افزودندانشآموزToolStripMenuItem.Name = "افزودندانشآموزToolStripMenuItem";
            افزودندانشآموزToolStripMenuItem.Size = new Size(282, 34);
            افزودندانشآموزToolStripMenuItem.Text = "امور دانش آموزان";
            // 
            // mnuAddGrade
            // 
            mnuAddGrade.Name = "mnuAddGrade";
            mnuAddGrade.Size = new Size(270, 34);
            mnuAddGrade.Text = "اختصاص نمره";
            mnuAddGrade.Click += mnuAddGrade_Click;
            // 
            // mnuAddStudent
            // 
            mnuAddStudent.Name = "mnuAddStudent";
            mnuAddStudent.Size = new Size(270, 34);
            mnuAddStudent.Text = "افزودن دانش آموز";
            mnuAddStudent.Click += mnuAddStudent_Click;
            // 
            // افزودنآموزگارToolStripMenuItem
            // 
            افزودنآموزگارToolStripMenuItem.Name = "افزودنآموزگارToolStripMenuItem";
            افزودنآموزگارToolStripMenuItem.Size = new Size(282, 34);
            افزودنآموزگارToolStripMenuItem.Text = "افزودن آموزگار";
            افزودنآموزگارToolStripMenuItem.Click += mnuAddTeacher_Click;
            // 
            // mnuAddSubject
            // 
            mnuAddSubject.Name = "mnuAddSubject";
            mnuAddSubject.Size = new Size(282, 34);
            mnuAddSubject.Text = "افزودن درس";
            mnuAddSubject.Click += mnuAddSubject_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(279, 6);
            // 
            // mnuAddCourse
            // 
            mnuAddCourse.Name = "mnuAddCourse";
            mnuAddCourse.Size = new Size(282, 34);
            mnuAddCourse.Text = "افزودن دوره آموزشی";
            mnuAddCourse.Click += mnuAddCourse_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(279, 6);
            // 
            // mnuFindTop
            // 
            mnuFindTop.Name = "mnuFindTop";
            mnuFindTop.Size = new Size(282, 34);
            mnuFindTop.Text = "یافتن معلم نمونه";
            mnuFindTop.Click += mnuFindTop_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(73, 29);
            helpToolStripMenuItem.Text = "&راهنما";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(190, 34);
            aboutToolStripMenuItem.Text = "درباره ما...";
            // 
            // یافتندانشآموزنمونهToolStripMenuItem
            // 
            یافتندانشآموزنمونهToolStripMenuItem.Name = "یافتندانشآموزنمونهToolStripMenuItem";
            یافتندانشآموزنمونهToolStripMenuItem.Size = new Size(282, 34);
            یافتندانشآموزنمونهToolStripMenuItem.Text = "یافتن دانش آموز نمونه";
            یافتندانشآموزنمونهToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(834, 790);
            Controls.Add(gbTeacherSubject);
            Controls.Add(gbCourceSubject);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Margin = new Padding(4, 5, 4, 5);
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
        private ToolStripMenuItem یافتندانشآموزنمونهToolStripMenuItem;
    }
}