namespace _22.Loan_Calculator
{
    partial class Form1
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
            this.LoanAmount = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.DownPayment = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.IR = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.Term = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblMonthlyPaymentAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoanAmount
            // 
            this.LoanAmount.AutoSize = true;
            this.LoanAmount.Location = new System.Drawing.Point(94, 73);
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Size = new System.Drawing.Size(85, 16);
            this.LoanAmount.TabIndex = 0;
            this.LoanAmount.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(254, 70);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(143, 22);
            this.txtLoanAmount.TabIndex = 1;
            // 
            // DownPayment
            // 
            this.DownPayment.AutoSize = true;
            this.DownPayment.Location = new System.Drawing.Point(94, 127);
            this.DownPayment.Name = "DownPayment";
            this.DownPayment.Size = new System.Drawing.Size(97, 16);
            this.DownPayment.TabIndex = 0;
            this.DownPayment.Text = "Down Payment";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(254, 124);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(143, 22);
            this.txtDownPayment.TabIndex = 1;
            // 
            // IR
            // 
            this.IR.AutoSize = true;
            this.IR.Location = new System.Drawing.Point(94, 187);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(82, 16);
            this.IR.TabIndex = 0;
            this.IR.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(254, 184);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(143, 22);
            this.txtInterestRate.TabIndex = 1;
            // 
            // Term
            // 
            this.Term.AutoSize = true;
            this.Term.Location = new System.Drawing.Point(94, 249);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(91, 16);
            this.Term.TabIndex = 0;
            this.Term.Text = "Term in Years";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(254, 246);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(143, 22);
            this.txtTerm.TabIndex = 1;
            // 
            // btnMortgage
            // 
            this.btnMortgage.Location = new System.Drawing.Point(151, 313);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(93, 29);
            this.btnMortgage.TabIndex = 2;
            this.btnMortgage.Text = "Mortgage";
            this.btnMortgage.UseVisualStyleBackColor = true;
            this.btnMortgage.Click += new System.EventHandler(this.btnMortgage_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(265, 313);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(78, 29);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(210, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(94, 355);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(122, 16);
            this.lblMonthlyPayment.TabIndex = 0;
            this.lblMonthlyPayment.Text = "Monthly Payment: $";
            // 
            // lblMonthlyPaymentAmount
            // 
            this.lblMonthlyPaymentAmount.AutoSize = true;
            this.lblMonthlyPaymentAmount.Location = new System.Drawing.Point(222, 355);
            this.lblMonthlyPaymentAmount.Name = "lblMonthlyPaymentAmount";
            this.lblMonthlyPaymentAmount.Size = new System.Drawing.Size(22, 16);
            this.lblMonthlyPaymentAmount.TabIndex = 0;
            this.lblMonthlyPaymentAmount.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblMonthlyPaymentAmount);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.DownPayment);
            this.Controls.Add(this.LoanAmount);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoanAmount;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label DownPayment;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label IR;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label Term;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblMonthlyPaymentAmount;
    }
}

