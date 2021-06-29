using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RatingSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        private void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
        {
            myTimer.Stop();

            if (alarmCounter <= 20)
            {
                dataGridView1.ClearSelection();

                var random = new Random();
                var rndNumber = random.Next(0, dataGridView1.Rows.Count);
                dataGridView1.Rows[rndNumber].Selected = true;

                alarmCounter += 1;
                myTimer.Enabled = true;
            }
            else
            {
                exitFlag = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }

        #region Rate/Delete/Edit
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new MovieRatingsEntities1())
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        con.Open();
                        com = new SqlCommand("DELETE FROM MOVIES WHERE Title = @Title", con);
                        com.Parameters.AddWithValue("@Title", row.Cells["titleDataGridViewTextBoxColumn"].Value);
                        com.ExecuteNonQuery();
                        db.SaveChanges();
                        UpdateDataIntoDatagrid();
                        con.Close();
                    }
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["RateButton"].Index)
            {
                using (var db = new MovieRatingsEntities1())
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    con.Open();
                    com = new SqlCommand("UPDATE MOVIES SET Ratings = ISNULL(Ratings, 0)+1 WHERE Title = @Title", con);
                    com.Parameters.AddWithValue("@Title", row.Cells["titleDataGridViewTextBoxColumn"].Value);
                    com.ExecuteNonQuery();
                    con.Close();
                    UpdateDataIntoDatagrid();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index)
            {
                Edit form = new Edit();
                form.dgvr = dataGridView1.Rows[e.RowIndex];
                form.ShowDialog();
                UpdateDataIntoDatagrid();
            }

        }
        #endregion

        #region MenuStrip
        private void lottoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            alarmCounter = 1;
            exitFlag = false;

            myTimer.Interval = 100;
            myTimer.Start();

            while (exitFlag == false)
            {
                Application.DoEvents();
            }
        }

        private void newMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMovie popUpForm = new NewMovie();
            popUpForm.ShowDialog();
            UpdateDataIntoDatagrid();
        }

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }
        #endregion

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRatingsDataSet3.MOVIE' table. You can move, or remove it, as needed.
            this.mOVIETableAdapter.Fill(this.movieRatingsDataSet3.MOVIE);
            this.mOVIESTableAdapter1.Fill(this.movieRatingsDataSet2.MOVIES);
            UpdateDataIntoDatagrid();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            loggedInToolStripMenuItem.Text = constant.UserName;
        }

        private void UpdateDataIntoDatagrid()
        {
            using (var db = new MovieRatingsEntities1())
            {
                dataGridView1.DataSource = db.MOVIES.ToList();
                db.SaveChanges();
            }
        }
    }
}



