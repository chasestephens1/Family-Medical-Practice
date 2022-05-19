
namespace ForsythFamilyPurchasingAndRequisition
{
    partial class ApproveOrder
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
            this.lbPurchaseReqLineItems = new System.Windows.Forms.CheckedListBox();
            this.lablePR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectPurReq = new System.Windows.Forms.Button();
            this.btnSelectLineItem = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lbPurchaseReqs = new System.Windows.Forms.CheckedListBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnResetButtons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPurchaseReqLineItems
            // 
            this.lbPurchaseReqLineItems.FormattingEnabled = true;
            this.lbPurchaseReqLineItems.Location = new System.Drawing.Point(421, 195);
            this.lbPurchaseReqLineItems.Name = "lbPurchaseReqLineItems";
            this.lbPurchaseReqLineItems.Size = new System.Drawing.Size(335, 184);
            this.lbPurchaseReqLineItems.TabIndex = 2;
            this.lbPurchaseReqLineItems.SelectedIndexChanged += new System.EventHandler(this.lbPurchaseReqLineItems_SelectedIndexChanged);
            // 
            // lablePR
            // 
            this.lablePR.AutoSize = true;
            this.lablePR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lablePR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablePR.Location = new System.Drawing.Point(120, 176);
            this.lablePR.Name = "lablePR";
            this.lablePR.Size = new System.Drawing.Size(162, 15);
            this.lablePR.TabIndex = 3;
            this.lablePR.Text = "Select Purchase Requisition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Line Item";
            // 
            // btnSelectPurReq
            // 
            this.btnSelectPurReq.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPurReq.Location = new System.Drawing.Point(118, 385);
            this.btnSelectPurReq.Name = "btnSelectPurReq";
            this.btnSelectPurReq.Size = new System.Drawing.Size(164, 23);
            this.btnSelectPurReq.TabIndex = 5;
            this.btnSelectPurReq.Text = "Select Purchase Requisition";
            this.btnSelectPurReq.UseVisualStyleBackColor = true;
            this.btnSelectPurReq.Click += new System.EventHandler(this.btnSelectPurReq_Click);
            // 
            // btnSelectLineItem
            // 
            this.btnSelectLineItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLineItem.Location = new System.Drawing.Point(529, 385);
            this.btnSelectLineItem.Name = "btnSelectLineItem";
            this.btnSelectLineItem.Size = new System.Drawing.Size(110, 23);
            this.btnSelectLineItem.TabIndex = 6;
            this.btnSelectLineItem.Text = "Select Line Item";
            this.btnSelectLineItem.UseVisualStyleBackColor = true;
            this.btnSelectLineItem.Click += new System.EventHandler(this.btnSelectLineItem_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(183, 415);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 7;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseMnemonic = false;
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.Location = new System.Drawing.Point(284, 415);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(75, 23);
            this.btnDecline.TabIndex = 8;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(357, 195);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(22, 184);
            this.vScrollBar1.TabIndex = 9;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(734, 195);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(22, 184);
            this.vScrollBar2.TabIndex = 10;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(564, 415);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOrder.TabIndex = 11;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // lbPurchaseReqs
            // 
            this.lbPurchaseReqs.FormattingEnabled = true;
            this.lbPurchaseReqs.Location = new System.Drawing.Point(45, 195);
            this.lbPurchaseReqs.Name = "lbPurchaseReqs";
            this.lbPurchaseReqs.Size = new System.Drawing.Size(335, 184);
            this.lbPurchaseReqs.TabIndex = 1;
            this.lbPurchaseReqs.SelectedIndexChanged += new System.EventHandler(this.lbPurchaseReqs_SelectedIndexChange);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(458, 415);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnResetButtons
            // 
            this.btnResetButtons.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetButtons.Location = new System.Drawing.Point(377, 415);
            this.btnResetButtons.Name = "btnResetButtons";
            this.btnResetButtons.Size = new System.Drawing.Size(75, 23);
            this.btnResetButtons.TabIndex = 13;
            this.btnResetButtons.Text = "Restart";
            this.btnResetButtons.UseVisualStyleBackColor = true;
            this.btnResetButtons.Click += new System.EventHandler(this.btnResetButtons_Click);
            // 
            // ApproveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetButtons);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnSelectLineItem);
            this.Controls.Add(this.btnSelectPurReq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lablePR);
            this.Controls.Add(this.lbPurchaseReqLineItems);
            this.Controls.Add(this.lbPurchaseReqs);
            this.Name = "ApproveOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Place Order";
            this.Controls.SetChildIndex(this.lbPurchaseReqs, 0);
            this.Controls.SetChildIndex(this.lbPurchaseReqLineItems, 0);
            this.Controls.SetChildIndex(this.lablePR, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSelectPurReq, 0);
            this.Controls.SetChildIndex(this.btnSelectLineItem, 0);
            this.Controls.SetChildIndex(this.btnApprove, 0);
            this.Controls.SetChildIndex(this.btnDecline, 0);
            this.Controls.SetChildIndex(this.vScrollBar1, 0);
            this.Controls.SetChildIndex(this.vScrollBar2, 0);
            this.Controls.SetChildIndex(this.btnCancelOrder, 0);
            this.Controls.SetChildIndex(this.btnPlaceOrder, 0);
            this.Controls.SetChildIndex(this.btnResetButtons, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox lbPurchaseReqLineItems;
        private System.Windows.Forms.Label lablePR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectPurReq;
        private System.Windows.Forms.Button btnSelectLineItem;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.CheckedListBox lbPurchaseReqs;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnResetButtons;
    }
}