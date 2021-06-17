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
        public string Title { get; set; }
        public int Rating { get; set; }
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        // This is the method to run when the timer is raised.
        private  void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();

            // Displays a message box asking whether to continue running the timer.
            if (alarmCounter < 5)
            {
                // Restarts the timer and increments the counter.
                var random = new Random();
                var rndNumber = random.Next(0, dataGridView1.Rows.Count);
                dataGridView1.Rows[rndNumber].Selected = true;
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

        #region LOGIN
        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from LOGIN";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["username"]) && txtPassword.Text.Equals(dr["password"].ToString()))
                {
                    NewMovieBbutton.Enabled = true;
                    LottoButton.Enabled = true;
                    loginLabel.Text = "Login Succesfull";
                    loginLabel.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    loginLabel.Text = "Either your username or password is incorrect";
                    loginLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            con.Close();
        }
        #endregion

        #region PopUpForms
        private void NewMovieBbutton_Click(object sender, EventArgs e)
        {
            NewMovie popUpForm = new NewMovie();
            popUpForm.ShowDialog();
            UpdateDataIntoDatagrid();
        }

        private void LottoButton_Click_1(object sender, EventArgs e)
        {
            //Lotto popUpForm = new Lotto();
            //popUpForm.ShowDialog();
            dataGridView1.ClearSelection();

            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 500;
            myTimer.Start();

            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }


        }
        #endregion

        private void UpdateDataIntoDatagrid()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MOVIES", con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "MOVIES");
            dataGridView1.DataSource = ds.Tables["MOVIES"].DefaultView;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataIntoDatagrid();

            DataGridViewButtonColumn RateButton = new DataGridViewButtonColumn();
            RateButton.Name = "Rate";
            RateButton.HeaderText = "Rate";
            RateButton.Text = "Rate";
            RateButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(RateButton);

            DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn();
            DeleteButton.Name = "Delete";
            DeleteButton.HeaderText = "Delete";
            DeleteButton.Text = "Delete";
            DeleteButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(DeleteButton);
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(e.ColumnIndex == dataGridView1.Columns["Rate"].Index)
            { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                con = new SqlConnection(@"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True");
                com = new SqlCommand();
                com.Connection = con;
                con.Open();
                com = new SqlCommand("UPDATE MOVIES SET Ratings = ISNULL(Ratings, 0)+1 WHERE Title = @Title", con);
                com.Parameters.AddWithValue("@Title", row.Cells["TitleColumn"].Value);
                com.ExecuteNonQuery();
                con.Close();
                UpdateDataIntoDatagrid();
            }

            if(e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                con = new SqlConnection(@"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True");
                com = new SqlCommand();
                com.Connection = con;
                con.Open();
                com = new SqlCommand("DELETE FROM MOVIES WHERE Title = @Title", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@Title", row.Cells["TitleColumn"].Value);
                com.ExecuteNonQuery();
                con.Close();

                UpdateDataIntoDatagrid();
            }
        }
    }
}
    
