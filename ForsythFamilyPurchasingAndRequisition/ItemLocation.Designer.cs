
namespace ForsythFamilyPurchasingAndRequisition
{
    partial class ItemLocation
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
            this.cbItems = new System.Windows.Forms.CheckedListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cbItemLocation = new System.Windows.Forms.CheckedListBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.btnSelectLocation = new System.Windows.Forms.Button();
            this.btnLocationSelectQuantity = new System.Windows.Forms.Button();
            this.btnCancelLocation = new System.Windows.Forms.Button();
            this.itemLocationQuantityPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelectBinId = new System.Windows.Forms.ComboBox();
            this.btnCancelLocationQuantity = new System.Windows.Forms.Button();
            this.btnConfirmLocationQuantity = new System.Windows.Forms.Button();
            this.numLocationQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetButtons = new System.Windows.Forms.Button();
            this.itemLocationQuantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocationQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(52, 186);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(322, 184);
            this.cbItems.TabIndex = 1;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(351, 186);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 184);
            this.vScrollBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Item to Move";
            // 
            // cbItemLocation
            // 
            this.cbItemLocation.FormattingEnabled = true;
            this.cbItemLocation.Location = new System.Drawing.Point(453, 186);
            this.cbItemLocation.Name = "cbItemLocation";
            this.cbItemLocation.Size = new System.Drawing.Size(322, 184);
            this.cbItemLocation.TabIndex = 4;
            this.cbItemLocation.SelectedIndexChanged += new System.EventHandler(this.cbItemLocation_SelectedIndexChanged);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(753, 186);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(22, 184);
            this.vScrollBar2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select New Location";
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItem.Location = new System.Drawing.Point(148, 376);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(75, 23);
            this.btnSelectItem.TabIndex = 7;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLocation.Location = new System.Drawing.Point(560, 376);
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Size = new System.Drawing.Size(105, 23);
            this.btnSelectLocation.TabIndex = 8;
            this.btnSelectLocation.Text = "Select Location";
            this.btnSelectLocation.UseVisualStyleBackColor = true;
            this.btnSelectLocation.Click += new System.EventHandler(this.btnSelectLocation_Click);
            // 
            // btnLocationSelectQuantity
            // 
            this.btnLocationSelectQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationSelectQuantity.Location = new System.Drawing.Point(271, 415);
            this.btnLocationSelectQuantity.Name = "btnLocationSelectQuantity";
            this.btnLocationSelectQuantity.Size = new System.Drawing.Size(102, 23);
            this.btnLocationSelectQuantity.TabIndex = 9;
            this.btnLocationSelectQuantity.Text = "Select Quantity";
            this.btnLocationSelectQuantity.UseVisualStyleBackColor = true;
            this.btnLocationSelectQuantity.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancelLocation
            // 
            this.btnCancelLocation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLocation.Location = new System.Drawing.Point(465, 415);
            this.btnCancelLocation.Name = "btnCancelLocation";
            this.btnCancelLocation.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLocation.TabIndex = 10;
            this.btnCancelLocation.Text = "Cancel";
            this.btnCancelLocation.UseVisualStyleBackColor = true;
            this.btnCancelLocation.Click += new System.EventHandler(this.btnCancelLocation_Click);
            // 
            // itemLocationQuantityPanel
            // 
            this.itemLocationQuantityPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.itemLocationQuantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemLocationQuantityPanel.Controls.Add(this.label4);
            this.itemLocationQuantityPanel.Controls.Add(this.cbSelectBinId);
            this.itemLocationQuantityPanel.Controls.Add(this.btnCancelLocationQuantity);
            this.itemLocationQuantityPanel.Controls.Add(this.btnConfirmLocationQuantity);
            this.itemLocationQuantityPanel.Controls.Add(this.numLocationQuantity);
            this.itemLocationQuantityPanel.Controls.Add(this.label3);
            this.itemLocationQuantityPanel.Location = new System.Drawing.Point(303, 148);
            this.itemLocationQuantityPanel.Name = "itemLocationQuantityPanel";
            this.itemLocationQuantityPanel.Size = new System.Drawing.Size(230, 183);
            this.itemLocationQuantityPanel.TabIndex = 11;
            this.itemLocationQuantityPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Bin:";
            // 
            // cbSelectBinId
            // 
            this.cbSelectBinId.FormattingEnabled = true;
            this.cbSelectBinId.Location = new System.Drawing.Point(47, 85);
            this.cbSelectBinId.Name = "cbSelectBinId";
            this.cbSelectBinId.Size = new System.Drawing.Size(121, 21);
            this.cbSelectBinId.TabIndex = 6;
            // 
            // btnCancelLocationQuantity
            // 
            this.btnCancelLocationQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLocationQuantity.Location = new System.Drawing.Point(125, 123);
            this.btnCancelLocationQuantity.Name = "btnCancelLocationQuantity";
            this.btnCancelLocationQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnCancelLocationQuantity.TabIndex = 5;
            this.btnCancelLocationQuantity.Text = "Cancel";
            this.btnCancelLocationQuantity.UseVisualStyleBackColor = true;
            this.btnCancelLocationQuantity.Click += new System.EventHandler(this.btnCancelLocationQuantity_Click);
            // 
            // btnConfirmLocationQuantity
            // 
            this.btnConfirmLocationQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmLocationQuantity.Location = new System.Drawing.Point(34, 123);
            this.btnConfirmLocationQuantity.Name = "btnConfirmLocationQuantity";
            this.btnConfirmLocationQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmLocationQuantity.TabIndex = 4;
            this.btnConfirmLocationQuantity.Text = "Confirm";
            this.btnConfirmLocationQuantity.UseVisualStyleBackColor = true;
            this.btnConfirmLocationQuantity.Click += new System.EventHandler(this.btnConfirmLocationQuantity_Click);
            // 
            // numLocationQuantity
            // 
            this.numLocationQuantity.Location = new System.Drawing.Point(48, 37);
            this.numLocationQuantity.Name = "numLocationQuantity";
            this.numLocationQuantity.Size = new System.Drawing.Size(120, 20);
            this.numLocationQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Quantity:";
            // 
            // btnResetButtons
            // 
            this.btnResetButtons.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetButtons.Location = new System.Drawing.Point(384, 415);
            this.btnResetButtons.Name = "btnResetButtons";
            this.btnResetButtons.Size = new System.Drawing.Size(75, 23);
            this.btnResetButtons.TabIndex = 14;
            this.btnResetButtons.Text = "Clear";
            this.btnResetButtons.UseVisualStyleBackColor = true;
            this.btnResetButtons.Click += new System.EventHandler(this.btnResetButtons_Click);
            // 
            // ItemLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.btnResetButtons);
            this.Controls.Add(this.itemLocationQuantityPanel);
            this.Controls.Add(this.btnCancelLocation);
            this.Controls.Add(this.btnLocationSelectQuantity);
            this.Controls.Add(this.btnSelectLocation);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.cbItemLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.cbItems);
            this.Name = "ItemLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Location";
            this.Controls.SetChildIndex(this.cbItems, 0);
            this.Controls.SetChildIndex(this.vScrollBar1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbItemLocation, 0);
            this.Controls.SetChildIndex(this.vScrollBar2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSelectItem, 0);
            this.Controls.SetChildIndex(this.btnSelectLocation, 0);
            this.Controls.SetChildIndex(this.btnLocationSelectQuantity, 0);
            this.Controls.SetChildIndex(this.btnCancelLocation, 0);
            this.Controls.SetChildIndex(this.itemLocationQuantityPanel, 0);
            this.Controls.SetChildIndex(this.btnResetButtons, 0);
            this.itemLocationQuantityPanel.ResumeLayout(false);
            this.itemLocationQuantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLocationQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbItems;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cbItemLocation;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.Button btnLocationSelectQuantity;
        private System.Windows.Forms.Button btnCancelLocation;
        private System.Windows.Forms.Panel itemLocationQuantityPanel;
        private System.Windows.Forms.Button btnCancelLocationQuantity;
        private System.Windows.Forms.Button btnConfirmLocationQuantity;
        private System.Windows.Forms.NumericUpDown numLocationQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetButtons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSelectBinId;
    }
}