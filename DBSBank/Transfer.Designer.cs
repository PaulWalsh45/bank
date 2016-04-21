namespace DAL
{
    partial class Transfer
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
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateAccs = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditedBal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxBank = new System.Windows.Forms.ComboBox();
            this.cbxAccNumInternal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Enabled = false;
            this.txtOverdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraft.Location = new System.Drawing.Point(121, 228);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(100, 23);
            this.txtOverdraft.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 139;
            this.label3.Text = "Overdraft";
            // 
            // btnUpdateAccs
            // 
            this.btnUpdateAccs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateAccs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccs.Location = new System.Drawing.Point(370, 269);
            this.btnUpdateAccs.Name = "btnUpdateAccs";
            this.btnUpdateAccs.Size = new System.Drawing.Size(128, 35);
            this.btnUpdateAccs.TabIndex = 137;
            this.btnUpdateAccs.Text = "Update Database";
            this.btnUpdateAccs.UseVisualStyleBackColor = false;
            this.btnUpdateAccs.Click += new System.EventHandler(this.btnUpdateAccs_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Lime;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(121, 269);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(128, 35);
            this.btnTransfer.TabIndex = 138;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransAmount
            // 
            this.txtTransAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransAmount.Location = new System.Drawing.Point(121, 186);
            this.txtTransAmount.Name = "txtTransAmount";
            this.txtTransAmount.Size = new System.Drawing.Size(100, 23);
            this.txtTransAmount.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 135;
            this.label1.Text = "Transfer Amount";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(121, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 23);
            this.txtId.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 133;
            this.label2.Text = "Account ID";
            // 
            // txtBal
            // 
            this.txtBal.Enabled = false;
            this.txtBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBal.Location = new System.Drawing.Point(121, 144);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(100, 23);
            this.txtBal.TabIndex = 132;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(12, 144);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 131;
            this.lblBalance.Text = "Balance";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(235, 102);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(180, 17);
            this.lblAccountNumber.TabIndex = 129;
            this.lblAccountNumber.Text = "Enter Acc Number to Credit";
            // 
            // txtAccNum
            // 
            this.txtAccNum.Enabled = false;
            this.txtAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.Location = new System.Drawing.Point(121, 102);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(100, 23);
            this.txtAccNum.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 141;
            this.label4.Text = "Account Number";
            // 
            // txtCreditedBal
            // 
            this.txtCreditedBal.Enabled = false;
            this.txtCreditedBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditedBal.Location = new System.Drawing.Point(455, 144);
            this.txtCreditedBal.Name = "txtCreditedBal";
            this.txtCreditedBal.Size = new System.Drawing.Size(100, 23);
            this.txtCreditedBal.TabIndex = 143;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 17);
            this.label5.TabIndex = 144;
            this.label5.Text = "Balance Internal Accounts ONLY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 149;
            this.label7.Text = "Sort Code";
            // 
            // txtSortCode
            // 
            this.txtSortCode.Enabled = false;
            this.txtSortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSortCode.Location = new System.Drawing.Point(455, 186);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(100, 23);
            this.txtSortCode.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 151;
            this.label8.Text = "Bank";
            // 
            // cbxBank
            // 
            this.cbxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBank.FormattingEnabled = true;
            this.cbxBank.Items.AddRange(new object[] {
            "DBS",
            "Bank of Ireland",
            "AIB",
            "Ulster Bank"});
            this.cbxBank.Location = new System.Drawing.Point(434, 64);
            this.cbxBank.Name = "cbxBank";
            this.cbxBank.Size = new System.Drawing.Size(121, 24);
            this.cbxBank.TabIndex = 152;
            this.cbxBank.SelectedIndexChanged += new System.EventHandler(this.cbxBank_SelectedIndexChanged);
            // 
            // cbxAccNumInternal
            // 
            this.cbxAccNumInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccNumInternal.FormattingEnabled = true;
            this.cbxAccNumInternal.Location = new System.Drawing.Point(438, 101);
            this.cbxAccNumInternal.Name = "cbxAccNumInternal";
            this.cbxAccNumInternal.Size = new System.Drawing.Size(121, 24);
            this.cbxAccNumInternal.TabIndex = 153;
            this.cbxAccNumInternal.SelectedIndexChanged += new System.EventHandler(this.cbxAccNumInternal_SelectedIndexChanged);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(571, 327);
            this.Controls.Add(this.cbxAccNumInternal);
            this.Controls.Add(this.cbxBank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreditedBal);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOverdraft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateAccs);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBal);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateAccs;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreditedBal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxBank;
        private System.Windows.Forms.ComboBox cbxAccNumInternal;
    }
}