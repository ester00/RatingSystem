
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loggedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lottoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.movieRatingsDataSet5 = new RatingSystem.MovieRatingsDataSet5();
            this.mOVIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIESTableAdapter = new RatingSystem.MovieRatingsDataSet5TableAdapters.MOVIESTableAdapter();
            this.RateButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mOVyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRatingsEntities1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsEntities1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.RateButton,
            this.EditButton,
            this.DeleteButton,
            this.lOGINsDataGridViewTextBoxColumn,
            this.mOVIESDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieRatingsEntities1BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggedInToolStripMenuItem,
            this.newMovieToolStripMenuItem,
            this.lottoToolStripMenuItem});
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
            this.logOutToolStripMenuItem1});
            this.loggedInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInToolStripMenuItem.Name = "loggedInToolStripMenuItem";
            this.loggedInToolStripMenuItem.Size = new System.Drawing.Size(145, 36);
            this.loggedInToolStripMenuItem.Text = "logged in:";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(198, 38);
            this.logOutToolStripMenuItem1.Text = "log out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click_1);
            // 
            // newMovieToolStripMenuItem
            // 
            this.newMovieToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newMovieToolStripMenuItem.Name = "newMovieToolStripMenuItem";
            this.newMovieToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.newMovieToolStripMenuItem.Text = "new movie";
            this.newMovieToolStripMenuItem.Click += new System.EventHandler(this.newMovieToolStripMenuItem_Click);
            // 
            // lottoToolStripMenuItem
            // 
            this.lottoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lottoToolStripMenuItem.Name = "lottoToolStripMenuItem";
            this.lottoToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.lottoToolStripMenuItem.Text = "lotto";
            this.lottoToolStripMenuItem.Click += new System.EventHandler(this.lottoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // movieRatingsDataSet5
            // 
            this.movieRatingsDataSet5.DataSetName = "MovieRatingsDataSet5";
            this.movieRatingsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIESBindingSource
            // 
            this.mOVIESBindingSource.DataMember = "MOVIES";
            this.mOVIESBindingSource.DataSource = this.movieRatingsDataSet5;
            // 
            // mOVIESTableAdapter
            // 
            this.mOVIESTableAdapter.ClearBeforeFill = true;
            // 
            // RateButton
            // 
            this.RateButton.DataPropertyName = "Title";
            this.RateButton.FillWeight = 90F;
            this.RateButton.HeaderText = "Rate";
            this.RateButton.MinimumWidth = 8;
            this.RateButton.Name = "RateButton";
            this.RateButton.Text = "👍";
            this.RateButton.UseColumnTextForButtonValue = true;
            this.RateButton.Width = 60;
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "Edit";
            this.EditButton.MinimumWidth = 8;
            this.EditButton.Name = "EditButton";
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
            this.DeleteButton.Text = "⌫";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 60;
            // 
            // mOVyBindingSource
            // 
            this.mOVyBindingSource.DataSource = typeof(RatingSystem.MOVy);
            // 
            // movieRatingsEntities1BindingSource
            // 
            this.movieRatingsEntities1BindingSource.DataSource = typeof(RatingSystem.MovieRatingsEntities1);
            // 
            // lOGINsDataGridViewTextBoxColumn
            // 
            this.lOGINsDataGridViewTextBoxColumn.DataPropertyName = "LOGINs";
            this.lOGINsDataGridViewTextBoxColumn.HeaderText = "LOGINs";
            this.lOGINsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lOGINsDataGridViewTextBoxColumn.Name = "lOGINsDataGridViewTextBoxColumn";
            this.lOGINsDataGridViewTextBoxColumn.Width = 150;
            // 
            // mOVIESDataGridViewTextBoxColumn
            // 
            this.mOVIESDataGridViewTextBoxColumn.DataPropertyName = "MOVIES";
            this.mOVIESDataGridViewTextBoxColumn.HeaderText = "MOVIES";
            this.mOVIESDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mOVIESDataGridViewTextBoxColumn.Name = "mOVIESDataGridViewTextBoxColumn";
            this.mOVIESDataGridViewTextBoxColumn.Width = 150;
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.databaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            this.changeTrackerDataGridViewTextBoxColumn.Width = 150;
            // 
            // configurationDataGridViewTextBoxColumn
            // 
            this.configurationDataGridViewTextBoxColumn.DataPropertyName = "Configuration";
            this.configurationDataGridViewTextBoxColumn.HeaderText = "Configuration";
            this.configurationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.configurationDataGridViewTextBoxColumn.Name = "configurationDataGridViewTextBoxColumn";
            this.configurationDataGridViewTextBoxColumn.ReadOnly = true;
            this.configurationDataGridViewTextBoxColumn.Width = 150;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsEntities1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newMovieToolStripMenuItem;
        private ToolStripMenuItem lottoToolStripMenuItem;
        private TextBox txtUsername;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem loggedInToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private MovieRatingsDataSet5 movieRatingsDataSet5;
        private BindingSource mOVIESBindingSource;
        private MovieRatingsDataSet5TableAdapters.MOVIESTableAdapter mOVIESTableAdapter;
        private DataGridViewButtonColumn RateButton;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
        private BindingSource mOVyBindingSource;
        private DataGridViewTextBoxColumn lOGINsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mOVIESDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
        private BindingSource movieRatingsEntities1BindingSource;
    }
}

