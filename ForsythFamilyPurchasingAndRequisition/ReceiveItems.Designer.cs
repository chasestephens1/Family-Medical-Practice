
namespace ForsythFamilyPurchasingAndRequisition
{
    partial class ReceiveItems
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
            this.shipmentSelectionPanel = new System.Windows.Forms.Panel();
            this.btnShipment = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbShipments = new System.Windows.Forms.CheckedListBox();
            this.cbLineItems = new System.Windows.Forms.CheckedListBox();
            this.lblLineItems = new System.Windows.Forms.Label();
            this.lblMainShippment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectShipmentLineItem = new System.Windows.Forms.Button();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnSelectAddItemQuantity = new System.Windows.Forms.Button();
            this.btnCancelAddItem = new System.Windows.Forms.Button();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBinSelection = new System.Windows.Forms.ComboBox();
            this.btnCancelQuantity = new System.Windows.Forms.Button();
            this.btnConfirmAddItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numAddItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnResetButtons = new System.Windows.Forms.Button();
            this.shipmentSelectionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // shipmentSelectionPanel
            // 
            this.shipmentSelectionPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.shipmentSelectionPanel.Controls.Add(this.btnShipment);
            this.shipmentSelectionPanel.Controls.Add(this.vScrollBar1);
            this.shipmentSelectionPanel.Controls.Add(this.cbShipments);
            this.shipmentSelectionPanel.Location = new System.Drawing.Point(12, 176);
            this.shipmentSelectionPanel.Name = "shipmentSelectionPanel";
            this.shipmentSelectionPanel.Size = new System.Drawing.Size(493, 228);
            this.shipmentSelectionPanel.TabIndex = 0;
            this.shipmentSelectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.shipmentSelectionPanel_Paint);
            // 
            // btnShipment
            // 
            this.btnShipment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipment.Location = new System.Drawing.Point(225, 190);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.Size = new System.Drawing.Size(116, 23);
            this.btnShipment.TabIndex = 3;
            this.btnShipment.Text = "Select Shipment";
            this.btnShipment.UseVisualStyleBackColor = true;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(437, 30);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 150);
            this.vScrollBar1.TabIndex = 2;
            // 
            // cbShipments
            // 
            this.cbShipments.FormattingEnabled = true;
            this.cbShipments.Location = new System.Drawing.Point(140, 30);
            this.cbShipments.Name = "cbShipments";
            this.cbShipments.Size = new System.Drawing.Size(318, 154);
            this.cbShipments.TabIndex = 1;
            this.cbShipments.SelectedIndexChanged += new System.EventHandler(this.clbShipments_SelectedIndexChanged);
            // 
            // cbLineItems
            // 
            this.cbLineItems.FormattingEnabled = true;
            this.cbLineItems.Location = new System.Drawing.Point(103, 30);
            this.cbLineItems.Name = "cbLineItems";
            this.cbLineItems.Size = new System.Drawing.Size(315, 154);
            this.cbLineItems.TabIndex = 1;
            this.cbLineItems.SelectedIndexChanged += new System.EventHandler(this.cblLineItems_SelectedIndexChanged);
            // 
            // lblLineItems
            // 
            this.lblLineItems.AutoSize = true;
            this.lblLineItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLineItems.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineItems.Location = new System.Drawing.Point(747, 152);
            this.lblLineItems.Name = "lblLineItems";
            this.lblLineItems.Size = new System.Drawing.Size(80, 17);
            this.lblLineItems.TabIndex = 2;
            this.lblLineItems.Text = "Line Items";
            this.lblLineItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainShippment
            // 
            this.lblMainShippment.AutoSize = true;
            this.lblMainShippment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMainShippment.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainShippment.Location = new System.Drawing.Point(201, 152);
            this.lblMainShippment.Name = "lblMainShippment";
            this.lblMainShippment.Size = new System.Drawing.Size(76, 17);
            this.lblMainShippment.TabIndex = 3;
            this.lblMainShippment.Text = "Shipments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btnSelectShipmentLineItem);
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Controls.Add(this.cbLineItems);
            this.panel1.Location = new System.Drawing.Point(537, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 228);
            this.panel1.TabIndex = 4;
            // 
            // btnSelectShipmentLineItem
            // 
            this.btnSelectShipmentLineItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectShipmentLineItem.Location = new System.Drawing.Point(202, 190);
            this.btnSelectShipmentLineItem.Name = "btnSelectShipmentLineItem";
            this.btnSelectShipmentLineItem.Size = new System.Drawing.Size(103, 23);
            this.btnSelectShipmentLineItem.TabIndex = 3;
            this.btnSelectShipmentLineItem.Text = "Select Line Item";
            this.btnSelectShipmentLineItem.UseVisualStyleBackColor = true;
            this.btnSelectShipmentLineItem.Click += new System.EventHandler(this.btnLineItem_Click);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(400, 30);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(18, 154);
            this.vScrollBar2.TabIndex = 2;
            // 
            // btnSelectAddItemQuantity
            // 
            this.btnSelectAddItemQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAddItemQuantity.Location = new System.Drawing.Point(354, 410);
            this.btnSelectAddItemQuantity.Name = "btnSelectAddItemQuantity";
            this.btnSelectAddItemQuantity.Size = new System.Drawing.Size(105, 23);
            this.btnSelectAddItemQuantity.TabIndex = 5;
            this.btnSelectAddItemQuantity.Text = "Select Quantity";
            this.btnSelectAddItemQuantity.UseVisualStyleBackColor = true;
            this.btnSelectAddItemQuantity.Click += new System.EventHandler(this.btnSelectAddItemQuantity_Click);
            // 
            // btnCancelAddItem
            // 
            this.btnCancelAddItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddItem.Location = new System.Drawing.Point(571, 410);
            this.btnCancelAddItem.Name = "btnCancelAddItem";
            this.btnCancelAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddItem.TabIndex = 6;
            this.btnCancelAddItem.Text = "Cancel";
            this.btnCancelAddItem.UseVisualStyleBackColor = true;
            this.btnCancelAddItem.Click += new System.EventHandler(this.btnCancelAddItem_Click);
            // 
            // quantityPanel
            // 
            this.quantityPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.quantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityPanel.Controls.Add(this.label2);
            this.quantityPanel.Controls.Add(this.cbBinSelection);
            this.quantityPanel.Controls.Add(this.btnCancelQuantity);
            this.quantityPanel.Controls.Add(this.btnConfirmAddItems);
            this.quantityPanel.Controls.Add(this.label1);
            this.quantityPanel.Controls.Add(this.numAddItemQuantity);
            this.quantityPanel.Location = new System.Drawing.Point(400, 132);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(246, 168);
            this.quantityPanel.TabIndex = 7;
            this.quantityPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Bin:";
            // 
            // cbBinSelection
            // 
            this.cbBinSelection.FormattingEnabled = true;
            this.cbBinSelection.Location = new System.Drawing.Point(60, 90);
            this.cbBinSelection.Name = "cbBinSelection";
            this.cbBinSelection.Size = new System.Drawing.Size(121, 21);
            this.cbBinSelection.TabIndex = 4;
            // 
            // btnCancelQuantity
            // 
            this.btnCancelQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelQuantity.Location = new System.Drawing.Point(137, 117);
            this.btnCancelQuantity.Name = "btnCancelQuantity";
            this.btnCancelQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnCancelQuantity.TabIndex = 3;
            this.btnCancelQuantity.Text = "Cancel";
            this.btnCancelQuantity.UseVisualStyleBackColor = true;
            this.btnCancelQuantity.Click += new System.EventHandler(this.btnCancelQuantity_Click);
            // 
            // btnConfirmAddItems
            // 
            this.btnConfirmAddItems.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddItems.Location = new System.Drawing.Point(30, 117);
            this.btnConfirmAddItems.Name = "btnConfirmAddItems";
            this.btnConfirmAddItems.Size = new System.Drawing.Size(100, 23);
            this.btnConfirmAddItems.TabIndex = 2;
            this.btnConfirmAddItems.Text = "Confirm Add Items";
            this.btnConfirmAddItems.UseVisualStyleBackColor = true;
            this.btnConfirmAddItems.Click += new System.EventHandler(this.btnConfirmAddItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm Quantity:";
            // 
            // numAddItemQuantity
            // 
            this.numAddItemQuantity.Location = new System.Drawing.Point(60, 50);
            this.numAddItemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddItemQuantity.Name = "numAddItemQuantity";
            this.numAddItemQuantity.Size = new System.Drawing.Size(131, 20);
            this.numAddItemQuantity.TabIndex = 0;
            this.numAddItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddItemQuantity.ValueChanged += new System.EventHandler(this.numAddItemQuantity_ValueChanged);
            // 
            // btnResetButtons
            // 
            this.btnResetButtons.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetButtons.Location = new System.Drawing.Point(476, 410);
            this.btnResetButtons.Name = "btnResetButtons";
            this.btnResetButtons.Size = new System.Drawing.Size(75, 23);
            this.btnResetButtons.TabIndex = 8;
            this.btnResetButtons.Text = "Clear";
            this.btnResetButtons.UseVisualStyleBackColor = true;
            this.btnResetButtons.Click += new System.EventHandler(this.btnResetButtons_Click);
            // 
            // ReceiveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1023, 436);
            this.Controls.Add(this.btnResetButtons);
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.btnCancelAddItem);
            this.Controls.Add(this.lblMainShippment);
            this.Controls.Add(this.btnSelectAddItemQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLineItems);
            this.Controls.Add(this.shipmentSelectionPanel);
            this.Name = "ReceiveItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.Controls.SetChildIndex(this.shipmentSelectionPanel, 0);
            this.Controls.SetChildIndex(this.lblLineItems, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSelectAddItemQuantity, 0);
            this.Controls.SetChildIndex(this.lblMainShippment, 0);
            this.Controls.SetChildIndex(this.btnCancelAddItem, 0);
            this.Controls.SetChildIndex(this.quantityPanel, 0);
            this.Controls.SetChildIndex(this.btnResetButtons, 0);
            this.shipmentSelectionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddItemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel shipmentSelectionPanel;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckedListBox cbShipments;
        private System.Windows.Forms.CheckedListBox cbLineItems;
        private System.Windows.Forms.Label lblLineItems;
        private System.Windows.Forms.Label lblMainShippment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectShipmentLineItem;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button btnSelectAddItemQuantity;
        private System.Windows.Forms.Button btnCancelAddItem;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.NumericUpDown numAddItemQuantity;
        private System.Windows.Forms.Button btnCancelQuantity;
        private System.Windows.Forms.Button btnConfirmAddItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBinSelection;
        private System.Windows.Forms.Button btnResetButtons;
    }
}