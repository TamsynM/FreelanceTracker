namespace TestFreelanceTracker
{
    partial class Form3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FullBillingInfoTable = new TestFreelanceTracker.FullBillingInfoTable();
            this.billinginfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billinginfoTableAdapter = new TestFreelanceTracker.FullBillingInfoTableTableAdapters.billinginfoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.billinginfotestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freelancetrackDataSet4 = new TestFreelanceTracker.freelancetrackDataSet4();
            this.freelancetrackDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billinginfotestTableAdapter = new TestFreelanceTracker.freelancetrackDataSet4TableAdapters.billinginfotestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FullBillingInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfotestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FullBillingInfoTable
            // 
            this.FullBillingInfoTable.DataSetName = "FullBillingInfoTable";
            this.FullBillingInfoTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billinginfoBindingSource
            // 
            this.billinginfoBindingSource.DataMember = "billinginfo";
            this.billinginfoBindingSource.DataSource = this.FullBillingInfoTable;
            // 
            // billinginfoTableAdapter
            // 
            this.billinginfoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "BillingInfo";
            reportDataSource1.Value = this.billinginfotestBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TestFreelanceTracker.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(750, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(138, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(12, 12);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.searchTxtBox.TabIndex = 2;
            // 
            // billinginfotestBindingSource
            // 
            this.billinginfotestBindingSource.DataMember = "billinginfotest";
            this.billinginfotestBindingSource.DataSource = this.freelancetrackDataSet4;
            // 
            // freelancetrackDataSet4
            // 
            this.freelancetrackDataSet4.DataSetName = "freelancetrackDataSet4";
            this.freelancetrackDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freelancetrackDataSet4BindingSource
            // 
            this.freelancetrackDataSet4BindingSource.DataSource = this.freelancetrackDataSet4;
            this.freelancetrackDataSet4BindingSource.Position = 0;
            // 
            // billinginfotestTableAdapter
            // 
            this.billinginfotestTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 467);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FullBillingInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinginfotestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource billinginfoBindingSource;
        private FullBillingInfoTable FullBillingInfoTable;
        private FullBillingInfoTableTableAdapters.billinginfoTableAdapter billinginfoTableAdapter;
        private System.Windows.Forms.BindingSource freelancetrackDataSet4BindingSource;
        private freelancetrackDataSet4 freelancetrackDataSet4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource billinginfotestBindingSource;
        private freelancetrackDataSet4TableAdapters.billinginfotestTableAdapter billinginfotestTableAdapter;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
    }
}