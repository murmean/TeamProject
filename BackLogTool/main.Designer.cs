namespace BackLogTool
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.mainMonitoringButton = new System.Windows.Forms.Button();
            this.mainDefectsButton = new System.Windows.Forms.Button();
            this.mainBacklogButton = new System.Windows.Forms.Button();
            this.mainRevertsButton = new System.Windows.Forms.Button();
            this.mainStatisticsButton = new System.Windows.Forms.Button();
            this.mainTeamManagementButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMonitoringButton
            // 
            this.mainMonitoringButton.Location = new System.Drawing.Point(824, 34);
            this.mainMonitoringButton.Name = "mainMonitoringButton";
            this.mainMonitoringButton.Size = new System.Drawing.Size(242, 50);
            this.mainMonitoringButton.TabIndex = 0;
            this.mainMonitoringButton.Text = "Monitoring";
            this.mainMonitoringButton.UseVisualStyleBackColor = true;
            this.mainMonitoringButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainDefectsButton
            // 
            this.mainDefectsButton.Location = new System.Drawing.Point(824, 178);
            this.mainDefectsButton.Name = "mainDefectsButton";
            this.mainDefectsButton.Size = new System.Drawing.Size(242, 50);
            this.mainDefectsButton.TabIndex = 0;
            this.mainDefectsButton.Text = "Defects";
            this.mainDefectsButton.UseVisualStyleBackColor = true;
            // 
            // mainBacklogButton
            // 
            this.mainBacklogButton.Location = new System.Drawing.Point(824, 122);
            this.mainBacklogButton.Name = "mainBacklogButton";
            this.mainBacklogButton.Size = new System.Drawing.Size(242, 50);
            this.mainBacklogButton.TabIndex = 1;
            this.mainBacklogButton.Text = "Backlog";
            this.mainBacklogButton.UseVisualStyleBackColor = true;
            this.mainBacklogButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainRevertsButton
            // 
            this.mainRevertsButton.Location = new System.Drawing.Point(824, 234);
            this.mainRevertsButton.Name = "mainRevertsButton";
            this.mainRevertsButton.Size = new System.Drawing.Size(242, 50);
            this.mainRevertsButton.TabIndex = 2;
            this.mainRevertsButton.Text = "Reverts";
            this.mainRevertsButton.UseVisualStyleBackColor = true;
            // 
            // mainStatisticsButton
            // 
            this.mainStatisticsButton.Location = new System.Drawing.Point(824, 290);
            this.mainStatisticsButton.Name = "mainStatisticsButton";
            this.mainStatisticsButton.Size = new System.Drawing.Size(242, 50);
            this.mainStatisticsButton.TabIndex = 3;
            this.mainStatisticsButton.Text = "Statistics";
            this.mainStatisticsButton.UseVisualStyleBackColor = true;
            // 
            // mainTeamManagementButton
            // 
            this.mainTeamManagementButton.Location = new System.Drawing.Point(824, 411);
            this.mainTeamManagementButton.Name = "mainTeamManagementButton";
            this.mainTeamManagementButton.Size = new System.Drawing.Size(242, 50);
            this.mainTeamManagementButton.TabIndex = 4;
            this.mainTeamManagementButton.Text = "Team Management";
            this.mainTeamManagementButton.UseVisualStyleBackColor = true;
            this.mainTeamManagementButton.Click += new System.EventHandler(this.mainTeamManagementButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BackLogTool.Properties.Resources.image1;
            this.pictureBox2.Location = new System.Drawing.Point(111, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(403, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1134, 518);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mainTeamManagementButton);
            this.Controls.Add(this.mainStatisticsButton);
            this.Controls.Add(this.mainRevertsButton);
            this.Controls.Add(this.mainBacklogButton);
            this.Controls.Add(this.mainDefectsButton);
            this.Controls.Add(this.mainMonitoringButton);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMonitoringButton;
        private System.Windows.Forms.Button mainDefectsButton;
        private System.Windows.Forms.Button mainBacklogButton;
        private System.Windows.Forms.Button mainRevertsButton;
        private System.Windows.Forms.Button mainStatisticsButton;
        private System.Windows.Forms.Button mainTeamManagementButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

