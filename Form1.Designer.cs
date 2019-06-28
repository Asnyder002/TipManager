namespace TipManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navPanel = new System.Windows.Forms.Panel();
            this.homeControl = new TipManager.UserControls.Home();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeButton.Location = new System.Drawing.Point(0, 106);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(198, 72);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addButton.Location = new System.Drawing.Point(0, 181);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(198, 72);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Tip";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.subtractButton.FlatAppearance.BorderSize = 0;
            this.subtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.ForeColor = System.Drawing.Color.White;
            this.subtractButton.Image = ((System.Drawing.Image)(resources.GetObject("subtractButton.Image")));
            this.subtractButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtractButton.Location = new System.Drawing.Point(0, 256);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(198, 72);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "Transaction";
            this.subtractButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.subtractButton.UseVisualStyleBackColor = false;
            // 
            // analysisButton
            // 
            this.analysisButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.analysisButton.FlatAppearance.BorderSize = 0;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisButton.ForeColor = System.Drawing.Color.White;
            this.analysisButton.Image = ((System.Drawing.Image)(resources.GetObject("analysisButton.Image")));
            this.analysisButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.analysisButton.Location = new System.Drawing.Point(0, 331);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(198, 72);
            this.analysisButton.TabIndex = 3;
            this.analysisButton.Text = "Analysis";
            this.analysisButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.analysisButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.navPanel.Controls.Add(this.pictureBox1);
            this.navPanel.Controls.Add(this.analysisButton);
            this.navPanel.Controls.Add(this.subtractButton);
            this.navPanel.Controls.Add(this.addButton);
            this.navPanel.Controls.Add(this.homeButton);
            this.navPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(198, 457);
            this.navPanel.TabIndex = 1;
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.homeControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.homeControl.Location = new System.Drawing.Point(198, 0);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(536, 457);
            this.homeControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 457);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel navPanel;
        private UserControls.Home homeControl;
    }
}

