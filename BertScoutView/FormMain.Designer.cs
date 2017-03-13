namespace BertScoutView
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelKindleFilePath = new System.Windows.Forms.Label();
            this.textBoxKindleFilePath = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.dataGridViewStand = new System.Windows.Forms.DataGridView();
            this.Match = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alliance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoScoreHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoScoreLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoBaseline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoPlaceGear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoOpenHopper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeleScoreHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeleScoreLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeleGearsPlaced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeleClimbed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeleTouchpad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShowPitInfo = new System.Windows.Forms.Button();
            this.buttonShowPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStand)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKindleFilePath
            // 
            this.labelKindleFilePath.AutoSize = true;
            this.labelKindleFilePath.Location = new System.Drawing.Point(12, 15);
            this.labelKindleFilePath.Name = "labelKindleFilePath";
            this.labelKindleFilePath.Size = new System.Drawing.Size(83, 13);
            this.labelKindleFilePath.TabIndex = 0;
            this.labelKindleFilePath.Text = "Kindle File Path:";
            // 
            // textBoxKindleFilePath
            // 
            this.textBoxKindleFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKindleFilePath.Location = new System.Drawing.Point(101, 12);
            this.textBoxKindleFilePath.Name = "textBoxKindleFilePath";
            this.textBoxKindleFilePath.Size = new System.Drawing.Size(620, 20);
            this.textBoxKindleFilePath.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(727, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team:";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.Enabled = false;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(101, 40);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam.Sorted = true;
            this.comboBoxTeam.TabIndex = 4;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // dataGridViewStand
            // 
            this.dataGridViewStand.AllowUserToAddRows = false;
            this.dataGridViewStand.AllowUserToDeleteRows = false;
            this.dataGridViewStand.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridViewStand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Match,
            this.Alliance,
            this.AutoScoreHigh,
            this.AutoScoreLow,
            this.AutoBaseline,
            this.AutoPlaceGear,
            this.AutoOpenHopper,
            this.TeleScoreHigh,
            this.TeleScoreLow,
            this.TeleGearsPlaced,
            this.TeleClimbed,
            this.TeleTouchpad,
            this.Comment,
            this.ScoutName});
            this.dataGridViewStand.Enabled = false;
            this.dataGridViewStand.Location = new System.Drawing.Point(15, 67);
            this.dataGridViewStand.MultiSelect = false;
            this.dataGridViewStand.Name = "dataGridViewStand";
            this.dataGridViewStand.ReadOnly = true;
            this.dataGridViewStand.RowHeadersVisible = false;
            this.dataGridViewStand.Size = new System.Drawing.Size(787, 486);
            this.dataGridViewStand.TabIndex = 5;
            // 
            // Match
            // 
            this.Match.HeaderText = "Match";
            this.Match.Name = "Match";
            this.Match.ReadOnly = true;
            this.Match.Width = 62;
            // 
            // Alliance
            // 
            this.Alliance.HeaderText = "Alliance";
            this.Alliance.Name = "Alliance";
            this.Alliance.ReadOnly = true;
            this.Alliance.Width = 69;
            // 
            // AutoScoreHigh
            // 
            this.AutoScoreHigh.HeaderText = "AutoScoreHigh";
            this.AutoScoreHigh.Name = "AutoScoreHigh";
            this.AutoScoreHigh.ReadOnly = true;
            this.AutoScoreHigh.Width = 104;
            // 
            // AutoScoreLow
            // 
            this.AutoScoreLow.HeaderText = "AutoScoreLow";
            this.AutoScoreLow.Name = "AutoScoreLow";
            this.AutoScoreLow.ReadOnly = true;
            this.AutoScoreLow.Width = 102;
            // 
            // AutoBaseline
            // 
            this.AutoBaseline.HeaderText = "AutoBaseline";
            this.AutoBaseline.Name = "AutoBaseline";
            this.AutoBaseline.ReadOnly = true;
            this.AutoBaseline.Width = 94;
            // 
            // AutoPlaceGear
            // 
            this.AutoPlaceGear.HeaderText = "AutoPlaceGear";
            this.AutoPlaceGear.Name = "AutoPlaceGear";
            this.AutoPlaceGear.ReadOnly = true;
            this.AutoPlaceGear.Width = 104;
            // 
            // AutoOpenHopper
            // 
            this.AutoOpenHopper.HeaderText = "AutoOpenHopper";
            this.AutoOpenHopper.Name = "AutoOpenHopper";
            this.AutoOpenHopper.ReadOnly = true;
            this.AutoOpenHopper.Width = 115;
            // 
            // TeleScoreHigh
            // 
            this.TeleScoreHigh.HeaderText = "TeleScoreHigh";
            this.TeleScoreHigh.Name = "TeleScoreHigh";
            this.TeleScoreHigh.ReadOnly = true;
            this.TeleScoreHigh.Width = 103;
            // 
            // TeleScoreLow
            // 
            this.TeleScoreLow.HeaderText = "TeleScoreLow";
            this.TeleScoreLow.Name = "TeleScoreLow";
            this.TeleScoreLow.ReadOnly = true;
            this.TeleScoreLow.Width = 101;
            // 
            // TeleGearsPlaced
            // 
            this.TeleGearsPlaced.HeaderText = "TeleGearsPlaced";
            this.TeleGearsPlaced.Name = "TeleGearsPlaced";
            this.TeleGearsPlaced.ReadOnly = true;
            this.TeleGearsPlaced.Width = 114;
            // 
            // TeleClimbed
            // 
            this.TeleClimbed.HeaderText = "TeleClimbed";
            this.TeleClimbed.Name = "TeleClimbed";
            this.TeleClimbed.ReadOnly = true;
            this.TeleClimbed.Width = 90;
            // 
            // TeleTouchpad
            // 
            this.TeleTouchpad.HeaderText = "TeleTouchpad";
            this.TeleTouchpad.Name = "TeleTouchpad";
            this.TeleTouchpad.ReadOnly = true;
            this.TeleTouchpad.Width = 102;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 76;
            // 
            // ScoutName
            // 
            this.ScoutName.HeaderText = "ScoutName";
            this.ScoutName.Name = "ScoutName";
            this.ScoutName.ReadOnly = true;
            this.ScoutName.Width = 88;
            // 
            // buttonShowPitInfo
            // 
            this.buttonShowPitInfo.Enabled = false;
            this.buttonShowPitInfo.Location = new System.Drawing.Point(249, 38);
            this.buttonShowPitInfo.Name = "buttonShowPitInfo";
            this.buttonShowPitInfo.Size = new System.Drawing.Size(111, 23);
            this.buttonShowPitInfo.TabIndex = 6;
            this.buttonShowPitInfo.Text = "Show Pit Info";
            this.buttonShowPitInfo.UseVisualStyleBackColor = true;
            this.buttonShowPitInfo.Click += new System.EventHandler(this.buttonShowPitInfo_Click);
            // 
            // buttonShowPicture
            // 
            this.buttonShowPicture.Enabled = false;
            this.buttonShowPicture.Location = new System.Drawing.Point(388, 38);
            this.buttonShowPicture.Name = "buttonShowPicture";
            this.buttonShowPicture.Size = new System.Drawing.Size(111, 23);
            this.buttonShowPicture.TabIndex = 7;
            this.buttonShowPicture.Text = "Show Picture";
            this.buttonShowPicture.UseVisualStyleBackColor = true;
            this.buttonShowPicture.Click += new System.EventHandler(this.buttonShowPicture_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 565);
            this.Controls.Add(this.buttonShowPicture);
            this.Controls.Add(this.buttonShowPitInfo);
            this.Controls.Add(this.dataGridViewStand);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxKindleFilePath);
            this.Controls.Add(this.labelKindleFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BERT Scout View";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKindleFilePath;
        private System.Windows.Forms.TextBox textBoxKindleFilePath;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.DataGridView dataGridViewStand;
        private System.Windows.Forms.Button buttonShowPitInfo;
        private System.Windows.Forms.Button buttonShowPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Match;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alliance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoScoreHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoScoreLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoBaseline;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoPlaceGear;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoOpenHopper;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeleScoreHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeleScoreLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeleGearsPlaced;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeleClimbed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeleTouchpad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoutName;
    }
}

