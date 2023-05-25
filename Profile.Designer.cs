
namespace LibraMind
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Label();
            this.IdInput = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.NationalityLabel = new System.Windows.Forms.Label();
            this.Nationallity = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DashBoardPanel = new System.Windows.Forms.Panel();
            this.DashBoardIcon = new System.Windows.Forms.PictureBox();
            this.LogoutLabelBtn = new System.Windows.Forms.Label();
            this.ReturnLabelBtn = new System.Windows.Forms.Label();
            this.BorrowLabelBtn = new System.Windows.Forms.Label();
            this.ProfileLabelBtn = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.DashBoardLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.DashBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.OkBtn);
            this.panel1.Controls.Add(this.IdInput);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.PositionLabel);
            this.panel1.Controls.Add(this.Position);
            this.panel1.Controls.Add(this.NationalityLabel);
            this.panel1.Controls.Add(this.Nationallity);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.ProfileLabel);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.ProfilePic);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(345, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 760);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmailLabel.Location = new System.Drawing.Point(505, 205);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 41);
            this.EmailLabel.TabIndex = 30;
            this.EmailLabel.Visible = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Email.Location = new System.Drawing.Point(333, 205);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(134, 41);
            this.Email.TabIndex = 29;
            this.Email.Text = "Email:";
            this.Email.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(686, 258);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(188, 37);
            this.ErrorLabel.TabIndex = 28;
            this.ErrorLabel.Text = "Required!";
            this.ErrorLabel.Visible = false;
            // 
            // OkBtn
            // 
            this.OkBtn.AutoSize = true;
            this.OkBtn.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OkBtn.Image = ((System.Drawing.Image)(resources.GetObject("OkBtn.Image")));
            this.OkBtn.Location = new System.Drawing.Point(583, 258);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(65, 42);
            this.OkBtn.TabIndex = 27;
            this.OkBtn.Text = "OK";
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // IdInput
            // 
            this.IdInput.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdInput.Location = new System.Drawing.Point(450, 258);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(87, 37);
            this.IdInput.TabIndex = 24;
            this.IdInput.WordWrap = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IdLabel.Location = new System.Drawing.Point(256, 258);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(188, 41);
            this.IdLabel.TabIndex = 12;
            this.IdLabel.Text = "Your ID: ";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PositionLabel.Location = new System.Drawing.Point(525, 503);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(0, 41);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Visible = false;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Position.Location = new System.Drawing.Point(333, 503);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(186, 41);
            this.Position.TabIndex = 9;
            this.Position.Text = "Position: ";
            this.Position.Visible = false;
            // 
            // NationalityLabel
            // 
            this.NationalityLabel.AutoSize = true;
            this.NationalityLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NationalityLabel.Location = new System.Drawing.Point(605, 390);
            this.NationalityLabel.Name = "NationalityLabel";
            this.NationalityLabel.Size = new System.Drawing.Size(0, 41);
            this.NationalityLabel.TabIndex = 8;
            this.NationalityLabel.Visible = false;
            // 
            // Nationallity
            // 
            this.Nationallity.AutoSize = true;
            this.Nationallity.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nationallity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nationallity.Location = new System.Drawing.Point(333, 390);
            this.Nationallity.Name = "Nationallity";
            this.Nationallity.Size = new System.Drawing.Size(243, 41);
            this.Nationallity.TabIndex = 7;
            this.Nationallity.Text = "Nationality:";
            this.Nationallity.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordLabel.Location = new System.Drawing.Point(548, 300);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 41);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Visible = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Password.Location = new System.Drawing.Point(333, 300);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(209, 41);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password: ";
            this.Password.Visible = false;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProfileLabel.Location = new System.Drawing.Point(420, 80);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(156, 47);
            this.ProfileLabel.TabIndex = 4;
            this.ProfileLabel.Text = "Profile";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.UsernameLabel.Location = new System.Drawing.Point(83, 364);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 41);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Visible = false;
            // 
            // ProfilePic
            // 
            this.ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Image")));
            this.ProfilePic.Location = new System.Drawing.Point(17, 109);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(233, 228);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 2;
            this.ProfilePic.TabStop = false;
            this.ProfilePic.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Harrington", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(341, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 52);
            this.label6.TabIndex = 1;
            this.label6.Text = "The Great Hall";
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashBoardPanel.BackgroundImage")));
            this.DashBoardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoardPanel.Controls.Add(this.DashBoardIcon);
            this.DashBoardPanel.Controls.Add(this.LogoutLabelBtn);
            this.DashBoardPanel.Controls.Add(this.ReturnLabelBtn);
            this.DashBoardPanel.Controls.Add(this.BorrowLabelBtn);
            this.DashBoardPanel.Controls.Add(this.ProfileLabelBtn);
            this.DashBoardPanel.Controls.Add(this.StudentLabel);
            this.DashBoardPanel.Controls.Add(this.DashBoardLabel);
            this.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.Size = new System.Drawing.Size(339, 760);
            this.DashBoardPanel.TabIndex = 2;
            // 
            // DashBoardIcon
            // 
            this.DashBoardIcon.Image = ((System.Drawing.Image)(resources.GetObject("DashBoardIcon.Image")));
            this.DashBoardIcon.Location = new System.Drawing.Point(21, 85);
            this.DashBoardIcon.Name = "DashBoardIcon";
            this.DashBoardIcon.Size = new System.Drawing.Size(58, 42);
            this.DashBoardIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashBoardIcon.TabIndex = 4;
            this.DashBoardIcon.TabStop = false;
            // 
            // LogoutLabelBtn
            // 
            this.LogoutLabelBtn.AutoSize = true;
            this.LogoutLabelBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutLabelBtn.Font = new System.Drawing.Font("Harrington", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabelBtn.ForeColor = System.Drawing.Color.Black;
            this.LogoutLabelBtn.Location = new System.Drawing.Point(97, 602);
            this.LogoutLabelBtn.Name = "LogoutLabelBtn";
            this.LogoutLabelBtn.Size = new System.Drawing.Size(130, 37);
            this.LogoutLabelBtn.TabIndex = 5;
            this.LogoutLabelBtn.Text = "Log out";
            this.LogoutLabelBtn.Click += new System.EventHandler(this.LogoutLabelBtn_Click);
            // 
            // ReturnLabelBtn
            // 
            this.ReturnLabelBtn.AutoSize = true;
            this.ReturnLabelBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReturnLabelBtn.Font = new System.Drawing.Font("Harrington", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLabelBtn.ForeColor = System.Drawing.Color.Black;
            this.ReturnLabelBtn.Location = new System.Drawing.Point(106, 405);
            this.ReturnLabelBtn.Name = "ReturnLabelBtn";
            this.ReturnLabelBtn.Size = new System.Drawing.Size(119, 37);
            this.ReturnLabelBtn.TabIndex = 4;
            this.ReturnLabelBtn.Text = "Return";
            this.ReturnLabelBtn.Click += new System.EventHandler(this.ReturnLabelBtn_Click);
            // 
            // BorrowLabelBtn
            // 
            this.BorrowLabelBtn.AutoSize = true;
            this.BorrowLabelBtn.BackColor = System.Drawing.Color.Transparent;
            this.BorrowLabelBtn.Font = new System.Drawing.Font("Harrington", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowLabelBtn.ForeColor = System.Drawing.Color.Black;
            this.BorrowLabelBtn.Location = new System.Drawing.Point(97, 300);
            this.BorrowLabelBtn.Name = "BorrowLabelBtn";
            this.BorrowLabelBtn.Size = new System.Drawing.Size(128, 37);
            this.BorrowLabelBtn.TabIndex = 3;
            this.BorrowLabelBtn.Text = "Borrow";
            this.BorrowLabelBtn.Click += new System.EventHandler(this.BorrowLabelBtn_Click);
            // 
            // ProfileLabelBtn
            // 
            this.ProfileLabelBtn.AutoSize = true;
            this.ProfileLabelBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProfileLabelBtn.Font = new System.Drawing.Font("Harrington", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabelBtn.ForeColor = System.Drawing.Color.Black;
            this.ProfileLabelBtn.Location = new System.Drawing.Point(106, 193);
            this.ProfileLabelBtn.Name = "ProfileLabelBtn";
            this.ProfileLabelBtn.Size = new System.Drawing.Size(119, 37);
            this.ProfileLabelBtn.TabIndex = 2;
            this.ProfileLabelBtn.Text = "Profile";
            this.ProfileLabelBtn.Click += new System.EventHandler(this.ProfileLabelBtn_Click);
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.BackColor = System.Drawing.Color.Transparent;
            this.StudentLabel.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StudentLabel.Location = new System.Drawing.Point(97, 18);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(144, 42);
            this.StudentLabel.TabIndex = 1;
            this.StudentLabel.Text = "Student";
            // 
            // DashBoardLabel
            // 
            this.DashBoardLabel.AutoSize = true;
            this.DashBoardLabel.BackColor = System.Drawing.Color.Transparent;
            this.DashBoardLabel.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoardLabel.ForeColor = System.Drawing.Color.Black;
            this.DashBoardLabel.Location = new System.Drawing.Point(75, 85);
            this.DashBoardLabel.Name = "DashBoardLabel";
            this.DashBoardLabel.Size = new System.Drawing.Size(208, 42);
            this.DashBoardLabel.TabIndex = 0;
            this.DashBoardLabel.Text = "DashBoard";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 760);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DashBoardPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.Text = "LibraMind";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.DashBoardPanel.ResumeLayout(false);
            this.DashBoardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel DashBoardPanel;
        private System.Windows.Forms.PictureBox DashBoardIcon;
        private System.Windows.Forms.Label LogoutLabelBtn;
        private System.Windows.Forms.Label ReturnLabelBtn;
        private System.Windows.Forms.Label BorrowLabelBtn;
        private System.Windows.Forms.Label ProfileLabelBtn;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label DashBoardLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label NationalityLabel;
        private System.Windows.Forms.Label Nationallity;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdInput;
        private System.Windows.Forms.Label OkBtn;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Email;
    }
}