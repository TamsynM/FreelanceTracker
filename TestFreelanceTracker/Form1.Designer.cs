namespace TestFreelanceTracker
{
    partial class trackerMain
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
            this.addClientBtn = new System.Windows.Forms.Button();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.freelancetrackDataSet = new TestFreelanceTracker.freelancetrackDataSet();
            this.clientinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientinfoTableAdapter = new TestFreelanceTracker.freelancetrackDataSetTableAdapters.clientinfoTableAdapter();
            this.clientIDLbl = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.clientIDTxtBox = new System.Windows.Forms.TextBox();
            this.clientRateTxtBox = new System.Windows.Forms.TextBox();
            this.viewPaymentsBtn = new System.Windows.Forms.Button();
            this.editClientBtn = new System.Windows.Forms.Button();
            this.clientNameTxtBox = new System.Windows.Forms.TextBox();
            this.clientNameLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.removeClientBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(69, 170);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(120, 23);
            this.addClientBtn.TabIndex = 0;
            this.addClientBtn.Text = "Add New Client";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // clientListBox
            // 
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.Location = new System.Drawing.Point(69, 58);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(120, 95);
            this.clientListBox.TabIndex = 1;
            this.clientListBox.SelectedIndexChanged += new System.EventHandler(this.clientListBox_SelectedIndexChanged);
            // 
            // freelancetrackDataSet
            // 
            this.freelancetrackDataSet.DataSetName = "freelancetrackDataSet";
            this.freelancetrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientinfoBindingSource
            // 
            this.clientinfoBindingSource.DataMember = "clientinfo";
            this.clientinfoBindingSource.DataSource = this.freelancetrackDataSet;
            // 
            // clientinfoTableAdapter
            // 
            this.clientinfoTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDLbl
            // 
            this.clientIDLbl.AutoSize = true;
            this.clientIDLbl.Location = new System.Drawing.Point(256, 88);
            this.clientIDLbl.Name = "clientIDLbl";
            this.clientIDLbl.Size = new System.Drawing.Size(47, 13);
            this.clientIDLbl.TabIndex = 2;
            this.clientIDLbl.Text = "Client ID";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(256, 118);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(42, 13);
            this.rateLabel.TabIndex = 3;
            this.rateLabel.Text = "Rate  $";
            // 
            // clientIDTxtBox
            // 
            this.clientIDTxtBox.Location = new System.Drawing.Point(364, 88);
            this.clientIDTxtBox.Name = "clientIDTxtBox";
            this.clientIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTxtBox.TabIndex = 5;
            // 
            // clientRateTxtBox
            // 
            this.clientRateTxtBox.Location = new System.Drawing.Point(364, 118);
            this.clientRateTxtBox.Name = "clientRateTxtBox";
            this.clientRateTxtBox.Size = new System.Drawing.Size(100, 20);
            this.clientRateTxtBox.TabIndex = 6;
            // 
            // viewPaymentsBtn
            // 
            this.viewPaymentsBtn.Location = new System.Drawing.Point(69, 292);
            this.viewPaymentsBtn.Name = "viewPaymentsBtn";
            this.viewPaymentsBtn.Size = new System.Drawing.Size(120, 23);
            this.viewPaymentsBtn.TabIndex = 9;
            this.viewPaymentsBtn.Text = "View Payments";
            this.viewPaymentsBtn.UseVisualStyleBackColor = true;
            this.viewPaymentsBtn.Click += new System.EventHandler(this.viewPaymentsBtn_Click);
            // 
            // editClientBtn
            // 
            this.editClientBtn.Location = new System.Drawing.Point(364, 156);
            this.editClientBtn.Name = "editClientBtn";
            this.editClientBtn.Size = new System.Drawing.Size(120, 23);
            this.editClientBtn.TabIndex = 10;
            this.editClientBtn.Text = "Update Existing Client";
            this.editClientBtn.UseVisualStyleBackColor = true;
            this.editClientBtn.Click += new System.EventHandler(this.editClientBtn_Click);
            // 
            // clientNameTxtBox
            // 
            this.clientNameTxtBox.Location = new System.Drawing.Point(364, 58);
            this.clientNameTxtBox.Name = "clientNameTxtBox";
            this.clientNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTxtBox.TabIndex = 12;
            // 
            // clientNameLbl
            // 
            this.clientNameLbl.AutoSize = true;
            this.clientNameLbl.Location = new System.Drawing.Point(256, 58);
            this.clientNameLbl.Name = "clientNameLbl";
            this.clientNameLbl.Size = new System.Drawing.Size(35, 13);
            this.clientNameLbl.TabIndex = 11;
            this.clientNameLbl.Text = "Name";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(69, 211);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(120, 23);
            this.refreshBtn.TabIndex = 13;
            this.refreshBtn.Text = "Refresh Client List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // removeClientBtn
            // 
            this.removeClientBtn.Location = new System.Drawing.Point(364, 195);
            this.removeClientBtn.Name = "removeClientBtn";
            this.removeClientBtn.Size = new System.Drawing.Size(120, 23);
            this.removeClientBtn.TabIndex = 14;
            this.removeClientBtn.Text = "Remove Client";
            this.removeClientBtn.UseVisualStyleBackColor = true;
            this.removeClientBtn.Click += new System.EventHandler(this.removeClientBtn_Click);
            // 
            // trackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 489);
            this.Controls.Add(this.removeClientBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.clientNameTxtBox);
            this.Controls.Add(this.clientNameLbl);
            this.Controls.Add(this.editClientBtn);
            this.Controls.Add(this.viewPaymentsBtn);
            this.Controls.Add(this.clientRateTxtBox);
            this.Controls.Add(this.clientIDTxtBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.clientIDLbl);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.addClientBtn);
            this.Name = "trackerMain";
            this.Text = "Freelance Tracker";
            this.Load += new System.EventHandler(this.trackerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.freelancetrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.ListBox clientListBox;
        private freelancetrackDataSet freelancetrackDataSet;
        private System.Windows.Forms.BindingSource clientinfoBindingSource;
        private freelancetrackDataSetTableAdapters.clientinfoTableAdapter clientinfoTableAdapter;
        private System.Windows.Forms.Label clientIDLbl;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox clientIDTxtBox;
        private System.Windows.Forms.TextBox clientRateTxtBox;
        private System.Windows.Forms.Button viewPaymentsBtn;
        private System.Windows.Forms.Button editClientBtn;
        private System.Windows.Forms.TextBox clientNameTxtBox;
        private System.Windows.Forms.Label clientNameLbl;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button removeClientBtn;
    }
}

