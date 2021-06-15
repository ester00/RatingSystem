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
    public partial class Lotto : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public string Title { get; set; }
        public int Rating { get; set; }
        int nRow;
        public Lotto()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True";
        }

        private void Lotto_Load(object sender, EventArgs e)
        {
            this.mOVIESTableAdapter.Fill(this.movieRatingsDataSet1.MOVIES);

            SqlDataAdapter da = new SqlDataAdapter("select top 1 * from MOVIES order by CHECKSUM(NEWID())", con.ConnectionString = @"Data Source=DESKTOP-TFVT6L2;Initial Catalog=MovieRatings;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "MOVIES");
            dataGridView1.DataSource = ds.Tables["MOVIES"].DefaultView;
        }
    }
}
