
namespace RatingSystem
{
    partial class Lotto
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieRatingsDataSet = new RatingSystem.MovieRatingsDataSet();
            this.movieRatingsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRatingsDataSet1 = new RatingSystem.MovieRatingsDataSet1();
            this.mOVIESTableAdapter = new RatingSystem.MovieRatingsDataSet1TableAdapters.MOVIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "Random selection:";
            // 
            // movieRatingsDataSet
            // 
            this.movieRatingsDataSet.DataSetName = "MovieRatingsDataSet";
            this.movieRatingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieRatingsDataSetBindingSource
            // 
            this.movieRatingsDataSetBindingSource.DataSource = this.movieRatingsDataSet;
            this.movieRatingsDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.ratingsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mOVIESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(485, 109);
            this.dataGridView1.TabIndex = 23;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 180;
            // 
            // ratingsDataGridViewTextBoxColumn
            // 
            this.ratingsDataGridViewTextBoxColumn.DataPropertyName = "Ratings";
            this.ratingsDataGridViewTextBoxColumn.HeaderText = "Ratings";
            this.ratingsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ratingsDataGridViewTextBoxColumn.Name = "ratingsDataGridViewTextBoxColumn";
            this.ratingsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingsDataGridViewTextBoxColumn.Width = 80;
            // 
            // mOVIESBindingSource
            // 
            this.mOVIESBindingSource.DataMember = "MOVIES";
            this.mOVIESBindingSource.DataSource = this.movieRatingsDataSet1;
            // 
            // movieRatingsDataSet1
            // 
            this.movieRatingsDataSet1.DataSetName = "MovieRatingsDataSet1";
            this.movieRatingsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIESTableAdapter
            // 
            this.mOVIESTableAdapter.ClearBeforeFill = true;
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(545, 254);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Lotto";
            this.ShowIcon = false;
            this.Text = "Lotto";
            this.Load += new System.EventHandler(this.Lotto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MovieRatingsDataSet movieRatingsDataSet;
        private System.Windows.Forms.BindingSource movieRatingsDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MovieRatingsDataSet1 movieRatingsDataSet1;
        private System.Windows.Forms.BindingSource mOVIESBindingSource;
        private MovieRatingsDataSet1TableAdapters.MOVIESTableAdapter mOVIESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingsDataGridViewTextBoxColumn;
    }
}