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
    public partial class trackerMain : Form
    {
        public trackerMain()
        {
            InitializeComponent();
            //Fill the listbox with the names of the clients
            fillListbox();
        }

        void fillListbox()
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "SELECT * FROM freelancetrack.clientinfotest";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("clientNametest");
                    clientListBox.Items.Add(sName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackerMain_Load(object sender, EventArgs e)
        {
            try
            {
                //Connect to the client info table in the database and select all information from that table
                string myConnection = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM freelancetrack.clientinfotest", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                //Create a Dataset
                DataSet ds = new DataSet();
                myConn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table where the client name is the one that has been selected
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "SELECT * FROM freelancetrack.clientinfotest WHERE clientNametest = '" + clientListBox.Text + "'  ;";
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
                    string sName = myReader.GetString("clientNametest");
                    string sID = myReader.GetString("idclientInfotest");
                    string sRate = myReader.GetString("clientRatetest").ToString();

                    clientNameTxtBox.Text = sName;
                    clientIDTxtBox.Text = sID;
                    clientRateTxtBox.Text = sRate;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "INSERT INTO freelancetrack.clientinfotest (clientNametest, idclientInfotest, clientRatetest) values ('" + this.clientNameTxtBox.Text + "', '" + this.clientIDTxtBox.Text + "', '" + this.clientRateTxtBox.Text + "') ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("New client added");

                while (myReader.Read())
                {
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            clientListBox.Items.Clear();
            clientNameTxtBox.Text = "";
            clientIDTxtBox.Text = "";
            clientRateTxtBox.Text = "";
            fillListbox();
        }

        private void editClientBtn_Click(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "UPDATE freelancetrack.clientinfotest set clientNametest = '" + this.clientNameTxtBox.Text + "', idclientInfotest = '" + this.clientIDTxtBox.Text + "', clientRatetest = '" + this.clientRateTxtBox.Text + "' WHERE clientNametest = '" + this.clientNameTxtBox.Text + "' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("Client " + this.clientNameTxtBox.Text + " has been updated successfully" );

                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeClientBtn_Click(object sender, EventArgs e)
        {
            //Connect to the client info table in the database and select all information from that table
            string constring = "user id=root;password=popple;persistsecurityinfo=True;server=localhost;database=freelancetrack";
            string Query = "DELETE FROM freelancetrack.clientinfotest WHERE clientNametest = '" + this.clientNameTxtBox.Text + "' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;

            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                MessageBox.Show("Client " + this.clientNameTxtBox.Text + " has been deleted successfully");

                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewPaymentsBtn_Click(object sender, EventArgs e)
        {
            //Hide Form 1 and show Form 2
            this.Hide();
            Form2 payments = new Form2();
            payments.ShowDialog();
        }

    }
}
