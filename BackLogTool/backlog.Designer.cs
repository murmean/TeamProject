namespace BackLogTool
{
    partial class backlog
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
            this.backlogUnassignedCheckBox = new System.Windows.Forms.CheckBox();
            this.backlogPrio0CheckBox = new System.Windows.Forms.CheckBox();
            this.backlogPrio1CheckBox = new System.Windows.Forms.CheckBox();
            this.backlogOngoingCheckBox = new System.Windows.Forms.CheckBox();
            this.backlogPrio2CheckBox = new System.Windows.Forms.CheckBox();
            this.backlogClosedCheckBox = new System.Windows.Forms.CheckBox();
            this.backlogEditEntryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Test_Case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backlogToolDatabaseDataSet = new BackLogTool.BacklogToolDatabaseDataSet();
            this.backlogTableAdapter = new BackLogTool.BacklogToolDatabaseDataSetTableAdapters.BacklogTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogToolDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // backlogUnassignedCheckBox
            // 
            this.backlogUnassignedCheckBox.AutoSize = true;
            this.backlogUnassignedCheckBox.Location = new System.Drawing.Point(617, 98);
            this.backlogUnassignedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backlogUnassignedCheckBox.Name = "backlogUnassignedCheckBox";
            this.backlogUnassignedCheckBox.Size = new System.Drawing.Size(82, 17);
            this.backlogUnassignedCheckBox.TabIndex = 1;
            this.backlogUnassignedCheckBox.Text = "Unassigned";
            this.backlogUnassignedCheckBox.UseVisualStyleBackColor = true;
            this.backlogUnassignedCheckBox.CheckedChanged += new System.EventHandler(this.backlogUnassignedCheckBox_CheckedChanged);
            // 
            // backlogPrio0CheckBox
            // 
            this.backlogPrio0CheckBox.AutoSize = true;
            this.backlogPrio0CheckBox.Location = new System.Drawing.Point(620, 204);
            this.backlogPrio0CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backlogPrio0CheckBox.Name = "backlogPrio0CheckBox";
            this.backlogPrio0CheckBox.Size = new System.Drawing.Size(53, 17);
            this.backlogPrio0CheckBox.TabIndex = 5;
            this.backlogPrio0CheckBox.Text = "Prio 0";
            this.backlogPrio0CheckBox.UseVisualStyleBackColor = true;
            this.backlogPrio0CheckBox.CheckedChanged += new System.EventHandler(this.backlogPrio0CheckBox_CheckedChanged);
            // 
            // backlogPrio1CheckBox
            // 
            this.backlogPrio1CheckBox.AutoSize = true;
            this.backlogPrio1CheckBox.Location = new System.Drawing.Point(620, 225);
            this.backlogPrio1CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backlogPrio1CheckBox.Name = "backlogPrio1CheckBox";
            this.backlogPrio1CheckBox.Size = new System.Drawing.Size(53, 17);
            this.backlogPrio1CheckBox.TabIndex = 10;
            this.backlogPrio1CheckBox.Text = "Prio 1";
            this.backlogPrio1CheckBox.UseVisualStyleBackColor = true;
            this.backlogPrio1CheckBox.CheckedChanged += new System.EventHandler(this.backlogPrio1CheckBox_CheckedChanged);
            // 
            // backlogOngoingCheckBox
            // 
            this.backlogOngoingCheckBox.AutoSize = true;
            this.backlogOngoingCheckBox.Location = new System.Drawing.Point(617, 119);
            this.backlogOngoingCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backlogOngoingCheckBox.Name = "backlogOngoingCheckBox";
            this.backlogOngoingCheckBox.Size = new System.Drawing.Size(66, 17);
            this.backlogOngoingCheckBox.TabIndex = 6;
            this.backlogOngoingCheckBox.Text = "Ongoing";
            this.backlogOngoingCheckBox.UseVisualStyleBackColor = true;
            this.backlogOngoingCheckBox.CheckedChanged += new System.EventHandler(this.backlogOngoingCheckBox_CheckedChanged);
            // 
            // backlogPrio2CheckBox
            // 
            this.backlogPrio2CheckBox.AutoSize = true;
            this.backlogPrio2CheckBox.Location = new System.Drawing.Point(620, 246);
            this.backlogPrio2CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backlogPrio2CheckBox.Name = "backlogPrio2CheckBox";
            this.backlogPrio2CheckBox.Size = new System.Drawing.Size(53, 17);
            this.backlogPrio2CheckBox.TabIndex = 15;
            this.backlogPrio2CheckBox.Text = "Prio 2";
            this.backlogPrio2CheckBox.UseVisualStyleBackColor = true;
            this.backlogPrio2CheckBox.CheckedChanged += new System.EventHandler(this.backlogPrio2CheckBox_CheckedChanged);
            // 
            // backlogClosedCheckBox
            // 
            this.backlogClosedCheckBox.AutoSize = true;
            this.backlogClosedCheckBox.Location = new System.Drawing.Point(617, 140);
            this.backlogClosedCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backlogClosedCheckBox.Name = "backlogClosedCheckBox";
            this.backlogClosedCheckBox.Size = new System.Drawing.Size(58, 17);
            this.backlogClosedCheckBox.TabIndex = 11;
            this.backlogClosedCheckBox.Text = "Closed";
            this.backlogClosedCheckBox.UseVisualStyleBackColor = true;
            this.backlogClosedCheckBox.CheckedChanged += new System.EventHandler(this.backlogClosedCheckBox_CheckedChanged_1);
            // 
            // backlogEditEntryButton
            // 
            this.backlogEditEntryButton.Location = new System.Drawing.Point(544, 368);
            this.backlogEditEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.backlogEditEntryButton.Name = "backlogEditEntryButton";
            this.backlogEditEntryButton.Size = new System.Drawing.Size(196, 37);
            this.backlogEditEntryButton.TabIndex = 16;
            this.backlogEditEntryButton.Text = "Edit Entry";
            this.backlogEditEntryButton.UseVisualStyleBackColor = true;
            this.backlogEditEntryButton.Click += new System.EventHandler(this.backlogEditEntryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Test_Case,
            this.ownerDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Jira,
            this.defectDataGridViewTextBoxColumn,
            this.prioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.backlogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 161);
            this.dataGridView1.TabIndex = 19;
            // 
            // Test_Case
            // 
            this.Test_Case.DataPropertyName = "Test_Case";
            this.Test_Case.HeaderText = "Test_Case";
            this.Test_Case.Name = "Test_Case";
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Jira
            // 
            this.Jira.DataPropertyName = "Jira";
            this.Jira.HeaderText = "Jira";
            this.Jira.Name = "Jira";
            // 
            // defectDataGridViewTextBoxColumn
            // 
            this.defectDataGridViewTextBoxColumn.DataPropertyName = "Defect";
            this.defectDataGridViewTextBoxColumn.HeaderText = "Defect";
            this.defectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.defectDataGridViewTextBoxColumn.Name = "defectDataGridViewTextBoxColumn";
            this.defectDataGridViewTextBoxColumn.Width = 125;
            // 
            // prioDataGridViewTextBoxColumn
            // 
            this.prioDataGridViewTextBoxColumn.DataPropertyName = "Prio";
            this.prioDataGridViewTextBoxColumn.HeaderText = "Prio";
            this.prioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prioDataGridViewTextBoxColumn.Name = "prioDataGridViewTextBoxColumn";
            this.prioDataGridViewTextBoxColumn.Width = 125;
            // 
            // backlogBindingSource
            // 
            this.backlogBindingSource.DataMember = "Backlog";
            this.backlogBindingSource.DataSource = this.backlogToolDatabaseDataSet;
            // 
            // backlogToolDatabaseDataSet
            // 
            this.backlogToolDatabaseDataSet.DataSetName = "BacklogToolDatabaseDataSet";
            this.backlogToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backlogTableAdapter
            // 
            this.backlogTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(840, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backlogEditEntryButton);
            this.Controls.Add(this.backlogPrio2CheckBox);
            this.Controls.Add(this.backlogClosedCheckBox);
            this.Controls.Add(this.backlogPrio1CheckBox);
            this.Controls.Add(this.backlogOngoingCheckBox);
            this.Controls.Add(this.backlogPrio0CheckBox);
            this.Controls.Add(this.backlogUnassignedCheckBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "backlog";
            this.Text = "backlog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogToolDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox backlogUnassignedCheckBox;
        private System.Windows.Forms.CheckBox backlogPrio0CheckBox;
        private System.Windows.Forms.CheckBox backlogPrio1CheckBox;
        private System.Windows.Forms.CheckBox backlogOngoingCheckBox;
        private System.Windows.Forms.CheckBox backlogPrio2CheckBox;
        private System.Windows.Forms.CheckBox backlogClosedCheckBox;
        private System.Windows.Forms.Button backlogEditEntryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BacklogToolDatabaseDataSet backlogToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource backlogBindingSource;
        private BacklogToolDatabaseDataSetTableAdapters.BacklogTableAdapter backlogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiraTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Case;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jira;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}