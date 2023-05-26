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
            this.title__2 = new System.Windows.Forms.Label();
            this.title__1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelHeures = new System.Windows.Forms.Label();
            this.LabelMinutes = new System.Windows.Forms.Label();
            this.LabelSecondes = new System.Windows.Forms.Label();
            this.LabelMillisecondes = new System.Windows.Forms.Label();
            this.labelSeparation1 = new System.Windows.Forms.Label();
            this.LabelSeparation2 = new System.Windows.Forms.Label();
            this.LabelSeparation3 = new System.Windows.Forms.Label();
            this.roundCorneredProgressBar1 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            this.roundCorneredProgressBar2 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            this.roundCorneredProgressBar3 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            this.roundCorneredProgressBar4 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            this.BottomPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar4)).BeginInit();
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
            this.buttonLogAdmin.Location = new System.Drawing.Point(972, 14);
            this.buttonLogAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogAdmin.Name = "buttonLogAdmin";
            this.buttonLogAdmin.Size = new System.Drawing.Size(87, 38);
            this.buttonLogAdmin.TabIndex = 0;
            this.buttonLogAdmin.Text = "Admin";
            this.buttonLogAdmin.UseVisualStyleBackColor = false;
            this.buttonLogAdmin.Click += new System.EventHandler(this.buttonLogAdmin_Click);
            // 
            // buttonLogUsers
            // 
            this.buttonLogUsers.AutoEllipsis = true;
            this.buttonLogUsers.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogUsers.ForeColor = System.Drawing.Color.DimGray;
            this.buttonLogUsers.Location = new System.Drawing.Point(1077, 13);
            this.buttonLogUsers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogUsers.Name = "buttonLogUsers";
            this.buttonLogUsers.Size = new System.Drawing.Size(77, 39);
            this.buttonLogUsers.TabIndex = 1;
            this.buttonLogUsers.Text = "Vote";
            this.buttonLogUsers.UseVisualStyleBackColor = false;
            this.buttonLogUsers.Click += new System.EventHandler(this.buttonVote_Click);
            // 
            // buttonPlayTime
            // 
            this.buttonPlayTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayTime.ForeColor = System.Drawing.Color.DimGray;
            this.buttonPlayTime.Location = new System.Drawing.Point(539, 238);
            this.buttonPlayTime.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlayTime.Name = "buttonPlayTime";
            this.buttonPlayTime.Size = new System.Drawing.Size(187, 43);
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
            this.BottomPage.Size = new System.Drawing.Size(1265, 68);
            this.BottomPage.TabIndex = 3;
            // 
            // title__2
            // 
            this.title__2.AutoSize = true;
            this.title__2.BackColor = System.Drawing.Color.Transparent;
            this.title__2.Font = new System.Drawing.Font("Microsoft YaHei Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title__2.ForeColor = System.Drawing.Color.Gainsboro;
            this.title__2.Location = new System.Drawing.Point(158, 4);
            this.title__2.Name = "title__2";
            this.title__2.Size = new System.Drawing.Size(116, 57);
            this.title__2.TabIndex = 5;
            this.title__2.Text = "Vote";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(471, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = " Votes Stats Now";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelHeures
            // 
            this.LabelHeures.AutoSize = true;
            this.LabelHeures.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeures.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelHeures.Location = new System.Drawing.Point(327, 131);
            this.LabelHeures.Name = "LabelHeures";
            this.LabelHeures.Size = new System.Drawing.Size(127, 91);
            this.LabelHeures.TabIndex = 9;
            this.LabelHeures.Text = "00";
            this.LabelHeures.Click += new System.EventHandler(this.LabelHeures_Click);
            // 
            // LabelMinutes
            // 
            this.LabelMinutes.AutoSize = true;
            this.LabelMinutes.BackColor = System.Drawing.Color.Transparent;
            this.LabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMinutes.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelMinutes.Location = new System.Drawing.Point(480, 131);
            this.LabelMinutes.Name = "LabelMinutes";
            this.LabelMinutes.Size = new System.Drawing.Size(127, 91);
            this.LabelMinutes.TabIndex = 10;
            this.LabelMinutes.Text = "00";
            // 
            // LabelSecondes
            // 
            this.LabelSecondes.AutoSize = true;
            this.LabelSecondes.BackColor = System.Drawing.Color.Transparent;
            this.LabelSecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSecondes.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelSecondes.Location = new System.Drawing.Point(649, 131);
            this.LabelSecondes.Name = "LabelSecondes";
            this.LabelSecondes.Size = new System.Drawing.Size(127, 91);
            this.LabelSecondes.TabIndex = 11;
            this.LabelSecondes.Text = "00";
            this.LabelSecondes.Click += new System.EventHandler(this.LabelSeconde_Click);
            // 
            // LabelMillisecondes
            // 
            this.LabelMillisecondes.AutoSize = true;
            this.LabelMillisecondes.BackColor = System.Drawing.Color.Transparent;
            this.LabelMillisecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMillisecondes.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelMillisecondes.Location = new System.Drawing.Point(822, 131);
            this.LabelMillisecondes.Name = "LabelMillisecondes";
            this.LabelMillisecondes.Size = new System.Drawing.Size(127, 91);
            this.LabelMillisecondes.TabIndex = 12;
            this.LabelMillisecondes.Text = "00";
            // 
            // labelSeparation1
            // 
            this.labelSeparation1.AutoSize = true;
            this.labelSeparation1.BackColor = System.Drawing.Color.Transparent;
            this.labelSeparation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeparation1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSeparation1.Location = new System.Drawing.Point(435, 131);
            this.labelSeparation1.Name = "labelSeparation1";
            this.labelSeparation1.Size = new System.Drawing.Size(61, 91);
            this.labelSeparation1.TabIndex = 13;
            this.labelSeparation1.Text = ":";
            // 
            // LabelSeparation2
            // 
            this.LabelSeparation2.AutoSize = true;
            this.LabelSeparation2.BackColor = System.Drawing.Color.Transparent;
            this.LabelSeparation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeparation2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelSeparation2.Location = new System.Drawing.Point(593, 131);
            this.LabelSeparation2.Name = "LabelSeparation2";
            this.LabelSeparation2.Size = new System.Drawing.Size(61, 91);
            this.LabelSeparation2.TabIndex = 14;
            this.LabelSeparation2.Text = ":";
            // 
            // LabelSeparation3
            // 
            this.LabelSeparation3.AutoSize = true;
            this.LabelSeparation3.BackColor = System.Drawing.Color.Transparent;
            this.LabelSeparation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeparation3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LabelSeparation3.Location = new System.Drawing.Point(771, 131);
            this.LabelSeparation3.Name = "LabelSeparation3";
            this.LabelSeparation3.Size = new System.Drawing.Size(61, 91);
            this.LabelSeparation3.TabIndex = 15;
            this.LabelSeparation3.Text = ":";
            this.LabelSeparation3.Click += new System.EventHandler(this.LabelSeparation3_Click);
            // 
            // roundCorneredProgressBar1
            // 
            this.roundCorneredProgressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundCorneredProgressBar1.Location = new System.Drawing.Point(121, 377);
            this.roundCorneredProgressBar1.Name = "roundCorneredProgressBar1";
            this.roundCorneredProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundCorneredProgressBar1.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundCorneredProgressBar1.ProgressFont = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.roundCorneredProgressBar1.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar1.Size = new System.Drawing.Size(186, 174);
            this.roundCorneredProgressBar1.TabIndex = 16;
            this.roundCorneredProgressBar1.TabStop = false;
            this.roundCorneredProgressBar1.Value = 0;
            // 
            // roundCorneredProgressBar2
            // 
            this.roundCorneredProgressBar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundCorneredProgressBar2.Location = new System.Drawing.Point(390, 377);
            this.roundCorneredProgressBar2.Name = "roundCorneredProgressBar2";
            this.roundCorneredProgressBar2.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundCorneredProgressBar2.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundCorneredProgressBar2.ProgressFont = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.roundCorneredProgressBar2.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar2.Size = new System.Drawing.Size(186, 174);
            this.roundCorneredProgressBar2.TabIndex = 17;
            this.roundCorneredProgressBar2.TabStop = false;
            this.roundCorneredProgressBar2.Value = 0;
            // 
            // roundCorneredProgressBar3
            // 
            this.roundCorneredProgressBar3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundCorneredProgressBar3.Location = new System.Drawing.Point(646, 377);
            this.roundCorneredProgressBar3.Name = "roundCorneredProgressBar3";
            this.roundCorneredProgressBar3.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundCorneredProgressBar3.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundCorneredProgressBar3.ProgressFont = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.roundCorneredProgressBar3.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar3.Size = new System.Drawing.Size(186, 174);
            this.roundCorneredProgressBar3.TabIndex = 18;
            this.roundCorneredProgressBar3.TabStop = false;
            this.roundCorneredProgressBar3.Value = 0;
            // 
            // roundCorneredProgressBar4
            // 
            this.roundCorneredProgressBar4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundCorneredProgressBar4.Location = new System.Drawing.Point(920, 377);
            this.roundCorneredProgressBar4.Name = "roundCorneredProgressBar4";
            this.roundCorneredProgressBar4.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundCorneredProgressBar4.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundCorneredProgressBar4.ProgressFont = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.roundCorneredProgressBar4.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar4.Size = new System.Drawing.Size(186, 174);
            this.roundCorneredProgressBar4.TabIndex = 19;
            this.roundCorneredProgressBar4.TabStop = false;
            this.roundCorneredProgressBar4.Value = 0;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.roundCorneredProgressBar4);
            this.Controls.Add(this.roundCorneredProgressBar3);
            this.Controls.Add(this.roundCorneredProgressBar2);
            this.Controls.Add(this.roundCorneredProgressBar1);
            this.Controls.Add(this.LabelSeparation3);
            this.Controls.Add(this.LabelSeparation2);
            this.Controls.Add(this.labelSeparation1);
            this.Controls.Add(this.LabelMillisecondes);
            this.Controls.Add(this.LabelSecondes);
            this.Controls.Add(this.LabelMinutes);
            this.Controls.Add(this.LabelHeures);
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
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar4)).EndInit();
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
        private System.Windows.Forms.Label LabelHeures;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label LabelSecondes;
        private System.Windows.Forms.Label LabelMillisecondes;
        private System.Windows.Forms.Label labelSeparation1;
        private System.Windows.Forms.Label LabelSeparation2;
        private System.Windows.Forms.Label LabelSeparation3;
        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar1;
        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar2;
        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar3;
        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar4;
    }
}

