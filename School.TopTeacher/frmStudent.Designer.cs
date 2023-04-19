namespace School.TopTeacher
{
    partial class frmStudent
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
            label1 = new Label();
            label2 = new Label();
            tbFullName = new TextBox();
            tbNationalCode = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "نام دانش آموز";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 92);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "کد ملی";
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(36, 43);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(134, 23);
            tbFullName.TabIndex = 2;
            // 
            // tbNationalCode
            // 
            tbNationalCode.Location = new Point(36, 92);
            tbNationalCode.Name = "tbNationalCode";
            tbNationalCode.Size = new Size(134, 23);
            tbNationalCode.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(36, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(btnSave);
            Controls.Add(tbNationalCode);
            Controls.Add(tbFullName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudent";
            RightToLeft = RightToLeft.Yes;
            Text = "دانش آموز";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFullName;
        private TextBox tbNationalCode;
        private Button btnSave;
    }
}