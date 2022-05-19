using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForsythFamilyPurchasingAndRequisition
{
    public partial class OrderRequisition : BaseForm
    {
        public static int vendorID;
        public static int itemID;
        public static int userID = int.Parse(Properties.Settings.Default.UserID.ToString());
        public static int seqNum = 0;
        public static MedSystemDataSet md = new MedSystemDataSet();
        public static int purchaseOrderID;
        public static decimal itemCost;

        public OrderRequisition()
        {
            // Grab userID on launch
            InitializeComponent();
            PopulateVendors();
            btnSend.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = false;
            ddItem.Enabled = false;
            numAmount.Enabled = false;
        }

        private void ddVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

            MedSystemDataSetTableAdapters.WarehouseVendorsTableAdapter warehouseVendorsAdapter = new MedSystemDataSetTableAdapters.WarehouseVendorsTableAdapter();
            DataTable vendorsTable = new DataTable();
            warehouseVendorsAdapter.Fill(md.WarehouseVendors);
            string vendor = ddVendor.Text;
            
            vendorsTable = md.Tables["WarehouseVendors"];
            DataView dv = new DataView(vendorsTable);
    
            //Filter results
            dv.RowFilter = "VendorName = " + "\'"+ vendor +"\'";
            Console.WriteLine(dv[0]["VendorID"]);
            vendorID = (int)dv[0]["VendorID"];

            MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter purchaseOrderAdapter = new MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter();
            DataTable purchaseOrderTable = new DataTable();
            purchaseOrderAdapter.Fill(md.PurchaseOrders);
            purchaseOrderTable = md.Tables["PurchaseOrders"];
            DataView purchaseDV = new DataView(purchaseOrderTable);
            
            purchaseOrderAdapter.CreatePO(vendorID, userID);

            ddItem.Enabled = true;
            SetPurchaseOrderID();
            PopulateItems();
        }

        private void ddItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = ddItem.Text;
            numAmount.Enabled = true;

            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            DataView dv = new DataView(itemsTable);
            String lineItemString = ddItem.SelectedItem.ToString();
            int pFrom = lineItemString.IndexOf("Item #: ") + "Item #: ".Length;
            int pTo = lineItemString.IndexOf(" Item");
            String result = lineItemString.Substring(pFrom, pTo - pFrom);
            result.Trim(' ');
            itemID = int.Parse(result);
            dv.RowFilter = "ItemID = " + itemID;

            
            itemCost = decimal.Parse(dv[0]["UnitPrice"].ToString());
            
            Console.WriteLine(itemCost);


            // Pull item cost
            

        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = numAmount.Value;
            

            if(numAmount.Value != 0)
            {
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            btnSend.Enabled = true;
            btnClear.Enabled = true;
            btnDelete.Enabled = true;

            if (numAmount.Value > 0)
            {
                lboxOrder.Items.Add(numAmount.Value + " " + ddItem.Text);
                
                AddToPOLineItem();
                CheckListBox();
            }
            else
            {
                string message = "Order amount must be greater than 0";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult choice = MessageBox.Show(message, title, buttons);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lboxOrder.Items.Remove(lboxOrder.SelectedItem);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string message = "Do you want to clear the current order?";
            string title = "Confirm clear";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult choice = MessageBox.Show(message, title, buttons);

            if (choice == DialogResult.Yes)
            {
                lboxOrder.Items.Clear();
                seqNum = 0;
                DeleteOrder();
            }
            else
            {
                // does nothing
            }

            btnSend.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = false;
            ddItem.Enabled = false;
            numAmount.Enabled = false;
            numAmount.Value = 0;
            ddVendor.Text = "";
            ddItem.Text = "";
            CheckListBox();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            seqNum = 0;
            string message = "Do you want to finish order and send?";
            string title = "Confirm send";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult choice = MessageBox.Show(message, title, buttons);

            if (choice == DialogResult.Yes)
            {
                SendToManager();
                lboxOrder.Items.Clear();
            }
            else
            {
                // does nothing
            }
            CheckListBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DeleteOrder();
            this.Close();
        }

        private void SetPurchaseOrderID()
        {
            MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter PurchaseOrdersAdapter = new MedSystemDataSetTableAdapters.PurchaseOrdersTableAdapter();
            DataTable purchaseOrdersTable = new DataTable();
            PurchaseOrdersAdapter.Fill(md.PurchaseOrders);
            purchaseOrdersTable = md.Tables["PurchaseOrders"];
            DataView dv = new DataView(purchaseOrdersTable);

            int max = 0;
            for(int i = 0; i < dv.Count; i++)
            {
                if (int.Parse(purchaseOrdersTable.Rows[i]["PurchaseOrderID"].ToString()) > max)
                {
                    max = int.Parse(purchaseOrdersTable.Rows[i]["PurchaseOrderID"].ToString());
                }
                
            }
            purchaseOrderID = max;
        }

        private void PopulateVendors()
        {
            MedSystemDataSetTableAdapters.WarehouseVendorsTableAdapter warehouseVendorsAdapter = new MedSystemDataSetTableAdapters.WarehouseVendorsTableAdapter();
            DataTable vendorsTable = new DataTable();
            warehouseVendorsAdapter.Fill(md.WarehouseVendors);
            vendorsTable = md.Tables["WarehouseVendors"];
            string[] vendorID = new string[vendorsTable.Rows.Count];

            for (int i = 0; i < vendorsTable.Rows.Count; i++)
            {
                //vendorID[i] = vendorsTable.Rows[i]["VendorID"].ToString();
                ddVendor.Items.Add(vendorsTable.Rows[i]["VendorName"]).ToString();
            }
        }

        private void PopulateItems()
        {
            // Initiate Table
            MedSystemDataSetTableAdapters.ItemsWithVendorTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.ItemsWithVendorTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.ItemsWithVendor);
            itemsTable = md.Tables["ItemsWithVendor"];
            DataView dv = new DataView(itemsTable);

            // Clear current items
            ddItem.Items.Clear();
            
            //Filter results
            dv.RowFilter = "VendorID = " + "\'" + vendorID + "\'";
            
            // Populate ddItems
            for (int i = 0; i < dv.Count; i++)
            {
                
                ddItem.Items.Add("Item #: " + dv[i]["ItemID"] + " Item Name:" + dv[i]["ItemName"]).ToString();
            }
        }

        public void SendToManager()
        {
            Console.WriteLine("Sent to Manager");
        }

        public void CheckListBox()
        {
            if (lboxOrder.Items.Count != 0)
            {
                ddVendor.Enabled = false;
            }
            else
            {
                ddVendor.Enabled = true;
            }
        }

        public void AddToPOLineItem()
        {
            MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter lineItemsAdapter = new MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter();
            DataTable lineItemsTable = new DataTable();
            lineItemsAdapter.Fill(md.PurchaseOrderLineItems);
            lineItemsTable = md.Tables["PurchaseOrderLineItems"];

            // create item table
           
            

            // Generate Sequence number
            seqNum += 1;
            

            // Pull item number
           
            
            // Pull purchase quantity
            int quantity = Decimal.ToInt32(numAmount.Value);
            

            
            
            lineItemsAdapter.AddPOLineItem(seqNum, itemID, (double?)itemCost, quantity, purchaseOrderID);
        
        }

        private void DeleteOrder()
        {
            MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter lineItemsAdapter = new MedSystemDataSetTableAdapters.PurchaseOrderLineItemsTableAdapter();
            DataTable lineItemsTable = new DataTable();
            lineItemsAdapter.Fill(md.PurchaseOrderLineItems);
            lineItemsTable = md.Tables["PurchaseOrderLineItems"];

            var rows = lineItemsTable.Select("PurchaseOrderID = " + "\'" + purchaseOrderID + "\'");
            foreach (var row in rows)
                row.Delete();
        }

    }
}
