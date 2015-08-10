namespace TestFreelanceTracker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paymentsView = new System.Windows.Forms.DataGridView();
            this.clientnametestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbillinginfotestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebilledtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountbilledtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billinginfotestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freelancetrackDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freelancetrackDataSet2 = new TestFreelanceTracker.freelancetrackDataSet2();
            this.billinginfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fullBillingInfoTable = new TestFreelanceTracker.FullBillingInfoTable();
            this.clientNameTxtBoxPayments = new System.Windows.Forms.TextBox();
            this.clientNameLblPayments = new System.Windows.Forms.Label();
            this.clientIDTxtBoxPayments = new System.Windows.Forms.TextBox();
            this.clientIDLblPayments = new System.Windows.Forms.Label();
            this.invoiceIDPayments = new System.Windows.Forms.TextBox();
            this.clientInvoiceID = new System.Windows.Forms.Label();
            this.dateBilledLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addPaymentBtn = new System.Windows.Forms.Button();
            this.editPaymentBtn = new System.Windows.Forms.Button();
            this.deletePaymentBtn = new System.Windows.Forms.Button();
            this.refreshPayments = new System.Windows.Forms.Button();
            this.billinginfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billinginfoTableAdapter = new TestFreelanceTracker.freelancetrackDataSet2TableAdapters.billinginfoTableAdapter();
            this.billinginfoTableAdapter1 = new TestFreelanceTracker.FullBillingInfoTableTableAdapters.billinginfoTableAdapter();
            this.selectClientComboBox = new System.Windows.Forms.ComboBox();
            this.selectClientLbl = new System.Windows.Forms.Label();
            this.billinginfotestTableAdapter = new TestFreelanceTracker.freelancetrackDataSet2TableAdapters.billinginfotestTableAdapter();
            this.amountBilledTxtBox = new System.Windows.Forms.TextBox();
            this.amountBilledLbl = new System.Windows.Forms.Label();
            this.viewReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfotestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBillingInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentsView
            // 
            this.paymentsView.AllowUserToAddRows = false;
            this.paymentsView.AllowUserToDeleteRows = false;
            this.paymentsView.AutoGenerateColumns = false;
            this.paymentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientnametestDataGridViewTextBoxColumn,
            this.clientidtestDataGridViewTextBoxColumn,
            this.idbillinginfotestDataGridViewTextBoxColumn,
            this.datebilledtestDataGridViewTextBoxColumn,
            this.amountbilledtestDataGridViewTextBoxColumn});
            this.paymentsView.DataSource = this.billinginfotestBindingSource;
            this.paymentsView.Location = new System.Drawing.Point(363, 36);
            this.paymentsView.Name = "paymentsView";
            this.paymentsView.ReadOnly = true;
            this.paymentsView.Size = new System.Drawing.Size(480, 328);
            this.paymentsView.TabIndex = 0;
            // 
            // clientnametestDataGridViewTextBoxColumn
            // 
            this.clientnametestDataGridViewTextBoxColumn.DataPropertyName = "clientnametest";
            this.clientnametestDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.clientnametestDataGridViewTextBoxColumn.Name = "clientnametestDataGridViewTextBoxColumn";
            this.clientnametestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientidtestDataGridViewTextBoxColumn
            // 
            this.clientidtestDataGridViewTextBoxColumn.DataPropertyName = "clientidtest";
            this.clientidtestDataGridViewTextBoxColumn.HeaderText = "Client ID";
            this.clientidtestDataGridViewTextBoxColumn.Name = "clientidtestDataGridViewTextBoxColumn";
            this.clientidtestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idbillinginfotestDataGridViewTextBoxColumn
            // 
            this.idbillinginfotestDataGridViewTextBoxColumn.DataPropertyName = "idbillinginfotest";
            this.idbillinginfotestDataGridViewTextBoxColumn.HeaderText = "Invoice ID";
            this.idbillinginfotestDataGridViewTextBoxColumn.Name = "idbillinginfotestDataGridViewTextBoxColumn";
            this.idbillinginfotestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datebilledtestDataGridViewTextBoxColumn
            // 
            this.datebilledtestDataGridViewTextBoxColumn.DataPropertyName = "datebilledtest";
            this.datebilledtestDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datebilledtestDataGridViewTextBoxColumn.Name = "datebilledtestDataGridViewTextBoxColumn";
            this.datebilledtestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountbilledtestDataGridViewTextBoxColumn
            // 
            this.amountbilledtestDataGridViewTextBoxColumn.DataPropertyName = "amountbilledtest";
            this.amountbilledtestDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountbilledtestDataGridViewTextBoxColumn.Name = "amountbilledtestDataGridViewTextBoxColumn";
            this.amountbilledtestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billinginfotestBindingSource
            // 
            this.billinginfotestBindingSource.DataMember = "billinginfotest";
            this.billinginfotestBindingSource.DataSource = this.freelancetrackDataSet2BindingSource;
            // 
            // freelancetrackDataSet2BindingSource
            // 
            this.freelancetrackDataSet2BindingSource.DataSource = this.freelancetrackDataSet2;
            this.freelancetrackDataSet2BindingSource.Position = 0;
            // 
            // freelancetrackDataSet2
            // 
            this.freelancetrackDataSet2.DataSetName = "freelancetrackDataSet2";
            this.freelancetrackDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billinginfoBindingSource1
            // 
            this.billinginfoBindingSource1.DataMember = "billinginfo";
            this.billinginfoBindingSource1.DataSource = this.fullBillingInfoTable;
            // 
            // fullBillingInfoTable
            // 
            this.fullBillingInfoTable.DataSetName = "FullBillingInfoTable";
            this.fullBillingInfoTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientNameTxtBoxPayments
            // 
            this.clientNameTxtBoxPayments.Location = new System.Drawing.Point(116, 60);
            this.clientNameTxtBoxPayments.Name = "clientNameTxtBoxPayments";
            this.clientNameTxtBoxPayments.Size = new System.Drawing.Size(100, 20);
            this.clientNameTxtBoxPayments.TabIndex = 16;
            this.clientNameTxtBoxPayments.TextChanged += new System.EventHandler(this.clientNameTxtBoxPayments_TextChanged);
            // 
            // clientNameLblPayments
            // 
            this.clientNameLblPayments.AutoSize = true;
            this.clientNameLblPayments.Location = new System.Drawing.Point(37, 60);
            this.clientNameLblPayments.Name = "clientNameLblPayments";
            this.clientNameLblPayments.Size = new System.Drawing.Size(35, 13);
            this.clientNameLblPayments.TabIndex = 15;
            this.clientNameLblPayments.Text = "Name";
            // 
            // clientIDTxtBoxPayments
            // 
            this.clientIDTxtBoxPayments.Location = new System.Drawing.Point(116, 101);
            this.clientIDTxtBoxPayments.Name = "clientIDTxtBoxPayments";
            this.clientIDTxtBoxPayments.Size = new System.Drawing.Size(100, 20);
            this.clientIDTxtBoxPayments.TabIndex = 14;
            // 
            // clientIDLblPayments
            // 
            this.clientIDLblPayments.AutoSize = true;
            this.clientIDLblPayments.Location = new System.Drawing.Point(37, 104);
            this.clientIDLblPayments.Name = "clientIDLblPayments";
            this.clientIDLblPayments.Size = new System.Drawing.Size(47, 13);
            this.clientIDLblPayments.TabIndex = 13;
            this.clientIDLblPayments.Text = "Client ID";
            // 
            // invoiceIDPayments
            // 
            this.invoiceIDPayments.Location = new System.Drawing.Point(116, 149);
            this.invoiceIDPayments.Name = "invoiceIDPayments";
            this.invoiceIDPayments.Size = new System.Drawing.Size(100, 20);
            this.invoiceIDPayments.TabIndex = 18;
            // 
            // clientInvoiceID
            // 
            this.clientInvoiceID.AutoSize = true;
            this.clientInvoiceID.Location = new System.Drawing.Point(37, 152);
            this.clientInvoiceID.Name = "clientInvoiceID";
            this.clientInvoiceID.Size = new System.Drawing.Size(56, 13);
            this.clientInvoiceID.TabIndex = 17;
            this.clientInvoiceID.Text = "Invoice ID";
            // 
            // dateBilledLbl
            // 
            this.dateBilledLbl.AutoSize = true;
            this.dateBilledLbl.Location = new System.Drawing.Point(37, 235);
            this.dateBilledLbl.Name = "dateBilledLbl";
            this.dateBilledLbl.Size = new System.Drawing.Size(58, 13);
            this.dateBilledLbl.TabIndex = 19;
            this.dateBilledLbl.Text = "Date Billed";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // addPaymentBtn
            // 
            this.addPaymentBtn.Location = new System.Drawing.Point(40, 280);
            this.addPaymentBtn.Name = "addPaymentBtn";
            this.addPaymentBtn.Size = new System.Drawing.Size(112, 23);
            this.addPaymentBtn.TabIndex = 23;
            this.addPaymentBtn.Text = "Add Payment";
            this.addPaymentBtn.UseVisualStyleBackColor = true;
            this.addPaymentBtn.Click += new System.EventHandler(this.addPaymentBtn_Click);
            // 
            // editPaymentBtn
            // 
            this.editPaymentBtn.Location = new System.Drawing.Point(40, 309);
            this.editPaymentBtn.Name = "editPaymentBtn";
            this.editPaymentBtn.Size = new System.Drawing.Size(112, 23);
            this.editPaymentBtn.TabIndex = 24;
            this.editPaymentBtn.Text = "Edit Payment";
            this.editPaymentBtn.UseVisualStyleBackColor = true;
            this.editPaymentBtn.Click += new System.EventHandler(this.editPaymentBtn_Click);
            // 
            // deletePaymentBtn
            // 
            this.deletePaymentBtn.Location = new System.Drawing.Point(40, 338);
            this.deletePaymentBtn.Name = "deletePaymentBtn";
            this.deletePaymentBtn.Size = new System.Drawing.Size(112, 23);
            this.deletePaymentBtn.TabIndex = 25;
            this.deletePaymentBtn.Text = "Delete Payment";
            this.deletePaymentBtn.UseVisualStyleBackColor = true;
            this.deletePaymentBtn.Click += new System.EventHandler(this.deletePaymentBtn_Click);
            // 
            // refreshPayments
            // 
            this.refreshPayments.Location = new System.Drawing.Point(204, 280);
            this.refreshPayments.Name = "refreshPayments";
            this.refreshPayments.Size = new System.Drawing.Size(112, 52);
            this.refreshPayments.TabIndex = 26;
            this.refreshPayments.Text = "Refresh Payment List";
            this.refreshPayments.UseVisualStyleBackColor = true;
            this.refreshPayments.Click += new System.EventHandler(this.refreshPayments_Click);
            // 
            // billinginfoBindingSource
            // 
            this.billinginfoBindingSource.DataMember = "billinginfo";
            this.billinginfoBindingSource.DataSource = this.freelancetrackDataSet2;
            // 
            // billinginfoTableAdapter
            // 
            this.billinginfoTableAdapter.ClearBeforeFill = true;
            // 
            // billinginfoTableAdapter1
            // 
            this.billinginfoTableAdapter1.ClearBeforeFill = true;
            // 
            // selectClientComboBox
            // 
            this.selectClientComboBox.FormattingEnabled = true;
            this.selectClientComboBox.Location = new System.Drawing.Point(116, 12);
            this.selectClientComboBox.Name = "selectClientComboBox";
            this.selectClientComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectClientComboBox.TabIndex = 21;
            this.selectClientComboBox.SelectedIndexChanged += new System.EventHandler(this.selectClientComboBox_SelectedIndexChanged);
            // 
            // selectClientLbl
            // 
            this.selectClientLbl.AutoSize = true;
            this.selectClientLbl.Location = new System.Drawing.Point(40, 19);
            this.selectClientLbl.Name = "selectClientLbl";
            this.selectClientLbl.Size = new System.Drawing.Size(66, 13);
            this.selectClientLbl.TabIndex = 22;
            this.selectClientLbl.Text = "Select Client";
            // 
            // billinginfotestTableAdapter
            // 
            this.billinginfotestTableAdapter.ClearBeforeFill = true;
            // 
            // amountBilledTxtBox
            // 
            this.amountBilledTxtBox.Location = new System.Drawing.Point(116, 191);
            this.amountBilledTxtBox.Name = "amountBilledTxtBox";
            this.amountBilledTxtBox.Size = new System.Drawing.Size(100, 20);
            this.amountBilledTxtBox.TabIndex = 28;
            // 
            // amountBilledLbl
            // 
            this.amountBilledLbl.AutoSize = true;
            this.amountBilledLbl.Location = new System.Drawing.Point(37, 194);
            this.amountBilledLbl.Name = "amountBilledLbl";
            this.amountBilledLbl.Size = new System.Drawing.Size(43, 13);
            this.amountBilledLbl.TabIndex = 27;
            this.amountBilledLbl.Text = "Amount";
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.Location = new System.Drawing.Point(204, 338);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(112, 23);
            this.viewReportBtn.TabIndex = 29;
            this.viewReportBtn.Text = "View Report";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 376);
            this.Controls.Add(this.viewReportBtn);
            this.Controls.Add(this.amountBilledTxtBox);
            this.Controls.Add(this.amountBilledLbl);
            this.Controls.Add(this.refreshPayments);
            this.Controls.Add(this.deletePaymentBtn);
            this.Controls.Add(this.editPaymentBtn);
            this.Controls.Add(this.addPaymentBtn);
            this.Controls.Add(this.selectClientLbl);
            this.Controls.Add(this.selectClientComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateBilledLbl);
            this.Controls.Add(this.invoiceIDPayments);
            this.Controls.Add(this.clientInvoiceID);
            this.Controls.Add(this.clientNameTxtBoxPayments);
            this.Controls.Add(this.clientNameLblPayments);
            this.Controls.Add(this.clientIDTxtBoxPayments);
            this.Controls.Add(this.clientIDLblPayments);
            this.Controls.Add(this.paymentsView);
            this.Name = "Form2";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfotestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBillingInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentsView;
        private freelancetrackDataSet2 freelancetrackDataSet2;
        private System.Windows.Forms.BindingSource billinginfoBindingSource;
        private freelancetrackDataSet2TableAdapters.billinginfoTableAdapter billinginfoTableAdapter;
        private System.Windows.Forms.TextBox clientNameTxtBoxPayments;
        private System.Windows.Forms.Label clientNameLblPayments;
        private System.Windows.Forms.TextBox clientIDTxtBoxPayments;
        private System.Windows.Forms.Label clientIDLblPayments;
        private System.Windows.Forms.TextBox invoiceIDPayments;
        private System.Windows.Forms.Label clientInvoiceID;
        private System.Windows.Forms.Label dateBilledLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addPaymentBtn;
        private System.Windows.Forms.Button editPaymentBtn;
        private System.Windows.Forms.Button deletePaymentBtn;
        private System.Windows.Forms.Button refreshPayments;
        private FullBillingInfoTable fullBillingInfoTable;
        private System.Windows.Forms.BindingSource billinginfoBindingSource1;
        private FullBillingInfoTableTableAdapters.billinginfoTableAdapter billinginfoTableAdapter1;
        private System.Windows.Forms.ComboBox selectClientComboBox;
        private System.Windows.Forms.Label selectClientLbl;
        private System.Windows.Forms.BindingSource freelancetrackDataSet2BindingSource;
        private System.Windows.Forms.BindingSource billinginfotestBindingSource;
        private freelancetrackDataSet2TableAdapters.billinginfotestTableAdapter billinginfotestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnametestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbillinginfotestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebilledtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountbilledtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox amountBilledTxtBox;
        private System.Windows.Forms.Label amountBilledLbl;
        private System.Windows.Forms.Button viewReportBtn;
    }
}