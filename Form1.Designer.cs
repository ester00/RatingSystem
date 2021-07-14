
using System.Windows.Forms;

namespace RatingSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRatingsDataSet3 = new RatingSystem.MovieRatingsDataSet3();
            this.movieRatingsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mOVyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loggedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lottoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mOVIETableAdapter = new RatingSystem.MovieRatingsDataSet3TableAdapters.MOVIETableAdapter();
            this.movieRatingsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVyBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Summary,
            this.Genre,
            this.dataGridViewTextBoxColumn6,
            this.RateButton,
            this.EditButton,
            this.DeleteButton});
            this.dataGridView1.DataSource = this.moviesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 523);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // Summary
            // 
            this.Summary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Summary.DataPropertyName = "Summary";
            this.Summary.HeaderText = "Summary";
            this.Summary.MinimumWidth = 8;
            this.Summary.Name = "Summary";
            this.Summary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 8;
            this.Genre.Name = "Genre";
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Genre.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ratings";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ratings";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // RateButton
            // 
            this.RateButton.DataPropertyName = "Title";
            this.RateButton.FillWeight = 90F;
            this.RateButton.HeaderText = "Rate";
            this.RateButton.MinimumWidth = 8;
            this.RateButton.Name = "RateButton";
            this.RateButton.ReadOnly = true;
            this.RateButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RateButton.Text = "👍";
            this.RateButton.UseColumnTextForButtonValue = true;
            this.RateButton.Width = 60;
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "Edit";
            this.EditButton.MinimumWidth = 8;
            this.EditButton.Name = "EditButton";
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.Text = "✎";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 60;
            // 
            // DeleteButton
            // 
            this.DeleteButton.DataPropertyName = "Title";
            this.DeleteButton.FillWeight = 90F;
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.MinimumWidth = 8;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton.Text = "⌫";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 60;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataSource = this.mOVIEBindingSource;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.movieRatingsDataSet3;
            // 
            // movieRatingsDataSet3
            // 
            this.movieRatingsDataSet3.DataSetName = "MovieRatingsDataSet3";
            this.movieRatingsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtUsername.Location = new System.Drawing.Point(0, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggedInToolStripMenuItem,
            this.newMovieToolStripMenuItem,
            this.lottoToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1276, 40);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loggedInToolStripMenuItem
            // 
            this.loggedInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.deleteAccountToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.loggedInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInToolStripMenuItem.Name = "loggedInToolStripMenuItem";
            this.loggedInToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.loggedInToolStripMenuItem.Text = "username";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.deleteAccountToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(324, 38);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click_1);
            // 
            // newMovieToolStripMenuItem
            // 
            this.newMovieToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newMovieToolStripMenuItem.Name = "newMovieToolStripMenuItem";
            this.newMovieToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.newMovieToolStripMenuItem.Text = "New Movie";
            this.newMovieToolStripMenuItem.Click += new System.EventHandler(this.newMovieToolStripMenuItem_Click);
            // 
            // lottoToolStripMenuItem
            // 
            this.lottoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lottoToolStripMenuItem.Name = "lottoToolStripMenuItem";
            this.lottoToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.lottoToolStripMenuItem.Text = "Lotto";
            this.lottoToolStripMenuItem.Click += new System.EventHandler(this.lottoToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Visible = false;
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // movieRatingsDataSetBindingSource
            // 
            this.movieRatingsDataSetBindingSource.DataSource = this.movieRatingsDataSet3;
            this.movieRatingsDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(1276, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVyBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource mOVyBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newMovieToolStripMenuItem;
        private ToolStripMenuItem lottoToolStripMenuItem;
        private TextBox txtUsername;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem loggedInToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private BindingSource mOVIEBindingSource;
        private MovieRatingsDataSet3TableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem deleteAccountToolStripMenuItem;
        private ToolStripMenuItem logInToolStripMenuItem;
        private BindingSource movieRatingsDataSetBindingSource;
        private BindingSource movieRatingsDataSetBindingSource1;
        private BindingSource moviesBindingSource;
        public MovieRatingsDataSet3 movieRatingsDataSet3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Summary;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn RateButton;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
    }
}

