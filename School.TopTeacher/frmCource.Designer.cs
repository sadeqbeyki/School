namespace School.TopTeacher
{
    partial class frmCource
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
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            tbYear = new TextBox();
            tbDuration = new TextBox();
            tbDescription = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "افزودن";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 66);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 126);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "سال تحصیلی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 186);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "مدت زمان";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 246);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "توضحیات";
            // 
            // tbName
            // 
            tbName.Location = new Point(132, 86);
            tbName.Name = "tbName";
            tbName.Size = new Size(198, 23);
            tbName.TabIndex = 5;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(230, 146);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(100, 23);
            tbYear.TabIndex = 6;
            // 
            // tbDuration
            // 
            tbDuration.Location = new Point(276, 206);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(54, 23);
            tbDuration.TabIndex = 7;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(37, 266);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(293, 86);
            tbDescription.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 209);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 9;
            label5.Text = "روز";
            // 
            // frmCource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(label5);
            Controls.Add(tbDescription);
            Controls.Add(tbDuration);
            Controls.Add(tbYear);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "frmCource";
            RightToLeft = RightToLeft.Yes;
            Text = "دوره آموزشی";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbName;
        private TextBox tbYear;
        private TextBox tbDuration;
        private TextBox tbDescription;
        private Label label5;
    }
}