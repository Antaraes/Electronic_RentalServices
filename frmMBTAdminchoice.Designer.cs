
namespace RentalService
{
    partial class frmMBTadminchoice
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnViewCust = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Black;
            this.btnAddItem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItem.Location = new System.Drawing.Point(356, 139);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(158, 44);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Items";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnViewCust
            // 
            this.btnViewCust.BackColor = System.Drawing.Color.Black;
            this.btnViewCust.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCust.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewCust.Location = new System.Drawing.Point(633, 139);
            this.btnViewCust.Name = "btnViewCust";
            this.btnViewCust.Size = new System.Drawing.Size(169, 43);
            this.btnViewCust.TabIndex = 1;
            this.btnViewCust.Text = "View Customers Record";
            this.btnViewCust.UseVisualStyleBackColor = false;
            this.btnViewCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(464, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "WELCOME TO ADMIN";
            // 
            // frmMBTadminchoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1286, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnViewCust);
            this.Controls.Add(this.btnAddItem);
            this.Name = "frmMBTadminchoice";
            this.Text = "frmadminchoice";
            this.Load += new System.EventHandler(this.frmadminchoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnViewCust;
        private System.Windows.Forms.Label label4;
    }
}