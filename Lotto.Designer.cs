
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieRatingsDataSet = new RatingSystem.MovieRatingsDataSet();
            this.movieRatingsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRatingsDataSet1 = new RatingSystem.MovieRatingsDataSet1();
            this.mOVIESTableAdapter = new RatingSystem.MovieRatingsDataSet1TableAdapters.MOVIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(113, 19);
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
            this.ClientSize = new System.Drawing.Size(568, 360);
            this.Controls.Add(this.label1);
            this.Name = "Lotto";
            this.ShowIcon = false;
            this.Text = "Lotto";
            this.Load += new System.EventHandler(this.Lotto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRatingsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MovieRatingsDataSet movieRatingsDataSet;
        private System.Windows.Forms.BindingSource movieRatingsDataSetBindingSource;
        private MovieRatingsDataSet1 movieRatingsDataSet1;
        private System.Windows.Forms.BindingSource mOVIESBindingSource;
        private MovieRatingsDataSet1TableAdapters.MOVIESTableAdapter mOVIESTableAdapter;
    }
}