namespace UMS2026
{
    partial class InstructorForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dept_nameLabel;
            System.Windows.Forms.Label salaryLabel;
            this.universityDataSet = new UMS2026.UniversityDataSet();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter = new UMS2026.UniversityDataSetTableAdapters.instructorTableAdapter();
            this.tableAdapterManager = new UMS2026.UniversityDataSetTableAdapters.TableAdapterManager();
            this.instructorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dept_nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dept_nameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.instructorBindingSource.DataMember = "instructor";
            this.instructorBindingSource.DataSource = this.universityDataSet;
            
            this.instructorTableAdapter.ClearBeforeFill = true;
            
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = this.instructorTableAdapter;
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
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructors";
            
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
            
            this.instructorDataGridView.AutoGenerateColumns = false;
            this.instructorDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.instructorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.instructorDataGridView.DataSource = this.instructorBindingSource;
            this.instructorDataGridView.Location = new System.Drawing.Point(30, 250);
            this.instructorDataGridView.Name = "instructorDataGridView";
            this.instructorDataGridView.RowHeadersWidth = 51;
            this.instructorDataGridView.RowTemplate.Height = 24;
            this.instructorDataGridView.Size = new System.Drawing.Size(1050, 320);
            this.instructorDataGridView.TabIndex = 1;
            
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            
            this.dataGridViewTextBoxColumn4.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            iDLabel.Location = new System.Drawing.Point(30, 130);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            
            this.iDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.iDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(30, 145);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(150, 23);
            this.iDTextBox.TabIndex = 2;
            
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            nameLabel.Location = new System.Drawing.Point(200, 130);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(200, 145);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 23);
            this.nameTextBox.TabIndex = 4;
            
            dept_nameLabel.AutoSize = true;
            dept_nameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dept_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dept_nameLabel.Location = new System.Drawing.Point(520, 130);
            dept_nameLabel.Name = "dept_nameLabel";
            dept_nameLabel.Size = new System.Drawing.Size(71, 13);
            dept_nameLabel.TabIndex = 5;
            dept_nameLabel.Text = "Department:";
            
            this.dept_nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dept_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dept_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "dept_name", true));
            this.dept_nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_nameTextBox.Location = new System.Drawing.Point(520, 145);
            this.dept_nameTextBox.Name = "dept_nameTextBox";
            this.dept_nameTextBox.Size = new System.Drawing.Size(250, 23);
            this.dept_nameTextBox.TabIndex = 6;
            
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            salaryLabel.Location = new System.Drawing.Point(790, 130);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(46, 13);
            salaryLabel.TabIndex = 7;
            salaryLabel.Text = "Salary:";
            
            this.salaryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.salaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instructorBindingSource, "salary", true));
            this.salaryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTextBox.Location = new System.Drawing.Point(790, 145);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(150, 23);
            this.salaryTextBox.TabIndex = 8;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.instructorDataGridView);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(dept_nameLabel);
            this.Controls.Add(this.dept_nameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS 2026 - Instructors";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private UniversityDataSetTableAdapters.instructorTableAdapter instructorTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView instructorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox dept_nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
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
