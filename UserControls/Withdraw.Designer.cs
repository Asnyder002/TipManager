namespace TipManager.UserControls
{
    partial class Withdraw
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
            this.cancelButtonWithdraw = new System.Windows.Forms.Button();
            this.deleteButtonWithdraw = new System.Windows.Forms.Button();
            this.saveButtonWithdraw = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.withdrawDateLabel = new System.Windows.Forms.Label();
            this.spentLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.withdrawDateTextBox = new System.Windows.Forms.TextBox();
            this.spentTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewWithdraw = new System.Windows.Forms.DataGridView();
            this.DepositID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithdraw)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButtonWithdraw
            // 
            this.cancelButtonWithdraw.BackColor = System.Drawing.Color.LightSlateGray;
            this.cancelButtonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButtonWithdraw.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButtonWithdraw.Location = new System.Drawing.Point(31, 404);
            this.cancelButtonWithdraw.Name = "cancelButtonWithdraw";
            this.cancelButtonWithdraw.Size = new System.Drawing.Size(167, 39);
            this.cancelButtonWithdraw.TabIndex = 19;
            this.cancelButtonWithdraw.Text = "Cancel";
            this.cancelButtonWithdraw.UseVisualStyleBackColor = false;
            // 
            // deleteButtonWithdraw
            // 
            this.deleteButtonWithdraw.BackColor = System.Drawing.Color.LightSlateGray;
            this.deleteButtonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButtonWithdraw.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButtonWithdraw.Location = new System.Drawing.Point(31, 347);
            this.deleteButtonWithdraw.Name = "deleteButtonWithdraw";
            this.deleteButtonWithdraw.Size = new System.Drawing.Size(167, 39);
            this.deleteButtonWithdraw.TabIndex = 18;
            this.deleteButtonWithdraw.Text = "Delete";
            this.deleteButtonWithdraw.UseVisualStyleBackColor = false;
            // 
            // saveButtonWithdraw
            // 
            this.saveButtonWithdraw.BackColor = System.Drawing.Color.LightSlateGray;
            this.saveButtonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButtonWithdraw.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtonWithdraw.Location = new System.Drawing.Point(31, 286);
            this.saveButtonWithdraw.Name = "saveButtonWithdraw";
            this.saveButtonWithdraw.Size = new System.Drawing.Size(167, 39);
            this.saveButtonWithdraw.TabIndex = 17;
            this.saveButtonWithdraw.Text = "Save";
            this.saveButtonWithdraw.UseVisualStyleBackColor = false;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(70, 187);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(88, 18);
            this.categoryLabel.TabIndex = 16;
            this.categoryLabel.Text = "Category:";
            // 
            // withdrawDateLabel
            // 
            this.withdrawDateLabel.AutoSize = true;
            this.withdrawDateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawDateLabel.Location = new System.Drawing.Point(87, 103);
            this.withdrawDateLabel.Name = "withdrawDateLabel";
            this.withdrawDateLabel.Size = new System.Drawing.Size(54, 18);
            this.withdrawDateLabel.TabIndex = 15;
            this.withdrawDateLabel.Text = "Date:";
            // 
            // spentLabel
            // 
            this.spentLabel.AutoSize = true;
            this.spentLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spentLabel.Location = new System.Drawing.Point(83, 24);
            this.spentLabel.Name = "spentLabel";
            this.spentLabel.Size = new System.Drawing.Size(62, 18);
            this.spentLabel.TabIndex = 14;
            this.spentLabel.Text = "Spent:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(31, 217);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(167, 27);
            this.categoryTextBox.TabIndex = 13;
            // 
            // withdrawDateTextBox
            // 
            this.withdrawDateTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawDateTextBox.Location = new System.Drawing.Point(31, 134);
            this.withdrawDateTextBox.Name = "withdrawDateTextBox";
            this.withdrawDateTextBox.Size = new System.Drawing.Size(167, 27);
            this.withdrawDateTextBox.TabIndex = 12;
            // 
            // spentTextBox
            // 
            this.spentTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spentTextBox.Location = new System.Drawing.Point(31, 54);
            this.spentTextBox.Name = "spentTextBox";
            this.spentTextBox.Size = new System.Drawing.Size(167, 27);
            this.spentTextBox.TabIndex = 11;
            // 
            // dataGridViewWithdraw
            // 
            this.dataGridViewWithdraw.AllowUserToDeleteRows = false;
            this.dataGridViewWithdraw.AllowUserToOrderColumns = true;
            this.dataGridViewWithdraw.AllowUserToResizeColumns = false;
            this.dataGridViewWithdraw.AllowUserToResizeRows = false;
            this.dataGridViewWithdraw.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewWithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithdraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepositID,
            this.DepositAmount,
            this.DepositDate,
            this.HoursWorked});
            this.dataGridViewWithdraw.Location = new System.Drawing.Point(225, 15);
            this.dataGridViewWithdraw.Name = "dataGridViewWithdraw";
            this.dataGridViewWithdraw.ReadOnly = true;
            this.dataGridViewWithdraw.Size = new System.Drawing.Size(297, 428);
            this.dataGridViewWithdraw.TabIndex = 10;
            // 
            // DepositID
            // 
            this.DepositID.DataPropertyName = "DepositID";
            this.DepositID.HeaderText = "DepositID";
            this.DepositID.Name = "DepositID";
            this.DepositID.ReadOnly = true;
            this.DepositID.Visible = false;
            // 
            // DepositAmount
            // 
            this.DepositAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepositAmount.DataPropertyName = "DepositAmount";
            this.DepositAmount.HeaderText = "Amount";
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.ReadOnly = true;
            // 
            // DepositDate
            // 
            this.DepositDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepositDate.DataPropertyName = "DepoistDate";
            this.DepositDate.HeaderText = "Date";
            this.DepositDate.Name = "DepositDate";
            this.DepositDate.ReadOnly = true;
            // 
            // HoursWorked
            // 
            this.HoursWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoursWorked.DataPropertyName = "HoursWorked";
            this.HoursWorked.HeaderText = "Hours";
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.ReadOnly = true;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.cancelButtonWithdraw);
            this.Controls.Add(this.deleteButtonWithdraw);
            this.Controls.Add(this.saveButtonWithdraw);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.withdrawDateLabel);
            this.Controls.Add(this.spentLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.withdrawDateTextBox);
            this.Controls.Add(this.spentTextBox);
            this.Controls.Add(this.dataGridViewWithdraw);
            this.Location = new System.Drawing.Point(198, 0);
            this.Name = "Withdraw";
            this.Size = new System.Drawing.Size(536, 457);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithdraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButtonWithdraw;
        private System.Windows.Forms.Button deleteButtonWithdraw;
        private System.Windows.Forms.Button saveButtonWithdraw;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label withdrawDateLabel;
        private System.Windows.Forms.Label spentLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox withdrawDateTextBox;
        private System.Windows.Forms.TextBox spentTextBox;
        private System.Windows.Forms.DataGridView dataGridViewWithdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
    }
}
