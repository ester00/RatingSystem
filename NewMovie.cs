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
        public string Title { get; set; }

        public NewMovie()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }

        public void LogInButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            con.Open();
            com = new SqlCommand("INSERT INTO MOVIES (Title) VALUES (@Title)", con);
            com.Parameters.Add(new SqlParameter("@Title", TitleTxt.Text));
            com.ExecuteNonQuery();

            this.Close();
        }
    }
}


