namespace Login_Display
{
    partial class loginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.createNewAccountLink = new System.Windows.Forms.LinkLabel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.backgroundPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 35);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.closeButton.Location = new System.Drawing.Point(719, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 31);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Window;
            this.loginButton.Location = new System.Drawing.Point(57, 202);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(241, 39);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            //this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(53, 77);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(245, 23);
            this.userTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.passwordPicture);
            this.panel2.Controls.Add(this.userPicture);
            this.panel2.Controls.Add(this.createNewAccountLink);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Controls.Add(this.forgotPasswordLink);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.userTextBox);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(45, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 289);
            this.panel2.TabIndex = 4;
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = ((System.Drawing.Image)(resources.GetObject("passwordPicture.Image")));
            this.passwordPicture.Location = new System.Drawing.Point(9, 124);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(43, 28);
            this.passwordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPicture.TabIndex = 9;
            this.passwordPicture.TabStop = false;
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(10, 71);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(40, 32);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 8;
            this.userPicture.TabStop = false;
            // 
            // createNewAccountLink
            // 
            this.createNewAccountLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.createNewAccountLink.AutoSize = true;
            this.createNewAccountLink.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewAccountLink.LinkColor = System.Drawing.SystemColors.Window;
            this.createNewAccountLink.Location = new System.Drawing.Point(112, 250);
            this.createNewAccountLink.Name = "createNewAccountLink";
            this.createNewAccountLink.Size = new System.Drawing.Size(126, 17);
            this.createNewAccountLink.TabIndex = 7;
            this.createNewAccountLink.TabStop = true;
            this.createNewAccountLink.Text = "Create New Account";
            this.createNewAccountLink.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Thistle;
            this.passwordLabel.Location = new System.Drawing.Point(59, 108);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Thistle;
            this.userNameLabel.Location = new System.Drawing.Point(57, 58);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(74, 17);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "User Name";
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.forgotPasswordLink.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLink.LinkColor = System.Drawing.SystemColors.Window;
            this.forgotPasswordLink.Location = new System.Drawing.Point(120, 176);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(107, 17);
            this.forgotPasswordLink.TabIndex = 4;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password";
            this.forgotPasswordLink.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(53, 128);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(245, 23);
            this.passwordTextBox.TabIndex = 3;
            // 
            // backgroundPicture
            // 
            this.backgroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPicture.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPicture.Image")));
            this.backgroundPicture.Location = new System.Drawing.Point(0, 0);
            this.backgroundPicture.Name = "backgroundPicture";
            this.backgroundPicture.Size = new System.Drawing.Size(755, 459);
            this.backgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPicture.TabIndex = 5;
            this.backgroundPicture.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(755, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backgroundPicture);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.LinkLabel createNewAccountLink;
        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox backgroundPicture;
    }
}

