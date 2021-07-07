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
using System.Security.Cryptography;

namespace RatingSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private readonly MovieRatingsEntities2 _db;
        private LoginPage _login;
        public string _roleName;
        public int movieid;
        public int usersid;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
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
            _db = new MovieRatingsEntities2();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.mOVIESTableAdapter1.Fill(this.movieRatingsDataSet2.MOVIES);
            UpdateDataIntoDatagrid();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            loggedInToolStripMenuItem.Text = constant.UserName;

            if (_roleName != "Admin")
            {
                DeleteButton.Visible = false;
            }

            //LoginPage lp = new LoginPage();
            //lp.GuestButton

            if (_roleName != "Admin" && _roleName != "User")
            {
                DeleteButton.Visible = false;
                EditButton.Visible = false;
                RateButton.Visible = false;
                loggedInToolStripMenuItem.Visible = false;
                newMovieToolStripMenuItem.Visible = false;
                lottoToolStripMenuItem.Visible = false;
                logInToolStripMenuItem.Visible = true;
                
            }

            LoginPage lp = new LoginPage();
            string username = lp.txtUsername.Text;
            
            var id = _db.Movies.FirstOrDefault(q => q.ID == movieid);
            var movie = _db.Movies.FirstOrDefault(q => q.UsersId == usersid);
            if (usersid != movieid)
            {
                DeleteButton.Visible = false;
                EditButton.Visible = false;
            }
            con.Close();
        }

        public Form1(LoginPage login, string roleName)
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
            _login = login;
            _roleName = roleName;
            _db = new MovieRatingsEntities2();
        }

        #region Rate/Delete/Edit
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curMovieId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                Delete();
            }

            if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index)
            {
                Edit();
            }

            if (e.ColumnIndex == dataGridView1.Columns["RateButton"].Index)
            {
                using (var db = new MovieRatingsEntities2())
                {
                    var result = MessageBox.Show("You can vote only for one movie per session, are sure with your choice?", "Rate Movie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    { 
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    con.Open();
                    com = new SqlCommand($"UPDATE Movies SET Ratings = ISNULL(Ratings, 0)+1 WHERE ID = {curMovieId}", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    UpdateDataIntoDatagrid();
                    RateButton.Visible = false;
                    }
                }
            }
        }
        #endregion

        #region MenuStrip
        private void lottoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alarmCounter; i++)
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

                var a = dataGridView1.SelectedCells[1].Value.ToString();
                var b = dataGridView1.SelectedCells[3].Value.ToString();

                const string caption = "Lotto result";
                var result = MessageBox.Show("Result: " + a + ", " + b + ". " + Environment.NewLine + "Are you satisfied with the result?", caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    i++;
                }
                else
                {
                    break;
                }
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword popUpForm = new ChangePassword();
            popUpForm.ShowDialog();
            UpdateDataIntoDatagrid();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHA256 sha = SHA256.Create();

            LoginPage lp = new LoginPage();
            string username = lp.txtUsername.Text;
            string password = lp.txtPassword.Text;

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var hashed_password = sBuilder.ToString();
            var db = new MovieRatingsEntities2();


            if (MessageBox.Show("Are you sure you want to delete this account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                var user = db.Users.FirstOrDefault(q => q.Username == username && q.Password == hashed_password);
                con.Open();
                com.Connection = con;
                com = new SqlCommand("DELETE FROM Users WHERE username = @username", con);
                com.Parameters.AddWithValue("@username", constant.UserName);
                com.ExecuteNonQuery();

                MessageBox.Show("Account deleted succesfully.", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginPage LP = new LoginPage();
                LP.ShowDialog();
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage LP = new LoginPage();
            LP.ShowDialog();
        }
        #endregion

        #region Key events
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            Delete();
        }
        #endregion

        #region Methods
        private void UpdateDataIntoDatagrid()
        {
            using (var db = new MovieRatingsEntities2())
            {
                dataGridView1.DataSource = db.Movies.ToList();
                db.SaveChanges();
            }
        }

        private void Edit()
        {
            var RowIndex = dataGridView1.CurrentCell.RowIndex;
            Edit form = new Edit();
            form.dgvr = dataGridView1.Rows[RowIndex];
            form.ShowDialog();
            UpdateDataIntoDatagrid();
        }

        private void Delete()
        {
            var RowIndex = dataGridView1.CurrentCell.RowIndex;
            int curMovieId = int.Parse(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            if (MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new MovieRatingsEntities2())
                {
                    DataGridViewRow row = dataGridView1.Rows[RowIndex];
                    con.Open();
                    com = new SqlCommand($"DELETE FROM UserRoles WHERE ID = {curMovieId}", con);
                    com.ExecuteNonQuery();
                    com = new SqlCommand($"DELETE FROM Movies WHERE ID = {curMovieId}", con);
                    com.ExecuteNonQuery();
                    db.SaveChanges();
                    UpdateDataIntoDatagrid();
                    con.Close();
                }
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close(); 
        }
    }
}