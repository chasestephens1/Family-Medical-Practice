
namespace ForsythFamilyPurchasingAndRequisition
{
    partial class AddItem
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
            this.clbShipments = new System.Windows.Forms.CheckedListBox();
            this.cblLineItems = new System.Windows.Forms.CheckedListBox();
            this.lblLineItems = new System.Windows.Forms.Label();
            this.lblMainShippment = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLineItem = new System.Windows.Forms.Button();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.btnCancelAddItem = new System.Windows.Forms.Button();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.btnCancelQuantity = new System.Windows.Forms.Button();
            this.btnConfirmQuantity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.shipmentSelectionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // shipmentSelectionPanel
            // 
            this.shipmentSelectionPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.shipmentSelectionPanel.Controls.Add(this.btnShipment);
            this.shipmentSelectionPanel.Controls.Add(this.vScrollBar1);
            this.shipmentSelectionPanel.Controls.Add(this.clbShipments);
            this.shipmentSelectionPanel.Location = new System.Drawing.Point(12, 176);
            this.shipmentSelectionPanel.Name = "shipmentSelectionPanel";
            this.shipmentSelectionPanel.Size = new System.Drawing.Size(493, 228);
            this.shipmentSelectionPanel.TabIndex = 0;
            this.shipmentSelectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.shipmentSelectionPanel_Paint);
            // 
            // btnShipment
            // 
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
            // clbShipments
            // 
            this.clbShipments.FormattingEnabled = true;
            this.clbShipments.Location = new System.Drawing.Point(140, 30);
            this.clbShipments.Name = "clbShipments";
            this.clbShipments.Size = new System.Drawing.Size(318, 154);
            this.clbShipments.TabIndex = 1;
            this.clbShipments.SelectedIndexChanged += new System.EventHandler(this.clbShipments_SelectedIndexChanged);
            // 
            // cblLineItems
            // 
            this.cblLineItems.FormattingEnabled = true;
            this.cblLineItems.Location = new System.Drawing.Point(103, 30);
            this.cblLineItems.Name = "cblLineItems";
            this.cblLineItems.Size = new System.Drawing.Size(315, 154);
            this.cblLineItems.TabIndex = 1;
            this.cblLineItems.SelectedIndexChanged += new System.EventHandler(this.cblLineItems_SelectedIndexChanged);
            // 
            // lblLineItems
            // 
            this.lblLineItems.AutoSize = true;
            this.lblLineItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineItems.Location = new System.Drawing.Point(747, 152);
            this.lblLineItems.Name = "lblLineItems";
            this.lblLineItems.Size = new System.Drawing.Size(95, 24);
            this.lblLineItems.TabIndex = 2;
            this.lblLineItems.Text = "Line Items";
            this.lblLineItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainShippment
            // 
            this.lblMainShippment.AutoSize = true;
            this.lblMainShippment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainShippment.Location = new System.Drawing.Point(233, 149);
            this.lblMainShippment.Name = "lblMainShippment";
            this.lblMainShippment.Size = new System.Drawing.Size(99, 24);
            this.lblMainShippment.TabIndex = 3;
            this.lblMainShippment.Text = "Shipments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btnLineItem);
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Controls.Add(this.cblLineItems);
            this.panel1.Location = new System.Drawing.Point(537, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 228);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLineItem
            // 
            this.btnLineItem.Location = new System.Drawing.Point(202, 190);
            this.btnLineItem.Name = "btnLineItem";
            this.btnLineItem.Size = new System.Drawing.Size(103, 23);
            this.btnLineItem.TabIndex = 3;
            this.btnLineItem.Text = "Select Line Item";
            this.btnLineItem.UseVisualStyleBackColor = true;
            this.btnLineItem.Click += new System.EventHandler(this.btnLineItem_Click);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(400, 30);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(18, 154);
            this.vScrollBar2.TabIndex = 2;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(400, 410);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(105, 23);
            this.btnConfirmAdd.TabIndex = 5;
            this.btnConfirmAdd.Text = "Confirm Add Item";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // btnCancelAddItem
            // 
            this.btnCancelAddItem.Location = new System.Drawing.Point(537, 410);
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
            this.quantityPanel.Controls.Add(this.btnCancelQuantity);
            this.quantityPanel.Controls.Add(this.btnConfirmQuantity);
            this.quantityPanel.Controls.Add(this.label1);
            this.quantityPanel.Controls.Add(this.numericUpDown1);
            this.quantityPanel.Location = new System.Drawing.Point(400, 132);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(246, 168);
            this.quantityPanel.TabIndex = 7;
            this.quantityPanel.Visible = false;
            // 
            // btnCancelQuantity
            // 
            this.btnCancelQuantity.Location = new System.Drawing.Point(137, 117);
            this.btnCancelQuantity.Name = "btnCancelQuantity";
            this.btnCancelQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnCancelQuantity.TabIndex = 3;
            this.btnCancelQuantity.Text = "Cancel";
            this.btnCancelQuantity.UseVisualStyleBackColor = true;
            this.btnCancelQuantity.Click += new System.EventHandler(this.btnCancelQuantity_Click);
            // 
            // btnConfirmQuantity
            // 
            this.btnConfirmQuantity.Location = new System.Drawing.Point(30, 117);
            this.btnConfirmQuantity.Name = "btnConfirmQuantity";
            this.btnConfirmQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmQuantity.TabIndex = 2;
            this.btnConfirmQuantity.Text = "Confirm";
            this.btnConfirmQuantity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirm Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 74);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1023, 436);
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.btnCancelAddItem);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMainShippment);
            this.Controls.Add(this.lblLineItems);
            this.Controls.Add(this.shipmentSelectionPanel);
            this.Name = "AddItem";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.Controls.SetChildIndex(this.shipmentSelectionPanel, 0);
            this.Controls.SetChildIndex(this.lblLineItems, 0);
            this.Controls.SetChildIndex(this.lblMainShippment, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnConfirmAdd, 0);
            this.Controls.SetChildIndex(this.btnCancelAddItem, 0);
            this.Controls.SetChildIndex(this.quantityPanel, 0);
            this.shipmentSelectionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel shipmentSelectionPanel;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckedListBox clbShipments;
        private System.Windows.Forms.CheckedListBox cblLineItems;
        private System.Windows.Forms.Label lblLineItems;
        private System.Windows.Forms.Label lblMainShippment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLineItem;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Button btnCancelAddItem;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCancelQuantity;
        private System.Windows.Forms.Button btnConfirmQuantity;
        private System.Windows.Forms.Label label1;
    }
}