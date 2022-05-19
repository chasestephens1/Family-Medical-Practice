using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ForsythFamilyPurchasingAndRequisition
{
    
    public partial class InventoryScreen : BaseForm
    {
        public static MedSystemDataSet md = new MedSystemDataSet();
        // This form shows the complete inventory and allows the user to save it to a .txt file and be able to print the file to a printer.
        public InventoryScreen()
        {
            InitializeComponent();
            
            
          
        }

        

        private void saveAsPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            saveToTxt();

        }

        
        private static void saveToTxt()
        {
            //Saves Inventory List To .txt file.
            /* Needs: We will need to remove the symbols from the beginning of each line in the .txt file.
             * Also we will need to update this display when we connect to the database and have all of the information
             * that wee will need to display.
             */
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV file|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                StreamWriter sw = new StreamWriter(File.Create(path));
                // Create File Header Below
                //sw.Write("Item No\tItem Name\tItem Quantity\n\n");
                MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter inventoryCompleteTableAdapter = new MedSystemDataSetTableAdapters.InventoryCompleteTableAdapter();
                DataTable inventoryCompleteTable = new DataTable();
                inventoryCompleteTableAdapter.Fill(md.InventoryComplete);
                inventoryCompleteTable = md.Tables["InventoryComplete"];
                sw.Write("Item Name, Item Type, Section, Shelf, Position, Quantity, Low Stock Number, Unit Price, Office Location\n");
                for (int i = 0; i < inventoryCompleteTable.Rows.Count; i++)
                {
                 
                    sw.Write(inventoryCompleteTable.Rows[i]["ItemName"] + "," + inventoryCompleteTable.Rows[i]["ItemType"] + "," + inventoryCompleteTable.Rows[i]["Section"].ToString().Trim(' ')
                      + "," + inventoryCompleteTable.Rows[i]["Shelf"].ToString().Trim(' ') + "," + inventoryCompleteTable.Rows[i]["Position"].ToString().Trim(' ') + "," + inventoryCompleteTable.Rows[i]["Quantity"].ToString().Trim(' ') + ","  + inventoryCompleteTable.Rows[i]["LowStockNumber"] + "," + inventoryCompleteTable.Rows[i]["UnitPrice"] + "," + inventoryCompleteTable.Rows[i]["OfficeName"] + "\n");
                }
                sw.Close();
                sw.Dispose();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Need to create a method to print the .txt file to the printer and call it here.
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void InventoryScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medSystemDataSet.InventoryComplete' table. You can move, or remove it, as needed.
            this.inventoryCompleteTableAdapter.Fill(this.medSystemDataSet.InventoryComplete);

        }


    }
}
