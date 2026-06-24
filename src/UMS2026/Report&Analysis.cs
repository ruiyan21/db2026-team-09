using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UMS2026
{
    public partial class Report_Analysis : Form
    {
        // Chart control created at runtime; alias for older code references
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics;
        private System.Windows.Forms.DataGridView dgvReprort => this.reportDataGridView;
        string conStr =
      @"Data Source=.\sqlexpress;
          Initial Catalog=University;
          Integrated Security=True";

        public Report_Analysis()
        {
            InitializeComponent();
            // Wire buttons to their handlers so clicks perform actions
            this.button1.Click += button1_Click;
            this.button2.Click += button2_Click_1;
            this.button3.Click += button3_Click_1;
            this.button4.Click += button4_Click_1;
            this.button5.Click += button5_Click_1;
            this.button6.Click += button6_Click_1;
            this.button7.Click += button7_Click_1;
            this.button8.Click += button7_Click_1; // close
        }

        private void ReportAnalysis_Load(object sender, EventArgs e)
        {
            // create chart control dynamically and add to chartPanel
            this.chartAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAnalytics.Dock = DockStyle.Fill;
            this.chartAnalytics.MouseClick += chartAnalytics_Click;
            this.chartAnalytics.BackColor = Color.White;
            // ensure a ChartArea and Legend exist so series render correctly
            this.chartAnalytics.Series.Clear();
            this.chartAnalytics.ChartAreas.Add(new ChartArea("ChartArea1"));
            this.chartAnalytics.Legends.Add(new Legend("Legend1"));
            this.chartAnalytics.Titles.Clear();
            this.chartPanel.Controls.Clear();
            this.chartPanel.Controls.Add(this.chartAnalytics);
            this.chartAnalytics.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    "SELECT * FROM student";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReprort.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void chartAnalytics_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT dept_name,
             COUNT(*) AS TotalStudents
      FROM student
      GROUP BY dept_name";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Students");

            series.ChartType =
                SeriesChartType.Pie;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["dept_name"].ToString(),
                    Convert.ToInt32(row["TotalStudents"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Students by Department");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    "SELECT * FROM course";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReprort.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                @"SELECT
                    s.ID,
                    s.name,
                    c.course_id,
                    c.title,
                    t.grade
                  FROM takes t
                  INNER JOIN student s
                      ON t.ID = s.ID
                  INNER JOIN course c
                      ON t.course_id = c.course_id";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReprort.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT course_id,
             credits
      FROM course";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Credits");

            series.ChartType =
                SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["course_id"].ToString(),
                    Convert.ToInt32(row["credits"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Course Credits Analysis");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT course_id,
             COUNT(ID) AS TotalStudents
      FROM takes
      GROUP BY course_id";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Enrollment");

            series.ChartType =
                SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["course_id"].ToString(),
                    Convert.ToInt32(row["TotalStudents"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Enrollment per Course");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}