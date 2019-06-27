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
            this.SuspendLayout();
            // 
            // totalTxtLabel
            // 
            this.totalTxtLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtLabel.Location = new System.Drawing.Point(3, 59);
            this.totalTxtLabel.Name = "totalTxtLabel";
            this.totalTxtLabel.Size = new System.Drawing.Size(530, 55);
            this.totalTxtLabel.TabIndex = 0;
            this.totalTxtLabel.Text = "Total";
            this.totalTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(3, 114);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(530, 55);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "$150.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMadeTxtLabel
            // 
            this.totalMadeTxtLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMadeTxtLabel.Location = new System.Drawing.Point(10, 230);
            this.totalMadeTxtLabel.Name = "totalMadeTxtLabel";
            this.totalMadeTxtLabel.Size = new System.Drawing.Size(255, 49);
            this.totalMadeTxtLabel.TabIndex = 2;
            this.totalMadeTxtLabel.Text = "Total Made";
            this.totalMadeTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpentTxtLabel
            // 
            this.totalSpentTxtLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpentTxtLabel.Location = new System.Drawing.Point(278, 230);
            this.totalSpentTxtLabel.Name = "totalSpentTxtLabel";
            this.totalSpentTxtLabel.Size = new System.Drawing.Size(255, 49);
            this.totalSpentTxtLabel.TabIndex = 3;
            this.totalSpentTxtLabel.Text = "Total Spent";
            this.totalSpentTxtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMadeLabel
            // 
            this.totalMadeLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMadeLabel.Location = new System.Drawing.Point(10, 279);
            this.totalMadeLabel.Name = "totalMadeLabel";
            this.totalMadeLabel.Size = new System.Drawing.Size(255, 49);
            this.totalMadeLabel.TabIndex = 4;
            this.totalMadeLabel.Text = "Total Made";
            this.totalMadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSpentLabel
            // 
            this.totalSpentLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpentLabel.Location = new System.Drawing.Point(278, 279);
            this.totalSpentLabel.Name = "totalSpentLabel";
            this.totalSpentLabel.Size = new System.Drawing.Size(255, 49);
            this.totalSpentLabel.TabIndex = 5;
            this.totalSpentLabel.Text = "Total Spent";
            this.totalSpentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.totalSpentLabel);
            this.Controls.Add(this.totalMadeLabel);
            this.Controls.Add(this.totalSpentTxtLabel);
            this.Controls.Add(this.totalMadeTxtLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTxtLabel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(536, 457);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalTxtLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalMadeTxtLabel;
        private System.Windows.Forms.Label totalSpentTxtLabel;
        private System.Windows.Forms.Label totalMadeLabel;
        private System.Windows.Forms.Label totalSpentLabel;
    }
}
