
namespace LibraMind
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Black;
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftPanel.Controls.Add(this.LogoLabel);
            this.LeftPanel.Controls.Add(this.LogoPic);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(552, 692);
            this.LeftPanel.TabIndex = 2;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LogoLabel.Location = new System.Drawing.Point(66, 291);
            this.LogoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(400, 114);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Let\'s Explore \r\nThe Great Hall!";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(-18, 0);
            this.LogoPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(168, 150);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Black;
            this.RightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightPanel.BackgroundImage")));
            this.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightPanel.Controls.Add(this.LoginButton);
            this.RightPanel.Controls.Add(this.PasswordInput);
            this.RightPanel.Controls.Add(this.PasswordLabel);
            this.RightPanel.Controls.Add(this.UsernameInput);
            this.RightPanel.Controls.Add(this.UsernameLabel);
            this.RightPanel.Controls.Add(this.LoginLabel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightPanel.Location = new System.Drawing.Point(550, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(437, 692);
            this.RightPanel.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Maroon;
            this.LoginButton.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(30, 558);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(384, 65);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Enter with Magicians";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(48, 397);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(349, 28);
            this.PasswordInput.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Location = new System.Drawing.Point(42, 340);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(144, 31);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(48, 242);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(349, 28);
            this.UsernameInput.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Location = new System.Drawing.Point(42, 185);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(153, 31);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginLabel.Location = new System.Drawing.Point(174, 60);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(121, 44);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 692);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "LibraMind";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LoginLabel;
    }
}