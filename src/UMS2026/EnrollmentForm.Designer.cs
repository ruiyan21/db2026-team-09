namespace UMS2026
{
    partial class EnrollmentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label courseIdLabel;
            System.Windows.Forms.Label secIdLabel;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label gradeLabel;
            this.universityDataSet = new UMS2026.UniversityDataSet();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentTableAdapter = new UMS2026.UniversityDataSetTableAdapters.takesTableAdapter();
            this.tableAdapterManager = new UMS2026.UniversityDataSetTableAdapters.TableAdapterManager();
            this.enrollmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.secIdTextBox = new System.Windows.Forms.TextBox();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            studentIdLabel = new System.Windows.Forms.Label();
            courseIdLabel = new System.Windows.Forms.Label();
            secIdLabel = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.enrollmentBindingSource.DataMember = "takes";
            this.enrollmentBindingSource.DataSource = this.universityDataSet;
            
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = null;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = this.enrollmentTableAdapter;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.time_slotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UMS2026.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 60);
            this.panel1.TabIndex = 20;
            
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment";
            
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 50);
            this.panel2.TabIndex = 21;
            
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = false;
            
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(105, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 30;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(195, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 31;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(285, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 30);
            this.button4.TabIndex = 32;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.button5.Location = new System.Drawing.Point(1000, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 30);
            this.button5.TabIndex = 33;
            this.button5.Text = "← BACK";
            this.button5.UseVisualStyleBackColor = false;
            
            this.enrollmentDataGridView.AutoGenerateColumns = false;
            this.enrollmentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.enrollmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrollmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.enrollmentDataGridView.DataSource = this.enrollmentBindingSource;
            this.enrollmentDataGridView.Location = new System.Drawing.Point(30, 250);
            this.enrollmentDataGridView.Name = "enrollmentDataGridView";
            this.enrollmentDataGridView.RowHeadersWidth = 51;
            this.enrollmentDataGridView.RowTemplate.Height = 24;
            this.enrollmentDataGridView.Size = new System.Drawing.Size(1050, 320);
            this.enrollmentDataGridView.TabIndex = 1;
            
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 100;
            
            this.dataGridViewTextBoxColumn2.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Course ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 100;
            
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sec_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Section ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 100;
            
            this.dataGridViewTextBoxColumn4.DataPropertyName = "semester";
            this.dataGridViewTextBoxColumn4.HeaderText = "Semester";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            
            this.dataGridViewTextBoxColumn5.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Year";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grade";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            
            studentIdLabel.AutoSize = true;
            studentIdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            studentIdLabel.Location = new System.Drawing.Point(30, 130);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(78, 13);
            studentIdLabel.TabIndex = 1;
            studentIdLabel.Text = "STUDENT ID:";
            
            this.studentIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.studentIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "ID", true));
            this.studentIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox.Location = new System.Drawing.Point(30, 145);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.studentIdTextBox.TabIndex = 2;
            
            courseIdLabel.AutoSize = true;
            courseIdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courseIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            courseIdLabel.Location = new System.Drawing.Point(150, 130);
            courseIdLabel.Name = "courseIdLabel";
            courseIdLabel.Size = new System.Drawing.Size(71, 13);
            courseIdLabel.TabIndex = 3;
            courseIdLabel.Text = "COURSE ID:";
            
            this.courseIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.courseIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "course_id", true));
            this.courseIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdTextBox.Location = new System.Drawing.Point(150, 145);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.courseIdTextBox.TabIndex = 4;
            
            secIdLabel.AutoSize = true;
            secIdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            secIdLabel.Location = new System.Drawing.Point(270, 130);
            secIdLabel.Name = "secIdLabel";
            secIdLabel.Size = new System.Drawing.Size(77, 13);
            secIdLabel.TabIndex = 5;
            secIdLabel.Text = "SECTION ID:";
            
            this.secIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.secIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "sec_id", true));
            this.secIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secIdTextBox.Location = new System.Drawing.Point(270, 145);
            this.secIdTextBox.Name = "secIdTextBox";
            this.secIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.secIdTextBox.TabIndex = 6;
            
            semesterLabel.AutoSize = true;
            semesterLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            semesterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            semesterLabel.Location = new System.Drawing.Point(390, 130);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(80, 13);
            semesterLabel.TabIndex = 7;
            semesterLabel.Text = "SEMESTER:";
            
            this.semesterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.semesterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "semester", true));
            this.semesterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterTextBox.Location = new System.Drawing.Point(390, 145);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(100, 23);
            this.semesterTextBox.TabIndex = 8;
            
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            yearLabel.Location = new System.Drawing.Point(510, 130);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(41, 13);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "YEAR:";
            
            this.yearTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "year", true));
            this.yearTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(510, 145);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(80, 23);
            this.yearTextBox.TabIndex = 10;
            
            gradeLabel.AutoSize = true;
            gradeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            gradeLabel.Location = new System.Drawing.Point(610, 130);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(55, 13);
            gradeLabel.TabIndex = 11;
            gradeLabel.Text = "GRADE:";
            
            this.gradeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gradeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource, "grade", true));
            this.gradeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTextBox.Location = new System.Drawing.Point(610, 145);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(80, 23);
            this.gradeTextBox.TabIndex = 12;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.enrollmentDataGridView);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(secIdLabel);
            this.Controls.Add(this.secIdTextBox);
            this.Controls.Add(courseIdLabel);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(studentIdLabel);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS 2026 - Enrollment";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private UniversityDataSetTableAdapters.takesTableAdapter enrollmentTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView enrollmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox secIdTextBox;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
