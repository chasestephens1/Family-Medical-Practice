using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ForsythFamilyPurchasingAndRequisition
{
    
    public partial class ApproveOrder : BaseForm
    {
        public static DateTime currentDate = DateTime.Now;
        public static List<int> approvedItems = new List<int>();
        public static int selectedLineItemID;
        public static int purchaseOrderID;
        public static MedSystemDataSet md = new MedSystemDataSet();
        public ApproveOrder()
        {
            InitializeComponent();
            btnApprove.Enabled = false;
            btnDecline.Enabled = false;
            btnSelectLineItem.Enabled = false;
            btnPlaceOrder.Enabled = false;
            btnSelectPurReq.Enabled = false;
            lbPurchaseReqLineItems.Enabled = false;
            btnResetButtons.Enabled = false;
            PopulatePurchaseRequsition();
            
        }

        private void lbPurchaseReqs_SelectedIndexChange(object sender, EventArgs e)
        {
            int index = lbPurchaseReqs.SelectedIndex;

            for (int x = 0; x < lbPurchaseReqs.Items.Count; x++)
            {
                if (x != index)
                {
                    lbPurchaseReqs.SetItemChecked(x, false);
                }

            }
            MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter purchaseOrdersTableAdapter = new MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter();
            DataTable purchaseOrdersTable = new DataTable();
            purchaseOrdersTableAdapter.Fill(md.PurchaseOrders);
            int purOrders = int.Parse(lbPurchaseReqs.SelectedItem.ToString());
            
            purchaseOrdersTable = md.Tables["PurchaseOrders"];
            DataView purchases = new DataView(purchaseOrdersTable);

            //Filter results
            purchases.RowFilter = "PurchaseOrderID = " + purOrders;
            purchaseOrderID = int.Parse(lbPurchaseReqs.SelectedItem.ToString());
           
            lbPurchaseReqLineItems.Items.Clear();
            btnSelectPurReq.Enabled = true;
            PopulatePurchaseOrderLineItems(purchaseOrderID);
        }
        private void PopulatePurchaseRequsition()
        {
            MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter purchaseOrdersTableAdapter = new MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter();
            DataTable purchaseOrdersTable = new DataTable();
            purchaseOrdersTableAdapter.Fill(md.PurchaseOrders);
            purchaseOrdersTable = md.Tables["PurchaseOrders"];

            for (int i = 0; i < purchaseOrdersTable.Rows.Count; i++)
            {
                
                if ((int)purchaseOrdersTable.Rows[i]["Status"] == 1 || (int)purchaseOrdersTable.Rows[i]["Status"] == 5)
                {
                    lbPurchaseReqs.Items.Add((int)purchaseOrdersTable.Rows[i]["PurchaseOrderID"]);
                }

            }
        }

        private void PopulatePurchaseOrderLineItems(int purchaseOrderID)
        {
            MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter purchaseOrderLineItemsTableAdapter = new MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter();
            DataTable purchaseOrderLineItemsTable = new DataTable();
            purchaseOrderLineItemsTableAdapter.Fill(md.PurchaseOrderLineItems);
            purchaseOrderLineItemsTable = md.Tables["PurchaseOrderLineItems"];
            DataView purchaseOrderLineItems = new DataView(purchaseOrderLineItemsTable);
            purchaseOrderLineItems.RowFilter = "PurchaseOrderID = " + purchaseOrderID;

            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            DataView itemsView = new DataView(itemsTable);
            
            for (int i = 0; i < purchaseOrderLineItems.Count; i++)
            {
                //Filter the items added
                if(bool.Parse(purchaseOrderLineItems[i]["Ordered"].ToString()) == false)
                {
                    for (int x = 0; x < itemsView.Count; x++)
                    {
                        if(bool.Parse(purchaseOrderLineItems[i]["Ordered"].ToString()) == false)
                        {
                            itemsView.RowFilter = "ItemID = " + "'" + int.Parse(purchaseOrderLineItems[i]["ItemNumber"].ToString()) + "'";
                            lbPurchaseReqLineItems.Items.Add("Item: " + itemsView[x]["ItemName"].ToString() + " $" + purchaseOrderLineItems[i]["ItemCost"].ToString() + " #: " + purchaseOrderLineItems[i]["PurchaseQuantity"].ToString() + " Total: $" + (float.Parse(purchaseOrderLineItems[i]["ItemCost"].ToString()) * int.Parse(purchaseOrderLineItems[i]["PurchaseQuantity"].ToString())));
                        }
                        
                    }
                    
                }
                
               
            }
        }

        private void btnSelectPurReq_Click(object sender, EventArgs e)
        {
            btnDecline.Enabled = true;
            if(lbPurchaseReqs.SelectedItem != null)
            {
                btnSelectPurReq.Enabled = false;
                btnSelectLineItem.Enabled = true;
                lbPurchaseReqs.Enabled = false;
                lbPurchaseReqLineItems.Enabled = true;
                btnResetButtons.Enabled = true;
                purchaseOrderID = int.Parse(lbPurchaseReqs.SelectedItem.ToString());
                Console.WriteLine(purchaseOrderID);
            }
            
        }

        private void btnSelectLineItem_Click(object sender, EventArgs e)
        {
            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            DataView itemsView = new DataView(itemsTable);

            if (lbPurchaseReqLineItems.SelectedItem != null)
            {
                btnApprove.Enabled = true;
                btnDecline.Enabled = true;
                lbPurchaseReqLineItems.Enabled = false;
                btnSelectLineItem.Enabled = false;
                String lineItemString = lbPurchaseReqLineItems.SelectedItem.ToString();
                int pFrom = lineItemString.IndexOf("Item: ") + "Item: ".Length;
                int pTo = lineItemString.IndexOf(" $");
                String result = lineItemString.Substring(pFrom, pTo - pFrom);
                result.Trim(' ');
                //Add Code to get
                itemsView.RowFilter = "ItemName = " + "'" + result + "'";
                selectedLineItemID = int.Parse(itemsView[0]["ItemID"].ToString());
                
                
            }
            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            //btnApprove.Enabled = false;
            lbPurchaseReqLineItems.Enabled = true;
            btnDecline.Enabled = false;
            //approvedItems.Add(lbPurchaseReqLineItems.SelectedItem.ToString());
            lbPurchaseReqLineItems.Items.Remove(lbPurchaseReqLineItems.SelectedItem);
            approvedItems.Add(selectedLineItemID);
            btnPlaceOrder.Enabled = true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int max = 0;
            int ShipmentSeqNum = 1;
            btnSelectPurReq.Enabled = true;
            btnSelectLineItem.Enabled = false;
            //Create Shipment
            MedSystemDataSetTableAdapters.ShipmentsTableAdapter shipmentAdapt = new MedSystemDataSetTableAdapters.ShipmentsTableAdapter();
            DataTable shipmentsTable = new DataTable();
            shipmentAdapt.Fill(md.Shipments);
            shipmentsTable = md.Tables["Shipments"];
            DataView shipsView = new DataView(shipmentsTable);
            shipmentAdapt.CreateShippment();
            shipmentAdapt.Fill(md.Shipments);

            MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter lineItemAdapt = new MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter();
            DataTable lineItemTable = new DataTable();
            lineItemAdapt.Fill(md.ShipmentLineItems);
            lineItemTable = md.Tables["ShipmentLineItems"];
            DataView lineItemView = new DataView(lineItemTable);

            
            MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter purchaseOrderLineItemsTableAdapter = new MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter();
            DataTable purchaseOrderLineItemsTable = new DataTable();
            purchaseOrderLineItemsTableAdapter.Fill(md.PurchaseOrderLineItems);
            purchaseOrderLineItemsTable = md.Tables["PurchaseOrderLineItems"];
            DataView purchaseOrderLineItems = new DataView(purchaseOrderLineItemsTable);
            
            
            for(int i = 0; i < shipsView.Count; i++)
            {
                if(int.Parse(shipmentsTable.Rows[i]["ShipmentID"].ToString()) > max)
                {
                    max = int.Parse(shipmentsTable.Rows[i]["ShipmentID"].ToString());
                    Console.WriteLine(max);
                }
            }

            for(int item = 0; item < approvedItems.Count; item++)
            {

                selectedLineItemID = approvedItems[item];
                purchaseOrderLineItems.RowFilter = "ItemNumber = " + int.Parse(approvedItems[item].ToString());
                int expQuantity = int.Parse(purchaseOrderLineItems[0]["PurchaseQuantity"].ToString());
                int purchaseSeq = int.Parse(purchaseOrderLineItems[0]["POLineSeq"].ToString());
                Console.WriteLine(max + " " + ShipmentSeqNum + " " + selectedLineItemID + " " + purchaseOrderID + " " + purchaseSeq + " " + expQuantity);
                lineItemAdapt.Insert(max, ShipmentSeqNum, selectedLineItemID, purchaseOrderID, purchaseSeq, expQuantity, 0);
                ShipmentSeqNum++;
                purchaseOrderLineItemsTableAdapter.UpdatePOLineItem(selectedLineItemID, purchaseOrderID);
               
            }
            approvedItems.Clear();
            MessageBox.Show("Order Placed!");
            btnPlaceOrder.Enabled = false;
            
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;
            btnDecline.Enabled = false;
            btnSelectLineItem.Enabled = false;
            MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter purOrderAdapt = new MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter();
            purOrderAdapt.DecinePurchase(purchaseOrderID);
            MessageBox.Show("Purchase Order Declined.");
        }

        private void lbPurchaseReqLineItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbPurchaseReqLineItems.SelectedIndex;

            for (int x = 0; x < lbPurchaseReqLineItems.Items.Count; x++)
            {
                if (x != index)
                {
                    lbPurchaseReqLineItems.SetItemChecked(x, false);
                    btnSelectLineItem.Enabled = true;
                }

            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            //Code to delete order

            this.Close();
        }

        private void btnResetButtons_Click(object sender, EventArgs e)
        {
            btnSelectPurReq.Enabled = true;
            btnApprove.Enabled = false;
            btnDecline.Enabled = false;
            lbPurchaseReqs.Enabled = true;
            btnSelectLineItem.Enabled = false;
            lbPurchaseReqLineItems.Items.Clear();
            btnPlaceOrder.Enabled = false;
            btnResetButtons.Enabled = false;

        }
    }
}
