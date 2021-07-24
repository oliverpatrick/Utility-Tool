
namespace UTool
{
    partial class UToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UToolForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnDeleteTempFiles = new System.Windows.Forms.Button();
            this.btnDefrag = new System.Windows.Forms.Button();
            this.btnDeleteCacheMemory = new System.Windows.Forms.Button();
            this.btnPrefetch = new System.Windows.Forms.Button();
            this.btnCleanManager = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnComputerDetails = new System.Windows.Forms.Button();
            this.btnPreformanceInfo = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelSideMenu.Controls.Add(this.btnDeleteTempFiles);
            this.panelSideMenu.Controls.Add(this.btnDefrag);
            this.panelSideMenu.Controls.Add(this.btnDeleteCacheMemory);
            this.panelSideMenu.Controls.Add(this.btnPrefetch);
            this.panelSideMenu.Controls.Add(this.btnCleanManager);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 418);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnDeleteTempFiles
            // 
            this.btnDeleteTempFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnDeleteTempFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteTempFiles.FlatAppearance.BorderSize = 0;
            this.btnDeleteTempFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDeleteTempFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTempFiles.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTempFiles.Location = new System.Drawing.Point(0, 336);
            this.btnDeleteTempFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTempFiles.Name = "btnDeleteTempFiles";
            this.btnDeleteTempFiles.Size = new System.Drawing.Size(200, 84);
            this.btnDeleteTempFiles.TabIndex = 6;
            this.btnDeleteTempFiles.Text = "Delete Temp Files";
            this.btnDeleteTempFiles.UseVisualStyleBackColor = false;
            this.btnDeleteTempFiles.Click += new System.EventHandler(this.btnDeleteTempFiles_Click);
            // 
            // btnDefrag
            // 
            this.btnDefrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnDefrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDefrag.FlatAppearance.BorderSize = 0;
            this.btnDefrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDefrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefrag.ForeColor = System.Drawing.Color.White;
            this.btnDefrag.Location = new System.Drawing.Point(0, 252);
            this.btnDefrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnDefrag.Name = "btnDefrag";
            this.btnDefrag.Size = new System.Drawing.Size(200, 84);
            this.btnDefrag.TabIndex = 5;
            this.btnDefrag.Text = "Defrag";
            this.btnDefrag.UseVisualStyleBackColor = false;
            this.btnDefrag.Click += new System.EventHandler(this.btnDefrag_Click);
            // 
            // btnDeleteCacheMemory
            // 
            this.btnDeleteCacheMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnDeleteCacheMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteCacheMemory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCacheMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnDeleteCacheMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCacheMemory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCacheMemory.Location = new System.Drawing.Point(0, 168);
            this.btnDeleteCacheMemory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCacheMemory.Name = "btnDeleteCacheMemory";
            this.btnDeleteCacheMemory.Size = new System.Drawing.Size(200, 84);
            this.btnDeleteCacheMemory.TabIndex = 4;
            this.btnDeleteCacheMemory.Text = "Delete Cache Memory";
            this.btnDeleteCacheMemory.UseVisualStyleBackColor = false;
            this.btnDeleteCacheMemory.Click += new System.EventHandler(this.btnDeleteCacheMemory_Click);
            // 
            // btnPrefetch
            // 
            this.btnPrefetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnPrefetch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrefetch.FlatAppearance.BorderSize = 0;
            this.btnPrefetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPrefetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrefetch.ForeColor = System.Drawing.Color.White;
            this.btnPrefetch.Location = new System.Drawing.Point(0, 84);
            this.btnPrefetch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrefetch.Name = "btnPrefetch";
            this.btnPrefetch.Size = new System.Drawing.Size(200, 84);
            this.btnPrefetch.TabIndex = 3;
            this.btnPrefetch.Text = "Prefetch";
            this.btnPrefetch.UseVisualStyleBackColor = false;
            this.btnPrefetch.Click += new System.EventHandler(this.btnPrefetch_Click);
            // 
            // btnCleanManager
            // 
            this.btnCleanManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnCleanManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCleanManager.FlatAppearance.BorderSize = 0;
            this.btnCleanManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCleanManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanManager.ForeColor = System.Drawing.Color.White;
            this.btnCleanManager.Location = new System.Drawing.Point(0, 0);
            this.btnCleanManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanManager.Name = "btnCleanManager";
            this.btnCleanManager.Size = new System.Drawing.Size(200, 84);
            this.btnCleanManager.TabIndex = 2;
            this.btnCleanManager.Text = "Clean Manager";
            this.btnCleanManager.UseVisualStyleBackColor = false;
            this.btnCleanManager.Click += new System.EventHandler(this.btnCleanManager_Click);
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.btnPreformanceInfo);
            this.panelView.Controls.Add(this.btnComputerDetails);
            this.panelView.Controls.Add(this.labelTitle);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(200, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(250, 418);
            this.panelView.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(43, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Utility Preformance Tool";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.UseWaitCursor = true;
            // 
            // btnComputerDetails
            // 
            this.btnComputerDetails.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnComputerDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnComputerDetails.FlatAppearance.BorderSize = 0;
            this.btnComputerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputerDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnComputerDetails.Location = new System.Drawing.Point(0, 383);
            this.btnComputerDetails.Name = "btnComputerDetails";
            this.btnComputerDetails.Size = new System.Drawing.Size(250, 35);
            this.btnComputerDetails.TabIndex = 2;
            this.btnComputerDetails.Text = "Computer Details";
            this.btnComputerDetails.UseVisualStyleBackColor = false;
            this.btnComputerDetails.Click += new System.EventHandler(this.btnComputerDetails_Click);
            // 
            // btnPreformanceInfo
            // 
            this.btnPreformanceInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPreformanceInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPreformanceInfo.FlatAppearance.BorderSize = 0;
            this.btnPreformanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreformanceInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreformanceInfo.Location = new System.Drawing.Point(0, 348);
            this.btnPreformanceInfo.Name = "btnPreformanceInfo";
            this.btnPreformanceInfo.Size = new System.Drawing.Size(250, 35);
            this.btnPreformanceInfo.TabIndex = 3;
            this.btnPreformanceInfo.Text = "Preformance Info";
            this.btnPreformanceInfo.UseVisualStyleBackColor = false;
            this.btnPreformanceInfo.Click += new System.EventHandler(this.btnPreformanceInfo_Click);
            // 
            // UToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(450, 418);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utility Tool";
            this.panelSideMenu.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnDeleteCacheMemory;
        private System.Windows.Forms.Button btnPrefetch;
        private System.Windows.Forms.Button btnCleanManager;
        private System.Windows.Forms.Button btnDefrag;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnDeleteTempFiles;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnComputerDetails;
        private System.Windows.Forms.Button btnPreformanceInfo;
    }
}

