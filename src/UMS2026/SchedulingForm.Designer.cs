namespace UMS2026
{
    partial class SchedulingForm
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
            System.Windows.Forms.Label dayLabel;
            this.timeSlotIdLabel = new System.Windows.Forms.Label();
            this.startHrLabel = new System.Windows.Forms.Label();
            this.startMinLabel = new System.Windows.Forms.Label();
            this.endHrLabel = new System.Windows.Forms.Label();
            this.endMinLabel = new System.Windows.Forms.Label();
            this.universityDataSet = new UMS2026.UniversityDataSet();
            this.schedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulingTableAdapter = new UMS2026.UniversityDataSetTableAdapters.time_slotTableAdapter();
            this.tableAdapterManager = new UMS2026.UniversityDataSetTableAdapters.TableAdapterManager();
            this.schedulingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSlotIdTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.startHrTextBox = new System.Windows.Forms.TextBox();
            this.startMinTextBox = new System.Windows.Forms.TextBox();
            this.endHrTextBox = new System.Windows.Forms.TextBox();
            this.endMinTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            dayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeSlotIdLabel
            // 
            this.timeSlotIdLabel.AutoSize = true;
            this.timeSlotIdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSlotIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.timeSlotIdLabel.Location = new System.Drawing.Point(30, 130);
            this.timeSlotIdLabel.Name = "timeSlotIdLabel";
            this.timeSlotIdLabel.Size = new System.Drawing.Size(100, 19);
            this.timeSlotIdLabel.TabIndex = 1;
            this.timeSlotIdLabel.Text = "TIME SLOT ID:";
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dayLabel.Location = new System.Drawing.Point(170, 130);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(41, 19);
            dayLabel.TabIndex = 3;
            dayLabel.Text = "DAY:";
            // 
            // startHrLabel
            // 
            this.startHrLabel.AutoSize = true;
            this.startHrLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.startHrLabel.Location = new System.Drawing.Point(290, 130);
            this.startHrLabel.Name = "startHrLabel";
            this.startHrLabel.Size = new System.Drawing.Size(79, 19);
            this.startHrLabel.TabIndex = 5;
            this.startHrLabel.Text = "START HR:";
            // 
            // startMinLabel
            // 
            this.startMinLabel.AutoSize = true;
            this.startMinLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.startMinLabel.Location = new System.Drawing.Point(390, 130);
            this.startMinLabel.Name = "startMinLabel";
            this.startMinLabel.Size = new System.Drawing.Size(87, 19);
            this.startMinLabel.TabIndex = 7;
            this.startMinLabel.Text = "START MIN:";
            // 
            // endHrLabel
            // 
            this.endHrLabel.AutoSize = true;
            this.endHrLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endHrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.endHrLabel.Location = new System.Drawing.Point(490, 130);
            this.endHrLabel.Name = "endHrLabel";
            this.endHrLabel.Size = new System.Drawing.Size(65, 19);
            this.endHrLabel.TabIndex = 9;
            this.endHrLabel.Text = "END HR:";
            // 
            // endMinLabel
            // 
            this.endMinLabel.AutoSize = true;
            this.endMinLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.endMinLabel.Location = new System.Drawing.Point(590, 130);
            this.endMinLabel.Name = "endMinLabel";
            this.endMinLabel.Size = new System.Drawing.Size(73, 19);
            this.endMinLabel.TabIndex = 11;
            this.endMinLabel.Text = "END MIN:";
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schedulingBindingSource
            // 
            this.schedulingBindingSource.DataMember = "time_slot";
            this.schedulingBindingSource.DataSource = this.universityDataSet;
            // 
            // schedulingTableAdapter
            // 
            this.schedulingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advisorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.classroomTableAdapter = null;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = null;
            this.tableAdapterManager.instructorTableAdapter = null;
            this.tableAdapterManager.prereqTableAdapter = null;
            this.tableAdapterManager.sectionTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.takesTableAdapter = null;
            this.tableAdapterManager.teachesTableAdapter = null;
            this.tableAdapterManager.time_slotTableAdapter = this.schedulingTableAdapter;
            this.tableAdapterManager.UpdateOrder = UMS2026.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // schedulingDataGridView
            // 
            this.schedulingDataGridView.AutoGenerateColumns = false;
            this.schedulingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.schedulingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.schedulingDataGridView.DataSource = this.schedulingBindingSource;
            this.schedulingDataGridView.Location = new System.Drawing.Point(30, 250);
            this.schedulingDataGridView.Name = "schedulingDataGridView";
            this.schedulingDataGridView.RowHeadersWidth = 51;
            this.schedulingDataGridView.RowTemplate.Height = 24;
            this.schedulingDataGridView.Size = new System.Drawing.Size(1050, 320);
            this.schedulingDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "time_slot_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Time Slot ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "day";
            this.dataGridViewTextBoxColumn2.HeaderText = "Day";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "start_hr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Hour";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "start_min";
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Min";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "end_hr";
            this.dataGridViewTextBoxColumn5.HeaderText = "End Hour";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "end_min";
            this.dataGridViewTextBoxColumn6.HeaderText = "End Min";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // timeSlotIdTextBox
            // 
            this.timeSlotIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.timeSlotIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeSlotIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedulingBindingSource, "time_slot_id", true));
            this.timeSlotIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSlotIdTextBox.Location = new System.Drawing.Point(30, 145);
            this.timeSlotIdTextBox.Name = "timeSlotIdTextBox";
            this.timeSlotIdTextBox.Size = new System.Drawing.Size(120, 27);
            this.timeSlotIdTextBox.TabIndex = 2;
            // 
            // dayTextBox
            // 
            this.dayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedulingBindingSource, "day", true));
            this.dayTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTextBox.Location = new System.Drawing.Point(170, 145);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 27);
            this.dayTextBox.TabIndex = 4;
            // 
            // startHrTextBox
            // 
            this.startHrTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.startHrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startHrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedulingBindingSource, "start_hr", true));
            this.startHrTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHrTextBox.Location = new System.Drawing.Point(290, 145);
            this.startHrTextBox.Name = "startHrTextBox";
            this.startHrTextBox.Size = new System.Drawing.Size(80, 27);
            this.startHrTextBox.TabIndex = 6;
            // 
            // startMinTextBox
            // 
            this.startMinTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.startMinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startMinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedulingBindingSource, "start_min", true));
            this.startMinTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMinTextBox.Location = new System.Drawing.Point(390, 145);
            this.startMinTextBox.Name = "startMinTextBox";
            this.startMinTextBox.Size = new System.Drawing.Size(80, 27);
            this.startMinTextBox.TabIndex = 8;
            // 
            // endHrTextBox
            // 
            this.endHrTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.endHrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endHrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedulingBindingSource, "end_hr", true));
            this.endHrTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endHrTextBox.Location = new System.Drawing.Point(490, 145);
            this.endHrTextBox.Name = "endHrTextBox";
            this.endHrTextBox.Size = new System.Drawing.Size(80, 27);
            this.endHrTextBox.TabIndex = 10;
            // 
            // endMinTextBox
            // 
            this.endMinTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.endMinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endMinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schedulingBindingSource, "end_min", true));
            this.endMinTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMinTextBox.Location = new System.Drawing.Point(590, 145);
            this.endMinTextBox.Name = "endMinTextBox";
            this.endMinTextBox.Size = new System.Drawing.Size(80, 27);
            this.endMinTextBox.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.button7.Location = new System.Drawing.Point(1000, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 30);
            this.button7.TabIndex = 35;
            this.button7.Text = "← BACK";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(515, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 30);
            this.button6.TabIndex = 34;
            this.button6.Text = "REFRESH";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(375, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 30);
            this.button5.TabIndex = 33;
            this.button5.Text = "CHECK CONFLICTS";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
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
            // 
            // button3
            // 
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
            // 
            // button2
            // 
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
            // 
            // button1
            // 
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
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 60);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scheduling";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 50);
            this.panel2.TabIndex = 21;
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.schedulingDataGridView);
            this.Controls.Add(this.endMinLabel);
            this.Controls.Add(this.endMinTextBox);
            this.Controls.Add(this.endHrLabel);
            this.Controls.Add(this.endHrTextBox);
            this.Controls.Add(this.startMinLabel);
            this.Controls.Add(this.startMinTextBox);
            this.Controls.Add(this.startHrLabel);
            this.Controls.Add(this.startHrTextBox);
            this.Controls.Add(dayLabel);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.timeSlotIdLabel);
            this.Controls.Add(this.timeSlotIdTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SchedulingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS 2026 - Scheduling";
            this.Load += new System.EventHandler(this.SchedulingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulingDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource schedulingBindingSource;
        private UniversityDataSetTableAdapters.time_slotTableAdapter schedulingTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView schedulingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox timeSlotIdTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox startHrTextBox;
        private System.Windows.Forms.TextBox startMinTextBox;
        private System.Windows.Forms.TextBox endHrTextBox;
        private System.Windows.Forms.TextBox endMinTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeSlotIdLabel;
        private System.Windows.Forms.Label startHrLabel;
        private System.Windows.Forms.Label startMinLabel;
        private System.Windows.Forms.Label endHrLabel;
        private System.Windows.Forms.Label endMinLabel;
    }
}
