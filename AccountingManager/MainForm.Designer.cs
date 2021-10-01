
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
            this._txtExpenses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSummary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._btnAddBill = new System.Windows.Forms.Button();
            this._txtNewBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtNewIncome = new System.Windows.Forms.TextBox();
            this._btnAddIncome = new System.Windows.Forms.Button();
            this._txtExpensesAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _txtExpenses
            // 
            this._txtExpenses.BackColor = System.Drawing.Color.DarkGray;
            this._txtExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExpenses.Location = new System.Drawing.Point(12, 155);
            this._txtExpenses.Multiline = true;
            this._txtExpenses.Name = "_txtExpenses";
            this._txtExpenses.ReadOnly = true;
            this._txtExpenses.Size = new System.Drawing.Size(250, 747);
            this._txtExpenses.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(908, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Summary";
            // 
            // _txtSummary
            // 
            this._txtSummary.BackColor = System.Drawing.Color.DarkGray;
            this._txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSummary.Location = new System.Drawing.Point(774, 571);
            this._txtSummary.Multiline = true;
            this._txtSummary.Name = "_txtSummary";
            this._txtSummary.ReadOnly = true;
            this._txtSummary.Size = new System.Drawing.Size(398, 178);
            this._txtSummary.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(314, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Overview of Bills";
            // 
            // _btnAddBill
            // 
            this._btnAddBill.BackColor = System.Drawing.Color.Gray;
            this._btnAddBill.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddBill.Location = new System.Drawing.Point(1062, 777);
            this._btnAddBill.Name = "_btnAddBill";
            this._btnAddBill.Size = new System.Drawing.Size(78, 52);
            this._btnAddBill.TabIndex = 2;
            this._btnAddBill.Text = "Add";
            this._btnAddBill.UseVisualStyleBackColor = false;
            this._btnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // _txtNewBill
            // 
            this._txtNewBill.BackColor = System.Drawing.Color.DarkGray;
            this._txtNewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNewBill.Location = new System.Drawing.Point(774, 786);
            this._txtNewBill.Name = "_txtNewBill";
            this._txtNewBill.Size = new System.Drawing.Size(280, 30);
            this._txtNewBill.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(897, 754);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add New Bill";
            // 
            // _btnSave
            // 
            this._btnSave.BackColor = System.Drawing.Color.Gray;
            this._btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSave.Location = new System.Drawing.Point(1468, 851);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(120, 52);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save Shit";
            this._btnSave.UseVisualStyleBackColor = false;
            this._btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.Color.DarkGray;
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.Location = new System.Drawing.Point(503, 155);
            this.txtIncome.Multiline = true;
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.ReadOnly = true;
            this.txtIncome.Size = new System.Drawing.Size(250, 747);
            this.txtIncome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(849, 832);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Add New Income";
            // 
            // _txtNewIncome
            // 
            this._txtNewIncome.BackColor = System.Drawing.Color.DarkGray;
            this._txtNewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNewIncome.Location = new System.Drawing.Point(774, 865);
            this._txtNewIncome.Name = "_txtNewIncome";
            this._txtNewIncome.Size = new System.Drawing.Size(280, 30);
            this._txtNewIncome.TabIndex = 13;
            // 
            // _btnAddIncome
            // 
            this._btnAddIncome.BackColor = System.Drawing.Color.Gray;
            this._btnAddIncome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddIncome.Location = new System.Drawing.Point(1062, 855);
            this._btnAddIncome.Name = "_btnAddIncome";
            this._btnAddIncome.Size = new System.Drawing.Size(78, 52);
            this._btnAddIncome.TabIndex = 14;
            this._btnAddIncome.Text = "Add";
            this._btnAddIncome.UseVisualStyleBackColor = false;
            this._btnAddIncome.Click += new System.EventHandler(this.BtnAddIncome_Click);
            // 
            // _txtExpensesAmount
            // 
            this._txtExpensesAmount.BackColor = System.Drawing.Color.DarkGray;
            this._txtExpensesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtExpensesAmount.Location = new System.Drawing.Point(258, 155);
            this._txtExpensesAmount.Multiline = true;
            this._txtExpensesAmount.Name = "_txtExpensesAmount";
            this._txtExpensesAmount.ReadOnly = true;
            this._txtExpensesAmount.Size = new System.Drawing.Size(250, 747);
            this._txtExpensesAmount.TabIndex = 15;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AccountingManager.Properties.Resources.RicknMorty;
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this._txtExpensesAmount);
            this.Controls.Add(this._btnAddIncome);
            this.Controls.Add(this._txtNewIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtNewBill);
            this.Controls.Add(this._btnAddBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtExpenses);
            this.Name = "MainPage";
            this.Text = "Accounting Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnAddBill;
        private System.Windows.Forms.TextBox _txtNewBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtNewIncome;
        private System.Windows.Forms.Button _btnAddIncome;
        private System.Windows.Forms.TextBox _txtExpensesAmount;
    }
}

