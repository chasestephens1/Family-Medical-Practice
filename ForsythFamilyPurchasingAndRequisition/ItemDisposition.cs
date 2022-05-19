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
    public partial class ItemDisposition : BaseForm
    {
        public static int selectedLineItemID;
        public static int itemQuantity;
        public static int itemId;
        public static int inventoryID;
        public static String itemName;
        public static int binSelected;
        public static int inventoryQuantity;
        public static int DispoReasonID;
        public static MedSystemDataSet md = new MedSystemDataSet();
        public ItemDisposition()
        {
            InitializeComponent();
            btnSelectDispoQuantity.Enabled = false;
            btnItemDispoSelect.Enabled = false;
            btnDispoReason.Enabled = false;
            clbReason.Enabled = false;
            btnResetButtons.Enabled = false;
            numDispoQuantity.Enabled = false;
            PopulateDispositions();
            PopulateDispoReasons();



        }

        private void clbItemSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbItemSelection.SelectedIndex;
            btnItemDispoSelect.Enabled = true;
            for (int x = 0; x < clbItemSelection.Items.Count; x++)
            {
                if (x != index)
                {
                    clbItemSelection.SetItemChecked(x, false);
                    
                }

            }

            MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
            DataTable inventoryCompleteTable = new DataTable();
            inventoryCompleteTableAdapter.Fill(md.InventoryComplete);
            //int selectItem = int.Parse(clbItemSelection.SelectedItem.ToString());

            inventoryCompleteTable = md.Tables["InventoryComplete"];
            DataView inventory = new DataView(inventoryCompleteTable);

            //inventory.RowFilter = "ItemID = " + selectItem;
            //itemId = int.Parse(clbItemSelection.SelectedItem.ToString());

            //clbItemSelection.Items.Clear();
            

        }

        private void PopulateDispositions()
        {
            MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
            DataTable inventoryCompleteTable = new DataTable();
            inventoryCompleteTableAdapter.Fill(md.InventoryComplete);
            inventoryCompleteTable = md.Tables["InventoryComplete"];
            DataView inventoryView = new DataView(inventoryCompleteTable);
            inventoryView.RowFilter = "Quantity > " + 0;


            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            DataView itemsView = new DataView(itemsTable);

            for (int i = 0; i < inventoryCompleteTable.Rows.Count; i++)
            {
                itemsView.RowFilter = "ItemID = " + "'" + int.Parse(inventoryCompleteTable.Rows[i]["ItemID"].ToString()) + "'";
                clbItemSelection.Items.Add("ItemID: " + inventoryCompleteTable.Rows[i]["ItemID"].ToString() +  " Item: " + inventoryCompleteTable.Rows[i]["ItemName"]).ToString();
            }
        }

        private void PopulateDispoReasons()
        {
            MedSystemDataSetTableAdapters.DispoReasonsTableAdapter dispoReasonsTableAdapter = new MedSystemDataSetTableAdapters.DispoReasonsTableAdapter();
            DataTable dispoReasonsTable = new DataTable();
            dispoReasonsTableAdapter.Fill(md.DispoReasons);
            dispoReasonsTable = md.Tables["DispoReasons"];

            for (int i = 0; i < dispoReasonsTable.Rows.Count; i++)
            {
                clbReason.Items.Add(dispoReasonsTable.Rows[i]["DispoReasonDesc"]).ToString();
            }
        }

        private void itemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void clbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbReason.SelectedIndex;

            for (int x = 0; x < clbReason.Items.Count; x++)
            {
                if (x != index)
                {
                    clbReason.SetItemChecked(x, false);
                }

            }
        }

        private void btnItemSelect_Click(object sender, EventArgs e)
        {
            cbBinID.Items.Clear();
            MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
            DataTable inventoryCompleteTable = new DataTable();
            inventoryCompleteTableAdapter.Fill(md.InventoryComplete);
            inventoryCompleteTable = md.Tables["InventoryComplete"];
            DataView inventoryView = new DataView(inventoryCompleteTable);

            MedSystemDataSetTableAdapters.WarehouseBinTableAdapter warehouseBinTableAdapter = new MedSystemDataSetTableAdapters.WarehouseBinTableAdapter();
            DataTable binTable = new DataTable();
            warehouseBinTableAdapter.Fill(md.WarehouseBin);
            binTable = md.Tables["WarehouseBin"];
            DataView binTableView = new DataView(binTable);
            
            

            MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter WarehouseInventoryTableAdapter = new MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter();
            DataTable warehouseInventoryTable = new DataTable();
            WarehouseInventoryTableAdapter.Fill(md.WarehouseInventory);
            warehouseInventoryTable = md.Tables["WarehouseInventory"];
            DataView warehouseInventoryView = new DataView(warehouseInventoryTable);

            btnResetButtons.Enabled = true;
            

            if (clbItemSelection.SelectedItem != null)
            {
                btnDispoReason.Enabled = true;
                clbItemSelection.Enabled = false;
                clbReason.Enabled = true;
                btnItemDispoSelect.Enabled = false;

                String lineItemString = clbItemSelection.SelectedItem.ToString();
                int pFrom = lineItemString.IndexOf("ItemID: ") + "ItemID: ".Length;

                int pTo = lineItemString.IndexOf(" I");
                String result = lineItemString.Substring(pFrom, pTo - pFrom);
                result.Trim(' ');
                //Add Code to get
                inventoryView.RowFilter = "ItemID = " + "'" + result + "'";
                selectedLineItemID = int.Parse(inventoryView[0]["ItemID"].ToString());
                itemName = inventoryView[0]["ItemName"].ToString();
                //inventoryQuantity = int.Parse(inventoryView[0]["Quantity"].ToString());

                //Console.WriteLine(selectedLineItemID);
                
                //Console.WriteLine(maxValue + " " + inventoryQuantity);
                
                

                for (int i = 0; i < warehouseInventoryView.Count; i++)
                {
                    warehouseInventoryView.RowFilter = "ItemID = \'" + selectedLineItemID + "\' AND Quantity > " + 0;
                    try
                    {
                        cbBinID.Items.Add(warehouseInventoryView[i]["BinID"].ToString());
                    }
                    catch (IndexOutOfRangeException)
                    {
                        System.Media.SystemSounds.Asterisk.Play();
                        MessageBox.Show("This item is out of stock. Select another item.");
                        btnItemDispoSelect.Enabled = true;
                        btnDispoReason.Enabled = false;
                    }
                    
                }
            }
            
        }

        private void btnReason_Click(object sender, EventArgs e)
        {
            if(clbReason.SelectedItem != null)
            {
                btnDispoReason.Enabled = false;
                btnSelectDispoQuantity.Enabled = true;
                clbReason.Enabled = false;

            }
            
        }

        private void btnConfirmDispo_Click(object sender, EventArgs e)
        {
            
            btnSelectDispoQuantity.Enabled = false;
            btnDispoReason.Enabled = false;
            itemDispoQuantityPanel.Show();
        }

        private void btnCancelDisposition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelQuantity_Click(object sender, EventArgs e)
        {
            itemDispoQuantityPanel.Hide();
        }

        private void btnConfirmDispoQuantity_Click(object sender, EventArgs e)
        {

            MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter WarehouseInventoryTableAdapter = new MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter();
            DataTable warehouseInventoryTable = new DataTable();
            WarehouseInventoryTableAdapter.Fill(md.WarehouseInventory);
            warehouseInventoryTable = md.Tables["WarehouseInventory"];
            DataView warehouseInventoryView = new DataView(warehouseInventoryTable);

            MedSystemDataSetTableAdapters.DispositionsTableAdapter DispoAdapter = new MedSystemDataSetTableAdapters.DispositionsTableAdapter();
            

            MedSystemDataSetTableAdapters.DispoReasonsTableAdapter DispoReasonsTableAdapter = new MedSystemDataSetTableAdapters.DispoReasonsTableAdapter();
            DataTable dispositionsTable = new DataTable();
            DispoReasonsTableAdapter.Fill(md.DispoReasons);
            dispositionsTable = md.Tables["DispoReasons"];
            DataView dispositionsView = new DataView(dispositionsTable);

            dispositionsView.RowFilter = "DispoReasonDesc = " + "'" + clbReason.SelectedItem.ToString() + "'";


            itemQuantity = int.Parse(numDispoQuantity.Value.ToString());
            
            DispoReasonID = int.Parse(dispositionsTable.Rows[0]["DispoReasonID"].ToString());

            if (cbBinID.SelectedItem != null)
            {
                binSelected = int.Parse(cbBinID.SelectedItem.ToString());

                DispoAdapter.CreateDispo(Properties.Settings.Default.UserID, Properties.Settings.Default.SessionLocationID, itemQuantity, DispoReasonID);
                WarehouseInventoryTableAdapter.RemoveItem(binSelected, selectedLineItemID, itemQuantity);
                
                MessageBox.Show("Item Successfully Removed!");
                itemDispoQuantityPanel.Hide();

            } 
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Must Select Bin");
            }

        }

        private void btnResetButtons_Click(object sender, EventArgs e)
        {
            btnItemDispoSelect.Enabled = false;
            btnSelectDispoQuantity.Enabled = false;
            clbItemSelection.Enabled = true;
            clbReason.Enabled = false;
            btnDispoReason.Enabled = false;
            btnResetButtons.Enabled = false;
            
            cbBinID.Text = "";
            numDispoQuantity.ResetText();
            
        }

        private void cbBinID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            numDispoQuantity.Enabled = true;
            binSelected = int.Parse(cbBinID.SelectedItem.ToString());
            PopulateItemQuantity(binSelected);

            

        }

        private void PopulateItemQuantity(int binSelected)
        {
            MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter WarehouseInventoryTableAdapter = new MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter();
            DataTable warehouseInventoryTable = new DataTable();
            WarehouseInventoryTableAdapter.Fill(md.WarehouseInventory);
            warehouseInventoryTable = md.Tables["WarehouseInventory"];
            DataView warehouseInventoryView = new DataView(warehouseInventoryTable);
            
            String lineItemString = clbItemSelection.SelectedItem.ToString();
            int pFrom = lineItemString.IndexOf("ItemID: ") + "ItemID: ".Length;

            int pTo = lineItemString.IndexOf(" I");
            String result = lineItemString.Substring(pFrom, pTo - pFrom);
            result.Trim(' ');
            //Add Code to get
            
            selectedLineItemID = int.Parse(result);

            warehouseInventoryView.RowFilter = "BinID = " + binSelected;
            
            int maxValue = int.Parse(warehouseInventoryView[0]["Quantity"].ToString());
            inventoryQuantity = maxValue;
            numDispoQuantity.Maximum = inventoryQuantity;
            
            numDispoQuantity.Value = inventoryQuantity;
        }
    }
}
