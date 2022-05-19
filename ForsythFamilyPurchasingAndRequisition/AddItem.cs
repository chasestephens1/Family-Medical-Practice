
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
    public partial class AddItem : BaseForm
    {
        public AddItem()
        {
            InitializeComponent();
            btnConfirmAdd.Enabled = false;
            btnLineItem.Enabled = false;
        }


         public static void addItem()
        {
            DataTable item = new DataTable();
            


        }

        private void shipmentSelectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clbShipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbShipments.SelectedIndex;

            for (int x = 0; x < clbShipments.Items.Count; x++)
            {
                if (x != index)
                {
                    clbShipments.SetItemChecked(x, false);
                }

            }
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            btnLineItem.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cblLineItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cblLineItems.SelectedIndex;

            for (int x = 0; x < cblLineItems.Items.Count; x++)
            {
                if (x != index)
                {
                    cblLineItems.SetItemChecked(x, false);
                }

            }
        }

        private void btnLineItem_Click(object sender, EventArgs e)
        {
            btnConfirmAdd.Enabled = true;
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            btnConfirmAdd.Enabled = false;
            btnLineItem.Enabled = false;
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
    }
}
