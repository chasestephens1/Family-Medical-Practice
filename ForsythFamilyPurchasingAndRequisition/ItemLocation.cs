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
    
    public partial class ItemLocation : BaseForm
    {
        public static int fromBinId;
        public static int toBinId;
        public static int selectedLineItemID;
        public static String itemName;
        public static int inventoryQuantity;
        public static MedSystemDataSet md = new MedSystemDataSet();
        
        
        public ItemLocation()
        {
            InitializeComponent();
            
            btnLocationSelectQuantity.Enabled = false;
            btnSelectLocation.Enabled = false;
            cbItemLocation.Enabled = false;
            btnResetButtons.Enabled = false;
            btnSelectItem.Enabled = false;
            PopulateLocations();
            PopulateItems();
        }


        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbItems.SelectedIndex;

            for (int x = 0; x < cbItems.Items.Count; x++)
            {
                if (x != index)
                {
                    cbItems.SetItemChecked(x, false);
                }

            }

            MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
            DataTable inventoryCompleteTable = new DataTable();
            inventoryCompleteTableAdapter.Fill(md.InventoryComplete);

            inventoryCompleteTable = md.Tables["InventoryComplete"];
            DataView inventory = new DataView(inventoryCompleteTable);

            btnSelectItem.Enabled = true;

            
        }
        private void PopulateLocations()
        {
            MedSystemDataSetTableAdapters.OfficeLocationTableAdapter officeLocationAdapter = new MedSystemDataSetTableAdapters.OfficeLocationTableAdapter();
            DataTable locationTable = new DataTable();
            officeLocationAdapter.Fill(md.OfficeLocation);
            locationTable = md.Tables["OfficeLocation"];

            for (int i = 0; i < locationTable.Rows.Count; i++)
            {
                cbItemLocation.Items.Add(locationTable.Rows[i]["OfficeName"]).ToString();
            }
          

        }

        private void PopulateItems()
        {
            MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
            DataTable inventoryCompleteTable = new DataTable();
            inventoryCompleteTableAdapter.Fill(md.InventoryComplete);
            inventoryCompleteTable = md.Tables["InventoryComplete"];

            for (int i = 0; i < inventoryCompleteTable.Rows.Count; i++)
            {
                cbItems.Items.Add("Item: " + inventoryCompleteTable.Rows[i]["ItemName"] + " Office: " + inventoryCompleteTable.Rows[i]["OfficeID"] + " Bin: " + inventoryCompleteTable.Rows[i]["BinID"].ToString());
            }
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {

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

            if (cbItems.SelectedItem != null)
            {

                String lineItemString = cbItems.SelectedItem.ToString();
                int pFrom = lineItemString.IndexOf("Item: ") + "Item: ".Length;

                int pTo = lineItemString.IndexOf(" Office:");
                String result = lineItemString.Substring(pFrom, pTo - pFrom);
                result.Trim(' ');
                //Add Code to get
                inventoryView.RowFilter = "ItemName = " + "'" + result + "'";
                selectedLineItemID = int.Parse(inventoryView[0]["ItemID"].ToString());
                itemName = inventoryView[0]["ItemName"].ToString();
                inventoryQuantity = int.Parse(inventoryView[0]["Quantity"].ToString());
                
                
                btnSelectItem.Enabled = false;
                cbItemLocation.Enabled = true;
                cbItems.Enabled = false;


                int maxValue = inventoryQuantity;
                numLocationQuantity.Maximum = maxValue;
                numLocationQuantity.Minimum = 1;

                String binString = cbItems.SelectedItem.ToString();
                int bFrom = binString.IndexOf("Bin: ") + "Bin: ".Length;

                
                String binResult = binString.Substring(bFrom);
                binResult.Trim(' ');
                
                fromBinId = int.Parse(binResult.ToString());

                fromBinId = int.Parse(inventoryView[0]["BinID"].ToString());
                for (int i = 0; i < binTableView.Count; i++)
                {
                    

                    
                    cbSelectBinId.Items.Add(binTableView[i]["BinID"].ToString());
                }
            }
            btnResetButtons.Enabled = true;
            
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            if(cbItemLocation.SelectedItem != null)
            {
                btnLocationSelectQuantity.Enabled = true;
                btnSelectLocation.Enabled = false;
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnLocationSelectQuantity.Enabled = false;
            btnSelectLocation.Enabled = false;
            itemLocationQuantityPanel.Show();
        }

        

        private void cbItemLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbItemLocation.SelectedIndex;

            for (int x = 0; x < cbItemLocation.Items.Count; x++)
            {
               if(x != index)
                {
                    cbItemLocation.SetItemChecked(x, false);
                    btnSelectLocation.Enabled = true;
                }

            }
        }

        private void btnCancelLocation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelLocationQuantity_Click(object sender, EventArgs e)
        {
            itemLocationQuantityPanel.Hide();
        }

        private void btnConfirmLocationQuantity_Click(object sender, EventArgs e)
        {
            MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
            DataTable inventoryCompleteTable = new DataTable();
            inventoryCompleteTableAdapter.Fill(md.InventoryComplete);
            inventoryCompleteTable = md.Tables["InventoryComplete"];
            DataView inventoryView = new DataView(inventoryCompleteTable);

            MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter warehouseInventoryTableAdapter = new MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter();

            btnConfirmLocationQuantity.Enabled = false;
            if (cbSelectBinId.SelectedItem != null)
            {
                toBinId = int.Parse(cbSelectBinId.SelectedItem.ToString());
                warehouseInventoryTableAdapter.MoveItem(toBinId, selectedLineItemID, inventoryQuantity, fromBinId);
                

                MessageBox.Show("Item Successfully Moved!");
                itemLocationQuantityPanel.Hide();

            }
            else
            {
                MessageBox.Show("Must Select Bin");
            }
        }

        private void btnResetButtons_Click(object sender, EventArgs e)
        {
            btnSelectItem.Enabled = true;
            btnLocationSelectQuantity.Enabled = false;
            btnSelectLocation.Enabled = false;
            btnResetButtons.Enabled = false;
            cbItems.Enabled = true;
            cbItemLocation.Enabled = false;
            cbSelectBinId.ResetText();
            numLocationQuantity.Value = 1;
            
        }
    }
}
