namespace CSharp_CustomerManagementApp3
{
    partial class FrmMain
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
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnReleaseLock = new System.Windows.Forms.Button();
            this.BtnInsertCustomer = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.InsertCommunicationHistory = new System.Windows.Forms.Button();
            this.BtnCommunicationHistories = new System.Windows.Forms.Button();
            this.BtnInsertContract = new System.Windows.Forms.Button();
            this.BtnContracts = new System.Windows.Forms.Button();
            this.BtnInsertOrder = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(794, 449);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(161, 66);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.Text = "ログアウト";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnReleaseLock
            // 
            this.BtnReleaseLock.Location = new System.Drawing.Point(40, 35);
            this.BtnReleaseLock.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReleaseLock.Name = "BtnReleaseLock";
            this.BtnReleaseLock.Size = new System.Drawing.Size(161, 65);
            this.BtnReleaseLock.TabIndex = 8;
            this.BtnReleaseLock.Text = "アカウントロック解除";
            this.BtnReleaseLock.UseVisualStyleBackColor = true;
            this.BtnReleaseLock.Click += new System.EventHandler(this.BtnReleaseLock_Click);
            // 
            // BtnInsertCustomer
            // 
            this.BtnInsertCustomer.Location = new System.Drawing.Point(40, 132);
            this.BtnInsertCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsertCustomer.Name = "BtnInsertCustomer";
            this.BtnInsertCustomer.Size = new System.Drawing.Size(161, 66);
            this.BtnInsertCustomer.TabIndex = 10;
            this.BtnInsertCustomer.Text = "顧客登録";
            this.BtnInsertCustomer.UseVisualStyleBackColor = true;
            this.BtnInsertCustomer.Click += new System.EventHandler(this.BtnInsertCustomer_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Location = new System.Drawing.Point(229, 132);
            this.BtnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(161, 66);
            this.BtnCustomers.TabIndex = 11;
            this.BtnCustomers.Text = "顧客一覧";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // InsertCommunicationHistory
            // 
            this.InsertCommunicationHistory.Location = new System.Drawing.Point(40, 240);
            this.InsertCommunicationHistory.Margin = new System.Windows.Forms.Padding(4);
            this.InsertCommunicationHistory.Name = "InsertCommunicationHistory";
            this.InsertCommunicationHistory.Size = new System.Drawing.Size(161, 66);
            this.InsertCommunicationHistory.TabIndex = 16;
            this.InsertCommunicationHistory.Text = "コミュニケーション履歴登録";
            this.InsertCommunicationHistory.UseVisualStyleBackColor = true;
            this.InsertCommunicationHistory.Click += new System.EventHandler(this.InsertCommunicationHistory_Click);
            // 
            // BtnCommunicationHistories
            // 
            this.BtnCommunicationHistories.Location = new System.Drawing.Point(229, 240);
            this.BtnCommunicationHistories.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCommunicationHistories.Name = "BtnCommunicationHistories";
            this.BtnCommunicationHistories.Size = new System.Drawing.Size(161, 66);
            this.BtnCommunicationHistories.TabIndex = 17;
            this.BtnCommunicationHistories.Text = "コミュニケーション履歴一覧";
            this.BtnCommunicationHistories.UseVisualStyleBackColor = true;
            this.BtnCommunicationHistories.Click += new System.EventHandler(this.BtnCommunicationHistories_Click);
            // 
            // BtnInsertContract
            // 
            this.BtnInsertContract.Location = new System.Drawing.Point(40, 339);
            this.BtnInsertContract.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsertContract.Name = "BtnInsertContract";
            this.BtnInsertContract.Size = new System.Drawing.Size(161, 66);
            this.BtnInsertContract.TabIndex = 18;
            this.BtnInsertContract.Text = "契約情報登録";
            this.BtnInsertContract.UseVisualStyleBackColor = true;
            this.BtnInsertContract.Click += new System.EventHandler(this.BtnInsertContract_Click);
            // 
            // BtnContracts
            // 
            this.BtnContracts.Location = new System.Drawing.Point(229, 339);
            this.BtnContracts.Margin = new System.Windows.Forms.Padding(4);
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.Size = new System.Drawing.Size(161, 66);
            this.BtnContracts.TabIndex = 19;
            this.BtnContracts.Text = "契約情報一覧";
            this.BtnContracts.UseVisualStyleBackColor = true;
            this.BtnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // BtnInsertOrder
            // 
            this.BtnInsertOrder.Location = new System.Drawing.Point(40, 428);
            this.BtnInsertOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsertOrder.Name = "BtnInsertOrder";
            this.BtnInsertOrder.Size = new System.Drawing.Size(161, 66);
            this.BtnInsertOrder.TabIndex = 20;
            this.BtnInsertOrder.Text = "注文情報登録";
            this.BtnInsertOrder.UseVisualStyleBackColor = true;
            this.BtnInsertOrder.Click += new System.EventHandler(this.BtnInsertOrder_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.Location = new System.Drawing.Point(229, 428);
            this.BtnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(161, 66);
            this.BtnOrders.TabIndex = 21;
            this.BtnOrders.Text = "注文情報一覧";
            this.BtnOrders.UseVisualStyleBackColor = true;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.BtnOrders);
            this.Controls.Add(this.BtnInsertOrder);
            this.Controls.Add(this.BtnContracts);
            this.Controls.Add(this.BtnInsertContract);
            this.Controls.Add(this.BtnCommunicationHistories);
            this.Controls.Add(this.InsertCommunicationHistory);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnInsertCustomer);
            this.Controls.Add(this.BtnReleaseLock);
            this.Controls.Add(this.BtnLogout);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnLogout;
        internal System.Windows.Forms.Button BtnReleaseLock;
        internal System.Windows.Forms.Button BtnInsertCustomer;
        internal System.Windows.Forms.Button BtnCustomers;
        internal System.Windows.Forms.Button InsertCommunicationHistory;
        internal System.Windows.Forms.Button BtnCommunicationHistories;
        internal System.Windows.Forms.Button BtnInsertContract;
        internal System.Windows.Forms.Button BtnContracts;
        internal System.Windows.Forms.Button BtnInsertOrder;
        internal System.Windows.Forms.Button BtnOrders;
    }
}