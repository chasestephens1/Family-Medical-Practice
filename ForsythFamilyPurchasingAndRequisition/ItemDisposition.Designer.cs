
namespace ForsythFamilyPurchasingAndRequisition
{
    partial class ItemDisposition
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
            this.itemPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnItemDispoSelect = new System.Windows.Forms.Button();
            this.clbItemSelection = new System.Windows.Forms.CheckedListBox();
            this.lblItemSelection = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnDispoReason = new System.Windows.Forms.Button();
            this.clbReason = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDispoQuantity = new System.Windows.Forms.Button();
            this.btnCancelDisposition = new System.Windows.Forms.Button();
            this.itemDispoQuantityPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBinID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numDispoQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnCancelQuantity = new System.Windows.Forms.Button();
            this.btnConfirmDispoQuantity = new System.Windows.Forms.Button();
            this.btnResetButtons = new System.Windows.Forms.Button();
            this.itemPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.itemDispoQuantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDispoQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel
            // 
            this.itemPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.itemPanel.Controls.Add(this.vScrollBar1);
            this.itemPanel.Controls.Add(this.panel1);
            this.itemPanel.Controls.Add(this.btnItemDispoSelect);
            this.itemPanel.Controls.Add(this.clbItemSelection);
            this.itemPanel.Location = new System.Drawing.Point(12, 179);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(296, 190);
            this.itemPanel.TabIndex = 0;
            this.itemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.itemPanel_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(272, 28);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 124);
            this.vScrollBar1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(313, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnItemDispoSelect
            // 
            this.btnItemDispoSelect.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDispoSelect.Location = new System.Drawing.Point(99, 158);
            this.btnItemDispoSelect.Name = "btnItemDispoSelect";
            this.btnItemDispoSelect.Size = new System.Drawing.Size(75, 23);
            this.btnItemDispoSelect.TabIndex = 1;
            this.btnItemDispoSelect.Text = "Select Item";
            this.btnItemDispoSelect.UseVisualStyleBackColor = true;
            this.btnItemDispoSelect.Click += new System.EventHandler(this.btnItemSelect_Click);
            // 
            // clbItemSelection
            // 
            this.clbItemSelection.FormattingEnabled = true;
            this.clbItemSelection.Location = new System.Drawing.Point(3, 28);
            this.clbItemSelection.Name = "clbItemSelection";
            this.clbItemSelection.Size = new System.Drawing.Size(290, 124);
            this.clbItemSelection.TabIndex = 0;
            this.clbItemSelection.SelectedIndexChanged += new System.EventHandler(this.clbItemSelection_SelectedIndexChanged);
            // 
            // lblItemSelection
            // 
            this.lblItemSelection.AutoSize = true;
            this.lblItemSelection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblItemSelection.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSelection.Location = new System.Drawing.Point(121, 157);
            this.lblItemSelection.Name = "lblItemSelection";
            this.lblItemSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblItemSelection.Size = new System.Drawing.Size(46, 17);
            this.lblItemSelection.TabIndex = 1;
            this.lblItemSelection.Text = "Items";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.vScrollBar2);
            this.panel2.Controls.Add(this.btnDispoReason);
            this.panel2.Controls.Add(this.clbReason);
            this.panel2.Location = new System.Drawing.Point(328, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 190);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(278, 28);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(19, 124);
            this.vScrollBar2.TabIndex = 2;
            // 
            // btnDispoReason
            // 
            this.btnDispoReason.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispoReason.Location = new System.Drawing.Point(105, 158);
            this.btnDispoReason.Name = "btnDispoReason";
            this.btnDispoReason.Size = new System.Drawing.Size(91, 23);
            this.btnDispoReason.TabIndex = 1;
            this.btnDispoReason.Text = "Select Reason";
            this.btnDispoReason.UseVisualStyleBackColor = true;
            this.btnDispoReason.Click += new System.EventHandler(this.btnReason_Click);
            // 
            // clbReason
            // 
            this.clbReason.FormattingEnabled = true;
            this.clbReason.Location = new System.Drawing.Point(4, 28);
            this.clbReason.Name = "clbReason";
            this.clbReason.Size = new System.Drawing.Size(293, 124);
            this.clbReason.TabIndex = 0;
            this.clbReason.SelectedIndexChanged += new System.EventHandler(this.clbReason_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reason for Disposition";
            // 
            // btnSelectDispoQuantity
            // 
            this.btnSelectDispoQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDispoQuantity.Location = new System.Drawing.Point(182, 375);
            this.btnSelectDispoQuantity.Name = "btnSelectDispoQuantity";
            this.btnSelectDispoQuantity.Size = new System.Drawing.Size(95, 23);
            this.btnSelectDispoQuantity.TabIndex = 4;
            this.btnSelectDispoQuantity.Text = "Select Quantity";
            this.btnSelectDispoQuantity.UseVisualStyleBackColor = true;
            this.btnSelectDispoQuantity.Click += new System.EventHandler(this.btnConfirmDispo_Click);
            // 
            // btnCancelDisposition
            // 
            this.btnCancelDisposition.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDisposition.Location = new System.Drawing.Point(369, 375);
            this.btnCancelDisposition.Name = "btnCancelDisposition";
            this.btnCancelDisposition.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDisposition.TabIndex = 5;
            this.btnCancelDisposition.Text = "Cancel";
            this.btnCancelDisposition.UseVisualStyleBackColor = true;
            this.btnCancelDisposition.Click += new System.EventHandler(this.btnCancelDisposition_Click);
            // 
            // itemDispoQuantityPanel
            // 
            this.itemDispoQuantityPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemDispoQuantityPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.itemDispoQuantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDispoQuantityPanel.Controls.Add(this.label3);
            this.itemDispoQuantityPanel.Controls.Add(this.cbBinID);
            this.itemDispoQuantityPanel.Controls.Add(this.label2);
            this.itemDispoQuantityPanel.Controls.Add(this.numDispoQuantity);
            this.itemDispoQuantityPanel.Controls.Add(this.btnCancelQuantity);
            this.itemDispoQuantityPanel.Controls.Add(this.btnConfirmDispoQuantity);
            this.itemDispoQuantityPanel.Location = new System.Drawing.Point(233, 132);
            this.itemDispoQuantityPanel.Name = "itemDispoQuantityPanel";
            this.itemDispoQuantityPanel.Size = new System.Drawing.Size(200, 161);
            this.itemDispoQuantityPanel.TabIndex = 6;
            this.itemDispoQuantityPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Bin:";
            // 
            // cbBinID
            // 
            this.cbBinID.FormattingEnabled = true;
            this.cbBinID.Location = new System.Drawing.Point(33, 24);
            this.cbBinID.Name = "cbBinID";
            this.cbBinID.Size = new System.Drawing.Size(121, 21);
            this.cbBinID.TabIndex = 4;
            this.cbBinID.SelectedIndexChanged += new System.EventHandler(this.cbBinID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Quantity:";
            // 
            // numDispoQuantity
            // 
            this.numDispoQuantity.Location = new System.Drawing.Point(33, 74);
            this.numDispoQuantity.Name = "numDispoQuantity";
            this.numDispoQuantity.Size = new System.Drawing.Size(121, 20);
            this.numDispoQuantity.TabIndex = 2;
            // 
            // btnCancelQuantity
            // 
            this.btnCancelQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelQuantity.Location = new System.Drawing.Point(99, 117);
            this.btnCancelQuantity.Name = "btnCancelQuantity";
            this.btnCancelQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnCancelQuantity.TabIndex = 1;
            this.btnCancelQuantity.Text = "Cancel";
            this.btnCancelQuantity.UseVisualStyleBackColor = true;
            this.btnCancelQuantity.Click += new System.EventHandler(this.btnCancelQuantity_Click);
            // 
            // btnConfirmDispoQuantity
            // 
            this.btnConfirmDispoQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDispoQuantity.Location = new System.Drawing.Point(18, 117);
            this.btnConfirmDispoQuantity.Name = "btnConfirmDispoQuantity";
            this.btnConfirmDispoQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmDispoQuantity.TabIndex = 0;
            this.btnConfirmDispoQuantity.Text = "Confirm";
            this.btnConfirmDispoQuantity.UseVisualStyleBackColor = true;
            this.btnConfirmDispoQuantity.Click += new System.EventHandler(this.btnConfirmDispoQuantity_Click);
            // 
            // btnResetButtons
            // 
            this.btnResetButtons.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetButtons.Location = new System.Drawing.Point(284, 375);
            this.btnResetButtons.Name = "btnResetButtons";
            this.btnResetButtons.Size = new System.Drawing.Size(75, 23);
            this.btnResetButtons.TabIndex = 7;
            this.btnResetButtons.Text = "Clear";
            this.btnResetButtons.UseVisualStyleBackColor = true;
            this.btnResetButtons.Click += new System.EventHandler(this.btnResetButtons_Click);
            // 
            // ItemDisposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(678, 434);
            this.Controls.Add(this.btnResetButtons);
            this.Controls.Add(this.itemDispoQuantityPanel);
            this.Controls.Add(this.btnCancelDisposition);
            this.Controls.Add(this.btnSelectDispoQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblItemSelection);
            this.Controls.Add(this.itemPanel);
            this.Name = "ItemDisposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Disposition";
            this.Controls.SetChildIndex(this.itemPanel, 0);
            this.Controls.SetChildIndex(this.lblItemSelection, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSelectDispoQuantity, 0);
            this.Controls.SetChildIndex(this.btnCancelDisposition, 0);
            this.Controls.SetChildIndex(this.itemDispoQuantityPanel, 0);
            this.Controls.SetChildIndex(this.btnResetButtons, 0);
            this.itemPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.itemDispoQuantityPanel.ResumeLayout(false);
            this.itemDispoQuantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDispoQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel itemPanel;
        private System.Windows.Forms.Label lblItemSelection;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnItemDispoSelect;
        private System.Windows.Forms.CheckedListBox clbItemSelection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button btnDispoReason;
        private System.Windows.Forms.CheckedListBox clbReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectDispoQuantity;
        private System.Windows.Forms.Button btnCancelDisposition;
        private System.Windows.Forms.Panel itemDispoQuantityPanel;
        private System.Windows.Forms.NumericUpDown numDispoQuantity;
        private System.Windows.Forms.Button btnCancelQuantity;
        private System.Windows.Forms.Button btnConfirmDispoQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBinID;
        private System.Windows.Forms.Button btnResetButtons;
    }
}