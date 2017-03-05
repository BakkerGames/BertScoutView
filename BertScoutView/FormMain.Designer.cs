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
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team:";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(101, 38);
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
            this.dataGridViewStand.Location = new System.Drawing.Point(15, 65);
            this.dataGridViewStand.MultiSelect = false;
            this.dataGridViewStand.Name = "dataGridViewStand";
            this.dataGridViewStand.ReadOnly = true;
            this.dataGridViewStand.RowHeadersVisible = false;
            this.dataGridViewStand.Size = new System.Drawing.Size(787, 488);
            this.dataGridViewStand.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 565);
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
    }
}

