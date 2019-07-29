namespace TipManager.UserControls
{
    partial class AddTip
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
            this.dataGridViewAddTip = new System.Windows.Forms.DataGridView();
            this.DepositID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTip)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddTip
            // 
            this.dataGridViewAddTip.AllowUserToDeleteRows = false;
            this.dataGridViewAddTip.AllowUserToOrderColumns = true;
            this.dataGridViewAddTip.AllowUserToResizeColumns = false;
            this.dataGridViewAddTip.AllowUserToResizeRows = false;
            this.dataGridViewAddTip.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAddTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddTip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepositID,
            this.DepositAmount,
            this.DepositDate,
            this.HoursWorked});
            this.dataGridViewAddTip.Location = new System.Drawing.Point(225, 15);
            this.dataGridViewAddTip.Name = "dataGridViewAddTip";
            this.dataGridViewAddTip.ReadOnly = true;
            this.dataGridViewAddTip.Size = new System.Drawing.Size(297, 428);
            this.dataGridViewAddTip.TabIndex = 0;
            this.dataGridViewAddTip.DoubleClick += new System.EventHandler(this.DataGridViewAddTip_DoubleClick);
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
            // tipTextBox
            // 
            this.tipTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipTextBox.Location = new System.Drawing.Point(31, 54);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(167, 27);
            this.tipTextBox.TabIndex = 1;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(31, 134);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(167, 27);
            this.dateTextBox.TabIndex = 2;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(31, 217);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(167, 27);
            this.hoursWorkedTextBox.TabIndex = 3;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(60, 24);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(109, 18);
            this.tipLabel.TabIndex = 4;
            this.tipLabel.Text = "Tip Amount:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(87, 103);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(54, 18);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Date:";
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedLabel.Location = new System.Drawing.Point(50, 187);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(129, 18);
            this.hoursWorkedLabel.TabIndex = 6;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(31, 286);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 39);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(31, 347);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 39);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(31, 404);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 39);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.dataGridViewAddTip);
            this.Location = new System.Drawing.Point(198, 0);
            this.Name = "AddTip";
            this.Size = new System.Drawing.Size(536, 457);
            this.Load += new System.EventHandler(this.AddTip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddTip;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
    }
}
