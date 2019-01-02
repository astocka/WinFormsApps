namespace Cafeteria
{
    partial class FrmCafeteria
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
            this.LblAppetizer = new System.Windows.Forms.Label();
            this.LblMain = new System.Windows.Forms.Label();
            this.LblRefreshment = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.TxtApetizer = new System.Windows.Forms.TextBox();
            this.TxtMain = new System.Windows.Forms.TextBox();
            this.TxtRefreshment = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.groupBoxAppetizers = new System.Windows.Forms.GroupBox();
            this.RdoSoup = new System.Windows.Forms.RadioButton();
            this.RdoSalad = new System.Windows.Forms.RadioButton();
            this.groupBoxMains = new System.Windows.Forms.GroupBox();
            this.RdoChicken = new System.Windows.Forms.RadioButton();
            this.RdoLasagne = new System.Windows.Forms.RadioButton();
            this.RdoSteak = new System.Windows.Forms.RadioButton();
            this.groupBoxRefreshments = new System.Windows.Forms.GroupBox();
            this.RdoPop = new System.Windows.Forms.RadioButton();
            this.RdoWater = new System.Windows.Forms.RadioButton();
            this.RdoJuice = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBoxAppetizers.SuspendLayout();
            this.groupBoxMains.SuspendLayout();
            this.groupBoxRefreshments.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAppetizer
            // 
            this.LblAppetizer.AutoSize = true;
            this.LblAppetizer.Location = new System.Drawing.Point(29, 49);
            this.LblAppetizer.Name = "LblAppetizer";
            this.LblAppetizer.Size = new System.Drawing.Size(51, 13);
            this.LblAppetizer.TabIndex = 0;
            this.LblAppetizer.Text = "Appetizer";
            // 
            // LblMain
            // 
            this.LblMain.AutoSize = true;
            this.LblMain.Location = new System.Drawing.Point(29, 82);
            this.LblMain.Name = "LblMain";
            this.LblMain.Size = new System.Drawing.Size(30, 13);
            this.LblMain.TabIndex = 1;
            this.LblMain.Text = "Main";
            // 
            // LblRefreshment
            // 
            this.LblRefreshment.AutoSize = true;
            this.LblRefreshment.Location = new System.Drawing.Point(29, 115);
            this.LblRefreshment.Name = "LblRefreshment";
            this.LblRefreshment.Size = new System.Drawing.Size(67, 13);
            this.LblRefreshment.TabIndex = 2;
            this.LblRefreshment.Text = "Refreshment";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(29, 302);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(31, 13);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total";
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Location = new System.Drawing.Point(29, 269);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(54, 13);
            this.LblTax.TabIndex = 4;
            this.LblTax.Text = "Tax (13%)";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(29, 236);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.LblSubtotal.TabIndex = 3;
            this.LblSubtotal.Text = "Subtotal";
            // 
            // TxtApetizer
            // 
            this.TxtApetizer.Location = new System.Drawing.Point(100, 46);
            this.TxtApetizer.Name = "TxtApetizer";
            this.TxtApetizer.ReadOnly = true;
            this.TxtApetizer.Size = new System.Drawing.Size(162, 20);
            this.TxtApetizer.TabIndex = 6;
            // 
            // TxtMain
            // 
            this.TxtMain.Location = new System.Drawing.Point(100, 79);
            this.TxtMain.Name = "TxtMain";
            this.TxtMain.ReadOnly = true;
            this.TxtMain.Size = new System.Drawing.Size(162, 20);
            this.TxtMain.TabIndex = 7;
            // 
            // TxtRefreshment
            // 
            this.TxtRefreshment.Location = new System.Drawing.Point(100, 112);
            this.TxtRefreshment.Name = "TxtRefreshment";
            this.TxtRefreshment.ReadOnly = true;
            this.TxtRefreshment.Size = new System.Drawing.Size(162, 20);
            this.TxtRefreshment.TabIndex = 8;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(100, 299);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(162, 20);
            this.TxtTotal.TabIndex = 11;
            // 
            // TxtTax
            // 
            this.TxtTax.Location = new System.Drawing.Point(100, 266);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.ReadOnly = true;
            this.TxtTax.Size = new System.Drawing.Size(162, 20);
            this.TxtTax.TabIndex = 10;
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(100, 233);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ReadOnly = true;
            this.TxtSubtotal.Size = new System.Drawing.Size(162, 20);
            this.TxtSubtotal.TabIndex = 9;
            // 
            // groupBoxAppetizers
            // 
            this.groupBoxAppetizers.Controls.Add(this.RdoSalad);
            this.groupBoxAppetizers.Controls.Add(this.RdoSoup);
            this.groupBoxAppetizers.Location = new System.Drawing.Point(299, 29);
            this.groupBoxAppetizers.Name = "groupBoxAppetizers";
            this.groupBoxAppetizers.Size = new System.Drawing.Size(134, 114);
            this.groupBoxAppetizers.TabIndex = 12;
            this.groupBoxAppetizers.TabStop = false;
            this.groupBoxAppetizers.Text = "Appetizers";
            // 
            // RdoSoup
            // 
            this.RdoSoup.AutoSize = true;
            this.RdoSoup.Location = new System.Drawing.Point(18, 36);
            this.RdoSoup.Name = "RdoSoup";
            this.RdoSoup.Size = new System.Drawing.Size(83, 17);
            this.RdoSoup.TabIndex = 0;
            this.RdoSoup.TabStop = true;
            this.RdoSoup.Text = "Soup $ 2.00";
            this.RdoSoup.UseVisualStyleBackColor = true;
            this.RdoSoup.CheckedChanged += new System.EventHandler(this.RdoSoup_CheckedChanged);
            // 
            // RdoSalad
            // 
            this.RdoSalad.AutoSize = true;
            this.RdoSalad.Location = new System.Drawing.Point(16, 69);
            this.RdoSalad.Name = "RdoSalad";
            this.RdoSalad.Size = new System.Drawing.Size(85, 17);
            this.RdoSalad.TabIndex = 1;
            this.RdoSalad.TabStop = true;
            this.RdoSalad.Text = "Salad $ 2.50";
            this.RdoSalad.UseVisualStyleBackColor = true;
            this.RdoSalad.CheckedChanged += new System.EventHandler(this.RdoSalad_CheckedChanged);
            // 
            // groupBoxMains
            // 
            this.groupBoxMains.Controls.Add(this.RdoSteak);
            this.groupBoxMains.Controls.Add(this.RdoLasagne);
            this.groupBoxMains.Controls.Add(this.RdoChicken);
            this.groupBoxMains.Location = new System.Drawing.Point(470, 122);
            this.groupBoxMains.Name = "groupBoxMains";
            this.groupBoxMains.Size = new System.Drawing.Size(162, 136);
            this.groupBoxMains.TabIndex = 13;
            this.groupBoxMains.TabStop = false;
            this.groupBoxMains.Text = "Mains";
            // 
            // RdoChicken
            // 
            this.RdoChicken.AutoSize = true;
            this.RdoChicken.Location = new System.Drawing.Point(20, 33);
            this.RdoChicken.Name = "RdoChicken";
            this.RdoChicken.Size = new System.Drawing.Size(103, 17);
            this.RdoChicken.TabIndex = 0;
            this.RdoChicken.TabStop = true;
            this.RdoChicken.Text = "Chicken $ 10.50";
            this.RdoChicken.UseVisualStyleBackColor = true;
            this.RdoChicken.CheckedChanged += new System.EventHandler(this.RdoChicken_CheckedChanged);
            // 
            // RdoLasagne
            // 
            this.RdoLasagne.AutoSize = true;
            this.RdoLasagne.Location = new System.Drawing.Point(20, 66);
            this.RdoLasagne.Name = "RdoLasagne";
            this.RdoLasagne.Size = new System.Drawing.Size(105, 17);
            this.RdoLasagne.TabIndex = 1;
            this.RdoLasagne.TabStop = true;
            this.RdoLasagne.Text = "Lasagne $ 11.55";
            this.RdoLasagne.UseVisualStyleBackColor = true;
            this.RdoLasagne.CheckedChanged += new System.EventHandler(this.RdoLasagne_CheckedChanged);
            // 
            // RdoSteak
            // 
            this.RdoSteak.AutoSize = true;
            this.RdoSteak.Location = new System.Drawing.Point(20, 100);
            this.RdoSteak.Name = "RdoSteak";
            this.RdoSteak.Size = new System.Drawing.Size(92, 17);
            this.RdoSteak.TabIndex = 2;
            this.RdoSteak.TabStop = true;
            this.RdoSteak.Text = "Steak $ 15.00";
            this.RdoSteak.UseVisualStyleBackColor = true;
            this.RdoSteak.CheckedChanged += new System.EventHandler(this.RdoSteak_CheckedChanged);
            // 
            // groupBoxRefreshments
            // 
            this.groupBoxRefreshments.Controls.Add(this.RdoJuice);
            this.groupBoxRefreshments.Controls.Add(this.RdoWater);
            this.groupBoxRefreshments.Controls.Add(this.RdoPop);
            this.groupBoxRefreshments.Location = new System.Drawing.Point(299, 199);
            this.groupBoxRefreshments.Name = "groupBoxRefreshments";
            this.groupBoxRefreshments.Size = new System.Drawing.Size(134, 154);
            this.groupBoxRefreshments.TabIndex = 14;
            this.groupBoxRefreshments.TabStop = false;
            this.groupBoxRefreshments.Text = "Refreshments";
            // 
            // RdoPop
            // 
            this.RdoPop.AutoSize = true;
            this.RdoPop.Location = new System.Drawing.Point(16, 42);
            this.RdoPop.Name = "RdoPop";
            this.RdoPop.Size = new System.Drawing.Size(77, 17);
            this.RdoPop.TabIndex = 0;
            this.RdoPop.TabStop = true;
            this.RdoPop.Text = "Pop $ 1.25";
            this.RdoPop.UseVisualStyleBackColor = true;
            this.RdoPop.CheckedChanged += new System.EventHandler(this.RdoPop_CheckedChanged);
            // 
            // RdoWater
            // 
            this.RdoWater.AutoSize = true;
            this.RdoWater.Location = new System.Drawing.Point(16, 77);
            this.RdoWater.Name = "RdoWater";
            this.RdoWater.Size = new System.Drawing.Size(87, 17);
            this.RdoWater.TabIndex = 1;
            this.RdoWater.TabStop = true;
            this.RdoWater.Text = "Water $ 1.00";
            this.RdoWater.UseVisualStyleBackColor = true;
            this.RdoWater.CheckedChanged += new System.EventHandler(this.RdoWater_CheckedChanged);
            // 
            // RdoJuice
            // 
            this.RdoJuice.AutoSize = true;
            this.RdoJuice.Location = new System.Drawing.Point(16, 112);
            this.RdoJuice.Name = "RdoJuice";
            this.RdoJuice.Size = new System.Drawing.Size(83, 17);
            this.RdoJuice.TabIndex = 2;
            this.RdoJuice.TabStop = true;
            this.RdoJuice.Text = "Juice $ 1.30";
            this.RdoJuice.UseVisualStyleBackColor = true;
            this.RdoJuice.CheckedChanged += new System.EventHandler(this.RdoJuice_CheckedChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(299, 385);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(93, 23);
            this.BtnCalculate.TabIndex = 15;
            this.BtnCalculate.Text = "Calculate Bill";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(436, 385);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.BtnNewOrder.TabIndex = 16;
            this.BtnNewOrder.Text = "New Order";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(557, 385);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 17;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBoxRefreshments);
            this.Controls.Add(this.groupBoxMains);
            this.Controls.Add(this.groupBoxAppetizers);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtTax);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtRefreshment);
            this.Controls.Add(this.TxtMain);
            this.Controls.Add(this.TxtApetizer);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.LblRefreshment);
            this.Controls.Add(this.LblMain);
            this.Controls.Add(this.LblAppetizer);
            this.Name = "FrmCafeteria";
            this.Text = "Cafeteria";
            this.Load += new System.EventHandler(this.FrmCafeteria_Load);
            this.groupBoxAppetizers.ResumeLayout(false);
            this.groupBoxAppetizers.PerformLayout();
            this.groupBoxMains.ResumeLayout(false);
            this.groupBoxMains.PerformLayout();
            this.groupBoxRefreshments.ResumeLayout(false);
            this.groupBoxRefreshments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAppetizer;
        private System.Windows.Forms.Label LblMain;
        private System.Windows.Forms.Label LblRefreshment;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.TextBox TxtApetizer;
        private System.Windows.Forms.TextBox TxtMain;
        private System.Windows.Forms.TextBox TxtRefreshment;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.GroupBox groupBoxAppetizers;
        private System.Windows.Forms.RadioButton RdoSalad;
        private System.Windows.Forms.RadioButton RdoSoup;
        private System.Windows.Forms.GroupBox groupBoxMains;
        private System.Windows.Forms.RadioButton RdoSteak;
        private System.Windows.Forms.RadioButton RdoLasagne;
        private System.Windows.Forms.RadioButton RdoChicken;
        private System.Windows.Forms.GroupBox groupBoxRefreshments;
        private System.Windows.Forms.RadioButton RdoJuice;
        private System.Windows.Forms.RadioButton RdoWater;
        private System.Windows.Forms.RadioButton RdoPop;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnExit;
    }
}

