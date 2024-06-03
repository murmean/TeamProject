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
            this.mainBacklogButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMonitoringButton
            // 
            this.mainMonitoringButton.Location = new System.Drawing.Point(618, 118);
            this.mainMonitoringButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainMonitoringButton.Name = "mainMonitoringButton";
            this.mainMonitoringButton.Size = new System.Drawing.Size(182, 41);
            this.mainMonitoringButton.TabIndex = 0;
            this.mainMonitoringButton.Text = "Monitoring";
            this.mainMonitoringButton.UseVisualStyleBackColor = true;
            this.mainMonitoringButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainBacklogButton
            // 
            this.mainBacklogButton.Location = new System.Drawing.Point(618, 175);
            this.mainBacklogButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainBacklogButton.Name = "mainBacklogButton";
            this.mainBacklogButton.Size = new System.Drawing.Size(182, 41);
            this.mainBacklogButton.TabIndex = 1;
            this.mainBacklogButton.Text = "Backlog";
            this.mainBacklogButton.UseVisualStyleBackColor = true;
            this.mainBacklogButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BackLogTool.Properties.Resources.team;
            this.pictureBox2.Location = new System.Drawing.Point(83, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(850, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mainBacklogButton);
            this.Controls.Add(this.mainMonitoringButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMonitoringButton;
        private System.Windows.Forms.Button mainBacklogButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

