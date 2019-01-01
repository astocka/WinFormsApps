namespace Payroll
{
    partial class FrmPayroll
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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblRateOfPay = new System.Windows.Forms.Label();
            this.TxtRateOfPay = new System.Windows.Forms.TextBox();
            this.LblHoursWorked = new System.Windows.Forms.Label();
            this.TxtHoursWorked = new System.Windows.Forms.TextBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.groupBoxSalary = new System.Windows.Forms.GroupBox();
            this.LblGrossPay = new System.Windows.Forms.Label();
            this.LblNetPay = new System.Windows.Forms.Label();
            this.LblTaxes = new System.Windows.Forms.Label();
            this.TxtNetPay = new System.Windows.Forms.TextBox();
            this.TxtGrossPay = new System.Windows.Forms.TextBox();
            this.TxtTaxes = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblEmployeeToPay = new System.Windows.Forms.Label();
            this.LblEmployeeToPayDisplay = new System.Windows.Forms.Label();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(15, 35);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(163, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(195, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblRateOfPay
            // 
            this.LblRateOfPay.AutoSize = true;
            this.LblRateOfPay.Location = new System.Drawing.Point(15, 69);
            this.LblRateOfPay.Name = "LblRateOfPay";
            this.LblRateOfPay.Size = new System.Drawing.Size(62, 13);
            this.LblRateOfPay.TabIndex = 2;
            this.LblRateOfPay.Text = "Rate of pay";
            // 
            // TxtRateOfPay
            // 
            this.TxtRateOfPay.Location = new System.Drawing.Point(163, 66);
            this.TxtRateOfPay.Name = "TxtRateOfPay";
            this.TxtRateOfPay.Size = new System.Drawing.Size(195, 20);
            this.TxtRateOfPay.TabIndex = 3;
            // 
            // LblHoursWorked
            // 
            this.LblHoursWorked.AutoSize = true;
            this.LblHoursWorked.Location = new System.Drawing.Point(15, 104);
            this.LblHoursWorked.Name = "LblHoursWorked";
            this.LblHoursWorked.Size = new System.Drawing.Size(73, 13);
            this.LblHoursWorked.TabIndex = 4;
            this.LblHoursWorked.Text = "Hours worked";
            // 
            // TxtHoursWorked
            // 
            this.TxtHoursWorked.Location = new System.Drawing.Point(163, 101);
            this.TxtHoursWorked.Name = "TxtHoursWorked";
            this.TxtHoursWorked.Size = new System.Drawing.Size(195, 20);
            this.TxtHoursWorked.TabIndex = 5;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.LblName);
            this.groupBoxEmployee.Controls.Add(this.TxtHoursWorked);
            this.groupBoxEmployee.Controls.Add(this.TxtName);
            this.groupBoxEmployee.Controls.Add(this.LblHoursWorked);
            this.groupBoxEmployee.Controls.Add(this.LblRateOfPay);
            this.groupBoxEmployee.Controls.Add(this.TxtRateOfPay);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(379, 143);
            this.groupBoxEmployee.TabIndex = 6;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee";
            // 
            // groupBoxSalary
            // 
            this.groupBoxSalary.Controls.Add(this.LblEmployeeToPayDisplay);
            this.groupBoxSalary.Controls.Add(this.LblEmployeeToPay);
            this.groupBoxSalary.Controls.Add(this.TxtNetPay);
            this.groupBoxSalary.Controls.Add(this.LblNetPay);
            this.groupBoxSalary.Controls.Add(this.TxtGrossPay);
            this.groupBoxSalary.Controls.Add(this.TxtTaxes);
            this.groupBoxSalary.Controls.Add(this.LblGrossPay);
            this.groupBoxSalary.Controls.Add(this.LblTaxes);
            this.groupBoxSalary.Location = new System.Drawing.Point(12, 170);
            this.groupBoxSalary.Name = "groupBoxSalary";
            this.groupBoxSalary.Size = new System.Drawing.Size(379, 179);
            this.groupBoxSalary.TabIndex = 7;
            this.groupBoxSalary.TabStop = false;
            this.groupBoxSalary.Text = "Calculated salary";
            // 
            // LblGrossPay
            // 
            this.LblGrossPay.AutoSize = true;
            this.LblGrossPay.Location = new System.Drawing.Point(15, 67);
            this.LblGrossPay.Name = "LblGrossPay";
            this.LblGrossPay.Size = new System.Drawing.Size(54, 13);
            this.LblGrossPay.TabIndex = 1;
            this.LblGrossPay.Text = "Gross pay";
            // 
            // LblNetPay
            // 
            this.LblNetPay.AutoSize = true;
            this.LblNetPay.Location = new System.Drawing.Point(15, 136);
            this.LblNetPay.Name = "LblNetPay";
            this.LblNetPay.Size = new System.Drawing.Size(44, 13);
            this.LblNetPay.TabIndex = 7;
            this.LblNetPay.Text = "Net pay";
            // 
            // LblTaxes
            // 
            this.LblTaxes.AutoSize = true;
            this.LblTaxes.Location = new System.Drawing.Point(15, 101);
            this.LblTaxes.Name = "LblTaxes";
            this.LblTaxes.Size = new System.Drawing.Size(65, 13);
            this.LblTaxes.TabIndex = 6;
            this.LblTaxes.Text = "Taxes (20%)";
            // 
            // TxtNetPay
            // 
            this.TxtNetPay.Location = new System.Drawing.Point(163, 133);
            this.TxtNetPay.Name = "TxtNetPay";
            this.TxtNetPay.ReadOnly = true;
            this.TxtNetPay.Size = new System.Drawing.Size(195, 20);
            this.TxtNetPay.TabIndex = 8;
            // 
            // TxtGrossPay
            // 
            this.TxtGrossPay.Location = new System.Drawing.Point(163, 64);
            this.TxtGrossPay.Name = "TxtGrossPay";
            this.TxtGrossPay.ReadOnly = true;
            this.TxtGrossPay.Size = new System.Drawing.Size(195, 20);
            this.TxtGrossPay.TabIndex = 6;
            // 
            // TxtTaxes
            // 
            this.TxtTaxes.Location = new System.Drawing.Point(163, 98);
            this.TxtTaxes.Name = "TxtTaxes";
            this.TxtTaxes.ReadOnly = true;
            this.TxtTaxes.Size = new System.Drawing.Size(195, 20);
            this.TxtTaxes.TabIndex = 7;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(154, 355);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 8;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(316, 355);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(235, 355);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblEmployeeToPay
            // 
            this.LblEmployeeToPay.AutoSize = true;
            this.LblEmployeeToPay.Location = new System.Drawing.Point(15, 36);
            this.LblEmployeeToPay.Name = "LblEmployeeToPay";
            this.LblEmployeeToPay.Size = new System.Drawing.Size(53, 13);
            this.LblEmployeeToPay.TabIndex = 9;
            this.LblEmployeeToPay.Text = "Employee";
            // 
            // LblEmployeeToPayDisplay
            // 
            this.LblEmployeeToPayDisplay.AutoSize = true;
            this.LblEmployeeToPayDisplay.Location = new System.Drawing.Point(160, 36);
            this.LblEmployeeToPayDisplay.Name = "LblEmployeeToPayDisplay";
            this.LblEmployeeToPayDisplay.Size = new System.Drawing.Size(0, 13);
            this.LblEmployeeToPayDisplay.TabIndex = 10;
            // 
            // FrmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 392);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBoxSalary);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "FrmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxSalary.ResumeLayout(false);
            this.groupBoxSalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblRateOfPay;
        private System.Windows.Forms.TextBox TxtRateOfPay;
        private System.Windows.Forms.Label LblHoursWorked;
        private System.Windows.Forms.TextBox TxtHoursWorked;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.GroupBox groupBoxSalary;
        private System.Windows.Forms.TextBox TxtNetPay;
        private System.Windows.Forms.Label LblNetPay;
        private System.Windows.Forms.TextBox TxtGrossPay;
        private System.Windows.Forms.TextBox TxtTaxes;
        private System.Windows.Forms.Label LblGrossPay;
        private System.Windows.Forms.Label LblTaxes;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblEmployeeToPayDisplay;
        private System.Windows.Forms.Label LblEmployeeToPay;
        private System.Windows.Forms.Button BtnClear;
    }
}

