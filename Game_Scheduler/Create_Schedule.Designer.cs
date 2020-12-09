namespace Game_Scheduler
{
    partial class Create_Schedule
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Game_Scheduler.Database1DataSet();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txtTname = new MetroFramework.Controls.MetroTextBox();
            this.Logout = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtGameId = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.scheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new Game_Scheduler.Database1DataSetTableAdapters.ScheduleTableAdapter();
            this.scheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roundDataGridViewTextBoxColumn,
            this.team1DataGridViewTextBoxColumn,
            this.vsDataGridViewTextBoxColumn,
            this.team2DataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.gameIdDataGridViewTextBoxColumn,
            this.tournamentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduleBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(187, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 190);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roundDataGridViewTextBoxColumn
            // 
            this.roundDataGridViewTextBoxColumn.DataPropertyName = "Round";
            this.roundDataGridViewTextBoxColumn.HeaderText = "Round";
            this.roundDataGridViewTextBoxColumn.Name = "roundDataGridViewTextBoxColumn";
            // 
            // team1DataGridViewTextBoxColumn
            // 
            this.team1DataGridViewTextBoxColumn.DataPropertyName = "team1";
            this.team1DataGridViewTextBoxColumn.HeaderText = "team1";
            this.team1DataGridViewTextBoxColumn.Name = "team1DataGridViewTextBoxColumn";
            // 
            // vsDataGridViewTextBoxColumn
            // 
            this.vsDataGridViewTextBoxColumn.DataPropertyName = "vs";
            this.vsDataGridViewTextBoxColumn.HeaderText = "vs";
            this.vsDataGridViewTextBoxColumn.Name = "vsDataGridViewTextBoxColumn";
            // 
            // team2DataGridViewTextBoxColumn
            // 
            this.team2DataGridViewTextBoxColumn.DataPropertyName = "team2";
            this.team2DataGridViewTextBoxColumn.HeaderText = "team2";
            this.team2DataGridViewTextBoxColumn.Name = "team2DataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            this.gameIdDataGridViewTextBoxColumn.DataPropertyName = "GameId";
            this.gameIdDataGridViewTextBoxColumn.HeaderText = "GameId";
            this.gameIdDataGridViewTextBoxColumn.Name = "gameIdDataGridViewTextBoxColumn";
            // 
            // tournamentNameDataGridViewTextBoxColumn
            // 
            this.tournamentNameDataGridViewTextBoxColumn.DataPropertyName = "TournamentName";
            this.tournamentNameDataGridViewTextBoxColumn.HeaderText = "TournamentName";
            this.tournamentNameDataGridViewTextBoxColumn.Name = "tournamentNameDataGridViewTextBoxColumn";
            // 
            // scheduleBindingSource3
            // 
            this.scheduleBindingSource3.DataMember = "Schedule";
            this.scheduleBindingSource3.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Green;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(130, 161);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(51, 20);
            this.metroButton2.TabIndex = 35;
            this.metroButton2.Text = "Add";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtTname
            // 
            // 
            // 
            // 
            this.txtTname.CustomButton.Image = null;
            this.txtTname.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtTname.CustomButton.Name = "";
            this.txtTname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTname.CustomButton.TabIndex = 1;
            this.txtTname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTname.CustomButton.UseSelectable = true;
            this.txtTname.CustomButton.Visible = false;
            this.txtTname.Lines = new string[0];
            this.txtTname.Location = new System.Drawing.Point(23, 108);
            this.txtTname.MaxLength = 32767;
            this.txtTname.Name = "txtTname";
            this.txtTname.PasswordChar = '\0';
            this.txtTname.PromptText = "Tournament Name";
            this.txtTname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTname.SelectedText = "";
            this.txtTname.SelectionLength = 0;
            this.txtTname.SelectionStart = 0;
            this.txtTname.ShortcutsEnabled = true;
            this.txtTname.Size = new System.Drawing.Size(112, 23);
            this.txtTname.TabIndex = 34;
            this.txtTname.UseCustomBackColor = true;
            this.txtTname.UseCustomForeColor = true;
            this.txtTname.UseSelectable = true;
            this.txtTname.UseStyleColors = true;
            this.txtTname.WaterMark = "Tournament Name";
            this.txtTname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(465, 26);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(121, 29);
            this.Logout.TabIndex = 33;
            this.Logout.Text = "Logout";
            this.Logout.UseCustomBackColor = true;
            this.Logout.UseCustomForeColor = true;
            this.Logout.UseSelectable = true;
            this.Logout.UseStyleColors = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(23, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(427, 29);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Schedule";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtGameId
            // 
            // 
            // 
            // 
            this.txtGameId.CustomButton.Image = null;
            this.txtGameId.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtGameId.CustomButton.Name = "";
            this.txtGameId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGameId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGameId.CustomButton.TabIndex = 1;
            this.txtGameId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGameId.CustomButton.UseSelectable = true;
            this.txtGameId.CustomButton.Visible = false;
            this.txtGameId.Lines = new string[0];
            this.txtGameId.Location = new System.Drawing.Point(23, 79);
            this.txtGameId.MaxLength = 32767;
            this.txtGameId.Name = "txtGameId";
            this.txtGameId.PasswordChar = '\0';
            this.txtGameId.PromptText = "Game Id";
            this.txtGameId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGameId.SelectedText = "";
            this.txtGameId.SelectionLength = 0;
            this.txtGameId.SelectionStart = 0;
            this.txtGameId.ShortcutsEnabled = true;
            this.txtGameId.Size = new System.Drawing.Size(112, 23);
            this.txtGameId.TabIndex = 37;
            this.txtGameId.UseCustomBackColor = true;
            this.txtGameId.UseCustomForeColor = true;
            this.txtGameId.UseSelectable = true;
            this.txtGameId.UseStyleColors = true;
            this.txtGameId.WaterMark = "Game Id";
            this.txtGameId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGameId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 39;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 15);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "Enter team Names";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Green;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(139, 357);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 20);
            this.metroButton1.TabIndex = 43;
            this.metroButton1.Text = "DoubleRoundRobin";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.Green;
            this.metroButton3.ForeColor = System.Drawing.Color.White;
            this.metroButton3.Location = new System.Drawing.Point(23, 357);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(101, 20);
            this.metroButton3.TabIndex = 44;
            this.metroButton3.Text = "RoundRbin";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(26, 339);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 15);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Select Game Type";
            // 
            // scheduleBindingSource1
            // 
            this.scheduleBindingSource1.DataMember = "Schedule";
            this.scheduleBindingSource1.DataSource = this.database1DataSet;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.database1DataSet;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleBindingSource2
            // 
            this.scheduleBindingSource2.DataMember = "Schedule";
            this.scheduleBindingSource2.DataSource = this.database1DataSet;
            // 
            // Create_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtGameId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtTname);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Create_Schedule";
            this.Load += new System.EventHandler(this.Create_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtTname;
        private MetroFramework.Controls.MetroButton Logout;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtGameId;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private Database1DataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.BindingSource scheduleBindingSource1;
        private System.Windows.Forms.BindingSource scheduleBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scheduleBindingSource3;
    }
}