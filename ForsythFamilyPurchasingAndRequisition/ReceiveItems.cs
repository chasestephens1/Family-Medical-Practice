
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
    public partial class ReceiveItems : BaseForm
    {
        public static int shipmentID;
        public static int selectedLineItemID;
        public static int expectedQuantity;
        public static int arrivedQuantity;
        public static int recievedQuantity;
        public static int selectedBinID;
        public static MedSystemDataSet md = new MedSystemDataSet();
        public ReceiveItems()
        {
            InitializeComponent();
            btnSelectAddItemQuantity.Enabled = false;
            btnSelectShipmentLineItem.Enabled = false;
            btnResetButtons.Enabled = false;
            btnShipment.Enabled = false;
            cbLineItems.Enabled = false;
            cbBinSelection.Enabled = false;
            PopulateShipments();
           
        }


         public static void addItem()
        {
            DataTable item = new DataTable();
            


        }

        private void clbShipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLineItems.Items.Clear();
            int index = cbShipments.SelectedIndex;
            cbLineItems.Items.Clear();
            for (int x = 0; x < cbShipments.Items.Count; x++)
            {
                if (x != index)
                {
                    cbShipments.SetItemChecked(x, false);
                }

            }

            MedSystemDataSetTableAdapters.ShipmentsTableAdapter shipmentsTableAdapter = new MedSystemDataSetTableAdapters.ShipmentsTableAdapter();
            DataTable shipmentsTable = new DataTable();
            shipmentsTableAdapter.Fill(md.Shipments);
            int selectShipments = int.Parse(cbShipments.SelectedItem.ToString());

            shipmentsTable = md.Tables["Shipments"];
            DataView shipments = new DataView(shipmentsTable);

            shipments.RowFilter = "ShipmentID = " + selectShipments;
            shipmentID = int.Parse(cbShipments.SelectedItem.ToString());

            btnShipment.Enabled = true;
            
            PopulateShipmentLineItems(shipmentID);
        }

        private void PopulateShipments()
        {
            MedSystemDataSetTableAdapters.ShipmentsTableAdapter shipmentsTableAdapter = new MedSystemDataSetTableAdapters.ShipmentsTableAdapter();
            DataTable shipmentsTable = new DataTable();
            shipmentsTableAdapter.Fill(md.Shipments);
            shipmentsTable = md.Tables["Shipments"];

            for (int i = 0; i < shipmentsTable.Rows.Count; i++)
            {
                cbShipments.Items.Add(shipmentsTable.Rows[i]["ShipmentID"]).ToString();
            }

        }

        private void PopulateShipmentLineItems(int shipmentID)
        {
            MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter shipmentLineItemsTableAdapter = new MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter();
            DataTable shipmentLineItemsTable = new DataTable();
            shipmentLineItemsTableAdapter.Fill(md.ShipmentLineItems);
            shipmentLineItemsTable = md.Tables["ShipmentLineItems"];
            DataView shipmentItems = new DataView(shipmentLineItemsTable);
            shipmentItems.RowFilter = "ShipmentID = " + shipmentID;

            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            DataView itemsView = new DataView(itemsTable);

            for (int i = 0; i < shipmentItems.Count; i++)
            {
                itemsView.RowFilter = "ItemID = " + "'" + int.Parse(shipmentItems[i]["ItemID"].ToString()) + "'";
                cbLineItems.Items.Add("ItemID: " + shipmentItems[i]["ItemID"].ToString() + " Expected Amount: " + shipmentItems[i]["ExpectedQuantity"].ToString() + " Amount Arrived: " + int.Parse(shipmentItems[i]["ArrivedQuantity"].ToString()));

                
        



            }


        }
        private void shipmentSelectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnShipment_Click(object sender, EventArgs e)
        {
            if (cbShipments.SelectedItem != null)
            {
                btnShipment.Enabled = false;
                cbShipments.Enabled = false;
                cbLineItems.Enabled = true;
                btnResetButtons.Enabled = true;
                shipmentID = int.Parse(cbShipments.SelectedItem.ToString());
                Console.WriteLine(shipmentID);
            }

        }

       

        private void cblLineItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbLineItems.SelectedIndex;
            btnSelectShipmentLineItem.Enabled = true;

            for (int x = 0; x < cbLineItems.Items.Count; x++)
            {
                if (x != index)
                {
                    cbLineItems.SetItemChecked(x, false);
                    
                }

            }
        }

        private void btnLineItem_Click(object sender, EventArgs e)
        {
            MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter shipmentLineItemsTableAdapter = new MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter();
            DataTable shipmentLineItemsTable = new DataTable();
            shipmentLineItemsTableAdapter.Fill(md.ShipmentLineItems);
            shipmentLineItemsTable = md.Tables["ShipmentLineItems"];
            DataView shipmentItems = new DataView(shipmentLineItemsTable);


            MedSystemDataSetTableAdapters.WarehouseBinTableAdapter warehouseBinTableAdapter = new MedSystemDataSetTableAdapters.WarehouseBinTableAdapter();
            DataTable binTable = new DataTable();
            warehouseBinTableAdapter.Fill(md.WarehouseBin);
            binTable = md.Tables["WarehouseBin"];
            DataView binTableView = new DataView(binTable);


            

            if (cbLineItems.SelectedItem != null)
            {
                btnSelectAddItemQuantity.Enabled = true;
                btnSelectShipmentLineItem.Enabled = false;
                cbLineItems.Enabled = false;
                btnCancelAddItem.Enabled = true;


                String lineItemString = cbLineItems.SelectedItem.ToString();
                int pFrom = lineItemString.IndexOf("ItemID: ") + "ItemID: ".Length;

                int pTo = lineItemString.IndexOf(" E");
                String result = lineItemString.Substring(pFrom, pTo - pFrom);
                result.Trim(' ');
                //Add Code to get
                shipmentItems.RowFilter = "ItemID = " + "'" + result + "'" + " AND ShipmentID = " + "'" + shipmentID + "'";
                selectedLineItemID = int.Parse(shipmentItems[0]["ItemID"].ToString());
                arrivedQuantity = int.Parse(shipmentItems[0]["ArrivedQuantity"].ToString());
                expectedQuantity = int.Parse(shipmentItems[0]["ExpectedQuantity"].ToString());
                int maxValue = expectedQuantity - arrivedQuantity;
                Console.WriteLine(maxValue + " " + expectedQuantity + " " + arrivedQuantity);
                numAddItemQuantity.Maximum = maxValue;

                for(int i = 0; i < binTableView.Count; i++)
                {
                    cbBinSelection.Items.Add(binTableView[i]["BinID"].ToString());
                }
                
            }


        }

        private void btnSelectAddItemQuantity_Click(object sender, EventArgs e)
        {
            btnSelectAddItemQuantity.Enabled = false;
            btnSelectShipmentLineItem.Enabled = false;
            quantityPanel.Show();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelAddItem_Click(object sender, EventArgs e)
        {
            //Closes add item form 
            
            this.Close();
        }

        private void btnCancelQuantity_Click(object sender, EventArgs e)
        {
            //Hides quantity selection panel from view
            quantityPanel.Hide();
        }

        private void btnConfirmAddItems_Click(object sender, EventArgs e)
        {
            MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter WarehouseInventoryTableAdapter = new MedSystemDataSetTableAdapters.WarehouseInventoryTableAdapter();
            DataTable warehouseInventoryTable = new DataTable();
            WarehouseInventoryTableAdapter.Fill(md.WarehouseInventory);
            warehouseInventoryTable = md.Tables["WarehouseInventory"];
            DataView warehouseInventoryView = new DataView(warehouseInventoryTable);

            MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter shipmentLineItemsTableAdapter = new MedSystemDataSetTableAdapters.ShipmentLineItemsTableAdapter();
            DataTable shipmentLineItemsTable = new DataTable();
            shipmentLineItemsTableAdapter.Fill(md.ShipmentLineItems);
            shipmentLineItemsTable = md.Tables["ShipmentLineItems"];
            DataView shipmentItems = new DataView(shipmentLineItemsTable);

            
            
           
            

            if (cbBinSelection.SelectedItem != null)
            {
                selectedBinID = int.Parse(cbBinSelection.SelectedItem.ToString());
                recievedQuantity = int.Parse(numAddItemQuantity.Value.ToString());

                WarehouseInventoryTableAdapter.RecieveItem(selectedBinID, selectedLineItemID, recievedQuantity, shipmentID);

                MessageBox.Show("Item Successfully Received!");
                quantityPanel.Hide();

            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Must Select Bin");
            }

        }

        private void btnResetButtons_Click(object sender, EventArgs e)
        {
            btnShipment.Enabled = false;
            btnResetButtons.Enabled = false;
            cbShipments.Enabled = true;
            cbLineItems.Items.Clear();
            btnSelectShipmentLineItem.Enabled = false;
            btnSelectAddItemQuantity.Enabled = false;
            cbBinSelection.Enabled = false;
            cbBinSelection.ResetText();
            numAddItemQuantity.ResetText();
        }

        private void numAddItemQuantity_ValueChanged(object sender, EventArgs e)
        {
            cbBinSelection.Enabled = true;
        }
    }
}
