namespace test
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.Btn__Time = new System.Windows.Forms.Button();
            this.numericUpDownHeure = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconde = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMilliseconde = new System.Windows.Forms.NumericUpDown();
            this.Heure = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.Seconde = new System.Windows.Forms.Label();
            this.Milliseconde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMilliseconde)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn__Time
            // 
            this.Btn__Time.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Btn__Time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Btn__Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn__Time.ForeColor = System.Drawing.Color.DimGray;
            this.Btn__Time.Location = new System.Drawing.Point(235, 121);
            this.Btn__Time.Name = "Btn__Time";
            this.Btn__Time.Size = new System.Drawing.Size(114, 43);
            this.Btn__Time.TabIndex = 1;
            this.Btn__Time.Text = "Valider";
            this.Btn__Time.UseVisualStyleBackColor = true;
            this.Btn__Time.Click += new System.EventHandler(this.Btn__Time_Click);
            this.Btn__Time.MouseEnter += new System.EventHandler(this.Btn__Time_MouseEnter);
            this.Btn__Time.MouseLeave += new System.EventHandler(this.Btn__Time_MouseLeave);
            // 
            // numericUpDownHeure
            // 
            this.numericUpDownHeure.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDownHeure.Location = new System.Drawing.Point(43, 64);
            this.numericUpDownHeure.Name = "numericUpDownHeure";
            this.numericUpDownHeure.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHeure.TabIndex = 2;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDownMinute.Location = new System.Drawing.Point(169, 63);
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMinute.TabIndex = 3;
            // 
            // numericUpDownSeconde
            // 
            this.numericUpDownSeconde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDownSeconde.Location = new System.Drawing.Point(295, 64);
            this.numericUpDownSeconde.Name = "numericUpDownSeconde";
            this.numericUpDownSeconde.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSeconde.TabIndex = 4;
            // 
            // numericUpDownMilliseconde
            // 
            this.numericUpDownMilliseconde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numericUpDownMilliseconde.Location = new System.Drawing.Point(421, 64);
            this.numericUpDownMilliseconde.Name = "numericUpDownMilliseconde";
            this.numericUpDownMilliseconde.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMilliseconde.TabIndex = 5;
            // 
            // Heure
            // 
            this.Heure.AutoSize = true;
            this.Heure.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Heure.Location = new System.Drawing.Point(40, 38);
            this.Heure.Name = "Heure";
            this.Heure.Size = new System.Drawing.Size(44, 16);
            this.Heure.TabIndex = 6;
            this.Heure.Text = "Heure";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Minute.Location = new System.Drawing.Point(166, 38);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(53, 16);
            this.Minute.TabIndex = 7;
            this.Minute.Text = "Minutes";
            // 
            // Seconde
            // 
            this.Seconde.AutoSize = true;
            this.Seconde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Seconde.Location = new System.Drawing.Point(292, 38);
            this.Seconde.Name = "Seconde";
            this.Seconde.Size = new System.Drawing.Size(69, 16);
            this.Seconde.TabIndex = 8;
            this.Seconde.Text = "Secondes";
            // 
            // Milliseconde
            // 
            this.Milliseconde.AutoSize = true;
            this.Milliseconde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Milliseconde.Location = new System.Drawing.Point(418, 38);
            this.Milliseconde.Name = "Milliseconde";
            this.Milliseconde.Size = new System.Drawing.Size(90, 16);
            this.Milliseconde.TabIndex = 9;
            this.Milliseconde.Text = "Millisecondes";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 195);
            this.Controls.Add(this.Milliseconde);
            this.Controls.Add(this.Seconde);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Heure);
            this.Controls.Add(this.numericUpDownMilliseconde);
            this.Controls.Add(this.numericUpDownSeconde);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.numericUpDownHeure);
            this.Controls.Add(this.Btn__Time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(591, 242);
            this.Name = "Timer";
            this.Text = "Durée de Vote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMilliseconde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn__Time;
        private System.Windows.Forms.NumericUpDown numericUpDownHeure;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconde;
        private System.Windows.Forms.NumericUpDown numericUpDownMilliseconde;
        private System.Windows.Forms.Label Heure;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Seconde;
        private System.Windows.Forms.Label Milliseconde;
    }
}