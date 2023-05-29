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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.buttonPlayTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonLogAdmin = new System.Windows.Forms.Button();
            this.btn__Vote = new System.Windows.Forms.Button();
            this.title__1 = new System.Windows.Forms.Label();
            this.BottomPage = new System.Windows.Forms.Panel();
            this.title__2 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar4 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.BottomPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlayTime
            // 
            this.buttonPlayTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlayTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonPlayTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayTime.ForeColor = System.Drawing.Color.Gray;
            this.buttonPlayTime.Location = new System.Drawing.Point(539, 238);
            this.buttonPlayTime.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayTime.Name = "buttonPlayTime";
            this.buttonPlayTime.Size = new System.Drawing.Size(187, 43);
            this.buttonPlayTime.TabIndex = 2;
            this.buttonPlayTime.Text = "Play Time";
            this.buttonPlayTime.UseVisualStyleBackColor = true;
            this.buttonPlayTime.Click += new System.EventHandler(this.buttonPlayTime_Click);
            this.buttonPlayTime.MouseEnter += new System.EventHandler(this.buttonPlayTime_MouseEnter);
            this.buttonPlayTime.MouseLeave += new System.EventHandler(this.buttonPlayTime_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(471, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = " Votes Stats Now";
            // 
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.SystemColors.Control;
            this.LabelTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTime.Location = new System.Drawing.Point(358, 128);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(583, 91);
            this.LabelTime.TabIndex = 20;
            this.LabelTime.Text = "00 : 00 : 00 : 00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonLogAdmin
            // 
            this.buttonLogAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogAdmin.AutoEllipsis = true;
            this.buttonLogAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonLogAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.buttonLogAdmin.Location = new System.Drawing.Point(993, 14);
            this.buttonLogAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogAdmin.Name = "buttonLogAdmin";
            this.buttonLogAdmin.Size = new System.Drawing.Size(87, 39);
            this.buttonLogAdmin.TabIndex = 0;
            this.buttonLogAdmin.Text = "Admin";
            this.buttonLogAdmin.UseVisualStyleBackColor = false;
            this.buttonLogAdmin.Click += new System.EventHandler(this.buttonLogAdmin_Click);
            this.buttonLogAdmin.MouseEnter += new System.EventHandler(this.buttonLogAdmin_MouseEnter);
            this.buttonLogAdmin.MouseLeave += new System.EventHandler(this.buttonLogAdmin_MouseLeave);
            // 
            // btn__Vote
            // 
            this.btn__Vote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn__Vote.AutoEllipsis = true;
            this.btn__Vote.BackColor = System.Drawing.SystemColors.Control;
            this.btn__Vote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn__Vote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn__Vote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__Vote.ForeColor = System.Drawing.Color.DimGray;
            this.btn__Vote.Location = new System.Drawing.Point(1101, 14);
            this.btn__Vote.Margin = new System.Windows.Forms.Padding(4);
            this.btn__Vote.Name = "btn__Vote";
            this.btn__Vote.Size = new System.Drawing.Size(77, 39);
            this.btn__Vote.TabIndex = 1;
            this.btn__Vote.Text = "Voter";
            this.btn__Vote.UseVisualStyleBackColor = false;
            this.btn__Vote.Click += new System.EventHandler(this.btn__Vote_Click);
            this.btn__Vote.MouseEnter += new System.EventHandler(this.btn__Vote_MouseEnter);
            this.btn__Vote.MouseLeave += new System.EventHandler(this.btn__Vote_MouseLeave);
            // 
            // title__1
            // 
            this.title__1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.title__1.AutoSize = true;
            this.title__1.BackColor = System.Drawing.Color.Transparent;
            this.title__1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title__1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.title__1.Location = new System.Drawing.Point(9, 8);
            this.title__1.Name = "title__1";
            this.title__1.Size = new System.Drawing.Size(157, 52);
            this.title__1.TabIndex = 5;
            this.title__1.Text = "Digital";
            this.title__1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BottomPage
            // 
            this.BottomPage.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.BottomPage.AutoScroll = true;
            this.BottomPage.BackColor = System.Drawing.SystemColors.GrayText;
            this.BottomPage.Controls.Add(this.title__2);
            this.BottomPage.Controls.Add(this.title__1);
            this.BottomPage.Controls.Add(this.buttonLogAdmin);
            this.BottomPage.Controls.Add(this.btn__Vote);
            this.BottomPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomPage.Location = new System.Drawing.Point(0, 0);
            this.BottomPage.Margin = new System.Windows.Forms.Padding(4);
            this.BottomPage.Name = "BottomPage";
            this.BottomPage.Size = new System.Drawing.Size(1262, 68);
            this.BottomPage.TabIndex = 3;
            // 
            // title__2
            // 
            this.title__2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.title__2.AutoSize = true;
            this.title__2.BackColor = System.Drawing.Color.Transparent;
            this.title__2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.title__2.Font = new System.Drawing.Font("Microsoft YaHei Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title__2.ForeColor = System.Drawing.Color.Gainsboro;
            this.title__2.Location = new System.Drawing.Point(152, 4);
            this.title__2.Name = "title__2";
            this.title__2.Size = new System.Drawing.Size(116, 57);
            this.title__2.TabIndex = 5;
            this.title__2.Text = "Vote";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(159, 368);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(178, 178);
            this.guna2CircleProgressBar1.TabIndex = 21;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(440, 368);
            this.guna2CircleProgressBar2.Minimum = 0;
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(178, 178);
            this.guna2CircleProgressBar2.TabIndex = 22;
            this.guna2CircleProgressBar2.Text = "guna2CircleProgressBar2";
            // 
            // guna2CircleProgressBar3
            // 
            this.guna2CircleProgressBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar3.Location = new System.Drawing.Point(702, 368);
            this.guna2CircleProgressBar3.Minimum = 0;
            this.guna2CircleProgressBar3.Name = "guna2CircleProgressBar3";
            this.guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar3.Size = new System.Drawing.Size(178, 178);
            this.guna2CircleProgressBar3.TabIndex = 23;
            this.guna2CircleProgressBar3.Text = "guna2CircleProgressBar3";
            // 
            // guna2CircleProgressBar4
            // 
            this.guna2CircleProgressBar4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar4.Location = new System.Drawing.Point(964, 368);
            this.guna2CircleProgressBar4.Minimum = 0;
            this.guna2CircleProgressBar4.Name = "guna2CircleProgressBar4";
            this.guna2CircleProgressBar4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar4.Size = new System.Drawing.Size(178, 178);
            this.guna2CircleProgressBar4.TabIndex = 24;
            this.guna2CircleProgressBar4.Text = "guna2CircleProgressBar4";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.guna2CircleProgressBar4);
            this.Controls.Add(this.guna2CircleProgressBar3);
            this.Controls.Add(this.guna2CircleProgressBar2);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BottomPage);
            this.Controls.Add(this.buttonPlayTime);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalVote";
            this.BottomPage.ResumeLayout(false);
            this.BottomPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlayTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonLogAdmin;
        private System.Windows.Forms.Button btn__Vote;
        private System.Windows.Forms.Label title__1;
        private System.Windows.Forms.Panel BottomPage;
        private System.Windows.Forms.Label title__2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar4;
    }
}

