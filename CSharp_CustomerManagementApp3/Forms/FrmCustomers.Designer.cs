namespace CSharp_CustomerManagementApp3.Forms
{
    partial class FrmCustomers
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
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtMailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeleteCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnUpdateCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LbllCustomerName = new System.Windows.Forms.Label();
            this.TxtSearchCustomerName = new System.Windows.Forms.TextBox();
            this.LblSearchCount = new System.Windows.Forms.Label();
            this.BtnOutputCSV = new System.Windows.Forms.Button();
            this.BtnSortAge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxtID,
            this.TxtCustomerName,
            this.TxtAge,
            this.TxtGender,
            this.TxtCompanyName,
            this.TxtDeptName,
            this.TxtMailAddress,
            this.TxtRemarks,
            this.BtnDeleteCustomer,
            this.BtnUpdateCustomer});
            this.DgvCustomers.Location = new System.Drawing.Point(114, 143);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.RowHeadersWidth = 62;
            this.DgvCustomers.RowTemplate.Height = 27;
            this.DgvCustomers.Size = new System.Drawing.Size(768, 372);
            this.DgvCustomers.TabIndex = 65;
            this.DgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellContentClick);
            // 
            // TxtID
            // 
            this.TxtID.DataPropertyName = "ID";
            this.TxtID.HeaderText = "ID";
            this.TxtID.MinimumWidth = 8;
            this.TxtID.Name = "TxtID";
            this.TxtID.Visible = false;
            this.TxtID.Width = 150;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.DataPropertyName = "CustomerName";
            this.TxtCustomerName.HeaderText = "顧客氏名";
            this.TxtCustomerName.MinimumWidth = 8;
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Width = 150;
            // 
            // TxtAge
            // 
            this.TxtAge.DataPropertyName = "Age";
            this.TxtAge.HeaderText = "年齢";
            this.TxtAge.MinimumWidth = 8;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Width = 150;
            // 
            // TxtGender
            // 
            this.TxtGender.DataPropertyName = "Gender";
            this.TxtGender.HeaderText = "性別";
            this.TxtGender.MinimumWidth = 8;
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Width = 150;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.DataPropertyName = "CompanyName";
            this.TxtCompanyName.HeaderText = "会社名";
            this.TxtCompanyName.MinimumWidth = 8;
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Width = 150;
            // 
            // TxtDeptName
            // 
            this.TxtDeptName.DataPropertyName = "DeptName";
            this.TxtDeptName.HeaderText = "部署名";
            this.TxtDeptName.MinimumWidth = 8;
            this.TxtDeptName.Name = "TxtDeptName";
            this.TxtDeptName.Width = 150;
            // 
            // TxtMailAddress
            // 
            this.TxtMailAddress.DataPropertyName = "MailAddress";
            this.TxtMailAddress.HeaderText = "メールアドレス";
            this.TxtMailAddress.MinimumWidth = 8;
            this.TxtMailAddress.Name = "TxtMailAddress";
            this.TxtMailAddress.Width = 150;
            // 
            // TxtRemarks
            // 
            this.TxtRemarks.DataPropertyName = "Remarks";
            this.TxtRemarks.HeaderText = "備考";
            this.TxtRemarks.MinimumWidth = 8;
            this.TxtRemarks.Name = "TxtRemarks";
            this.TxtRemarks.Width = 150;
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.HeaderText = "削除";
            this.BtnDeleteCustomer.MinimumWidth = 8;
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Width = 150;
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.HeaderText = "更新";
            this.BtnUpdateCustomer.MinimumWidth = 8;
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Width = 150;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(693, 536);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 64;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(701, 75);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(181, 52);
            this.BtnSearch.TabIndex = 76;
            this.BtnSearch.Text = "検索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LbllCustomerName
            // 
            this.LbllCustomerName.AutoSize = true;
            this.LbllCustomerName.Location = new System.Drawing.Point(103, 4);
            this.LbllCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbllCustomerName.Name = "LbllCustomerName";
            this.LbllCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbllCustomerName.Size = new System.Drawing.Size(80, 18);
            this.LbllCustomerName.TabIndex = 75;
            this.LbllCustomerName.Text = "顧客氏名";
            // 
            // TxtSearchCustomerName
            // 
            this.TxtSearchCustomerName.Location = new System.Drawing.Point(114, 35);
            this.TxtSearchCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearchCustomerName.Name = "TxtSearchCustomerName";
            this.TxtSearchCustomerName.Size = new System.Drawing.Size(769, 25);
            this.TxtSearchCustomerName.TabIndex = 74;
            // 
            // LblSearchCount
            // 
            this.LblSearchCount.AutoSize = true;
            this.LblSearchCount.Location = new System.Drawing.Point(891, 35);
            this.LblSearchCount.Name = "LblSearchCount";
            this.LblSearchCount.Size = new System.Drawing.Size(0, 18);
            this.LblSearchCount.TabIndex = 77;
            // 
            // BtnOutputCSV
            // 
            this.BtnOutputCSV.Location = new System.Drawing.Point(489, 536);
            this.BtnOutputCSV.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOutputCSV.Name = "BtnOutputCSV";
            this.BtnOutputCSV.Size = new System.Drawing.Size(179, 52);
            this.BtnOutputCSV.TabIndex = 78;
            this.BtnOutputCSV.Text = "CSV出力";
            this.BtnOutputCSV.UseVisualStyleBackColor = true;
            this.BtnOutputCSV.Click += new System.EventHandler(this.BtnOutputCSV_Click);
            // 
            // BtnSortAge
            // 
            this.BtnSortAge.Location = new System.Drawing.Point(489, 75);
            this.BtnSortAge.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSortAge.Name = "BtnSortAge";
            this.BtnSortAge.Size = new System.Drawing.Size(179, 52);
            this.BtnSortAge.TabIndex = 79;
            this.BtnSortAge.Text = "年齢でソート";
            this.BtnSortAge.UseVisualStyleBackColor = true;
            this.BtnSortAge.Click += new System.EventHandler(this.BtnSortAge_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 664);
            this.Controls.Add(this.BtnSortAge);
            this.Controls.Add(this.BtnOutputCSV);
            this.Controls.Add(this.LblSearchCount);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LbllCustomerName);
            this.Controls.Add(this.TxtSearchCustomerName);
            this.Controls.Add(this.DgvCustomers);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DgvCustomers;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtCustomerName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtAge;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtGender;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtCompanyName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtDeptName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtMailAddress;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtRemarks;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnDeleteCustomer;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnUpdateCustomer;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Button BtnSearch;
        internal System.Windows.Forms.Label LbllCustomerName;
        internal System.Windows.Forms.TextBox TxtSearchCustomerName;
        private System.Windows.Forms.Label LblSearchCount;
        internal System.Windows.Forms.Button BtnOutputCSV;
        internal System.Windows.Forms.Button BtnSortAge;
    }
}