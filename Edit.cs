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

        public Edit()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }
        

        #region ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("select");
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

        private void Edit_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = dgvr.Cells[2].Value.ToString();
            SummaryTxt.Text = dgvr.Cells[3].Value.ToString();
            comboBox1.Text = dgvr.Cells[4].Value.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using(var db = new MovieRatingsEntities1())
            {
                con.Open();
                com = new SqlCommand("UPDATE MOVIES SET Summary = @Summary, Genre = @Genre WHERE Title = @Title", con);
                com.Parameters.Add(new SqlParameter("@Title", TitleLabel.Text));
                com.Parameters.Add(new SqlParameter("@Summary", SummaryTxt.Text));
                com.Parameters.Add(new SqlParameter("@Genre", comboBox1.Text));
                com.ExecuteNonQuery();
                con.Close();
                db.SaveChanges();
                this.Close();
            }

           // using (var db = new MovieRatingsEntities1())
           // {
           //     con.Open();
           //     com = new SqlCommand("UPDATE MOVIES SET Summary = @Summary, Genre = @Genre, Title = @Title WHERE ID = @ID", con);
           //     com.Parameters.Add(new SqlParameter("@ID", ));
           //     com.Parameters.Add(new SqlParameter("@Title", TitleLabel.Text));
           //     com.Parameters.Add(new SqlParameter("@Summary", SummaryTxt.Text));
           //     com.Parameters.Add(new SqlParameter("@Genre", comboBox1.Text));
           //     com.ExecuteNonQuery();
           //     con.Close();
           //     db.SaveChanges();
           //     this.Close();
           // }
        }
    }
}
