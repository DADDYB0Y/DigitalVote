namespace test
{
    partial class LoginVote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVote));
            this.label2 = new System.Windows.Forms.Label();
            this.btn__ValidVote = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel__Photo = new System.Windows.Forms.Panel();
            this.btn__Capture = new System.Windows.Forms.Button();
            this.Label__ErrorMDP = new System.Windows.Forms.Label();
            this.Label__ErrorCapture = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox__cameraVote = new System.Windows.Forms.PictureBox();
            this.Panel__Photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__cameraVote)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            // 
            // btn__ValidVote
            // 
            this.btn__ValidVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn__ValidVote.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn__ValidVote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn__ValidVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__ValidVote.Location = new System.Drawing.Point(405, 352);
            this.btn__ValidVote.Name = "btn__ValidVote";
            this.btn__ValidVote.Size = new System.Drawing.Size(133, 46);
            this.btn__ValidVote.TabIndex = 12;
            this.btn__ValidVote.Text = "Valider";
            this.btn__ValidVote.UseVisualStyleBackColor = true;
            this.btn__ValidVote.Click += new System.EventHandler(this.btn__ValidVote_Click);
            this.btn__ValidVote.MouseEnter += new System.EventHandler(this.btn__ValidVote_MouseEnter);
            this.btn__ValidVote.MouseLeave += new System.EventHandler(this.btn__ValidVote_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 450);
            this.panel1.TabIndex = 15;
            // 
            // Panel__Photo
            // 
            this.Panel__Photo.AutoSize = true;
            this.Panel__Photo.BackColor = System.Drawing.Color.Transparent;
            this.Panel__Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel__Photo.Controls.Add(this.pictureBox__cameraVote);
            this.Panel__Photo.Controls.Add(this.btn__Capture);
            this.Panel__Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel__Photo.Location = new System.Drawing.Point(393, 61);
            this.Panel__Photo.Name = "Panel__Photo";
            this.Panel__Photo.Size = new System.Drawing.Size(145, 146);
            this.Panel__Photo.TabIndex = 18;
            // 
            // btn__Capture
            // 
            this.btn__Capture.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn__Capture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn__Capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__Capture.Location = new System.Drawing.Point(65, 112);
            this.btn__Capture.Name = "btn__Capture";
            this.btn__Capture.Size = new System.Drawing.Size(75, 29);
            this.btn__Capture.TabIndex = 0;
            this.btn__Capture.Text = "Capture";
            this.btn__Capture.UseVisualStyleBackColor = true;
            this.btn__Capture.MouseEnter += new System.EventHandler(this.btn__Capture_MouseEnter);
            this.btn__Capture.MouseLeave += new System.EventHandler(this.btn__Capture_MouseLeave);
            // 
            // Label__ErrorMDP
            // 
            this.Label__ErrorMDP.AutoSize = true;
            this.Label__ErrorMDP.ForeColor = System.Drawing.Color.LightCoral;
            this.Label__ErrorMDP.Location = new System.Drawing.Point(480, 322);
            this.Label__ErrorMDP.Name = "Label__ErrorMDP";
            this.Label__ErrorMDP.Size = new System.Drawing.Size(149, 16);
            this.Label__ErrorMDP.TabIndex = 21;
            this.Label__ErrorMDP.Text = "mot de passe incorrect!!";
            this.Label__ErrorMDP.Visible = false;
            // 
            // Label__ErrorCapture
            // 
            this.Label__ErrorCapture.AutoSize = true;
            this.Label__ErrorCapture.ForeColor = System.Drawing.Color.LightCoral;
            this.Label__ErrorCapture.Location = new System.Drawing.Point(397, 42);
            this.Label__ErrorCapture.Name = "Label__ErrorCapture";
            this.Label__ErrorCapture.Size = new System.Drawing.Size(137, 16);
            this.Label__ErrorCapture.TabIndex = 22;
            this.Label__ErrorCapture.Text = "Réesayer le Capture!!";
            this.Label__ErrorCapture.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(385, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Veuillez vous identifier svp!!!";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Vote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Digital";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox1.BorderRadius = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Enabled = false;
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(388, 242);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Nom";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(365, 25);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 31;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Silver;
            this.guna2TextBox2.BorderRadius = 3;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(388, 295);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.PlaceholderText = "Mot de Passe\r\n";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(365, 25);
            this.guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox2.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::test.Properties.Resources.vote__3_;
            this.pictureBox4.Location = new System.Drawing.Point(588, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::test.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(357, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::test.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(357, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox__cameraVote
            // 
            this.pictureBox__cameraVote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__cameraVote.Image")));
            this.pictureBox__cameraVote.Location = new System.Drawing.Point(48, 25);
            this.pictureBox__cameraVote.Name = "pictureBox__cameraVote";
            this.pictureBox__cameraVote.Size = new System.Drawing.Size(50, 49);
            this.pictureBox__cameraVote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__cameraVote.TabIndex = 23;
            this.pictureBox__cameraVote.TabStop = false;
            // 
            // LoginVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Label__ErrorCapture);
            this.Controls.Add(this.Label__ErrorMDP);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Panel__Photo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn__ValidVote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "LoginVote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voter";
            this.Panel__Photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__cameraVote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn__ValidVote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel__Photo;
        private System.Windows.Forms.Button btn__Capture;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label__ErrorMDP;
        private System.Windows.Forms.Label Label__ErrorCapture;
        private System.Windows.Forms.PictureBox pictureBox__cameraVote;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}