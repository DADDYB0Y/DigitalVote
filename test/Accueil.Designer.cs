namespace test
{
    partial class Accueil
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
            this.buttonLogAdmin = new System.Windows.Forms.Button();
            this.buttonLogUsers = new System.Windows.Forms.Button();
            this.buttonPlayTime = new System.Windows.Forms.Button();
            this.BottomPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.title__1 = new System.Windows.Forms.Label();
            this.title__2 = new System.Windows.Forms.Label();
            this.BottomPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogAdmin
            // 
            this.buttonLogAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogAdmin.AutoEllipsis = true;
            this.buttonLogAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.buttonLogAdmin.Location = new System.Drawing.Point(476, 15);
            this.buttonLogAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogAdmin.Name = "buttonLogAdmin";
            this.buttonLogAdmin.Size = new System.Drawing.Size(87, 38);
            this.buttonLogAdmin.TabIndex = 0;
            this.buttonLogAdmin.Text = "Admin";
            this.buttonLogAdmin.UseVisualStyleBackColor = false;
            this.buttonLogAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogUsers
            // 
            this.buttonLogUsers.AutoEllipsis = true;
            this.buttonLogUsers.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogUsers.ForeColor = System.Drawing.Color.DimGray;
            this.buttonLogUsers.Location = new System.Drawing.Point(577, 14);
            this.buttonLogUsers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogUsers.Name = "buttonLogUsers";
            this.buttonLogUsers.Size = new System.Drawing.Size(77, 39);
            this.buttonLogUsers.TabIndex = 1;
            this.buttonLogUsers.Text = "Vote";
            this.buttonLogUsers.UseVisualStyleBackColor = false;
            this.buttonLogUsers.Click += new System.EventHandler(this.buttonLogUsers_Click);
            // 
            // buttonPlayTime
            // 
            this.buttonPlayTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayTime.ForeColor = System.Drawing.Color.DimGray;
            this.buttonPlayTime.Location = new System.Drawing.Point(289, 196);
            this.buttonPlayTime.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayTime.Name = "buttonPlayTime";
            this.buttonPlayTime.Size = new System.Drawing.Size(131, 32);
            this.buttonPlayTime.TabIndex = 2;
            this.buttonPlayTime.Text = "Play Time";
            this.buttonPlayTime.UseVisualStyleBackColor = true;
            this.buttonPlayTime.Click += new System.EventHandler(this.buttonPlayTime_Click);
            // 
            // BottomPage
            // 
            this.BottomPage.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.BottomPage.AutoScroll = true;
            this.BottomPage.BackColor = System.Drawing.SystemColors.GrayText;
            this.BottomPage.Controls.Add(this.title__2);
            this.BottomPage.Controls.Add(this.title__1);
            this.BottomPage.Controls.Add(this.buttonLogUsers);
            this.BottomPage.Controls.Add(this.buttonLogAdmin);
            this.BottomPage.Location = new System.Drawing.Point(-3, 0);
            this.BottomPage.Margin = new System.Windows.Forms.Padding(4);
            this.BottomPage.Name = "BottomPage";
            this.BottomPage.Size = new System.Drawing.Size(715, 68);
            this.BottomPage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(228, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = " Votes Stats Now";
            // 
            // title__1
            // 
            this.title__1.AutoSize = true;
            this.title__1.BackColor = System.Drawing.Color.Transparent;
            this.title__1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title__1.ForeColor = System.Drawing.Color.Tomato;
            this.title__1.Location = new System.Drawing.Point(9, 8);
            this.title__1.Name = "title__1";
            this.title__1.Size = new System.Drawing.Size(157, 52);
            this.title__1.TabIndex = 5;
            this.title__1.Text = "Digital";
            this.title__1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // title__2
            // 
            this.title__2.AutoSize = true;
            this.title__2.BackColor = System.Drawing.Color.Transparent;
            this.title__2.Font = new System.Drawing.Font("Microsoft YaHei Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title__2.ForeColor = System.Drawing.Color.Gainsboro;
            this.title__2.Location = new System.Drawing.Point(158, 4);
            this.title__2.Name = "title__2";
            this.title__2.Size = new System.Drawing.Size(119, 57);
            this.title__2.TabIndex = 5;
            this.title__2.Text = "Vote";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BottomPage);
            this.Controls.Add(this.buttonPlayTime);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalVote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.BottomPage.ResumeLayout(false);
            this.BottomPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogAdmin;
        private System.Windows.Forms.Button buttonLogUsers;
        private System.Windows.Forms.Button buttonPlayTime;
        private System.Windows.Forms.Panel BottomPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title__2;
        private System.Windows.Forms.Label title__1;
    }
}

