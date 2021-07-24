
namespace UTool
{
    partial class Form2
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCDrive = new System.Windows.Forms.Button();
            this.btnDDrive = new System.Windows.Forms.Button();
            this.btnEDrive = new System.Windows.Forms.Button();
            this.btnFDrive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(258, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCDrive
            // 
            this.btnCDrive.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCDrive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCDrive.FlatAppearance.BorderSize = 0;
            this.btnCDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDrive.Location = new System.Drawing.Point(0, 348);
            this.btnCDrive.Name = "btnCDrive";
            this.btnCDrive.Size = new System.Drawing.Size(258, 74);
            this.btnCDrive.TabIndex = 1;
            this.btnCDrive.Text = "C:/";
            this.btnCDrive.UseVisualStyleBackColor = false;
            this.btnCDrive.Click += new System.EventHandler(this.btnCDrive_Click);
            // 
            // btnDDrive
            // 
            this.btnDDrive.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDDrive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDDrive.FlatAppearance.BorderSize = 0;
            this.btnDDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDDrive.Location = new System.Drawing.Point(0, 274);
            this.btnDDrive.Name = "btnDDrive";
            this.btnDDrive.Size = new System.Drawing.Size(258, 74);
            this.btnDDrive.TabIndex = 2;
            this.btnDDrive.Text = "D:/";
            this.btnDDrive.UseVisualStyleBackColor = false;
            this.btnDDrive.Click += new System.EventHandler(this.btnDDrive_Click);
            // 
            // btnEDrive
            // 
            this.btnEDrive.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEDrive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEDrive.FlatAppearance.BorderSize = 0;
            this.btnEDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDrive.Location = new System.Drawing.Point(0, 200);
            this.btnEDrive.Name = "btnEDrive";
            this.btnEDrive.Size = new System.Drawing.Size(258, 74);
            this.btnEDrive.TabIndex = 3;
            this.btnEDrive.Text = "E:/";
            this.btnEDrive.UseVisualStyleBackColor = false;
            this.btnEDrive.Click += new System.EventHandler(this.btnEDrive_Click);
            // 
            // btnFDrive
            // 
            this.btnFDrive.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFDrive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFDrive.FlatAppearance.BorderSize = 0;
            this.btnFDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFDrive.Location = new System.Drawing.Point(0, 126);
            this.btnFDrive.Name = "btnFDrive";
            this.btnFDrive.Size = new System.Drawing.Size(258, 74);
            this.btnFDrive.TabIndex = 4;
            this.btnFDrive.Text = "F:/";
            this.btnFDrive.UseVisualStyleBackColor = false;
            this.btnFDrive.Click += new System.EventHandler(this.btnFDrive_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(258, 422);
            this.Controls.Add(this.btnFDrive);
            this.Controls.Add(this.btnEDrive);
            this.Controls.Add(this.btnDDrive);
            this.Controls.Add(this.btnCDrive);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCDrive;
        private System.Windows.Forms.Button btnDDrive;
        private System.Windows.Forms.Button btnEDrive;
        private System.Windows.Forms.Button btnFDrive;
    }
}