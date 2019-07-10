namespace TipManager.UserControls
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalTxtLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalMadeTxtLabel = new System.Windows.Forms.Label();
            this.totalSpentTxtLabel = new System.Windows.Forms.Label();
            this.totalMadeLabel = new System.Windows.Forms.Label();
            this.totalSpentLabel = new System.Windows.Forms.Label();
            this.totalPanel = new System.Windows.Forms.Panel();
            this.totalMadePanel = new System.Windows.Forms.Panel();
            this.totalSpentPanel = new System.Windows.Forms.Panel();
            this.totalHoursPanel = new System.Windows.Forms.Panel();
            this.totalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.totalHoursTxtLabel = new System.Windows.Forms.Label();
            this.totalPanel.SuspendLayout();
            this.totalMadePanel.SuspendLayout();
            this.totalSpentPanel.SuspendLayout();
            this.totalHoursPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalTxtLabel
            // 
            this.totalTxtLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtLabel.Location = new System.Drawing.Point(19, 21);
            this.totalTxtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTxtLabel.Name = "totalTxtLabel";
            this.totalTxtLabel.Size = new System.Drawing.Size(447, 68);
            this.totalTxtLabel.TabIndex = 0;
            this.totalTxtLabel.Text = "Total";
            this.totalTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(9, 89);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(456, 68);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "$150.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMadeTxtLabel
            // 
            this.totalMadeTxtLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMadeTxtLabel.Location = new System.Drawing.Point(4, 14);
            this.totalMadeTxtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalMadeTxtLabel.Name = "totalMadeTxtLabel";
            this.totalMadeTxtLabel.Size = new System.Drawing.Size(324, 60);
            this.totalMadeTxtLabel.TabIndex = 2;
            this.totalMadeTxtLabel.Text = "Total Made";
            this.totalMadeTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpentTxtLabel
            // 
            this.totalSpentTxtLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpentTxtLabel.Location = new System.Drawing.Point(4, 14);
            this.totalSpentTxtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSpentTxtLabel.Name = "totalSpentTxtLabel";
            this.totalSpentTxtLabel.Size = new System.Drawing.Size(324, 60);
            this.totalSpentTxtLabel.TabIndex = 3;
            this.totalSpentTxtLabel.Text = "Total Spent";
            this.totalSpentTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMadeLabel
            // 
            this.totalMadeLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMadeLabel.Location = new System.Drawing.Point(4, 74);
            this.totalMadeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalMadeLabel.Name = "totalMadeLabel";
            this.totalMadeLabel.Size = new System.Drawing.Size(324, 60);
            this.totalMadeLabel.TabIndex = 4;
            this.totalMadeLabel.Text = "$300.00";
            this.totalMadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpentLabel
            // 
            this.totalSpentLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpentLabel.Location = new System.Drawing.Point(4, 74);
            this.totalSpentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSpentLabel.Name = "totalSpentLabel";
            this.totalSpentLabel.Size = new System.Drawing.Size(324, 60);
            this.totalSpentLabel.TabIndex = 5;
            this.totalSpentLabel.Text = "$150.00";
            this.totalSpentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPanel
            // 
            this.totalPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalPanel.Controls.Add(this.totalTxtLabel);
            this.totalPanel.Controls.Add(this.totalLabel);
            this.totalPanel.Location = new System.Drawing.Point(115, 49);
            this.totalPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(481, 169);
            this.totalPanel.TabIndex = 6;
            // 
            // totalMadePanel
            // 
            this.totalMadePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalMadePanel.Controls.Add(this.totalMadeTxtLabel);
            this.totalMadePanel.Controls.Add(this.totalMadeLabel);
            this.totalMadePanel.Location = new System.Drawing.Point(17, 245);
            this.totalMadePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalMadePanel.Name = "totalMadePanel";
            this.totalMadePanel.Size = new System.Drawing.Size(332, 159);
            this.totalMadePanel.TabIndex = 7;
            // 
            // totalSpentPanel
            // 
            this.totalSpentPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalSpentPanel.Controls.Add(this.totalSpentTxtLabel);
            this.totalSpentPanel.Controls.Add(this.totalSpentLabel);
            this.totalSpentPanel.Location = new System.Drawing.Point(357, 245);
            this.totalSpentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalSpentPanel.Name = "totalSpentPanel";
            this.totalSpentPanel.Size = new System.Drawing.Size(332, 159);
            this.totalSpentPanel.TabIndex = 5;
            // 
            // totalHoursPanel
            // 
            this.totalHoursPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalHoursPanel.Controls.Add(this.totalHoursWorkedLabel);
            this.totalHoursPanel.Controls.Add(this.totalHoursTxtLabel);
            this.totalHoursPanel.Location = new System.Drawing.Point(143, 425);
            this.totalHoursPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalHoursPanel.Name = "totalHoursPanel";
            this.totalHoursPanel.Size = new System.Drawing.Size(437, 123);
            this.totalHoursPanel.TabIndex = 8;
            // 
            // totalHoursWorkedLabel
            // 
            this.totalHoursWorkedLabel.AutoSize = true;
            this.totalHoursWorkedLabel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursWorkedLabel.Location = new System.Drawing.Point(181, 64);
            this.totalHoursWorkedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalHoursWorkedLabel.Name = "totalHoursWorkedLabel";
            this.totalHoursWorkedLabel.Size = new System.Drawing.Size(68, 45);
            this.totalHoursWorkedLabel.TabIndex = 1;
            this.totalHoursWorkedLabel.Text = "25";
            // 
            // totalHoursTxtLabel
            // 
            this.totalHoursTxtLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursTxtLabel.Location = new System.Drawing.Point(64, 17);
            this.totalHoursTxtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalHoursTxtLabel.Name = "totalHoursTxtLabel";
            this.totalHoursTxtLabel.Size = new System.Drawing.Size(296, 47);
            this.totalHoursTxtLabel.TabIndex = 0;
            this.totalHoursTxtLabel.Text = "Total Hours";
            this.totalHoursTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.totalHoursPanel);
            this.Controls.Add(this.totalSpentPanel);
            this.Controls.Add(this.totalMadePanel);
            this.Controls.Add(this.totalPanel);
            this.Location = new System.Drawing.Point(198, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(715, 562);
            this.Load += new System.EventHandler(this.Home_Load);
            this.totalPanel.ResumeLayout(false);
            this.totalMadePanel.ResumeLayout(false);
            this.totalSpentPanel.ResumeLayout(false);
            this.totalHoursPanel.ResumeLayout(false);
            this.totalHoursPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalTxtLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalMadeTxtLabel;
        private System.Windows.Forms.Label totalSpentTxtLabel;
        private System.Windows.Forms.Label totalMadeLabel;
        private System.Windows.Forms.Label totalSpentLabel;
        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.Panel totalMadePanel;
        private System.Windows.Forms.Panel totalSpentPanel;
        private System.Windows.Forms.Panel totalHoursPanel;
        private System.Windows.Forms.Label totalHoursWorkedLabel;
        private System.Windows.Forms.Label totalHoursTxtLabel;

       

    }
}
