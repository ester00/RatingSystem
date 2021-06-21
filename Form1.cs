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
using System.Data.Entity;
using System.Web.UI.WebControls;
using RatingSystem.GlobalConstants;

namespace RatingSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public string Title { get; set; }
        public int Rating { get; set; }
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();

            if (alarmCounter < 30)
            {
                // Restarts the timer and increments the counter.
                var random = new Random();
                var rndNumber = random.Next(0, dataGridView1.Rows.Count);
                dataGridView1.Rows[rndNumber].Selected = true;

                //logic before
                alarmCounter += 1;
                myTimer.Enabled = true;
            }
            else
            {
                // Stops the timer.
                exitFlag = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }
        #region NewMovie
        private void NewMovieBbutton_Click(object sender, EventArgs e)
        {
            NewMovie popUpForm = new NewMovie();
            popUpForm.ShowDialog();
            UpdateDataIntoDatagrid();
        }
        #endregion

        private void LottoButton_Click_1(object sender, EventArgs e)
        {
            //Lotto popUpForm = new Lotto();
            //popUpForm.ShowDialog();
            dataGridView1.ClearSelection();

            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 1000;
            myTimer.Start();

            while (exitFlag == false)
            {
                Application.DoEvents();
                dataGridView1.ClearSelection();

            }
        }

        private void UpdateDataIntoDatagrid()
        {
            using (var db = new MovieRatingsEntities1())
            {
                dataGridView1.DataSource = db.MOVIES.ToList();
                db.SaveChanges();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataIntoDatagrid();
            this.txtUsername.Text = LoginConstants.UserName;
        }

        #region Rate/Delete
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
                      com.Parameters.AddWithValue("@Title", row.Cells["TitleColumn"].Value);
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
                    com.Parameters.AddWithValue("@Title", row.Cells["TitleColumn"].Value);
                    com.ExecuteNonQuery();
                    con.Close();
                    UpdateDataIntoDatagrid();
                }
            }
        }
        #endregion

        #region LogOut
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }
        #endregion
    }
} 



