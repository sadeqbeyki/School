namespace School.TopTeacher
{
    partial class FindTop
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
            tbYear = new TextBox();
            btnFindSG = new Button();
            label1 = new Label();
            dgTopTeachers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgTopTeachers).BeginInit();
            SuspendLayout();
            // 
            // tbYear
            // 
            tbYear.Location = new Point(26, 146);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(229, 23);
            tbYear.TabIndex = 0;
            tbYear.Text = "1391";
            // 
            // btnFindSG
            // 
            btnFindSG.Location = new Point(322, 382);
            btnFindSG.Name = "btnFindSG";
            btnFindSG.Size = new Size(100, 23);
            btnFindSG.TabIndex = 1;
            btnFindSG.Text = "یافتن";
            btnFindSG.UseVisualStyleBackColor = true;
            btnFindSG.Click += btnFindSG_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 105);
            label1.Name = "label1";
            label1.Size = new Size(303, 15);
            label1.TabIndex = 2;
            label1.Text = "برای یافتن بهترین معلم ، سال تحصیلی مورد نظر را وارد نمایید";
            // 
            // dgTopTeachers
            // 
            dgTopTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTopTeachers.Location = new Point(26, 206);
            dgTopTeachers.Name = "dgTopTeachers";
            dgTopTeachers.RowTemplate.Height = 25;
            dgTopTeachers.Size = new Size(396, 150);
            dgTopTeachers.TabIndex = 4;
            // 
            // FindTop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 450);
            Controls.Add(dgTopTeachers);
            Controls.Add(label1);
            Controls.Add(btnFindSG);
            Controls.Add(tbYear);
            Name = "FindTop";
            Text = "FindTop";
            ((System.ComponentModel.ISupportInitialize)dgTopTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbYear;
        private Button btnFindSG;
        private Label label1;
        private DataGridView dgTopTeachers;
    }
}