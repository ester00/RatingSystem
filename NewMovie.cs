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

        public NewMovie()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }
        #region Genre ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("");
            string[] items = 
            {
                "Action",
                "Comedy",
                "Drama",
                "Fantas",
                "Horror",
                "Mystery",
                "Romance",
                "Thriller" 
            };
        }
        #endregion
        
        #region Add new movie button
        private void AddButton_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("INSERT INTO MOVIES (Title, Summary, Genre) VALUES (@Title, @Summary, @Genre)", con);
            com.Parameters.Add(new SqlParameter("@Title", TitleTxt.Text));
            com.Parameters.Add(new SqlParameter("@Summary", SummaryTxt.Text));
            com.Parameters.Add(new SqlParameter("@Genre", comboBox1.Text));
            com.ExecuteNonQuery();
            this.Close();
        }
        #endregion
    }
}


