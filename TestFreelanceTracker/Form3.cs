using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFreelanceTracker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freelancetrackDataSet4.billinginfotest' table. You can move, or remove it, as needed.
            this.billinginfotestTableAdapter.Fill(this.freelancetrackDataSet4.billinginfotest);
            
            // TODO: This line of code loads data into the 'FullBillingInfoTable.billinginfo' table. You can move, or remove it, as needed.
            //this.billinginfoTableAdapter.Fill(this.FullBillingInfoTable.billinginfo);

            this.reportViewer1.RefreshReport();
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

  
        }
    }
}
