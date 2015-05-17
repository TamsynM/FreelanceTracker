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

namespace TestFreelanceTracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            refreshTable();
            fillClientComboBox();
        }

        void refreshTable()
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
                    string sID = myReader.GetString("idbillingInfotest");
                    

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

        }
    }
}
