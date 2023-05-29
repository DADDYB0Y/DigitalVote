namespace test
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.btn__ValidAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Label__ErrorMDP = new System.Windows.Forms.Label();
            this.Label__ErrorCapture = new System.Windows.Forms.Label();
            this.Panel__Photo = new System.Windows.Forms.Panel();
            this.pictureBox__cameraAdmin = new System.Windows.Forms.PictureBox();
            this.btn__Capture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel__Photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__cameraAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn__ValidAdmin
            // 
            this.btn__ValidAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn__ValidAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn__ValidAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn__ValidAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__ValidAdmin.Location = new System.Drawing.Point(415, 361);
            this.btn__ValidAdmin.Name = "btn__ValidAdmin";
            this.btn__ValidAdmin.Size = new System.Drawing.Size(133, 46);
            this.btn__ValidAdmin.TabIndex = 2;
            this.btn__ValidAdmin.Text = "Valider";
            this.btn__ValidAdmin.UseVisualStyleBackColor = true;
            this.btn__ValidAdmin.Click += new System.EventHandler(this.btn__ValidAdmin_Click);
            this.btn__ValidAdmin.MouseEnter += new System.EventHandler(this.btn__ValidAdmin_MouseEnter);
            this.btn__ValidAdmin.MouseLeave += new System.EventHandler(this.btn__ValidAdmin_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 450);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digital";
            // 
            // Label__ErrorMDP
            // 
            this.Label__ErrorMDP.AutoSize = true;
            this.Label__ErrorMDP.ForeColor = System.Drawing.Color.LightCoral;
            this.Label__ErrorMDP.Location = new System.Drawing.Point(499, 319);
            this.Label__ErrorMDP.Name = "Label__ErrorMDP";
            this.Label__ErrorMDP.Size = new System.Drawing.Size(149, 16);
            this.Label__ErrorMDP.TabIndex = 11;
            this.Label__ErrorMDP.Text = "mot de passe incorrect!!";
            this.Label__ErrorMDP.Visible = false;
            // 
            // Label__ErrorCapture
            // 
            this.Label__ErrorCapture.AutoSize = true;
            this.Label__ErrorCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label__ErrorCapture.ForeColor = System.Drawing.Color.LightCoral;
            this.Label__ErrorCapture.Location = new System.Drawing.Point(407, 41);
            this.Label__ErrorCapture.Name = "Label__ErrorCapture";
            this.Label__ErrorCapture.Size = new System.Drawing.Size(137, 16);
            this.Label__ErrorCapture.TabIndex = 10;
            this.Label__ErrorCapture.Text = "Réesayer le Capture!!";
            this.Label__ErrorCapture.Visible = false;
            // 
            // Panel__Photo
            // 
            this.Panel__Photo.AutoSize = true;
            this.Panel__Photo.BackColor = System.Drawing.Color.Transparent;
            this.Panel__Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel__Photo.Controls.Add(this.pictureBox__cameraAdmin);
            this.Panel__Photo.Controls.Add(this.btn__Capture);
            this.Panel__Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel__Photo.Location = new System.Drawing.Point(403, 60);
            this.Panel__Photo.Name = "Panel__Photo";
            this.Panel__Photo.Size = new System.Drawing.Size(145, 146);
            this.Panel__Photo.TabIndex = 12;
            // 
            // pictureBox__cameraAdmin
            // 
            this.pictureBox__cameraAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox__cameraAdmin.Image")));
            this.pictureBox__cameraAdmin.Location = new System.Drawing.Point(48, 27);
            this.pictureBox__cameraAdmin.Name = "pictureBox__cameraAdmin";
            this.pictureBox__cameraAdmin.Size = new System.Drawing.Size(50, 49);
            this.pictureBox__cameraAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox__cameraAdmin.TabIndex = 1;
            this.pictureBox__cameraAdmin.TabStop = false;
            this.pictureBox__cameraAdmin.Click += new System.EventHandler(this.pictureBox__cameraAdmin_Click);
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
            this.btn__Capture.Click += new System.EventHandler(this.btn__Capture_Click);
            this.btn__Capture.MouseEnter += new System.EventHandler(this.btn__Capture_MouseEnter);
            this.btn__Capture.MouseLeave += new System.EventHandler(this.btn__Capture_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(614, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(392, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Veuillez vous identifier svp!!!";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(655, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vote";
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
            this.guna2TextBox2.Location = new System.Drawing.Point(403, 292);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.PlaceholderText = "Mot de Passe\r\n";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(365, 25);
            this.guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox2.TabIndex = 34;
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
            this.guna2TextBox1.Location = new System.Drawing.Point(403, 239);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "Nom";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(365, 25);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DigitalVote.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(374, 292);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DigitalVote.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(372, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Panel__Photo);
            this.Controls.Add(this.Label__ErrorMDP);
            this.Controls.Add(this.Label__ErrorCapture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn__ValidAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminConnect";
            this.Panel__Photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__cameraAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn__ValidAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label__ErrorMDP;
        private System.Windows.Forms.Label Label__ErrorCapture;
        private System.Windows.Forms.Panel Panel__Photo;
        private System.Windows.Forms.Button btn__Capture;
        private System.Windows.Forms.PictureBox pictureBox__cameraAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}