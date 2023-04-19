namespace School.TopTeacher
{
    partial class frmTeacher
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
            tbName = new TextBox();
            tbPersonnelNumber = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 68);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "نام آموزگار";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 137);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "شماره پرسنلی";
            // 
            // tbName
            // 
            tbName.Location = new Point(31, 68);
            tbName.Name = "tbName";
            tbName.Size = new Size(138, 23);
            tbName.TabIndex = 2;
            // 
            // tbPersonnelNumber
            // 
            tbPersonnelNumber.Location = new Point(31, 137);
            tbPersonnelNumber.Name = "tbPersonnelNumber";
            tbPersonnelNumber.Size = new Size(138, 23);
            tbPersonnelNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "افزودن";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(btnAdd);
            Controls.Add(tbPersonnelNumber);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTeacher";
            RightToLeft = RightToLeft.Yes;
            Text = "آموزگار";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbPersonnelNumber;
        private Button btnAdd;
    }
}