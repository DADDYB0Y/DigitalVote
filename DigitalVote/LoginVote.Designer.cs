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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn__ValidVote = new System.Windows.Forms.Button();
            this.textBox__ = new System.Windows.Forms.TextBox();
            this.textBox__NomComplet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel__Photo = new System.Windows.Forms.Panel();
            this.btn__Capture = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label__ErrorMDP = new System.Windows.Forms.Label();
            this.Label__ErrorCapture = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel__Photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(557, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "VOTER";
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
            this.btn__ValidVote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn__ValidVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__ValidVote.Location = new System.Drawing.Point(405, 352);
            this.btn__ValidVote.Name = "btn__ValidVote";
            this.btn__ValidVote.Size = new System.Drawing.Size(133, 46);
            this.btn__ValidVote.TabIndex = 12;
            this.btn__ValidVote.Text = "Valider";
            this.btn__ValidVote.UseVisualStyleBackColor = true;
            this.btn__ValidVote.MouseEnter += new System.EventHandler(this.btn__ValidVote_MouseEnter);
            this.btn__ValidVote.MouseLeave += new System.EventHandler(this.btn__ValidVote_MouseLeave);
            // 
            // textBox__
            // 
            this.textBox__.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.textBox__.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox__.Location = new System.Drawing.Point(388, 293);
            this.textBox__.Name = "textBox__";
            this.textBox__.Size = new System.Drawing.Size(337, 27);
            this.textBox__.TabIndex = 11;
            this.textBox__.Text = "  Mot de Passe";
            // 
            // textBox__NomComplet
            // 
            this.textBox__NomComplet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox__NomComplet.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.textBox__NomComplet.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox__NomComplet.Location = new System.Drawing.Point(388, 239);
            this.textBox__NomComplet.Name = "textBox__NomComplet";
            this.textBox__NomComplet.Size = new System.Drawing.Size(337, 27);
            this.textBox__NomComplet.TabIndex = 10;
            this.textBox__NomComplet.Text = "  Nom";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 455);
            this.panel1.TabIndex = 15;
            // 
            // Panel__Photo
            // 
            this.Panel__Photo.AutoSize = true;
            this.Panel__Photo.BackColor = System.Drawing.Color.Transparent;
            this.Panel__Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel__Photo.Controls.Add(this.pictureBox1);
            this.Panel__Photo.Controls.Add(this.btn__Capture);
            this.Panel__Photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel__Photo.Location = new System.Drawing.Point(393, 61);
            this.Panel__Photo.Name = "Panel__Photo";
            this.Panel__Photo.Size = new System.Drawing.Size(145, 146);
            this.Panel__Photo.TabIndex = 18;
            // 
            // btn__Capture
            // 
            this.btn__Capture.Location = new System.Drawing.Point(65, 112);
            this.btn__Capture.Name = "btn__Capture";
            this.btn__Capture.Size = new System.Drawing.Size(75, 29);
            this.btn__Capture.TabIndex = 0;
            this.btn__Capture.Text = "Capture";
            this.btn__Capture.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(357, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(357, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Label__ErrorMDP
            // 
            this.Label__ErrorMDP.AutoSize = true;
            this.Label__ErrorMDP.ForeColor = System.Drawing.Color.LightCoral;
            this.Label__ErrorMDP.Location = new System.Drawing.Point(481, 318);
            this.Label__ErrorMDP.Name = "Label__ErrorMDP";
            this.Label__ErrorMDP.Size = new System.Drawing.Size(149, 16);
            this.Label__ErrorMDP.TabIndex = 21;
            this.Label__ErrorMDP.Text = "mot de passe incorrect!!";
            // 
            // Label__ErrorCapture
            // 
            this.Label__ErrorCapture.AutoSize = true;
            this.Label__ErrorCapture.ForeColor = System.Drawing.Color.LightCoral;
            this.Label__ErrorCapture.Location = new System.Drawing.Point(559, 191);
            this.Label__ErrorCapture.Name = "Label__ErrorCapture";
            this.Label__ErrorCapture.Size = new System.Drawing.Size(137, 16);
            this.Label__ErrorCapture.TabIndex = 22;
            this.Label__ErrorCapture.Text = "Réesayer le Capture!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LoginVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label__ErrorCapture);
            this.Controls.Add(this.Label__ErrorMDP);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Panel__Photo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn__ValidVote);
            this.Controls.Add(this.textBox__);
            this.Controls.Add(this.textBox__NomComplet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginVote";
            this.Text = "Voter";
            this.Panel__Photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn__ValidVote;
        private System.Windows.Forms.TextBox textBox__;
        private System.Windows.Forms.TextBox textBox__NomComplet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel__Photo;
        private System.Windows.Forms.Button btn__Capture;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Label__ErrorMDP;
        private System.Windows.Forms.Label Label__ErrorCapture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}