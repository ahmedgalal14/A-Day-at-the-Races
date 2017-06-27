namespace RaceTrack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.BGImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AlLabel = new System.Windows.Forms.TextBox();
            this.BobLabel = new System.Windows.Forms.TextBox();
            this.JoeLabel = new System.Windows.Forms.TextBox();
            this.upDown_dog = new System.Windows.Forms.NumericUpDown();
            this.upDown_amount = new System.Windows.Forms.NumericUpDown();
            this.BetsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.guyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlRadio = new System.Windows.Forms.RadioButton();
            this.BobRadio = new System.Windows.Forms.RadioButton();
            this.JoeRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(2, 168);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(77, 18);
            this.dog4.TabIndex = 8;
            this.dog4.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(2, 114);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(77, 18);
            this.dog3.TabIndex = 7;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(2, 61);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(77, 18);
            this.dog2.TabIndex = 6;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(2, 12);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(77, 18);
            this.dog1.TabIndex = 5;
            this.dog1.TabStop = false;
            // 
            // BGImage
            // 
            this.BGImage.Image = ((System.Drawing.Image)(resources.GetObject("BGImage.Image")));
            this.BGImage.Location = new System.Drawing.Point(-1, -2);
            this.BGImage.Name = "BGImage";
            this.BGImage.Size = new System.Drawing.Size(603, 203);
            this.BGImage.TabIndex = 4;
            this.BGImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.AboutButton);
            this.groupBox1.Controls.Add(this.AlLabel);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.upDown_dog);
            this.groupBox1.Controls.Add(this.upDown_amount);
            this.groupBox1.Controls.Add(this.BetsButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.guyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AlRadio);
            this.groupBox1.Controls.Add(this.BobRadio);
            this.groupBox1.Controls.Add(this.JoeRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Petting Parlor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Gray;
            this.AboutButton.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.Location = new System.Drawing.Point(452, 132);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(101, 58);
            this.AboutButton.TabIndex = 71;
            this.AboutButton.Text = "About Us";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // AlLabel
            // 
            this.AlLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AlLabel.Enabled = false;
            this.AlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlLabel.Location = new System.Drawing.Point(265, 120);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(169, 21);
            this.AlLabel.TabIndex = 70;
            this.AlLabel.Text = "Al\'s Bet";
            // 
            // BobLabel
            // 
            this.BobLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BobLabel.Enabled = false;
            this.BobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BobLabel.Location = new System.Drawing.Point(265, 81);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(169, 21);
            this.BobLabel.TabIndex = 69;
            this.BobLabel.Text = "Bob\'s Bet";
            // 
            // JoeLabel
            // 
            this.JoeLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.JoeLabel.Enabled = false;
            this.JoeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoeLabel.Location = new System.Drawing.Point(265, 46);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(169, 21);
            this.JoeLabel.TabIndex = 68;
            this.JoeLabel.Text = "Joe\'t Bet";
            // 
            // upDown_dog
            // 
            this.upDown_dog.Location = new System.Drawing.Point(358, 170);
            this.upDown_dog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.upDown_dog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDown_dog.Name = "upDown_dog";
            this.upDown_dog.Size = new System.Drawing.Size(63, 20);
            this.upDown_dog.TabIndex = 67;
            this.upDown_dog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upDown_amount
            // 
            this.upDown_amount.Location = new System.Drawing.Point(150, 169);
            this.upDown_amount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDown_amount.Name = "upDown_amount";
            this.upDown_amount.Size = new System.Drawing.Size(63, 20);
            this.upDown_amount.TabIndex = 66;
            this.upDown_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDown_amount.ValueChanged += new System.EventHandler(this.upDown_amount_ValueChanged);
            // 
            // BetsButton
            // 
            this.BetsButton.BackColor = System.Drawing.Color.Gray;
            this.BetsButton.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsButton.Location = new System.Drawing.Point(69, 167);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(75, 23);
            this.BetsButton.TabIndex = 65;
            this.BetsButton.Text = "Bet";
            this.BetsButton.UseVisualStyleBackColor = false;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Bucks On Dog Number";
            // 
            // guyName
            // 
            this.guyName.AutoSize = true;
            this.guyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guyName.Location = new System.Drawing.Point(17, 170);
            this.guyName.Name = "guyName";
            this.guyName.Size = new System.Drawing.Size(0, 15);
            this.guyName.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Bets";
            // 
            // AlRadio
            // 
            this.AlRadio.AutoSize = true;
            this.AlRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlRadio.Location = new System.Drawing.Point(20, 120);
            this.AlRadio.Name = "AlRadio";
            this.AlRadio.Size = new System.Drawing.Size(35, 19);
            this.AlRadio.TabIndex = 58;
            this.AlRadio.TabStop = true;
            this.AlRadio.Text = "Al";
            this.AlRadio.UseVisualStyleBackColor = true;
            this.AlRadio.CheckedChanged += new System.EventHandler(this.AlRadio_CheckedChanged);
            // 
            // BobRadio
            // 
            this.BobRadio.AutoSize = true;
            this.BobRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BobRadio.Location = new System.Drawing.Point(20, 82);
            this.BobRadio.Name = "BobRadio";
            this.BobRadio.Size = new System.Drawing.Size(47, 19);
            this.BobRadio.TabIndex = 57;
            this.BobRadio.TabStop = true;
            this.BobRadio.Text = "Bob";
            this.BobRadio.UseVisualStyleBackColor = true;
            this.BobRadio.CheckedChanged += new System.EventHandler(this.BobRadio_CheckedChanged);
            // 
            // JoeRadio
            // 
            this.JoeRadio.AutoSize = true;
            this.JoeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoeRadio.Location = new System.Drawing.Point(20, 45);
            this.JoeRadio.Name = "JoeRadio";
            this.JoeRadio.Size = new System.Drawing.Size(45, 19);
            this.JoeRadio.TabIndex = 56;
            this.JoeRadio.TabStop = true;
            this.JoeRadio.Text = "Joe";
            this.JoeRadio.UseVisualStyleBackColor = true;
            this.JoeRadio.CheckedChanged += new System.EventHandler(this.JoeRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Minimum Bet: 5 Bucks";
            // 
            // RaceButton
            // 
            this.RaceButton.BackColor = System.Drawing.Color.Gray;
            this.RaceButton.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceButton.Location = new System.Drawing.Point(452, 59);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(101, 55);
            this.RaceButton.TabIndex = 54;
            this.RaceButton.Text = "Race";
            this.RaceButton.UseVisualStyleBackColor = false;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaceTrack.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(601, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.BGImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGImage;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown upDown_dog;
        private System.Windows.Forms.NumericUpDown upDown_amount;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label guyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AlRadio;
        private System.Windows.Forms.RadioButton BobRadio;
        private System.Windows.Forms.RadioButton JoeRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.TextBox AlLabel;
        private System.Windows.Forms.TextBox BobLabel;
        private System.Windows.Forms.TextBox JoeLabel;
        private System.Windows.Forms.Button AboutButton;
    }
}

