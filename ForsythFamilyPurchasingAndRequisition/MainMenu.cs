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
    // This is the main menu Strip
    /* We need to code the buttons as well as create forms for them to open. 
     * We will need to add buttons to this and add to the buttons different options
     * ex: The reports tab should give options for the different report options.
    */ 
    public partial class MainMenu : Form
    {
        public static MedSystemDataSet md = new MedSystemDataSet();
        public MainMenu()
        {
            InitializeComponent();
            
            manageInventoryToolStripMenuItem.Enabled = false;
            orderRequisitionToolStripMenuItem.Enabled = false;
            inventoryManagementToolStripMenuItem.Enabled = false;
            reportsToolStripMenuItem.Enabled = false;
            lblUserName.Text = "Welcome " + Properties.Settings.Default.UserName + ",";
            PopulateLocations();
        }

        private void PopulateLocations()
        {
            
            MedSystemDataSetTableAdapters.OfficeLocationTableAdapter officeLocationAdapter = new MedSystemDataSetTableAdapters.OfficeLocationTableAdapter();
            DataTable locationTable = new DataTable();
            officeLocationAdapter.Fill(md.OfficeLocation);
            locationTable = md.Tables["OfficeLocation"];

            string[] locationID = new string[locationTable.Rows.Count];

            for(int i = 0; i < locationTable.Rows.Count; i++)
            {
                locationID[i] = locationTable.Rows[i]["OfficeID"].ToString();
                lbSessionLocation.Items.Add(locationTable.Rows[i]["OfficeName"]).ToString();
            }
           
            
         
        }


        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryScreen = new InventoryScreen();
            inventoryScreen.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens form that displays different reports with powerBI 
            System.Diagnostics.Process.Start("https://app.powerbi.com/groups/e149144f-0b41-4a7e-a10e-2ec4ec4db94c/dashboards/401f0625-a5bb-4979-8668-7784264deed6?ctid=5f0bf8a8-7cde-4ba0-8d7a-13c380a001b5&pbi_source=linkShare");
        }

        private void orderRequisitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Should open a form that allows any user to fill out an order requistion form
            var orderRequisitionScreen = new OrderRequisition();
            orderRequisitionScreen.ShowDialog();
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SessionLocation = "";
            var logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
            this.Close();
        }

       

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Should open a form that allows user to add item from on order to in stock.
            var addInventoryScreen = new ReceiveItems();
            addInventoryScreen.ShowDialog();
        }

        private void itemDispositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Should open an order dispostion form that allows user to destroy an item and remove it from inventory
            var itemDispositionScreen = new ItemDisposition();
            itemDispositionScreen.ShowDialog();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Should open a form that shows approved order requisitions and allows user to place that order.
            var placeOrderScreen = new ApproveOrder();
            placeOrderScreen.ShowDialog();

        }

        private void manageItemLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Should open a form that allows user to manage each inventory item's location.
            var itemLocationScreen = new ItemLocation();
            itemLocationScreen.ShowDialog();
        }


        private void lbSessionLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            //Enable MenuBar

            if(lbSessionLocation.SelectedIndex != -1)
            {
                manageInventoryToolStripMenuItem.Enabled = true;
                orderRequisitionToolStripMenuItem.Enabled = true;
                inventoryManagementToolStripMenuItem.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
                //Create Datatable and view
                MedSystemDataSetTableAdapters.OfficeLocationTableAdapter officeLocationAdapter = new MedSystemDataSetTableAdapters.OfficeLocationTableAdapter();
                DataTable locationTable = new DataTable();
                officeLocationAdapter.Fill(md.OfficeLocation);
                locationTable = md.Tables["OfficeLocation"];
                //Set Location Name Session Variable
                Properties.Settings.Default.SessionLocation = lbSessionLocation.Text;


                DataView dv = new DataView(locationTable);

                //Filter results
                dv.RowFilter = String.Format("OfficeName = \'{0}\'", lbSessionLocation.Text);
                //Set OfficeID Session Variable
                Properties.Settings.Default.SessionLocationID = (int)dv[0]["OfficeID"];
            }
        }

        private void addItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addItemScreen = new AddItemForm();
            addItemScreen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
