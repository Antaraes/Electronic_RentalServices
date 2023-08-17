
namespace RentalService
{
    partial class frmMBTRentalForm
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
            this.lstAppliances = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnRentalOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rtbOrderInfo = new System.Windows.Forms.RichTextBox();
            this.lstItemName = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.txtCapcityKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDimensionKey = new System.Windows.Forms.TextBox();
            this.txtColorKey = new System.Windows.Forms.TextBox();
            this.txtRateKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonthlyKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAppliances
            // 
            this.lstAppliances.FormattingEnabled = true;
            this.lstAppliances.ItemHeight = 16;
            this.lstAppliances.Location = new System.Drawing.Point(19, 44);
            this.lstAppliances.Margin = new System.Windows.Forms.Padding(4);
            this.lstAppliances.Name = "lstAppliances";
            this.lstAppliances.Size = new System.Drawing.Size(244, 100);
            this.lstAppliances.TabIndex = 0;
            this.lstAppliances.SelectedIndexChanged += new System.EventHandler(this.lstAppliances_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose an Appliance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(973, 224);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(779, 11);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 16);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name=";
            // 
            // btnRentalOrder
            // 
            this.btnRentalOrder.BackColor = System.Drawing.Color.Black;
            this.btnRentalOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnRentalOrder.Location = new System.Drawing.Point(19, 803);
            this.btnRentalOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentalOrder.Name = "btnRentalOrder";
            this.btnRentalOrder.Size = new System.Drawing.Size(123, 63);
            this.btnRentalOrder.TabIndex = 5;
            this.btnRentalOrder.Text = "Place Order";
            this.btnRentalOrder.UseVisualStyleBackColor = false;
            this.btnRentalOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(948, 811);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(347, 811);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 55);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // rtbOrderInfo
            // 
            this.rtbOrderInfo.Location = new System.Drawing.Point(621, 516);
            this.rtbOrderInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOrderInfo.Name = "rtbOrderInfo";
            this.rtbOrderInfo.Size = new System.Drawing.Size(365, 211);
            this.rtbOrderInfo.TabIndex = 10;
            this.rtbOrderInfo.Text = "";
            // 
            // lstItemName
            // 
            this.lstItemName.FormattingEnabled = true;
            this.lstItemName.ItemHeight = 16;
            this.lstItemName.Location = new System.Drawing.Point(19, 516);
            this.lstItemName.Margin = new System.Windows.Forms.Padding(4);
            this.lstItemName.Name = "lstItemName";
            this.lstItemName.Size = new System.Drawing.Size(484, 212);
            this.lstItemName.TabIndex = 11;
            this.lstItemName.SelectedIndexChanged += new System.EventHandler(this.lstItemName_SelectedIndexChanged);
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.ItemHeight = 16;
            this.lstPrice.Location = new System.Drawing.Point(512, 516);
            this.lstPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(80, 100);
            this.lstPrice.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 71);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(563, 71);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Return Date";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrder.Location = new System.Drawing.Point(188, 803);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(123, 63);
            this.btnConfirmOrder.TabIndex = 17;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // txtCapcityKeyword
            // 
            this.txtCapcityKeyword.Location = new System.Drawing.Point(19, 201);
            this.txtCapcityKeyword.Name = "txtCapcityKeyword";
            this.txtCapcityKeyword.Size = new System.Drawing.Size(112, 22);
            this.txtCapcityKeyword.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(639, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(403, 735);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 738);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Capacity";
            // 
            // txtDimensionKey
            // 
            this.txtDimensionKey.Location = new System.Drawing.Point(157, 201);
            this.txtDimensionKey.Name = "txtDimensionKey";
            this.txtDimensionKey.Size = new System.Drawing.Size(97, 22);
            this.txtDimensionKey.TabIndex = 23;
            // 
            // txtColorKey
            // 
            this.txtColorKey.Location = new System.Drawing.Point(278, 204);
            this.txtColorKey.Name = "txtColorKey";
            this.txtColorKey.Size = new System.Drawing.Size(94, 22);
            this.txtColorKey.TabIndex = 24;
            // 
            // txtRateKey
            // 
            this.txtRateKey.Location = new System.Drawing.Point(403, 203);
            this.txtRateKey.Name = "txtRateKey";
            this.txtRateKey.Size = new System.Drawing.Size(100, 22);
            this.txtRateKey.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Dimension";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Rates";
            // 
            // txtMonthlyKey
            // 
            this.txtMonthlyKey.Location = new System.Drawing.Point(533, 204);
            this.txtMonthlyKey.Name = "txtMonthlyKey";
            this.txtMonthlyKey.Size = new System.Drawing.Size(100, 22);
            this.txtMonthlyKey.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Monthly Fee";
            // 
            // frmMBTRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 895);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMonthlyKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRateKey);
            this.Controls.Add(this.txtColorKey);
            this.Controls.Add(this.txtDimensionKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCapcityKeyword);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.lstItemName);
            this.Controls.Add(this.rtbOrderInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRentalOrder);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAppliances);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMBTRentalForm";
            this.Text = "frmRentalForm";
            this.Load += new System.EventHandler(this.frmRentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAppliances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnRentalOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.RichTextBox rtbOrderInfo;
        private System.Windows.Forms.ListBox lstItemName;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.TextBox txtCapcityKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDimensionKey;
        private System.Windows.Forms.TextBox txtColorKey;
        private System.Windows.Forms.TextBox txtRateKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonthlyKey;
        private System.Windows.Forms.Label label9;
    }
}