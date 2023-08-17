
namespace RentalService
{
	partial class frmMBTItemCreation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnExit = new System.Windows.Forms.Button();
            this.cboAppliances = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.Dimension = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonthlyFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinContractPeriod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1375, 479);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // cboAppliances
            // 
            this.cboAppliances.FormattingEnabled = true;
            this.cboAppliances.Items.AddRange(new object[] {
            "Refrigerators",
            "Washing Machines",
            "Air Conditioners",
            "TV",
            "Dishwasher"});
            this.cboAppliances.Location = new System.Drawing.Point(33, 53);
            this.cboAppliances.Margin = new System.Windows.Forms.Padding(4);
            this.cboAppliances.Name = "cboAppliances";
            this.cboAppliances.Size = new System.Drawing.Size(260, 24);
            this.cboAppliances.TabIndex = 11;
            this.cboAppliances.Text = "Microwave";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Choose One Type";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(44, 469);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(141, 47);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "Refresh";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNewClick);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(223, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(157, 25);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID=";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(213, 469);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(139, 49);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsertClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(383, 469);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 48);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(544, 471);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 44);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // rdoYes
            // 
            this.rdoYes.Checked = true;
            this.rdoYes.Location = new System.Drawing.Point(21, 30);
            this.rdoYes.Margin = new System.Windows.Forms.Padding(4);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(105, 46);
            this.rdoYes.TabIndex = 26;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNo);
            this.groupBox1.Controls.Add(this.rdoYes);
            this.groupBox1.Location = new System.Drawing.Point(383, 296);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(183, 103);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available";
            // 
            // rdoNo
            // 
            this.rdoNo.Location = new System.Drawing.Point(103, 34);
            this.rdoNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(72, 36);
            this.rdoNo.TabIndex = 27;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(699, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(760, 389);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(452, 9);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(239, 39);
            this.lblMessage.TabIndex = 29;
            this.lblMessage.Text = "Status=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 22);
            this.txtName.TabIndex = 31;
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(33, 177);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.Size = new System.Drawing.Size(260, 22);
            this.txtDimensions.TabIndex = 33;
            // 
            // Dimension
            // 
            this.Dimension.AutoSize = true;
            this.Dimension.Location = new System.Drawing.Point(32, 156);
            this.Dimension.Name = "Dimension";
            this.Dimension.Size = new System.Drawing.Size(71, 16);
            this.Dimension.TabIndex = 32;
            this.Dimension.Text = "Dimension";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(33, 238);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(260, 22);
            this.txtCapacity.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Capacity";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(33, 296);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(260, 22);
            this.txtColour.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Colour ";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(33, 364);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(260, 22);
            this.txtRating.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Rating ";
            // 
            // txtMonthlyFee
            // 
            this.txtMonthlyFee.Location = new System.Drawing.Point(369, 55);
            this.txtMonthlyFee.Name = "txtMonthlyFee";
            this.txtMonthlyFee.Size = new System.Drawing.Size(260, 22);
            this.txtMonthlyFee.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "MonthlyFee";
            // 
            // txtMinContractPeriod
            // 
            this.txtMinContractPeriod.Location = new System.Drawing.Point(369, 113);
            this.txtMinContractPeriod.Name = "txtMinContractPeriod";
            this.txtMinContractPeriod.Size = new System.Drawing.Size(260, 22);
            this.txtMinContractPeriod.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "MinContractPeriod";
            // 
            // frmMBTItemCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 530);
            this.Controls.Add(this.txtMinContractPeriod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMonthlyFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDimensions);
            this.Controls.Add(this.Dimension);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAppliances);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMBTItemCreation";
            this.Text = "Rental Service Admin";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cboAppliances;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.RadioButton rdoYes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Label Dimension;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonthlyFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinContractPeriod;
        private System.Windows.Forms.Label label7;
    }
}
