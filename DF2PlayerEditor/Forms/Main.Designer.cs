namespace DF2PlayerEditor.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbPlayerList = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFindGame = new System.Windows.Forms.Button();
            this.lblNovaHQ = new System.Windows.Forms.Label();
            this.btnRes640 = new System.Windows.Forms.Button();
            this.lblSetResolution = new System.Windows.Forms.Label();
            this.btnRes800 = new System.Windows.Forms.Button();
            this.btnRes1024 = new System.Windows.Forms.Button();
            this.lblPlayerList = new System.Windows.Forms.Label();
            this.lblSetGamma = new System.Windows.Forms.Label();
            this.trackBarGama = new System.Windows.Forms.TrackBar();
            this.lblGammaText = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.lblSetResolutionText = new System.Windows.Forms.Label();
            this.btnRes1280 = new System.Windows.Forms.Button();
            this.lblFacebook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGama)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayerList
            // 
            this.lbPlayerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.lbPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlayerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lbPlayerList.FormattingEnabled = true;
            this.lbPlayerList.Location = new System.Drawing.Point(12, 28);
            this.lbPlayerList.Name = "lbPlayerList";
            this.lbPlayerList.Size = new System.Drawing.Size(252, 65);
            this.lbPlayerList.TabIndex = 0;
            this.lbPlayerList.SelectedIndexChanged += new System.EventHandler(this.lbPlayerList_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnClose.Location = new System.Drawing.Point(206, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFindGame
            // 
            this.btnFindGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindGame.BackgroundImage")));
            this.btnFindGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnFindGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnFindGame.Location = new System.Drawing.Point(109, 226);
            this.btnFindGame.Name = "btnFindGame";
            this.btnFindGame.Size = new System.Drawing.Size(76, 23);
            this.btnFindGame.TabIndex = 4;
            this.btnFindGame.Text = "Find Game Path";
            this.btnFindGame.UseVisualStyleBackColor = true;
            this.btnFindGame.Click += new System.EventHandler(this.btnFindGame_Click);
            // 
            // lblNovaHQ
            // 
            this.lblNovaHQ.AutoSize = true;
            this.lblNovaHQ.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovaHQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaHQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblNovaHQ.Location = new System.Drawing.Point(72, 261);
            this.lblNovaHQ.Name = "lblNovaHQ";
            this.lblNovaHQ.Size = new System.Drawing.Size(124, 13);
            this.lblNovaHQ.TabIndex = 5;
            this.lblNovaHQ.Text = "(c) 2018 Novahq.net";
            this.lblNovaHQ.Click += new System.EventHandler(this.lblNovaHQ_Click);
            // 
            // btnRes640
            // 
            this.btnRes640.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes640.BackgroundImage")));
            this.btnRes640.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes640.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes640.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes640.Location = new System.Drawing.Point(14, 122);
            this.btnRes640.Name = "btnRes640";
            this.btnRes640.Size = new System.Drawing.Size(59, 23);
            this.btnRes640.TabIndex = 6;
            this.btnRes640.Text = "640x480";
            this.btnRes640.UseVisualStyleBackColor = true;
            this.btnRes640.Click += new System.EventHandler(this.btnSetRes640_Click);
            // 
            // lblSetResolution
            // 
            this.lblSetResolution.AutoSize = true;
            this.lblSetResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblSetResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblSetResolution.Location = new System.Drawing.Point(11, 101);
            this.lblSetResolution.Name = "lblSetResolution";
            this.lblSetResolution.Size = new System.Drawing.Size(94, 13);
            this.lblSetResolution.TabIndex = 7;
            this.lblSetResolution.Text = "Set Resolution:";
            // 
            // btnRes800
            // 
            this.btnRes800.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes800.BackgroundImage")));
            this.btnRes800.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes800.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes800.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes800.Location = new System.Drawing.Point(71, 122);
            this.btnRes800.Name = "btnRes800";
            this.btnRes800.Size = new System.Drawing.Size(60, 23);
            this.btnRes800.TabIndex = 8;
            this.btnRes800.Text = "800x600";
            this.btnRes800.UseVisualStyleBackColor = true;
            this.btnRes800.Click += new System.EventHandler(this.btnSetRes800_Click);
            // 
            // btnRes1024
            // 
            this.btnRes1024.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes1024.BackgroundImage")));
            this.btnRes1024.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes1024.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes1024.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes1024.Location = new System.Drawing.Point(128, 122);
            this.btnRes1024.Name = "btnRes1024";
            this.btnRes1024.Size = new System.Drawing.Size(70, 23);
            this.btnRes1024.TabIndex = 9;
            this.btnRes1024.Text = "1024x768";
            this.btnRes1024.UseVisualStyleBackColor = true;
            this.btnRes1024.Click += new System.EventHandler(this.btnSetRes1024_Click);
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblPlayerList.Location = new System.Drawing.Point(9, 7);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(97, 13);
            this.lblPlayerList.TabIndex = 10;
            this.lblPlayerList.Text = "Current Players:";
            // 
            // lblSetGamma
            // 
            this.lblSetGamma.AutoSize = true;
            this.lblSetGamma.BackColor = System.Drawing.Color.Transparent;
            this.lblSetGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetGamma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblSetGamma.Location = new System.Drawing.Point(11, 151);
            this.lblSetGamma.Name = "lblSetGamma";
            this.lblSetGamma.Size = new System.Drawing.Size(126, 13);
            this.lblSetGamma.TabIndex = 11;
            this.lblSetGamma.Text = "Set Gamma (50-450):";
            // 
            // trackBarGama
            // 
            this.trackBarGama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.trackBarGama.LargeChange = 1;
            this.trackBarGama.Location = new System.Drawing.Point(14, 172);
            this.trackBarGama.Maximum = 450;
            this.trackBarGama.Minimum = 50;
            this.trackBarGama.Name = "trackBarGama";
            this.trackBarGama.Size = new System.Drawing.Size(250, 45);
            this.trackBarGama.TabIndex = 13;
            this.trackBarGama.Value = 150;
            this.trackBarGama.Scroll += new System.EventHandler(this.trackBarGama_Scroll);
            // 
            // lblGammaText
            // 
            this.lblGammaText.AutoSize = true;
            this.lblGammaText.BackColor = System.Drawing.Color.Transparent;
            this.lblGammaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblGammaText.Location = new System.Drawing.Point(134, 151);
            this.lblGammaText.Name = "lblGammaText";
            this.lblGammaText.Size = new System.Drawing.Size(55, 13);
            this.lblGammaText.TabIndex = 14;
            this.lblGammaText.Text = "#gamma#";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.BackgroundImage")));
            this.btnSaveConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnSaveConfig.Location = new System.Drawing.Point(14, 226);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(78, 23);
            this.btnSaveConfig.TabIndex = 15;
            this.btnSaveConfig.Text = "Save df2.cfg";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // lblSetResolutionText
            // 
            this.lblSetResolutionText.AutoSize = true;
            this.lblSetResolutionText.BackColor = System.Drawing.Color.Transparent;
            this.lblSetResolutionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetResolutionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblSetResolutionText.Location = new System.Drawing.Point(99, 101);
            this.lblSetResolutionText.Name = "lblSetResolutionText";
            this.lblSetResolutionText.Size = new System.Drawing.Size(54, 13);
            this.lblSetResolutionText.TabIndex = 16;
            this.lblSetResolutionText.Text = "#current#";
            // 
            // btnRes1280
            // 
            this.btnRes1280.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes1280.BackgroundImage")));
            this.btnRes1280.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes1280.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes1280.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.btnRes1280.Location = new System.Drawing.Point(197, 122);
            this.btnRes1280.Name = "btnRes1280";
            this.btnRes1280.Size = new System.Drawing.Size(67, 23);
            this.btnRes1280.TabIndex = 18;
            this.btnRes1280.Text = "1280x960";
            this.btnRes1280.UseVisualStyleBackColor = true;
            this.btnRes1280.Click += new System.EventHandler(this.btnSetRes1280_Click);
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.BackColor = System.Drawing.Color.Transparent;
            this.lblFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(68)))), ((int)(((byte)(9)))));
            this.lblFacebook.Location = new System.Drawing.Point(70, 279);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(128, 13);
            this.lblFacebook.TabIndex = 19;
            this.lblFacebook.Text = "DF2 Facebook Group";
            this.lblFacebook.Click += new System.EventHandler(this.lblFacebook_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DF2PlayerEditor.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(277, 300);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.btnRes1280);
            this.Controls.Add(this.lblSetResolutionText);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.lblGammaText);
            this.Controls.Add(this.trackBarGama);
            this.Controls.Add(this.lblSetGamma);
            this.Controls.Add(this.lblPlayerList);
            this.Controls.Add(this.btnRes1024);
            this.Controls.Add(this.btnRes800);
            this.Controls.Add(this.lblSetResolution);
            this.Controls.Add(this.btnRes640);
            this.Controls.Add(this.lblNovaHQ);
            this.Controls.Add(this.btnFindGame);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbPlayerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DF2 Player Editor v1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawListBoxBorder);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindGame;
        private System.Windows.Forms.Label lblNovaHQ;
        public System.Windows.Forms.ListBox lbPlayerList;
        private System.Windows.Forms.Button btnRes640;
        private System.Windows.Forms.Label lblSetResolution;
        private System.Windows.Forms.Button btnRes800;
        private System.Windows.Forms.Button btnRes1024;
        private System.Windows.Forms.Label lblPlayerList;
        private System.Windows.Forms.Label lblSetGamma;
        private System.Windows.Forms.TrackBar trackBarGama;
        private System.Windows.Forms.Label lblGammaText;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label lblSetResolutionText;
        private System.Windows.Forms.Button btnRes1280;
        private System.Windows.Forms.Label lblFacebook;
    }
}

