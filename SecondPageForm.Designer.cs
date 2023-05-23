
namespace LibraMind
{
    partial class SecondPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondPageForm));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.SignUpButton = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Label();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.Controls.Add(this.SignUpButton);
            this.BackPanel.Controls.Add(this.LoginButton);
            this.BackPanel.Controls.Add(this.CaptionLabel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(839, 538);
            this.BackPanel.TabIndex = 0;
            this.BackPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SignUpButton
            // 
            this.SignUpButton.AutoSize = true;
            this.SignUpButton.Font = new System.Drawing.Font("Harrington", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpButton.Image = ((System.Drawing.Image)(resources.GetObject("SignUpButton.Image")));
            this.SignUpButton.Location = new System.Drawing.Point(562, 384);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(144, 52);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Enroll";
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.Font = new System.Drawing.Font("Harrington", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.Location = new System.Drawing.Point(148, 384);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(130, 52);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Enter";
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CaptionLabel.Location = new System.Drawing.Point(93, 216);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(684, 104);
            this.CaptionLabel.TabIndex = 4;
            this.CaptionLabel.Text = "You are close enough to start \r\nyour magical journey.";
            this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(839, 538);
            this.Controls.Add(this.BackPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SecondPageForm";
            this.Text = "LibraMind";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label SignUpButton;
        private System.Windows.Forms.Label LoginButton;
        private System.Windows.Forms.Label CaptionLabel;
    }
}

