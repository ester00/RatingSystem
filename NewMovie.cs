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
    public partial class NewMovie : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private readonly MovieRatingsEntities2 _db;

        public NewMovie()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
            _db = new MovieRatingsEntities2();
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(TitleTxt.Text.Length == 0)
            {
                Label.Text = "Movie title can not be empty.";
                Label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
            con.Open();
            com = new SqlCommand("INSERT INTO Movies (Title, Summary, Genre) VALUES (@Title, @Summary, @Genre)", con);
            com.Parameters.Add(new SqlParameter("@Title", TitleTxt.Text));
            com.Parameters.Add(new SqlParameter("@Summary", SummaryTxt.Text));
            com.Parameters.Add(new SqlParameter("@Genre", comboBox1.Text));
            com.ExecuteNonQuery();
            this.Close();
            }

            string username = constant.UserName;
            string title = TitleTxt.Text;

            var userId = _db.Users.FirstOrDefault(q => q.Username == username).Id;
            var movieId = _db.Movies.FirstOrDefault(q => q.Title == title).ID;
            _db.UserMovies.Add(new UserMovy { MovieId = movieId , UserId = userId});
            _db.SaveChanges();
        }
    }
}


