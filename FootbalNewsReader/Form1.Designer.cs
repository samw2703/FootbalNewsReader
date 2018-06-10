namespace FootbalNewsReader
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSummary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxTier2 = new System.Windows.Forms.CheckBox();
            this.checkBoxTier1 = new System.Windows.Forms.CheckBox();
            this.tabPagePlayers = new System.Windows.Forms.TabPage();
            this.tabPageFeeds = new System.Windows.Forms.TabPage();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.ColumnPlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSaveFeeds = new System.Windows.Forms.Button();
            this.dataGridViewFeeds = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSavePlayers = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageFeeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeeds)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSearch);
            this.tabControl.Controls.Add(this.tabPagePlayers);
            this.tabControl.Controls.Add(this.tabPageFeeds);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(688, 307);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.listView);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.checkBox3);
            this.tabPageSearch.Controls.Add(this.checkBoxTier2);
            this.tabPageSearch.Controls.Add(this.checkBoxTier1);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(680, 281);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderSummary});
            this.listView.Location = new System.Drawing.Point(6, 36);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(393, 239);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 393;
            // 
            // columnHeaderSummary
            // 
            this.columnHeaderSummary.Text = "Summary";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(246, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(187, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Tier 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxTier2
            // 
            this.checkBoxTier2.AutoSize = true;
            this.checkBoxTier2.Location = new System.Drawing.Point(101, 13);
            this.checkBoxTier2.Name = "checkBoxTier2";
            this.checkBoxTier2.Size = new System.Drawing.Size(53, 17);
            this.checkBoxTier2.TabIndex = 2;
            this.checkBoxTier2.Text = "Tier 2";
            this.checkBoxTier2.UseVisualStyleBackColor = true;
            // 
            // checkBoxTier1
            // 
            this.checkBoxTier1.AutoSize = true;
            this.checkBoxTier1.Location = new System.Drawing.Point(15, 13);
            this.checkBoxTier1.Name = "checkBoxTier1";
            this.checkBoxTier1.Size = new System.Drawing.Size(53, 17);
            this.checkBoxTier1.TabIndex = 1;
            this.checkBoxTier1.Text = "Tier 1";
            this.checkBoxTier1.UseVisualStyleBackColor = true;
            // 
            // tabPagePlayers
            // 
            this.tabPagePlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayers.Name = "tabPagePlayers";
            this.tabPagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlayers.Size = new System.Drawing.Size(680, 281);
            this.tabPagePlayers.TabIndex = 1;
            this.tabPagePlayers.Text = "Players";
            this.tabPagePlayers.UseVisualStyleBackColor = true;
            // 
            // tabPageFeeds
            // 
            this.tabPageFeeds.Controls.Add(this.buttonSavePlayers);
            this.tabPageFeeds.Controls.Add(this.dataGridViewPlayers);
            this.tabPageFeeds.Controls.Add(this.buttonSaveFeeds);
            this.tabPageFeeds.Controls.Add(this.dataGridViewFeeds);
            this.tabPageFeeds.Location = new System.Drawing.Point(4, 22);
            this.tabPageFeeds.Name = "tabPageFeeds";
            this.tabPageFeeds.Size = new System.Drawing.Size(680, 281);
            this.tabPageFeeds.TabIndex = 2;
            this.tabPageFeeds.Text = "Feeds";
            this.tabPageFeeds.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayerId,
            this.ColumnPlayerName,
            this.ColumnPlayerDelete});
            this.dataGridViewPlayers.Location = new System.Drawing.Point(551, 33);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(350, 150);
            this.dataGridViewPlayers.TabIndex = 2;
            this.dataGridViewPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellContentClick);
            // 
            // ColumnPlayerId
            // 
            this.ColumnPlayerId.HeaderText = "Id";
            this.ColumnPlayerId.Name = "ColumnPlayerId";
            this.ColumnPlayerId.ReadOnly = true;
            this.ColumnPlayerId.Width = 30;
            // 
            // ColumnPlayerName
            // 
            this.ColumnPlayerName.HeaderText = "Name";
            this.ColumnPlayerName.Name = "ColumnPlayerName";
            this.ColumnPlayerName.Width = 200;
            // 
            // ColumnPlayerDelete
            // 
            this.ColumnPlayerDelete.HeaderText = "";
            this.ColumnPlayerDelete.Name = "ColumnPlayerDelete";
            this.ColumnPlayerDelete.Text = "Delete";
            this.ColumnPlayerDelete.UseColumnTextForButtonValue = true;
            this.ColumnPlayerDelete.Width = 60;
            // 
            // buttonSaveFeeds
            // 
            this.buttonSaveFeeds.Location = new System.Drawing.Point(3, 189);
            this.buttonSaveFeeds.Name = "buttonSaveFeeds";
            this.buttonSaveFeeds.Size = new System.Drawing.Size(95, 23);
            this.buttonSaveFeeds.TabIndex = 1;
            this.buttonSaveFeeds.Text = "Save Changes";
            this.buttonSaveFeeds.UseVisualStyleBackColor = true;
            this.buttonSaveFeeds.Click += new System.EventHandler(this.buttonSaveFeeds_Click);
            // 
            // dataGridViewFeeds
            // 
            this.dataGridViewFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnProvider,
            this.ColumnUrl,
            this.ColumnDelete});
            this.dataGridViewFeeds.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewFeeds.Name = "dataGridViewFeeds";
            this.dataGridViewFeeds.Size = new System.Drawing.Size(539, 150);
            this.dataGridViewFeeds.TabIndex = 0;
            this.dataGridViewFeeds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeeds_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 30;
            // 
            // ColumnProvider
            // 
            this.ColumnProvider.HeaderText = "Provider";
            this.ColumnProvider.Name = "ColumnProvider";
            // 
            // ColumnUrl
            // 
            this.ColumnUrl.HeaderText = "Url";
            this.ColumnUrl.Name = "ColumnUrl";
            this.ColumnUrl.Width = 300;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 60;
            // 
            // buttonSavePlayers
            // 
            this.buttonSavePlayers.Location = new System.Drawing.Point(551, 189);
            this.buttonSavePlayers.Name = "buttonSavePlayers";
            this.buttonSavePlayers.Size = new System.Drawing.Size(95, 23);
            this.buttonSavePlayers.TabIndex = 3;
            this.buttonSavePlayers.Text = "Save Changes";
            this.buttonSavePlayers.UseVisualStyleBackColor = true;
            this.buttonSavePlayers.Click += new System.EventHandler(this.buttonSavePlayers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 331);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageFeeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TabPage tabPagePlayers;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxTier2;
        private System.Windows.Forms.CheckBox checkBoxTier1;
        private System.Windows.Forms.TabPage tabPageFeeds;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderSummary;
        private System.Windows.Forms.DataGridView dataGridViewFeeds;
        private System.Windows.Forms.Button buttonSaveFeeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUrl;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayerName;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnPlayerDelete;
        private System.Windows.Forms.Button buttonSavePlayers;
    }
}

