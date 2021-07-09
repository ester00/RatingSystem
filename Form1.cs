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
        private readonly MovieRatingsEntities3 _db;
        private LoginPage _login;
        public string _roleName;

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
            _db = new MovieRatingsEntities3();
        }

        public Form1(LoginPage login, string roleName)
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
            _login = login;
            _roleName = roleName;
            _db = new MovieRatingsEntities3();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRatingsDataSet.Movies' table. You can move, or remove it, as needed.
           // this.moviesTableAdapter.Fill(this.movieRatingsDataSet.Movies);
            UpdateDataIntoDatagrid();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            loggedInToolStripMenuItem.Text = constant.UserName;

            if (_roleName != "Admin")
            {
                DeleteButton.Visible = false;
            }

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

            //List<int> idList2 = new List<int>();
            //var result2 = (_db.Users.Where(j => idList2.Contains(j.Id))).ToList();
            //List<int> idList = new List<int>();
            //var result = (_db.UserMovies.Where(j => idList.Contains(j.Id))).ToList();
            //var result3 = result2.Where(p => result.All(p2 => p2.Id != p.Id));
            //
            //var items = this.dataGridView1.Rows.Cast<DataGridViewRow>()
            //.Where(row => row.Cells[1].Value.Equals(result3));
            //
            //foreach (DataGridViewRow row in items )
            //{
            //    DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //    dataGridViewCellStyle2.Padding = new Padding(0, 0, 1000, 0);
            //    row.Cells["EditButton"].Style = dataGridViewCellStyle2;
            //}
        }

        #region Rate/Delete/Edit
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var record = dataGridView1.CurrentRow.DataBoundItem as Movy;

            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                Delete();
            }

            if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index)
            {
                
                using (var db = new MovieRatingsEntities3())
                {
                    if (db.UserMovies.FirstOrDefault(u => u.MovieId == record.ID && u.UserId == constant.LoggedUserId) != null)
                    {
                        Edit(record);
                    }
                    else
                    {
                        MessageBox.Show("Да бе да,... не твой не барай!");
                    }

                   
                }

                
            }

            if (e.ColumnIndex == dataGridView1.Columns["RateButton"].Index)
            {
                using (var db = new MovieRatingsEntities3())
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    con.Open();
                    com = new SqlCommand($"UPDATE Movies SET Ratings = ISNULL(Ratings, 0)+1 WHERE ID = {record.ID}", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    UpdateDataIntoDatagrid();
                    //RateButton.Visible = false;
                }
            }
        }
        public void dataGridView1_CellValueChanged(object sender,
        DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "RateButton")
            {
                DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridView1.
                    Rows[e.RowIndex].Cells["Rate"];

                dataGridView1.Invalidate();
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
  
            Edit addEditForm = new Edit(null);

            if(addEditForm.ShowDialog() == DialogResult.OK)
            {
                UpdateDataIntoDatagrid();
            }
            
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
            var db = new MovieRatingsEntities3();


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
            Edit(dataGridView1.CurrentRow.DataBoundItem as Movy);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            Delete();
        }
        #endregion

        #region Methods
        private void UpdateDataIntoDatagrid()
        {
            using (var db = new MovieRatingsEntities3())
            {
                dataGridView1.DataSource = db.Movies.Where(m => m.HasBeenWatched == false).ToList();
                //db.SaveChanges();
            }
        }

        private void Edit(Movy currentMovie)
        {
            Edit form = new Edit(currentMovie);
            
            if(form.ShowDialog() == DialogResult.OK)
            {
                UpdateDataIntoDatagrid();
            }

        }

        private void Delete()
        {
            var RowIndex = dataGridView1.CurrentCell.RowIndex;
            int curMovieId = int.Parse(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
            if (MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new MovieRatingsEntities3())
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
            System.Windows.Forms.Application.Exit();
        }
    }
}