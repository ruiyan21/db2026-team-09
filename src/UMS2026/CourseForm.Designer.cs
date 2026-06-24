namespace UMS2026
{
    partial class CourseForm
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
            System.Windows.Forms.Label courseIdLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label dept_nameLabel;
            System.Windows.Forms.Label creditsLabel;
            this.universityDataSet = new UMS2026.UniversityDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new UMS2026.UniversityDataSetTableAdapters.courseTableAdapter();
            this.tableAdapterManager = new UMS2026.UniversityDataSetTableAdapters.TableAdapterManager();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.creditsTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            courseIdLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            dept_nameLabel = new System.Windows.Forms.Label();
            creditsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.universityDataSet;
            
            this.courseTableAdapter.ClearBeforeFill = true;
            
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = null;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = null;
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
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            
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
            
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(30, 250);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowHeadersWidth = 51;
            this.courseDataGridView.RowTemplate.Height = 24;
            this.courseDataGridView.Size = new System.Drawing.Size(1050, 320);
            this.courseDataGridView.TabIndex = 1;
            
            this.dataGridViewTextBoxColumn1.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Course ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            
            this.dataGridViewTextBoxColumn4.DataPropertyName = "credits";
            this.dataGridViewTextBoxColumn4.HeaderText = "Credits";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 100;
            
            courseIdLabel.AutoSize = true;
            courseIdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courseIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            courseIdLabel.Location = new System.Drawing.Point(30, 130);
            courseIdLabel.Name = "courseIdLabel";
            courseIdLabel.Size = new System.Drawing.Size(71, 13);
            courseIdLabel.TabIndex = 1;
            courseIdLabel.Text = "COURSE ID:";
            
            this.courseIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.courseIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "course_id", true));
            this.courseIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdTextBox.Location = new System.Drawing.Point(30, 145);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(150, 23);
            this.courseIdTextBox.TabIndex = 2;
            
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            titleLabel.Location = new System.Drawing.Point(200, 130);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(43, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "TITLE:";
            
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(200, 145);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(350, 23);
            this.titleTextBox.TabIndex = 4;
            
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dept_nameLabel.Location = new System.Drawing.Point(570, 130);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(101, 13);
            dept_nameLabel.TabIndex = 5;
            dept_nameLabel.Text = "DEPARTMENT:";
            
            this.dept_nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dept_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dept_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "dept_name", true));
            this.dept_nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_nameTextBox.Location = new System.Drawing.Point(570, 145);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.dept_nameTextBox.TabIndex = 6;
            
            creditsLabel.AutoSize = true;
            creditsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            creditsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            creditsLabel.Location = new System.Drawing.Point(790, 130);
            creditsLabel.Name = "creditsLabel";
            creditsLabel.Size = new System.Drawing.Size(62, 13);
            creditsLabel.TabIndex = 7;
            creditsLabel.Text = "CREDITS:";
            
            this.creditsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.creditsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "credits", true));
            this.creditsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsTextBox.Location = new System.Drawing.Point(790, 145);
            this.creditsTextBox.Name = "creditsTextBox";
            this.creditsTextBox.Size = new System.Drawing.Size(150, 23);
            this.creditsTextBox.TabIndex = 8;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(creditsLabel);
            this.Controls.Add(this.creditsTextBox);
            this.Controls.Add(dept_nameLabel);
            this.Controls.Add(this.dept_nameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(courseIdLabel);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS 2026 - Courses";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private UniversityDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.TextBox creditsTextBox;
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
