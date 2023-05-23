
namespace LibraMind
{
    partial class FirstPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoHomeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.GoHomeButton);
            this.panel1.Controls.Add(this.LogoLabel);
            this.panel1.Controls.Add(this.LogoPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 675);
            this.panel1.TabIndex = 1;
            // 
            // GoHomeButton
            // 
            this.GoHomeButton.ActiveBorderThickness = 1;
            this.GoHomeButton.ActiveCornerRadius = 20;
            this.GoHomeButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.GoHomeButton.ActiveForecolor = System.Drawing.Color.White;
            this.GoHomeButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.GoHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.GoHomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoHomeButton.BackgroundImage")));
            this.GoHomeButton.ButtonText = "Let\'s start the Magic";
            this.GoHomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoHomeButton.Font = new System.Drawing.Font("Harrington", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoHomeButton.ForeColor = System.Drawing.Color.Honeydew;
            this.GoHomeButton.IdleBorderThickness = 1;
            this.GoHomeButton.IdleCornerRadius = 20;
            this.GoHomeButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.GoHomeButton.IdleForecolor = System.Drawing.Color.White;
            this.GoHomeButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.GoHomeButton.Location = new System.Drawing.Point(175, 586);
            this.GoHomeButton.Margin = new System.Windows.Forms.Padding(9);
            this.GoHomeButton.Name = "GoHomeButton";
            this.GoHomeButton.Size = new System.Drawing.Size(506, 71);
            this.GoHomeButton.TabIndex = 2;
            this.GoHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoHomeButton.Click += new System.EventHandler(this.GoHomeButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoLabel.Location = new System.Drawing.Point(183, 443);
            this.LogoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(479, 94);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Unloch your Mind with\r\nLibraMind\r\n";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(339, 223);
            this.LogoPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(164, 152);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // FirstPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 675);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FirstPageForm";
            this.Text = "LibraMind";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 GoHomeButton;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPic;
    }
}