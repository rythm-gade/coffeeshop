using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Project_3 : Form
    {
        public Project_3()
        {
            InitializeComponent();
        }

        TransactionDatabase myDatabase = new TransactionDatabase();
       

        private void btnAddtoInventory_Click(object sender, EventArgs e)
        {
            //Declaring temporary variable
            int intInput = 0;

            if (Int32.TryParse(txtInventory.Text, out intInput))
            {
                if(intInput >= 0)
                {
                    //If large cup is selected, increment inventory by input value
                    if (rdoLG.Checked)
                    {
                        myDatabase.AddToInventory(rdoLG, txtInventory);
                        myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
                    }

                    //If medium cup is selected, increment inventory by input value
                    if (rdoMD.Checked)
                    {
                        myDatabase.AddToInventory(rdoMD, txtInventory);
                        myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
                    }

                    //If small cup is selected, increment inventory by input value
                    if (rdoSM.Checked)
                    {
                        myDatabase.AddToInventory(rdoSM, txtInventory);
                        myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
                    }

                    //If grounds is selected, increment inventory by input value
                    if (rdoGrounds.Checked)
                    {
                        myDatabase.AddToInventory(rdoGrounds, txtInventory);
                        myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
                    }

                    //If creamer is selected, increment inventory by input value
                    if (rdoCreamer.Checked)
                    {
                        myDatabase.AddToInventory(rdoCreamer, txtInventory);
                        myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
                    }

                    //If sugar is selected, increment inventory by input value
                    if (rdoSugar.Checked)
                    {
                        myDatabase.AddToInventory(rdoSugar, txtInventory);
                        myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
                    }

                }
                
                
                else
                {
                    MessageBox.Show("Negative numbers are not allowed.  Please correct.",
                    "INPUT ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }                                
            }
            
            else
            {
                MessageBox.Show("Invalid input, numerals only.  Please correct.",
                    "INPUT ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }
        
        //If large size is selected, check inventory
        private void rdoLargeSize_CheckedChanged(object sender, EventArgs e)
        {

            if (myDatabase.CheckInventory(rdoLargeSize, nudQuantity, cbCreamer, cbSugar) == false)
            {
                btnAddtoOrder.Enabled = false;
            }

            else
            {
                btnAddtoOrder.Enabled = true;
            }
        }

        //If medium size is selected, check inventory   
        private void rdoMediumSize_CheckedChanged(object sender, EventArgs e)
        {

            if (myDatabase.CheckInventory(rdoMediumSize, nudQuantity, cbCreamer, cbSugar) == false)
            {
                btnAddtoOrder.Enabled = false;
            }

            else
            {
                btnAddtoOrder.Enabled = true;
            }
        }

        //If small size is selected, check Inventory
        private void rdoSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            
            if (myDatabase.CheckInventory(rdoSmallSize, nudQuantity, cbCreamer, cbSugar) == false)
            {
                btnAddtoOrder.Enabled = false;
            }

            else
            {
                btnAddtoOrder.Enabled = true;
            }
        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            //Calls AddToOrder method for all cup sizes, then displays order
            myDatabase.AddToOrder(rdoLargeSize, nudQuantity, cbCreamer, cbSugar, txtOrders);
            myDatabase.AddToOrder(rdoMediumSize, nudQuantity, cbCreamer, cbSugar, txtOrders);
            myDatabase.AddToOrder(rdoSmallSize, nudQuantity, cbCreamer, cbSugar, txtOrders);
            myDatabase.DisplayOrder(txtOrders);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            myDatabase.UpdateInventory();
            myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
            myDatabase.DisplayInvoices(lstInvoice);
            myDatabase.AddInvoice();
            txtOrders.Clear();
            
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (rdoLargeSize.Checked)
            {
               if (myDatabase.CheckInventory(rdoLargeSize, nudQuantity, cbCreamer, cbSugar) == false)
                {
                    btnAddtoOrder.Enabled = false;
                }

                else
                {
                    btnAddtoOrder.Enabled = true;
                }
            }

            if (rdoMediumSize.Checked)
            {
                if (myDatabase.CheckInventory(rdoMediumSize, nudQuantity, cbCreamer, cbSugar) == false)
                {
                    btnAddtoOrder.Enabled = false;
                }

                else
                {
                    btnAddtoOrder.Enabled = true;
                }
            }

            if (rdoSmallSize.Checked)
            {
                if (myDatabase.CheckInventory(rdoSmallSize, nudQuantity, cbCreamer, cbSugar) == false)
                {
                    btnAddtoOrder.Enabled = false;
                }

                else
                {
                    btnAddtoOrder.Enabled = true;
                }
            }
        }

        private void Project_3_Load(object sender, EventArgs e)
        {
            myDatabase.DisplayInventory(rdoLG, rdoMD, rdoSM, rdoCreamer, rdoGrounds, rdoSugar);
            myDatabase.DisplayInvoices(lstInvoice);

            if (myDatabase.CheckEmptyID() == false)
            {
                myDatabase.AddInvoice();
            }
            
        }

        private void lstInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            myDatabase.DisplaySelectedInvoice(txtReceipt, lstInvoice);
        }
    }
    }

