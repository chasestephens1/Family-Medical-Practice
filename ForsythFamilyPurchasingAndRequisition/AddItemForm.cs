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
    public partial class AddItemForm : BaseForm
    {
        public static MedSystemDataSet md = new MedSystemDataSet();
        public int itemID;

        public AddItemForm()
        {
            InitializeComponent();
            PopulateVendors();
            PopulateTypes();

            tboxItemName.Enabled = false;
            ddItemType.Enabled = false;
            tboxUnitPrice.Enabled = false;
            tboxLowStock.Enabled = false;
            btnClear.Enabled = false;
            btnAdd.Enabled = false;
        }


        private void ddVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            tboxItemName.Enabled = true;
            btnClear.Enabled = true;
            
        }

        private void tboxItemName_TextChanged(object sender, EventArgs e)
        {
            ddItemType.Enabled = true;
            tboxUnitPrice.Enabled = true;
            tboxLowStock.Enabled = true;
            btnAdd.Enabled = true;
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
                ddVendors.Items.Add(vendorsTable.Rows[i]["VendorName"]).ToString();
            }
        }

        private void PopulateTypes()
        {
            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            string[] itemType = new string[itemsTable.Rows.Count];

            for (int i = 0; i < itemsTable.Rows.Count; i++)
            {
                ddItemType.Items.Add(itemsTable.Rows[i]["ItemType"]).ToString();
            }
        }

        private void CreateItemID()
        {
            MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
            DataTable itemsTable = new DataTable();
            itemsAdapter.Fill(md.WarehouseItems);
            itemsTable = md.Tables["WarehouseItems"];
            DataView dv = new DataView(itemsTable);

            int max = 0;
            for (int i = 0; i < dv.Count; i++)
            {
                if (int.Parse(itemsTable.Rows[i]["ItemID"].ToString()) > max)
                {
                    max = int.Parse(itemsTable.Rows[i]["ItemID"].ToString());
                }

            }
            itemID = max;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter itemsAdapter = new MedSystemDataSetTableAdapters.WarehouseItemsTableAdapter();
                DataTable itemsTable = new DataTable();
                itemsAdapter.Fill(md.WarehouseItems);
                itemsTable = md.Tables["WarehouseItems"];

                MedSystemDataSetTableAdapters.WarehouseVendorsTableAdapter warehouseVendorsAdapter = new MedSystemDataSetTableAdapters.WarehouseVendorsTableAdapter();
                DataTable vendorsTable = new DataTable();
                warehouseVendorsAdapter.Fill(md.WarehouseVendors);
                vendorsTable = md.Tables["WarehouseVendors"];
                DataView dv = new DataView(vendorsTable);
                dv.RowFilter = "VendorName = " + "'" + ddVendors.SelectedItem.ToString() + "'";

                CreateItemID();
                Console.WriteLine(itemID);
                string itemName = tboxItemName.Text.ToString();
                Console.WriteLine(itemName);
                string itemType = ddItemType.Text;
                Console.WriteLine(itemType);
                double itemPrice = Double.Parse(tboxUnitPrice.Text.ToString());
                Console.WriteLine(itemPrice);
                int itemLowStock = Int32.Parse(tboxLowStock.Text.ToString());
                Console.WriteLine(itemLowStock);
                int vendorID = int.Parse(vendorsTable.Rows[0]["VendorID"].ToString());
                Console.WriteLine(vendorID);

                itemsAdapter.AddItem(itemName, itemType, itemPrice, itemLowStock, vendorID);
            }
            catch (NullReferenceException)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("One or More Values Left Blank.");
                
            }
            catch (FormatException)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("One or More Values In Wrong Format.");
                
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxItemName.Clear();
            tboxUnitPrice.Clear();
            tboxLowStock.Clear();
            btnAdd.Enabled = false;
            tboxItemName.Enabled = false;
            ddItemType.Enabled = false;
            tboxUnitPrice.Enabled = false;
            tboxLowStock.Enabled = false;
            ddVendors.Text = "";
            ddItemType.Text = "";

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
