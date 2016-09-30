namespace WindowsFormsApplication1
{
    partial class Project_3
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
            this.gbInventoryManagement = new System.Windows.Forms.GroupBox();
            this.btnAddtoInventory = new System.Windows.Forms.Button();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.rdoSugar = new System.Windows.Forms.RadioButton();
            this.lblSugar = new System.Windows.Forms.Label();
            this.rdoCreamer = new System.Windows.Forms.RadioButton();
            this.lblCreamer = new System.Windows.Forms.Label();
            this.rdoGrounds = new System.Windows.Forms.RadioButton();
            this.lblGrounds = new System.Windows.Forms.Label();
            this.rdoLG = new System.Windows.Forms.RadioButton();
            this.lblLG = new System.Windows.Forms.Label();
            this.rdoMD = new System.Windows.Forms.RadioButton();
            this.lblMD = new System.Windows.Forms.Label();
            this.rdoSM = new System.Windows.Forms.RadioButton();
            this.lblSM = new System.Windows.Forms.Label();
            this.lblCups = new System.Windows.Forms.Label();
            this.gbBuildinganOrder = new System.Windows.Forms.GroupBox();
            this.gbPlaceOrder = new System.Windows.Forms.GroupBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.cbSugar = new System.Windows.Forms.CheckBox();
            this.cbCreamer = new System.Windows.Forms.CheckBox();
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.rdoMediumSize = new System.Windows.Forms.RadioButton();
            this.rdoLargeSize = new System.Windows.Forms.RadioButton();
            this.gbPastOrders = new System.Windows.Forms.GroupBox();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.gbInventoryManagement.SuspendLayout();
            this.gbBuildinganOrder.SuspendLayout();
            this.gbPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.gbPastOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInventoryManagement
            // 
            this.gbInventoryManagement.Controls.Add(this.btnAddtoInventory);
            this.gbInventoryManagement.Controls.Add(this.txtInventory);
            this.gbInventoryManagement.Controls.Add(this.rdoSugar);
            this.gbInventoryManagement.Controls.Add(this.lblSugar);
            this.gbInventoryManagement.Controls.Add(this.rdoCreamer);
            this.gbInventoryManagement.Controls.Add(this.lblCreamer);
            this.gbInventoryManagement.Controls.Add(this.rdoGrounds);
            this.gbInventoryManagement.Controls.Add(this.lblGrounds);
            this.gbInventoryManagement.Controls.Add(this.rdoLG);
            this.gbInventoryManagement.Controls.Add(this.lblLG);
            this.gbInventoryManagement.Controls.Add(this.rdoMD);
            this.gbInventoryManagement.Controls.Add(this.lblMD);
            this.gbInventoryManagement.Controls.Add(this.rdoSM);
            this.gbInventoryManagement.Controls.Add(this.lblSM);
            this.gbInventoryManagement.Controls.Add(this.lblCups);
            this.gbInventoryManagement.Location = new System.Drawing.Point(15, 17);
            this.gbInventoryManagement.Name = "gbInventoryManagement";
            this.gbInventoryManagement.Size = new System.Drawing.Size(675, 251);
            this.gbInventoryManagement.TabIndex = 0;
            this.gbInventoryManagement.TabStop = false;
            this.gbInventoryManagement.Text = "Inventory Management";
            // 
            // btnAddtoInventory
            // 
            this.btnAddtoInventory.Location = new System.Drawing.Point(276, 75);
            this.btnAddtoInventory.Name = "btnAddtoInventory";
            this.btnAddtoInventory.Size = new System.Drawing.Size(196, 31);
            this.btnAddtoInventory.TabIndex = 14;
            this.btnAddtoInventory.Text = "Add to Inventory";
            this.btnAddtoInventory.UseVisualStyleBackColor = true;
            this.btnAddtoInventory.Click += new System.EventHandler(this.btnAddtoInventory_Click);
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(276, 37);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(196, 26);
            this.txtInventory.TabIndex = 13;
            // 
            // rdoSugar
            // 
            this.rdoSugar.AutoSize = true;
            this.rdoSugar.Location = new System.Drawing.Point(123, 212);
            this.rdoSugar.Name = "rdoSugar";
            this.rdoSugar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSugar.Size = new System.Drawing.Size(43, 24);
            this.rdoSugar.TabIndex = 12;
            this.rdoSugar.TabStop = true;
            this.rdoSugar.Text = "0";
            this.rdoSugar.UseVisualStyleBackColor = true;
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(39, 212);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(56, 20);
            this.lblSugar.TabIndex = 11;
            this.lblSugar.Text = "Sugar:";
            // 
            // rdoCreamer
            // 
            this.rdoCreamer.AutoSize = true;
            this.rdoCreamer.Location = new System.Drawing.Point(123, 175);
            this.rdoCreamer.Name = "rdoCreamer";
            this.rdoCreamer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoCreamer.Size = new System.Drawing.Size(43, 24);
            this.rdoCreamer.TabIndex = 10;
            this.rdoCreamer.TabStop = true;
            this.rdoCreamer.Text = "0";
            this.rdoCreamer.UseVisualStyleBackColor = true;
            // 
            // lblCreamer
            // 
            this.lblCreamer.AutoSize = true;
            this.lblCreamer.Location = new System.Drawing.Point(39, 175);
            this.lblCreamer.Name = "lblCreamer";
            this.lblCreamer.Size = new System.Drawing.Size(74, 20);
            this.lblCreamer.TabIndex = 9;
            this.lblCreamer.Text = "Creamer:";
            // 
            // rdoGrounds
            // 
            this.rdoGrounds.AutoSize = true;
            this.rdoGrounds.Location = new System.Drawing.Point(123, 137);
            this.rdoGrounds.Name = "rdoGrounds";
            this.rdoGrounds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoGrounds.Size = new System.Drawing.Size(43, 24);
            this.rdoGrounds.TabIndex = 8;
            this.rdoGrounds.TabStop = true;
            this.rdoGrounds.Text = "0";
            this.rdoGrounds.UseVisualStyleBackColor = true;
            // 
            // lblGrounds
            // 
            this.lblGrounds.AutoSize = true;
            this.lblGrounds.Location = new System.Drawing.Point(39, 137);
            this.lblGrounds.Name = "lblGrounds";
            this.lblGrounds.Size = new System.Drawing.Size(75, 20);
            this.lblGrounds.TabIndex = 7;
            this.lblGrounds.Text = "Grounds:";
            // 
            // rdoLG
            // 
            this.rdoLG.AutoSize = true;
            this.rdoLG.Location = new System.Drawing.Point(90, 49);
            this.rdoLG.Name = "rdoLG";
            this.rdoLG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoLG.Size = new System.Drawing.Size(43, 24);
            this.rdoLG.TabIndex = 6;
            this.rdoLG.TabStop = true;
            this.rdoLG.Text = "0";
            this.rdoLG.UseVisualStyleBackColor = true;
            // 
            // lblLG
            // 
            this.lblLG.AutoSize = true;
            this.lblLG.Location = new System.Drawing.Point(51, 49);
            this.lblLG.Name = "lblLG";
            this.lblLG.Size = new System.Drawing.Size(35, 20);
            this.lblLG.TabIndex = 5;
            this.lblLG.Text = "LG:";
            // 
            // rdoMD
            // 
            this.rdoMD.AutoSize = true;
            this.rdoMD.Location = new System.Drawing.Point(90, 75);
            this.rdoMD.Name = "rdoMD";
            this.rdoMD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoMD.Size = new System.Drawing.Size(43, 24);
            this.rdoMD.TabIndex = 4;
            this.rdoMD.TabStop = true;
            this.rdoMD.Text = "0";
            this.rdoMD.UseVisualStyleBackColor = true;
            // 
            // lblMD
            // 
            this.lblMD.AutoSize = true;
            this.lblMD.Location = new System.Drawing.Point(51, 75);
            this.lblMD.Name = "lblMD";
            this.lblMD.Size = new System.Drawing.Size(38, 20);
            this.lblMD.TabIndex = 3;
            this.lblMD.Text = "MD:";
            // 
            // rdoSM
            // 
            this.rdoSM.AutoSize = true;
            this.rdoSM.Location = new System.Drawing.Point(90, 100);
            this.rdoSM.Name = "rdoSM";
            this.rdoSM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSM.Size = new System.Drawing.Size(43, 24);
            this.rdoSM.TabIndex = 2;
            this.rdoSM.TabStop = true;
            this.rdoSM.Text = "0";
            this.rdoSM.UseVisualStyleBackColor = true;
            // 
            // lblSM
            // 
            this.lblSM.AutoSize = true;
            this.lblSM.Location = new System.Drawing.Point(51, 100);
            this.lblSM.Name = "lblSM";
            this.lblSM.Size = new System.Drawing.Size(37, 20);
            this.lblSM.TabIndex = 1;
            this.lblSM.Text = "SM:";
            // 
            // lblCups
            // 
            this.lblCups.AutoSize = true;
            this.lblCups.Location = new System.Drawing.Point(39, 25);
            this.lblCups.Name = "lblCups";
            this.lblCups.Size = new System.Drawing.Size(50, 20);
            this.lblCups.TabIndex = 0;
            this.lblCups.Text = "Cups:";
            // 
            // gbBuildinganOrder
            // 
            this.gbBuildinganOrder.Controls.Add(this.gbPlaceOrder);
            this.gbBuildinganOrder.Controls.Add(this.lblOrders);
            this.gbBuildinganOrder.Controls.Add(this.txtOrders);
            this.gbBuildinganOrder.Controls.Add(this.btnAddtoOrder);
            this.gbBuildinganOrder.Controls.Add(this.nudQuantity);
            this.gbBuildinganOrder.Controls.Add(this.lblQty);
            this.gbBuildinganOrder.Controls.Add(this.cbSugar);
            this.gbBuildinganOrder.Controls.Add(this.cbCreamer);
            this.gbBuildinganOrder.Controls.Add(this.rdoSmallSize);
            this.gbBuildinganOrder.Controls.Add(this.rdoMediumSize);
            this.gbBuildinganOrder.Controls.Add(this.rdoLargeSize);
            this.gbBuildinganOrder.Location = new System.Drawing.Point(15, 295);
            this.gbBuildinganOrder.Name = "gbBuildinganOrder";
            this.gbBuildinganOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbBuildinganOrder.Size = new System.Drawing.Size(675, 555);
            this.gbBuildinganOrder.TabIndex = 1;
            this.gbBuildinganOrder.TabStop = false;
            this.gbBuildinganOrder.Text = "Building an Order";
            // 
            // gbPlaceOrder
            // 
            this.gbPlaceOrder.Controls.Add(this.btnPlaceOrder);
            this.gbPlaceOrder.Location = new System.Drawing.Point(18, 406);
            this.gbPlaceOrder.Name = "gbPlaceOrder";
            this.gbPlaceOrder.Size = new System.Drawing.Size(177, 125);
            this.gbPlaceOrder.TabIndex = 2;
            this.gbPlaceOrder.TabStop = false;
            this.gbPlaceOrder.Text = "Order Placement";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(36, 58);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(112, 31);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(213, 49);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(61, 20);
            this.lblOrders.TabIndex = 9;
            this.lblOrders.Text = "Orders:";
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(213, 82);
            this.txtOrders.Multiline = true;
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(427, 447);
            this.txtOrders.TabIndex = 8;
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.Location = new System.Drawing.Point(18, 331);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(177, 29);
            this.btnAddtoOrder.TabIndex = 7;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = true;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(112, 240);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(57, 26);
            this.nudQuantity.TabIndex = 6;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(14, 240);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 20);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Quantity:";
            // 
            // cbSugar
            // 
            this.cbSugar.AutoSize = true;
            this.cbSugar.Location = new System.Drawing.Point(39, 194);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.Size = new System.Drawing.Size(78, 24);
            this.cbSugar.TabIndex = 4;
            this.cbSugar.Text = "Sugar";
            this.cbSugar.UseVisualStyleBackColor = true;
            // 
            // cbCreamer
            // 
            this.cbCreamer.AutoSize = true;
            this.cbCreamer.Location = new System.Drawing.Point(39, 157);
            this.cbCreamer.Name = "cbCreamer";
            this.cbCreamer.Size = new System.Drawing.Size(96, 24);
            this.cbCreamer.TabIndex = 3;
            this.cbCreamer.Text = "Creamer";
            this.cbCreamer.UseVisualStyleBackColor = true;
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.Location = new System.Drawing.Point(39, 118);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(73, 24);
            this.rdoSmallSize.TabIndex = 2;
            this.rdoSmallSize.TabStop = true;
            this.rdoSmallSize.Text = "Small";
            this.rdoSmallSize.UseVisualStyleBackColor = true;
            this.rdoSmallSize.CheckedChanged += new System.EventHandler(this.rdoSmallSize_CheckedChanged);
            // 
            // rdoMediumSize
            // 
            this.rdoMediumSize.AutoSize = true;
            this.rdoMediumSize.Location = new System.Drawing.Point(39, 82);
            this.rdoMediumSize.Name = "rdoMediumSize";
            this.rdoMediumSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoMediumSize.Size = new System.Drawing.Size(90, 24);
            this.rdoMediumSize.TabIndex = 1;
            this.rdoMediumSize.TabStop = true;
            this.rdoMediumSize.Text = "Medium";
            this.rdoMediumSize.UseVisualStyleBackColor = true;
            this.rdoMediumSize.CheckedChanged += new System.EventHandler(this.rdoMediumSize_CheckedChanged);
            // 
            // rdoLargeSize
            // 
            this.rdoLargeSize.AutoSize = true;
            this.rdoLargeSize.Location = new System.Drawing.Point(39, 43);
            this.rdoLargeSize.Name = "rdoLargeSize";
            this.rdoLargeSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoLargeSize.Size = new System.Drawing.Size(75, 24);
            this.rdoLargeSize.TabIndex = 0;
            this.rdoLargeSize.TabStop = true;
            this.rdoLargeSize.Text = "Large";
            this.rdoLargeSize.UseVisualStyleBackColor = true;
            this.rdoLargeSize.CheckedChanged += new System.EventHandler(this.rdoLargeSize_CheckedChanged);
            // 
            // gbPastOrders
            // 
            this.gbPastOrders.Controls.Add(this.lstInvoice);
            this.gbPastOrders.Controls.Add(this.txtReceipt);
            this.gbPastOrders.Controls.Add(this.lblReceipt);
            this.gbPastOrders.Controls.Add(this.lblInvoices);
            this.gbPastOrders.Location = new System.Drawing.Point(699, 20);
            this.gbPastOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPastOrders.Name = "gbPastOrders";
            this.gbPastOrders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPastOrders.Size = new System.Drawing.Size(620, 831);
            this.gbPastOrders.TabIndex = 2;
            this.gbPastOrders.TabStop = false;
            this.gbPastOrders.Text = "Past Orders";
            // 
            // lstInvoice
            // 
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.ItemHeight = 20;
            this.lstInvoice.Location = new System.Drawing.Point(28, 70);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(539, 344);
            this.lstInvoice.TabIndex = 4;
            this.lstInvoice.SelectedIndexChanged += new System.EventHandler(this.lstInvoice_SelectedIndexChanged);
            // 
            // txtReceipt
            // 
            this.txtReceipt.Location = new System.Drawing.Point(18, 469);
            this.txtReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(590, 329);
            this.txtReceipt.TabIndex = 3;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(14, 432);
            this.lblReceipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(68, 20);
            this.lblReceipt.TabIndex = 1;
            this.lblReceipt.Text = "Receipt:";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Location = new System.Drawing.Point(24, 34);
            this.lblInvoices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(71, 20);
            this.lblInvoices.TabIndex = 0;
            this.lblInvoices.Text = "Invoices:";
            // 
            // Project_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 926);
            this.Controls.Add(this.gbPastOrders);
            this.Controls.Add(this.gbBuildinganOrder);
            this.Controls.Add(this.gbInventoryManagement);
            this.Name = "Project_3";
            this.Text = "2151-MGIS-350-Project-3";
            this.Load += new System.EventHandler(this.Project_3_Load);
            this.gbInventoryManagement.ResumeLayout(false);
            this.gbInventoryManagement.PerformLayout();
            this.gbBuildinganOrder.ResumeLayout(false);
            this.gbBuildinganOrder.PerformLayout();
            this.gbPlaceOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.gbPastOrders.ResumeLayout(false);
            this.gbPastOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInventoryManagement;
        private System.Windows.Forms.Button btnAddtoInventory;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.RadioButton rdoSugar;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.RadioButton rdoCreamer;
        private System.Windows.Forms.Label lblCreamer;
        private System.Windows.Forms.RadioButton rdoGrounds;
        private System.Windows.Forms.Label lblGrounds;
        private System.Windows.Forms.RadioButton rdoLG;
        private System.Windows.Forms.Label lblLG;
        private System.Windows.Forms.RadioButton rdoMD;
        private System.Windows.Forms.Label lblMD;
        private System.Windows.Forms.RadioButton rdoSM;
        private System.Windows.Forms.Label lblSM;
        private System.Windows.Forms.Label lblCups;
        private System.Windows.Forms.GroupBox gbBuildinganOrder;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.CheckBox cbSugar;
        private System.Windows.Forms.CheckBox cbCreamer;
        private System.Windows.Forms.RadioButton rdoSmallSize;
        private System.Windows.Forms.RadioButton rdoMediumSize;
        private System.Windows.Forms.RadioButton rdoLargeSize;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.GroupBox gbPlaceOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox gbPastOrders;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.ListBox lstInvoice;
    }
}

