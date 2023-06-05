namespace CSharp_CustomerManagementApp3.Forms
{
    partial class FrmContracts
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.DgvContracts = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtContractStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtContractEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtContractMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNotification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteContract = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(545, 350);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 67;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvContracts
            // 
            this.DgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxtID,
            this.TxtTitle,
            this.TxtDetail,
            this.TxtContractStartDate,
            this.TxtContractEndDate,
            this.TxtContractMoney,
            this.TxtNotification,
            this.DeleteContract});
            this.DgvContracts.Location = new System.Drawing.Point(73, 35);
            this.DgvContracts.Name = "DgvContracts";
            this.DgvContracts.RowHeadersWidth = 62;
            this.DgvContracts.RowTemplate.Height = 27;
            this.DgvContracts.Size = new System.Drawing.Size(651, 292);
            this.DgvContracts.TabIndex = 66;
            this.DgvContracts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContracts_CellContentClick);
            // 
            // TxtID
            // 
            this.TxtID.DataPropertyName = "Id";
            this.TxtID.HeaderText = "ID";
            this.TxtID.MinimumWidth = 8;
            this.TxtID.Name = "TxtID";
            this.TxtID.Visible = false;
            this.TxtID.Width = 150;
            // 
            // TxtTitle
            // 
            this.TxtTitle.DataPropertyName = "Title";
            this.TxtTitle.HeaderText = "タイトル";
            this.TxtTitle.MinimumWidth = 8;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Width = 150;
            // 
            // TxtDetail
            // 
            this.TxtDetail.DataPropertyName = "Detail";
            this.TxtDetail.HeaderText = "詳細";
            this.TxtDetail.MinimumWidth = 8;
            this.TxtDetail.Name = "TxtDetail";
            this.TxtDetail.Width = 150;
            // 
            // TxtContractStartDate
            // 
            this.TxtContractStartDate.DataPropertyName = "ContractStartDate";
            this.TxtContractStartDate.HeaderText = "契約開始日";
            this.TxtContractStartDate.MinimumWidth = 8;
            this.TxtContractStartDate.Name = "TxtContractStartDate";
            this.TxtContractStartDate.Width = 150;
            // 
            // TxtContractEndDate
            // 
            this.TxtContractEndDate.DataPropertyName = "ContractEndDate";
            this.TxtContractEndDate.HeaderText = "契約終了日";
            this.TxtContractEndDate.MinimumWidth = 8;
            this.TxtContractEndDate.Name = "TxtContractEndDate";
            this.TxtContractEndDate.Width = 150;
            // 
            // TxtContractMoney
            // 
            this.TxtContractMoney.DataPropertyName = "ContractMoney";
            this.TxtContractMoney.HeaderText = "契約金";
            this.TxtContractMoney.MinimumWidth = 8;
            this.TxtContractMoney.Name = "TxtContractMoney";
            this.TxtContractMoney.Width = 150;
            // 
            // TxtNotification
            // 
            this.TxtNotification.DataPropertyName = "Notification";
            this.TxtNotification.HeaderText = "通知ON,OFF";
            this.TxtNotification.MinimumWidth = 8;
            this.TxtNotification.Name = "TxtNotification";
            this.TxtNotification.Width = 150;
            // 
            // DeleteContract
            // 
            this.DeleteContract.HeaderText = "削除";
            this.DeleteContract.MinimumWidth = 8;
            this.DeleteContract.Name = "DeleteContract";
            this.DeleteContract.Width = 150;
            // 
            // FrmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvContracts);
            this.Name = "FrmContracts";
            this.Text = "FrmContracts";
            this.Load += new System.EventHandler(this.FrmContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvContracts;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtTitle;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtDetail;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtContractStartDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtContractEndDate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtContractMoney;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtNotification;
        internal System.Windows.Forms.DataGridViewButtonColumn DeleteContract;
    }
}