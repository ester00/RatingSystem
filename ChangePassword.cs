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
    public partial class ChangePassword : Form
    {
        User currentUser;

        public ChangePassword(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
             if (IsValidPassword(textNewPass.Text))
             {
                    using (var db = new MovieRatingsEntities3())
                    {
                        if (db.Users.FirstOrDefault(u => u.Password == currentUser.Password) != null)
                        {
                            currentUser.Password = textNewPass.Text;

                            db.Users.AddOrUpdate(currentUser);
                            db.SaveChanges();
                        }
                    else
                    {
                        loginLabel.Text = "Either your username or password is incorrect.";
                        loginLabel.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
             else
             {
                 loginLabel.Text = "Invalid password!";
                 loginLabel.ForeColor = System.Drawing.Color.Red;
                 label6.ForeColor = System.Drawing.Color.Red;
             }
        }
        private bool IsValidPassword(string password)
        {
            return (password.Length >= 6 &&
                    password.Any(char.IsUpper)
                    );
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            username.Text = constant.UserName;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textOldPass.PasswordChar = default(char);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textNewPass
                .PasswordChar = default(char);
        }
    }
}
