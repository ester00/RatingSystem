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

    public partial class Edit : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public DataGridViewRow dgvr;
        private int currMovieId;

        public Edit()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            currMovieId = int.Parse(dgvr.Cells[0].Value.ToString());
            TitleTxt.Text = dgvr.Cells[1].Value.ToString();
            SummaryTxt.Text = dgvr.Cells[2].Value.ToString();
            comboBox1.Text = dgvr.Cells[3].Value.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (TitleTxt.Text.Length == 0)
            {
                Label.Text = "Movie title can not be empty.";
                Label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                using (var db = new MovieRatingsEntities2())
                {
                    con.Open();
                    com = new SqlCommand($"UPDATE Movies SET Title = @Title, Summary = @Summary, Genre = @Genre WHERE ID = {currMovieId}", con);
                    com.Parameters.Add(new SqlParameter("@Title", TitleTxt.Text));
                    com.Parameters.Add(new SqlParameter("@Summary", SummaryTxt.Text));
                    com.Parameters.Add(new SqlParameter("@Genre", comboBox1.Text));
                    com.ExecuteNonQuery();
                    con.Close();
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
