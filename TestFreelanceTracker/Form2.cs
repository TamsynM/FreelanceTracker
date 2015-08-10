using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;

namespace TestFreelanceTracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            refreshTable2();
            fillClientComboBox();
        }

        MySqlDataAdapter da;        // Data Adapter
        DataSet ds;                 // Dataset
        string sTable = "Table";

        /*void refreshTable()
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "SELECT * FROM freelancetrack.billinginfotest";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();

                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    
                }   
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        void refreshTable2()
        {
            try
            {
                string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
                MySqlConnection conn = new MySqlConnection(constring);
                conn.Open();
                da = new MySqlDataAdapter("SELECT * FROM freelancetrack.billinginfotest;", conn);
                ds = new DataSet();
                da.Fill(ds, sTable);
 
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clientNameTxtBoxPayments.Clear();
                clientIDTxtBoxPayments.Clear();
                invoiceIDPayments.Clear();
                amountBilledTxtBox.Clear();
                paymentsView.Refresh();
                paymentsView.DataSource = ds;
                paymentsView.DataMember = sTable;
            }  
        }

        void fillClientComboBox()
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "SELECT * FROM freelancetrack.billinginfotest";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("clientnametest");
                    selectClientComboBox.Items.Add(sName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freelancetrackDataSet2.billinginfotest' table. You can move, or remove it, as needed.
            this.billinginfotestTableAdapter.Fill(this.freelancetrackDataSet2.billinginfotest);
            // TODO: This line of code loads data into the 'fullBillingInfoTable.billinginfo' table. You can move, or remove it, as needed.
            this.billinginfoTableAdapter1.Fill(this.fullBillingInfoTable.billinginfo);
            // TODO: This line of code loads data into the 'freelancetrackDataSet2.billinginfo' table. You can move, or remove it, as needed.
            this.billinginfoTableAdapter.Fill(this.freelancetrackDataSet2.billinginfo);

        }

        private void selectClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";         
            //string Query = "SELECT ci.clientName, ci.idclientInfo, bi.idbillinginfo, bi.clientid, bi.clientname, bi.idbillinginfo, bi.amountbilled, bi.datebilled FROM clientinfo ci INNER JOIN billinginfo bi ON bi.clientid = ci.idclientInfo WHERE ci.clientName = '" + selectClientComboBox.Text + "'  ;";
            string Query = "SELECT * FROM freelancetrack.billinginfotest WHERE clientnametest = '" + selectClientComboBox.Text + "'  ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    //Show the client name, ID and rate for the selected client
                    string sName = myReader.GetString("clientnametest");
                    string sID = myReader.GetString("clientidtest");
                    
                    clientNameTxtBoxPayments.Text = sName;
                    clientIDTxtBoxPayments.Text = sID;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientNameTxtBoxPayments_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = paymentsView.DataSource;
            bs.Filter = "[clientnametest] Like '%" + clientNameTxtBoxPayments.Text + "%'";
            paymentsView.DataSource = bs;
        }

        private void addPaymentBtn_Click(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "INSERT INTO freelancetrack.billinginfotest (idbillinginfotest, clientidtest, clientnametest, amountbilledtest, datebilledtest) values ('" + this.invoiceIDPayments.Text + "', '" + this.clientIDTxtBoxPayments.Text + "', '" + this.clientNameTxtBoxPayments.Text + "', '" + this.amountBilledTxtBox.Text + "', '" + this.dateTimePicker1.Text + "') ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("New payment added");

                while (myReader.Read())
                {
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshPayments_Click(object sender, EventArgs e)
        {
            refreshTable2();
        }

        private void editPaymentBtn_Click(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "UPDATE freelancetrack.billinginfotest set clientnametest = '" + clientNameTxtBoxPayments.Text + "',  clientidtest = '" + this.clientIDTxtBoxPayments.Text + "', idbillinginfotest = '" + this.invoiceIDPayments.Text + "', amountbilledtest = '" + this.amountBilledTxtBox.Text + "', datebilledtest = '" + this.dateTimePicker1.Text + "' WHERE idbillinginfotest = '" + this.invoiceIDPayments.Text + "' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("Invoice  " + this.invoiceIDPayments.Text + " has been updated successfully");
                refreshTable2();

                while (myReader.Read())
                {
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletePaymentBtn_Click(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "DELETE FROM freelancetrack.billinginfotest WHERE idbillinginfotest = '" + this.invoiceIDPayments.Text + "' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("Invoice " + this.invoiceIDPayments.Text + " has been deleted successfully");
                refreshTable2();

                while (myReader.Read())
                {
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 report = new Form3();
            report.ShowDialog();
        }
    }
}
