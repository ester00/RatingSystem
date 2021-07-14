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
using System.Data.Entity.Migrations;

namespace RatingSystem
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private LoginPage _login;
        public string _roleName;
        private readonly MovieRatingsEntities3 _db;

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
            _db = new MovieRatingsEntities3();
        }

        public Form1(LoginPage login, string roleName)
        {
            InitializeComponent();
            _login = login;
            _roleName = roleName;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataIntoDatagrid();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            loggedInToolStripMenuItem.Text = constant.UserName;

            if (constant.RoleName != "Admin")
            {
               DeleteButton.Visible = false;
            }
           
           if (constant.RoleName != "Admin" && _roleName != "User")
           {
               DeleteButton.Visible = false;
               EditButton.Visible = false;
               RateButton.Visible = false;
               loggedInToolStripMenuItem.Visible = false;
               newMovieToolStripMenuItem.Visible = false;
               lottoToolStripMenuItem.Visible = false;
               logInToolStripMenuItem.Visible = true;
           }
        }

        #region Rate/Delete/Edit
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var record = dataGridView1.CurrentRow.DataBoundItem as Movy;

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

            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
            {
                using (var db = new MovieRatingsEntities3())
                {
                    Delete();
                    db.SaveChanges();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["RateButton"].Index)
            {
                using (var db = new MovieRatingsEntities3())
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    using (var db2 = new MovieRatingsEntities3())
                    {
                        var currentMovie = db2.Movies.First(x => x.ID == record.ID);
                        var convertedRating = 0;

                        if (currentMovie.Ratings != null)
                        {
                            convertedRating = int.Parse(currentMovie.Ratings);
                        }

                        currentMovie.Ratings = (convertedRating + 1).ToString();
                        db2.SaveChanges();

                    }
                    UpdateDataIntoDatagrid();
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
            string lgname = _login.txtUsername.Text;
            ChangePassword popUpForm = new ChangePassword(_login);
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
                var record = dataGridView1.CurrentRow.DataBoundItem as Movy;
                using (db = new MovieRatingsEntities3())
                {
                    if(db.Users.FirstOrDefault(u => u.Id == constant.LoggedUserId) != null)
                    {
                        var x = (from y in db.Users
                                 where y.Id == constant.LoggedUserId
                                 select y).FirstOrDefault();
                        db.Users.Remove(x);
                        db.SaveChanges();

                        MessageBox.Show("Account deleted succesfully.", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginPage LP = new LoginPage();
                        LP.ShowDialog();
                    }
                }
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
            var record = dataGridView1.CurrentRow.DataBoundItem as Movy;
            using (var db = new MovieRatingsDataSet())
            {
                if (db.UserMovies.FirstOrDefault(u => u.MovieId == record.ID && u.UserId == constant.LoggedUserId) != null)
                {
                    Edit(dataGridView1.CurrentRow.DataBoundItem as Movy);
                }
                else
                {
                    MessageBox.Show("Да бе да,... не твой не барай!");
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (constant.RoleName == "Admin")
            {
                Delete();
            }
            else
            {
                MessageBox.Show("Да бе да,... не твой не барай!");
            }
        }
        #endregion

        #region Methods
        private void UpdateDataIntoDatagrid()
        {
            using (var db = new MovieRatingsEntities3())
            {
                dataGridView1.DataSource = db.Movies.Where(m => m.HasBeenWatched == false).ToList();
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
            using (var db = new MovieRatingsEntities3())
            {
                var record = dataGridView1.CurrentRow.DataBoundItem as Movy;
                if (MessageBox.Show("Are you sure you want to delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var x = (from y in db.Movies
                             where y.ID == record.ID
                             select y).FirstOrDefault();
                    db.Movies.Remove(x);
                    db.SaveChanges();
                    UpdateDataIntoDatagrid();
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