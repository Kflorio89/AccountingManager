
namespace AccountingManager
{
    partial class MainPage
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
            this._txtBillOverview = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSummary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._btnAddBill = new System.Windows.Forms.Button();
            this._txtNewBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtBillOverview
            // 
            this._txtBillOverview.Location = new System.Drawing.Point(12, 156);
            this._txtBillOverview.Multiline = true;
            this._txtBillOverview.Name = "_txtBillOverview";
            this._txtBillOverview.Size = new System.Drawing.Size(759, 747);
            this._txtBillOverview.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(964, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Summary";
            // 
            // _txtSummary
            // 
            this._txtSummary.Location = new System.Drawing.Point(803, 156);
            this._txtSummary.Multiline = true;
            this._txtSummary.Name = "_txtSummary";
            this._txtSummary.Size = new System.Drawing.Size(398, 195);
            this._txtSummary.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Overview of Bills";
            // 
            // _btnAddBill
            // 
            this._btnAddBill.Location = new System.Drawing.Point(1102, 542);
            this._btnAddBill.Name = "_btnAddBill";
            this._btnAddBill.Size = new System.Drawing.Size(78, 30);
            this._btnAddBill.TabIndex = 7;
            this._btnAddBill.Text = "Add";
            this._btnAddBill.UseVisualStyleBackColor = true;
            this._btnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // _txtNewBill
            // 
            this._txtNewBill.Location = new System.Drawing.Point(803, 546);
            this._txtNewBill.Name = "_txtNewBill";
            this._txtNewBill.Size = new System.Drawing.Size(280, 26);
            this._txtNewBill.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add New Bill";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(1468, 851);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(120, 52);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save Shit";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtNewBill);
            this.Controls.Add(this._btnAddBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtBillOverview);
            this.Name = "MainPage";
            this.Text = "Accounting Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtBillOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnAddBill;
        private System.Windows.Forms.TextBox _txtNewBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnSave;
    }
}

