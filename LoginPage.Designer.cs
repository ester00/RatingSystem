
namespace RatingSystem
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.RegisterButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GuestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterButton.Location = new System.Drawing.Point(262, 409);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(215, 45);
            this.RegisterButton.TabIndex = 36;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(51, 529);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(433, 53);
            this.loginLabel.TabIndex = 35;
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogInButton.Location = new System.Drawing.Point(44, 409);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(209, 45);
            this.LogInButton.TabIndex = 34;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtPassword.Location = new System.Drawing.Point(130, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(267, 28);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.Text = "admin";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassEnter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtUsername.Location = new System.Drawing.Point(133, 157);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 28);
            this.txtUsername.TabIndex = 28;
            this.txtUsername.Text = "admin";
            this.txtUsername.Enter += new System.EventHandler(this.txtUserEnter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(191, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 43);
            this.label1.TabIndex = 37;
            this.label1.Text = "Log In:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(133, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 3);
            this.panel3.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(130, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 3);
            this.panel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(428, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "👁";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 81);
            this.label3.TabIndex = 42;
            this.label3.Text = "Password must be at least 6 characters long and must contain at least one upper c" +
    "ase letter.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuestButton
            // 
            this.GuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.GuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestButton.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GuestButton.Location = new System.Drawing.Point(44, 460);
            this.GuestButton.Name = "GuestButton";
            this.GuestButton.Size = new System.Drawing.Size(433, 45);
            this.GuestButton.TabIndex = 43;
            this.GuestButton.Text = "Log in as guest";
            this.GuestButton.UseVisualStyleBackColor = false;
            this.GuestButton.Click += new System.EventHandler(this.GuestButton_Click);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.LogInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(84)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(522, 597);
            this.Controls.Add(this.GuestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsername);
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Button GuestButton;
    }
}