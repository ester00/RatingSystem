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
using System.Data.Entity.Migrations;

namespace RatingSystem
{

    public partial class Edit : Form
    {

        Movy currentMovie;

        public Edit(Movy movie)
        {
            InitializeComponent();
            currentMovie = movie;
        }


        private void Edit_Load(object sender, EventArgs e)
        {

            if (currentMovie != null)
            {
                TitleTxt.Text = currentMovie.Title;
                SummaryTxt.Text = currentMovie.Summary;
                comboBox1.Text = currentMovie.Genre;
            }
            else
            {
                Text = "New Movie";
            }
     
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
                using (var db = new MovieRatingsEntities3())
                {

                    if(currentMovie == null)
                    {
                        currentMovie = new Movy();
                    }

                    currentMovie.Title = TitleTxt.Text;
                    currentMovie.Summary = SummaryTxt.Text;
                    currentMovie.Genre = comboBox1.Text;

                    db.Movies.AddOrUpdate(currentMovie);
                    db.SaveChanges();

                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
