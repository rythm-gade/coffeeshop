using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace WindowsFormsApplication1
{
    class TransactionDatabase
    {
        OdbcConnection objConnection;
        OdbcCommand objCommand;
        OdbcDataReader dbReader;


        public TransactionDatabase()
        {
            objConnection = new OdbcConnection("Driver={SQL Server};"
                + "Server=svcobdb.main.ad.rit.edu\\scbsqldev,50469;"
                + "DataBase=DBA_2151_Team5;"
                + "Uid=Team5;"
                + "Pwd=czhzqfet$#0387RYGV");
        }

        private void OpenDatabaseConnectExecuteQuery(string Query)
        {
            try
            {
                // Building command to database and executing the query string 
                objCommand = new OdbcCommand(Query, objConnection);

                // Opening the connection
                objConnection.Open();

                // Executing the query and closing the connection
                dbReader = objCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                // Determine if database is open.  If so close it.
                if (objConnection.State.ToString() == "Open")
                {
                    this.CloseDatabaseConnection();
                }
                // Display Error
                System.Windows.Forms.MessageBox.Show("Error:\n\n" + ex.ToString() + "\n");
                System.Windows.Forms.MessageBox.Show("Query:\n\n" + Query + "\n");
            }


        }

        private void CloseDatabaseConnection()
        {
            // Closing connection
            objConnection.Close();
        }

        //Method for pulling data from inventory table
        public void DisplayInventory(System.Windows.Forms.RadioButton btnLg, System.Windows.Forms.RadioButton btnMd, System.Windows.Forms.RadioButton btnSm, System.Windows.Forms.RadioButton btnCream, System.Windows.Forms.RadioButton btnGrounds, System.Windows.Forms.RadioButton btnSugar)
        {
            //Building query to pull inventory values
            string strQuery = "SELECT cupLG, cupMD, cupSM, grounds, creamer, sugar FROM inventory WHERE inventoryID = 1;";

            //Execute query
            this.OpenDatabaseConnectExecuteQuery(strQuery);

            //Display inventory
            while (dbReader.Read())
            {
                btnLg.Text = Convert.ToString(dbReader["cupLG"]);
                btnMd.Text = Convert.ToString(dbReader["cupMD"]);
                btnSm.Text = Convert.ToString(dbReader["cupSM"]);
                btnCream.Text = Convert.ToString(dbReader["creamer"]);
                btnGrounds.Text = Convert.ToString(dbReader["grounds"]);
                btnSugar.Text = Convert.ToString(dbReader["sugar"]);
            }

            // Closing database connection
            this.CloseDatabaseConnection();
        }

        //Method for adding information to Orders table, and orders form
        public void AddToOrder(System.Windows.Forms.RadioButton rdoBtn, System.Windows.Forms.NumericUpDown nudOrder, System.Windows.Forms.CheckBox chkordercreamer, System.Windows.Forms.CheckBox chkordersugar, System.Windows.Forms.TextBox txtorder)
        {
            int count = 0;
            //set counter = orderID
            string slQuery = "SELECT * FROM Orders";
            this.OpenDatabaseConnectExecuteQuery(slQuery);
            while (dbReader.Read())
            {
                count = Convert.ToInt32(dbReader["orderID"]);

            }
            this.CloseDatabaseConnection();

            int id = 0;
            string idQuery = "SELECT TOP 1 receiptID FROM Invoice ORDER BY receiptID DESC;";
            this.OpenDatabaseConnectExecuteQuery(idQuery);
            while(dbReader.Read())
            {
                id = Convert.ToInt32(dbReader["receiptID"]);
            }
            this.CloseDatabaseConnection();

            int quantity = Convert.ToInt32(nudOrder.Value);

            //check if rdo large order is selected
            if (rdoBtn.Name == "rdoLargeSize" && rdoBtn.Checked)
            {
                //build add to order query
                string strQuery = "INSERT INTO Orders (orderID, quantity, cupsize, grounds, creamer, sugar, receiptID) VALUES (" + (count + 1) + ", " + quantity + ", 'LG', " + (quantity * 4) + ", 0, 0, " + id + ");";
                this.OpenDatabaseConnectExecuteQuery(strQuery);
                this.CloseDatabaseConnection();

                if(chkordercreamer.Name == "cbCreamer" && chkordercreamer.Checked)
                {
                    strQuery = "UPDATE Orders SET creamer = " + quantity*2 + " WHERE OrderID = " + (count + 1) + ";";
                    this.OpenDatabaseConnectExecuteQuery(strQuery);
                    this.CloseDatabaseConnection();
                }
                if (chkordersugar.Name == "cbSugar" && chkordersugar.Checked)
                {
                    strQuery = "UPDATE Orders SET sugar = " + quantity + " WHERE OrderID = " + (count + 1) + ";";
                    this.OpenDatabaseConnectExecuteQuery(strQuery);
                    this.CloseDatabaseConnection();
                }


            }

            //check if rdoMediumOrder is selected
            if (rdoBtn.Name == "rdoMediumSize" && rdoBtn.Checked)
            {
                //build add to order query
                string strQuery = "INSERT INTO Orders (orderID, quantity, cupsize, grounds, creamer, sugar, receiptID) VALUES (" + (count + 1) + ", " + quantity + ", 'MD', " + (quantity * 3) + ", 0, 0,  " + id + ");";
                this.OpenDatabaseConnectExecuteQuery(strQuery);
                this.CloseDatabaseConnection();

                if (chkordercreamer.Name == "cbCreamer" && chkordercreamer.Checked)
                {
                    strQuery = "UPDATE Orders SET creamer = " + quantity * 2 + " WHERE OrderID = " + (count + 1) + ";";
                    this.OpenDatabaseConnectExecuteQuery(strQuery);
                    this.CloseDatabaseConnection();
                }
                if (chkordersugar.Name == "cbSugar" && chkordersugar.Checked)
                {
                    strQuery = "UPDATE Orders SET sugar = " + quantity + " WHERE OrderID = " + (count + 1) + ";";
                    this.OpenDatabaseConnectExecuteQuery(strQuery);
                    this.CloseDatabaseConnection();
                }
            }

            //check if rdoSmallOrder is selected
            if (rdoBtn.Name == "rdoSmallSize" && rdoBtn.Checked)
            {
                //build add to order query
                string strQuery = "INSERT INTO Orders (orderID, quantity, cupsize, grounds, creamer, sugar, receiptID) VALUES (" + (count + 1) + ", " + quantity + ", 'SM', " + (quantity * 2) + ", 0, 0,  " + id + ");";
                this.OpenDatabaseConnectExecuteQuery(strQuery);
                this.CloseDatabaseConnection();

                if (chkordercreamer.Name == "cbCreamer" && chkordercreamer.Checked)
                {
                    strQuery = "UPDATE Orders SET creamer = " + quantity * 2 + " WHERE OrderID = " + (count + 1) + ";";
                    this.OpenDatabaseConnectExecuteQuery(strQuery);
                    this.CloseDatabaseConnection();
                }
                if (chkordersugar.Name == "cbSugar" && chkordersugar.Checked)
                {
                    strQuery = "UPDATE Orders SET sugar = " + quantity + " WHERE OrderID = " + (count + 1) + ";";
                    this.OpenDatabaseConnectExecuteQuery(strQuery);
                    this.CloseDatabaseConnection();
                }
            }
       
        }

        //Method to display current order
        public void DisplayOrder(System.Windows.Forms.TextBox txtBox)
        {
            string pullQuery = "SELECT TOP 1 orderID, quantity, cupsize, creamer, sugar FROM Orders ORDER BY orderID DESC;";
            string QTY = "";
            string cupsize = "";
            string riCreamer = "";
            string riSugar = "";
            this.OpenDatabaseConnectExecuteQuery(pullQuery);

            while (dbReader.Read())
            {
                QTY = dbReader["quantity"].ToString();
                cupsize = dbReader["cupsize"].ToString();
                riCreamer = dbReader["creamer"].ToString();
                riSugar = dbReader["sugar"].ToString();
            }
            string wCream = "";
            string wSugar = "";

            if (riCreamer != "0")
            {
                wCream = " with creamer";
            }


            if (riSugar != "0")
            {
                wSugar = " with sugar";
            }
            this.CloseDatabaseConnection();
            txtBox.Text += QTY + " " + cupsize + wCream + wSugar + "\r\n";
        }

        //Method to update inventory based on recent order placed
        public void UpdateInventory()
        {
            int grounds = 0;
            int creamer = 0;
            int sugar = 0;

            string grdQuery = "SELECT sum(grounds) as grdSUM FROM Orders where receiptID = (select max(receiptID) from Orders) ;";
            this.OpenDatabaseConnectExecuteQuery(grdQuery);

            while(dbReader.Read())
            {
                grounds = Convert.ToInt32(dbReader["grdSUM"]);
            }

            this.CloseDatabaseConnection();

            string crmQuery = "SELECT SUM(creamer) AS crmSUM FROM Orders where receiptID = (select max(receiptID) from Orders) ;";
            this.OpenDatabaseConnectExecuteQuery(crmQuery);

            while (dbReader.Read())
            {
                creamer = Convert.ToInt32(dbReader["crmSUM"]);
            }

            this.CloseDatabaseConnection();

            string sugQuery = "SELECT SUM(sugar) AS sugSUM FROM Orders where receiptID = (select max(receiptID) from Orders) ;";
            this.OpenDatabaseConnectExecuteQuery(sugQuery);

            while (dbReader.Read())
            {
                sugar = Convert.ToInt32(dbReader["sugSUM"]);
            }

            this.CloseDatabaseConnection();

            string lrgQuery = "SELECT quantity AS qty FROM Orders WHERE cupsize = 'LG' and receiptID = (select max(receiptID) from Orders) ;";
            int lgCups = 0;

            this.OpenDatabaseConnectExecuteQuery(lrgQuery);

            while (dbReader.Read())
            {
                lgCups = Convert.ToInt32(dbReader["qty"]);

            }

            this.CloseDatabaseConnection();

            string mdQuery = "SELECT quantity AS qty FROM Orders WHERE cupsize = 'MD' and receiptID = (select max(receiptID) from Orders) ;";

            int mdCups = 0;

            this.OpenDatabaseConnectExecuteQuery(mdQuery);

            while (dbReader.Read())
            {
                mdCups = Convert.ToInt32(dbReader["qty"]);

            }

            this.CloseDatabaseConnection();

            string smQuery = "SELECT quantity AS qty FROM Orders WHERE cupsize = 'SM' and receiptID = (select max(receiptID) from Orders);";

            int smCups = 0;

            this.OpenDatabaseConnectExecuteQuery(smQuery);

            while (dbReader.Read())
            {

                smCups = Convert.ToInt32(dbReader["qty"]);
            }
                
            this.CloseDatabaseConnection();

            string updateQuery = "UPDATE Inventory SET cupLG = cupLG - " + lgCups + ", cupMD = cupMD - " + mdCups + ", cupSM = cupSM - " + smCups + ", grounds = grounds - " + grounds + ", creamer = creamer - " + creamer + ", sugar = sugar - " + sugar + "  WHERE inventoryID = 1;";

            this.OpenDatabaseConnectExecuteQuery(updateQuery);
            this.CloseDatabaseConnection();
            grounds = 0;
            creamer = 0;
            sugar = 0;
        }

        //Method to display invoices in listbox
        public void DisplayInvoices(System.Windows.Forms.ListBox ListBox)
        {
            // Clearing existing list
            ListBox.Items.Clear();

            // Building query to select transactions from a sepecifc account
            string strQuery = "SELECT receiptID, receiptdate FROM Invoice WHERE receiptID > 0;";

            // Executing query
            this.OpenDatabaseConnectExecuteQuery(strQuery);

            // Populating the checked listbox
            while (dbReader.Read())
            {
                ListBox.Items.Add("Invoice #" + dbReader["receiptID"].ToString() + " | " + dbReader["receiptdate"]);
            }

            // Closing database connection
            this.CloseDatabaseConnection();
        }

        //Method for displaying selected invoice into receipt box
        public void DisplaySelectedInvoice(System.Windows.Forms.TextBox txtBox, System.Windows.Forms.ListBox lstBox)
        {
            
            string A = lstBox.SelectedItem.ToString();
            string B = A.Substring(9, 1);
            string QTY = "";
            string cupsize = "";
            string riCreamer = "";
            string riSugar = "";

            txtBox.Clear();

            string strQuery = "SELECT orderID, quantity, cupsize, creamer, sugar FROM Orders WHERE receiptID = " + Convert.ToInt32(B) + ";";
            this.OpenDatabaseConnectExecuteQuery(strQuery);
            while (dbReader.Read())
            {
                QTY = dbReader["quantity"].ToString();
                cupsize = dbReader["cupsize"].ToString();
                riCreamer = dbReader["creamer"].ToString();
                riSugar = dbReader["sugar"].ToString();

                string wCream = "";
                string wSugar = "";

                if (riCreamer != "0")
                {
                    wCream = " with creamer";
                }


                if (riSugar != "0")
                {
                    wSugar = " with sugar";
                }

                txtBox.Text += QTY + " " + cupsize + wCream + wSugar + "\r\n";
            }
            
            this.CloseDatabaseConnection();
            
        }

        //Method for adding items to inventory table
        public void AddToInventory(System.Windows.Forms.RadioButton rdoBtn, System.Windows.Forms.TextBox txtBox)
        {
            if (rdoBtn.Name == "rdoLG")
            {
                //Building add to inventory query
                string strQuery = "UPDATE Inventory SET cupLG = cupLG + " + Convert.ToInt32(txtBox.Text) + "WHERE InventoryID = 1;";

                this.OpenDatabaseConnectExecuteQuery(strQuery);

                this.CloseDatabaseConnection();
            }

            else if (rdoBtn.Name == "rdoMD")
            {
                //Building add to inventory query
                string strQuery = "UPDATE Inventory SET cupMD = cupMD + " + Convert.ToInt32(txtBox.Text) + "WHERE InventoryID = 1;";

                this.OpenDatabaseConnectExecuteQuery(strQuery);

                this.CloseDatabaseConnection();
            }

            else if (rdoBtn.Name == "rdoSM")
            {
                //Building add to inventory query
                string strQuery = "UPDATE Inventory SET cupSM = cupSM + " + Convert.ToInt32(txtBox.Text) + "WHERE InventoryID = 1;";

                this.OpenDatabaseConnectExecuteQuery(strQuery);

                this.CloseDatabaseConnection();
            }

            else if (rdoBtn.Name == "rdoGrounds")
            {
                //Building add to inventory query
                string strQuery = "UPDATE Inventory SET grounds = grounds + " + Convert.ToInt32(txtBox.Text) + "WHERE InventoryID = 1;";

                this.OpenDatabaseConnectExecuteQuery(strQuery);

                this.CloseDatabaseConnection();
            }

            else if (rdoBtn.Name == "rdoSugar")
            {
                //Building add to inventory query
                string strQuery = "UPDATE Inventory SET sugar = sugar + " + Convert.ToInt32(txtBox.Text) + "WHERE InventoryID = 1;";

                this.OpenDatabaseConnectExecuteQuery(strQuery);

                this.CloseDatabaseConnection();
            }

            else if (rdoBtn.Name == "rdoCreamer")
            {
                //Building add to inventory query
                string strQuery = "UPDATE Inventory SET creamer = creamer + " + Convert.ToInt32(txtBox.Text) + "WHERE InventoryID = 1;";

                this.OpenDatabaseConnectExecuteQuery(strQuery);

                this.CloseDatabaseConnection();
            }
        }

        //Method to check for valid existing inventory
        public bool CheckInventory(System.Windows.Forms.RadioButton rdoBtn, System.Windows.Forms.NumericUpDown nudVal, System.Windows.Forms.CheckBox chkCreamer, System.Windows.Forms.CheckBox chkSugar)
        {
            bool Checked = true;
            int woLGCups = 0;
            int woMDCups = 0;
            int woSMCups = 0;
            int woGrounds = 0;
            int woCreamer = 0;
            int woSugar = 0;
            string strQuery = "SELECT cupLG, cupMD, cupSM, grounds, creamer, sugar FROM Inventory WHERE inventoryID = 1;";

            this.OpenDatabaseConnectExecuteQuery(strQuery);

            while (dbReader.Read())
            {
                woLGCups = Convert.ToInt32(dbReader["cupLG"]);
                woMDCups = Convert.ToInt32(dbReader["cupMD"]);
                woSMCups = Convert.ToInt32(dbReader["cupSM"]);
                woGrounds = Convert.ToInt32(dbReader["grounds"]);
                woCreamer = Convert.ToInt32(dbReader["creamer"]);
                woSugar = Convert.ToInt32(dbReader["sugar"]);
            }

            if (rdoBtn.Name == "rdoLargeSize")
            {
                if (woLGCups >= nudVal.Value && woGrounds >= nudVal.Value * 4)
                {
                    Checked = true;

                    if (chkCreamer.Checked)
                    {

                        if (woCreamer >= nudVal.Value * 2)
                        {
                            Checked = true;
                        }

                        else
                        {
                            Checked = false;
                        }

                    }

                    if (chkSugar.Checked)
                    {
                        if (woSugar >= nudVal.Value)
                        {
                            Checked = true;
                        }

                        else
                        {
                            Checked = false;
                        }
                    }
                }

                else
                {
                    Checked = false;
                }
            }

            if (rdoBtn.Name == "rdoMediumSize")
            {
                if (woMDCups >= nudVal.Value && woGrounds >= nudVal.Value * 3)
                {
                    Checked = true;

                    if (chkCreamer.Checked)
                    {

                        if (woCreamer >= nudVal.Value * 2)
                        {
                            Checked = true;
                        }

                        else
                        {
                            Checked = false;
                        }

                    }

                    if (chkSugar.Checked)
                    {
                        if (woSugar >= nudVal.Value)
                        {
                            Checked = true;
                        }

                        else
                        {
                            Checked = false;
                        }
                    }
                }
                else
                {
                    Checked = false;
                }
            }

            if (rdoBtn.Name == "rdoSmallSize")
            {
                if (woSMCups >= nudVal.Value && woGrounds >= nudVal.Value * 2)
                {
                    Checked = true;

                    if (chkCreamer.Checked)
                    {

                        if (woCreamer >= nudVal.Value * 2)
                        {
                            Checked = true;
                        }

                        else
                        {
                            Checked = false;
                        }

                    }

                    if (chkSugar.Checked)
                    {
                        if (woSugar >= nudVal.Value)
                        {
                            Checked = true;
                        }

                        else
                        {
                            Checked = false;
                        }
                    }
                }
                else
                {
                    Checked = false;
                }
            }
            this.CloseDatabaseConnection();
            return Checked;
        }

        //Method to add invoice
        //Used so that invoice keys can be populated prior to order being placed
        public void AddInvoice()
        {
            string strQuery = "SELECT receiptID FROM Invoice";

            int curID = 0;

            this.OpenDatabaseConnectExecuteQuery(strQuery);

            while (dbReader.Read())
            {
                curID = Convert.ToInt32(dbReader["receiptID"]);
            }
      
            this.CloseDatabaseConnection();

            string insQuery = "INSERT INTO Invoice (receiptID, receiptdate) VALUES (" + (curID + 1) +", '" + DateTime.Now.ToString() + "');";
            this.OpenDatabaseConnectExecuteQuery(insQuery);
            this.CloseDatabaseConnection();
        }

        //Used to check for initially empty invoice table
        public bool CheckEmptyID()
        {
            bool checkID = true;

            string strQuery = "SELECT COUNT(*) AS RowCnt FROM Invoice; ";
            int count = 0;

            this.OpenDatabaseConnectExecuteQuery(strQuery);

            while (dbReader.Read())
            {
                count = Convert.ToInt32(dbReader["RowCnt"]);
            }
            
            if(count == 0)
            {
                checkID = false;
            }

            this.CloseDatabaseConnection();
            return checkID;
        }
    }      
}
