using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForsythFamilyPurchasingAndRequisition
{
    public class Inventory
        //Uses Inventory Table
    {
        private int inventoryID;
        public int InventoryID
        {
            get { return inventoryID;}
            set {inventoryID = value;}
        }
        private int inventoryNumber;
        public int InventoryNumber
        {
            get { return inventoryNumber; }
            set { inventoryNumber = value; }
        }
        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        private int locationID;
        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }
        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        // Constructor
        public Inventory(int inventoryID, int inventoryNumber, int itemID, int locationID, int categoryID)
        {
            this.inventoryID = inventoryID;
            this.inventoryNumber = inventoryNumber;
            this.itemID = itemID;
            this.locationID = locationID;
            this.categoryID = categoryID;
        }

    }// End Class
    
    
    class InventoryItem
        // Uses Items table
    {
        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private string itemType;
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        private decimal unitPrice;
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value >= 0)
                {
                    unitPrice = value;
                }
                else
                {
                    MessageBox.Show("Invalid Unit Price Entered");
                }
            }
        }
        private int inventoryID;
        public int InventoryID
        {
            get { return inventoryID; }
            set { inventoryID = value; }
        }
        private int manufacturerID;
        public int ManufacturerID
        {
            get { return manufacturerID; }
            set { manufacturerID = value; }
        }
        // Constructor
        
        
        public InventoryItem(int itemID, string itemName, string itemType, decimal unitPrice, int inventoryID, int manufacturerID)
        {
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemType = itemType;
            if (unitPrice >= 0)
            {
                this.unitPrice = unitPrice;
            }
            else
            {
                MessageBox.Show("Invalid Unit Price Entered");
            }
            this.inventoryID = inventoryID;
            this.manufacturerID = manufacturerID;
        }
        
        public override string ToString()
        {
            return $"ItemID: {this.itemID}     Item Name: {this.itemName}     Item Type: {this.itemType}     " +
                $"Unit Price: {this.unitPrice: c}     ";
        }
    }//End Class

   
    public class Vendor
        // uses Vendors table
    {
        private int vendorID { get; set; }
        private string vendorName { get; set; }
        private string contactName { get; set; }
        private string contactEmail { get; set; }
        private string vendorAddress { get; set; }
        private string vendorCity { get; set; }
        private string vendorState { get; set; }
        private string zipCode { get; set; }
        private int inventoryID { get; set; }
        private int shipmentID { get; set; }
        //Constructor
        public Vendor(int vendorID, string vendorName, string contactName, string contactEmail, string vendorAddress, 
            string vendorCity, string vendorState, string zipCode, int inventoryID, int shipmentID)
        {
            this.vendorID = vendorID;
            this.vendorName = vendorName;
            this.contactName = contactName;
            this.contactEmail = contactEmail;
            this.vendorAddress = vendorAddress;
            this.vendorCity = vendorCity;
            this.vendorState = vendorState;
            this.zipCode = zipCode;
            this.inventoryID = inventoryID;
            this.shipmentID = shipmentID;
        }

        public override string ToString()
        {
            return $"VendorID: {this.vendorID}     Vendor Name: {this.vendorName}     Contact: {this.contactName}     Email: {this.contactEmail}" +
                $"     Address: {this.vendorAddress}     City: {this.vendorCity}     State: {this.vendorState}     Zipcode: {this.zipCode}\n";
        }
    }//End of Class

    
    public class InventoryRequisition
    //Uses Inventory_Requisitions table
    {
        private int iRequistionID { get; set; }
        private int purchaseOrderID { get; set; }
        private int locationNumber { get; set; }
        private int itemNumber { get; set; }
        private int orderQuantity
        {
            get { return this.orderQuantity; }
            set
            {
                if (value > 0)
                {
                    this.orderQuantity = value;
                }
                else
                {
                    MessageBox.Show("Invalid Quantity Entered");
                }
            }
        }
        private bool orderItem { get; set; }
        private decimal price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    MessageBox.Show("Invalid Price Entered");
                }
            }

        }
        private decimal totalCost{
            get
            {
                return totalCost;
            }
            set
            {
                if(value > 0)
                {
                    this.totalCost = value;
                }
                else
                {
                    MessageBox.Show("Invalid Total Price Entered");
                }
            }

        }
        private int userID { get; set; }

        //constructor
        public InventoryRequisition(int i_RequisitionID, int purchaseOrderID, int locationNumber, int itemNumber, 
            int orderQuantity, bool orderItem, decimal price, decimal totalCost, int userID)
        {
            this.iRequistionID = i_RequisitionID;
            this.purchaseOrderID = purchaseOrderID;
            this.locationNumber = locationNumber;
            this.itemNumber = itemNumber;
            if(orderQuantity > 0)
            {
                this.orderQuantity = orderQuantity;
            }
            else
            {
                MessageBox.Show("Invalid Quantity Entered");
            }
            this.orderItem = orderItem;
            if (price > 0)
            {
                this.price = price;
            }
            else
            {
                MessageBox.Show("Invalid Price Entered");
            }

            if (totalCost > 0)
            {
                this.totalCost = totalCost;
            }
            else
            {
                MessageBox.Show("Invalid Total Cost Entered");
            }
            this.userID = userID;
        }//End constructor

        public override string ToString()
        {
            return $"Inv. RequisitionID: {this.iRequistionID}     P.O. ID: {this.purchaseOrderID}     Location #: {this.locationNumber}" +
                $"     Item #: {this.itemNumber}     Quantity: {this.orderQuantity}     Item Price: {this.price:c}     " +
                $"Total Cost: {this.totalCost:c}     UserID: {this.userID}";
        }
    }//End Class


    public class ServiceRequisition
    //Uses Service_Requisitions Table
    {
        private int sRequisitionID { get; set; }
        private int vendorID { get; set; }
        private int sRequisitionNumber { get; set; }
        private string sDescription { get; set; }
        private string vendorName { get; set; }
        private decimal cost
        {
                get
            {
                    return this.cost;
                }
                set
            {
                    if (value > 0)
                    {
                        this.cost = value;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Price Entered");
                    }
                }
        }
        private string terms { get; set; }
        private int userID { get; set; }

        //Consructor
        public ServiceRequisition(int sRequisitionID, int vendorID, int sRequisitionNumber, string sDescription, string vendorName, decimal cost)
        {
            this.sRequisitionID = sRequisitionID;
            this.vendorID = vendorID;
            this.sRequisitionNumber = sRequisitionNumber;
            this.sDescription = sDescription;
            this.vendorName = vendorName;
            if (cost > 0)
            {
                this.cost = cost;
            }
            else
            {
                MessageBox.Show("Invalid Price Entered");
            }

        }
        public override string ToString()
        {
            return $"Service Requisition ID: {this.sRequisitionID}     Vendor ID: {this.vendorID}" +
               $"     Service Requisition Number: {this.sRequisitionNumber}     Description: {this.sDescription}" +
               $"     Vendor Name: {this.vendorName}     Cost: {this.cost}";
        }
    }//End class


    public class PurchaseOrder
     //Uses PURCHASE_ORDERS table
    {
        private int purchaseOrderID { get; set; }
        private int purchaseOrderNumber { get; set; }
        private int userID { get; set; }
        private int inventoryID { get; set; }
        private int poLineItemsID { get; set; }
        private int shipmentID { get; set; }
        private int vendorID { get; set; }

        //Constructor
        public PurchaseOrder(int purchaseOrderID, int purchaseOrderNumber, int userID, int inventoryID, int poLineItemsID, int shipmentID, int vendorID)
        {
            this.purchaseOrderID = purchaseOrderID;
            this.purchaseOrderNumber = purchaseOrderNumber;
            this.userID = userID;
            this.inventoryID = inventoryID;
            this.poLineItemsID = poLineItemsID;
            this.shipmentID = shipmentID;
            this.vendorID = vendorID;
        }

        public override string ToString()
        {
            return $"P.O. ID: {this.purchaseOrderID}     Purchase Order Number: {this.purchaseOrderNumber}" +
                $"     User ID: {this.userID}     Inventory ID: {this.inventoryID}     PO Line Items ID: {this.poLineItemsID}     " +
                $"Shipment ID: {this.shipmentID}     Vendor ID: {this.vendorID}";
        }
    }


    public class Disposition
        //Users DISPOSITIONS table
    {
        private int dispositionID { get; set; }
        private int dispoNumber { get; set; }
        private string dispoReason { get; set; }
        private int dispoQuantity { get; set; }
        private int locationID { get; set; }
        private int itemID { get; set; }
        private int medProductID { get; set; }

        //Constructor

        public Disposition(int dispositionID, int dispoNumber, string dispoReason, int dispoQuantity, int locationID, int itemID, int medProductID)
        {
            this.dispositionID = dispositionID;
            this.dispoNumber = dispoNumber;
            this.dispoReason = dispoReason;
            this.locationID = locationID;
            this.itemID = itemID;
        }

        public override string ToString()
        {
            return $"Disposition ID: {this.dispositionID}     Disposition Number: {this.dispoNumber}" +
               $"     Disposition Reason: {this.dispoReason}    Quantity:{this.dispoQuantity}     Location ID: {this.locationID}     Item ID: {this.itemID}     ";
        }
    }
}// End Namespace
