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
            this.backlogOwnerTextBox = new System.Windows.Forms.TextBox();
            this.backlogOwnerLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backlogToolDatabaseDataSet = new BackLogTool.BacklogToolDatabaseDataSet();
            this.backlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backlogTableAdapter = new BackLogTool.BacklogToolDatabaseDataSetTableAdapters.BacklogTableAdapter();
            this.tCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiraTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogToolDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backlogUnassignedCheckBox
            // 
            this.backlogUnassignedCheckBox.AutoSize = true;
            this.backlogUnassignedCheckBox.Location = new System.Drawing.Point(823, 120);
            this.backlogUnassignedCheckBox.Name = "backlogUnassignedCheckBox";
            this.backlogUnassignedCheckBox.Size = new System.Drawing.Size(102, 20);
            this.backlogUnassignedCheckBox.TabIndex = 1;
            this.backlogUnassignedCheckBox.Text = "Unassigned";
            this.backlogUnassignedCheckBox.UseVisualStyleBackColor = true;
            this.backlogUnassignedCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // backlogPrio0CheckBox
            // 
            this.backlogPrio0CheckBox.AutoSize = true;
            this.backlogPrio0CheckBox.Location = new System.Drawing.Point(826, 251);
            this.backlogPrio0CheckBox.Name = "backlogPrio0CheckBox";
            this.backlogPrio0CheckBox.Size = new System.Drawing.Size(63, 20);
            this.backlogPrio0CheckBox.TabIndex = 5;
            this.backlogPrio0CheckBox.Text = "Prio 0";
            this.backlogPrio0CheckBox.UseVisualStyleBackColor = true;
            // 
            // backlogPrio1CheckBox
            // 
            this.backlogPrio1CheckBox.AutoSize = true;
            this.backlogPrio1CheckBox.Location = new System.Drawing.Point(826, 303);
            this.backlogPrio1CheckBox.Name = "backlogPrio1CheckBox";
            this.backlogPrio1CheckBox.Size = new System.Drawing.Size(63, 20);
            this.backlogPrio1CheckBox.TabIndex = 10;
            this.backlogPrio1CheckBox.Text = "Prio 1";
            this.backlogPrio1CheckBox.UseVisualStyleBackColor = true;
            // 
            // backlogOngoingCheckBox
            // 
            this.backlogOngoingCheckBox.AutoSize = true;
            this.backlogOngoingCheckBox.Location = new System.Drawing.Point(823, 146);
            this.backlogOngoingCheckBox.Name = "backlogOngoingCheckBox";
            this.backlogOngoingCheckBox.Size = new System.Drawing.Size(80, 20);
            this.backlogOngoingCheckBox.TabIndex = 6;
            this.backlogOngoingCheckBox.Text = "Ongoing";
            this.backlogOngoingCheckBox.UseVisualStyleBackColor = true;
            // 
            // backlogPrio2CheckBox
            // 
            this.backlogPrio2CheckBox.AutoSize = true;
            this.backlogPrio2CheckBox.Location = new System.Drawing.Point(826, 277);
            this.backlogPrio2CheckBox.Name = "backlogPrio2CheckBox";
            this.backlogPrio2CheckBox.Size = new System.Drawing.Size(63, 20);
            this.backlogPrio2CheckBox.TabIndex = 15;
            this.backlogPrio2CheckBox.Text = "Prio 2";
            this.backlogPrio2CheckBox.UseVisualStyleBackColor = true;
            // 
            // backlogClosedCheckBox
            // 
            this.backlogClosedCheckBox.AutoSize = true;
            this.backlogClosedCheckBox.Location = new System.Drawing.Point(823, 172);
            this.backlogClosedCheckBox.Name = "backlogClosedCheckBox";
            this.backlogClosedCheckBox.Size = new System.Drawing.Size(72, 20);
            this.backlogClosedCheckBox.TabIndex = 11;
            this.backlogClosedCheckBox.Text = "Closed";
            this.backlogClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // backlogEditEntryButton
            // 
            this.backlogEditEntryButton.Location = new System.Drawing.Point(726, 453);
            this.backlogEditEntryButton.Name = "backlogEditEntryButton";
            this.backlogEditEntryButton.Size = new System.Drawing.Size(262, 45);
            this.backlogEditEntryButton.TabIndex = 16;
            this.backlogEditEntryButton.Text = "Edit Entry";
            this.backlogEditEntryButton.UseVisualStyleBackColor = true;
            this.backlogEditEntryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backlogOwnerTextBox
            // 
            this.backlogOwnerTextBox.Location = new System.Drawing.Point(823, 217);
            this.backlogOwnerTextBox.Name = "backlogOwnerTextBox";
            this.backlogOwnerTextBox.Size = new System.Drawing.Size(212, 22);
            this.backlogOwnerTextBox.TabIndex = 17;
            this.backlogOwnerTextBox.TextChanged += new System.EventHandler(this.backlogOwnerTextBox_TextChanged);
            // 
            // backlogOwnerLabel
            // 
            this.backlogOwnerLabel.AutoSize = true;
            this.backlogOwnerLabel.Location = new System.Drawing.Point(823, 198);
            this.backlogOwnerLabel.Name = "backlogOwnerLabel";
            this.backlogOwnerLabel.Size = new System.Drawing.Size(45, 16);
            this.backlogOwnerLabel.TabIndex = 18;
            this.backlogOwnerLabel.Text = "Owner";
            this.backlogOwnerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCNameDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.jiraTicketDataGridViewTextBoxColumn,
            this.defectDataGridViewTextBoxColumn,
            this.prioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.backlogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 198);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backlogToolDatabaseDataSet
            // 
            this.backlogToolDatabaseDataSet.DataSetName = "BacklogToolDatabaseDataSet";
            this.backlogToolDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backlogBindingSource
            // 
            this.backlogBindingSource.DataMember = "Backlog";
            this.backlogBindingSource.DataSource = this.backlogToolDatabaseDataSet;
            // 
            // backlogTableAdapter
            // 
            this.backlogTableAdapter.ClearBeforeFill = true;
            // 
            // tCNameDataGridViewTextBoxColumn
            // 
            this.tCNameDataGridViewTextBoxColumn.DataPropertyName = "TC Name";
            this.tCNameDataGridViewTextBoxColumn.HeaderText = "TC Name";
            this.tCNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNameDataGridViewTextBoxColumn.Name = "tCNameDataGridViewTextBoxColumn";
            this.tCNameDataGridViewTextBoxColumn.Width = 125;
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
            // jiraTicketDataGridViewTextBoxColumn
            // 
            this.jiraTicketDataGridViewTextBoxColumn.DataPropertyName = "Jira Ticket";
            this.jiraTicketDataGridViewTextBoxColumn.HeaderText = "Jira Ticket";
            this.jiraTicketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jiraTicketDataGridViewTextBoxColumn.Name = "jiraTicketDataGridViewTextBoxColumn";
            this.jiraTicketDataGridViewTextBoxColumn.Width = 125;
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
            // backlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1120, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backlogOwnerLabel);
            this.Controls.Add(this.backlogOwnerTextBox);
            this.Controls.Add(this.backlogEditEntryButton);
            this.Controls.Add(this.backlogPrio2CheckBox);
            this.Controls.Add(this.backlogClosedCheckBox);
            this.Controls.Add(this.backlogPrio1CheckBox);
            this.Controls.Add(this.backlogOngoingCheckBox);
            this.Controls.Add(this.backlogPrio0CheckBox);
            this.Controls.Add(this.backlogUnassignedCheckBox);
            this.Name = "backlog";
            this.Text = "backlog";
            this.Load += new System.EventHandler(this.backlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogToolDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlogBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox backlogOwnerTextBox;
        private System.Windows.Forms.Label backlogOwnerLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BacklogToolDatabaseDataSet backlogToolDatabaseDataSet;
        private System.Windows.Forms.BindingSource backlogBindingSource;
        private BacklogToolDatabaseDataSetTableAdapters.BacklogTableAdapter backlogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiraTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioDataGridViewTextBoxColumn;
    }
}