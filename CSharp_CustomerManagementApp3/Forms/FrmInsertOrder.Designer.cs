namespace CSharp_CustomerManagementApp3.Forms
{
    partial class FrmInsertOrder
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
            this.InsertOrder = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbIsNotification = new System.Windows.Forms.ComboBox();
            this.LblIsNotification = new System.Windows.Forms.Label();
            this.TxtContractMoney = new System.Windows.Forms.TextBox();
            this.LblContractMoney = new System.Windows.Forms.Label();
            this.DateContractEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblContractEndDate = new System.Windows.Forms.Label();
            this.DateContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblContractStartDate = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtDetail = new System.Windows.Forms.TextBox();
            this.LblDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertOrder
            // 
            this.InsertOrder.Location = new System.Drawing.Point(496, 846);
            this.InsertOrder.Margin = new System.Windows.Forms.Padding(2);
            this.InsertOrder.Name = "InsertOrder";
            this.InsertOrder.Size = new System.Drawing.Size(179, 52);
            this.InsertOrder.TabIndex = 165;
            this.InsertOrder.Text = "登録";
            this.InsertOrder.UseVisualStyleBackColor = true;
            this.InsertOrder.Click += new System.EventHandler(this.InsertOrder_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(269, 846);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 164;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbIsNotification
            // 
            this.CmbIsNotification.FormattingEnabled = true;
            this.CmbIsNotification.Location = new System.Drawing.Point(52, 797);
            this.CmbIsNotification.Name = "CmbIsNotification";
            this.CmbIsNotification.Size = new System.Drawing.Size(121, 26);
            this.CmbIsNotification.TabIndex = 177;
            // 
            // LblIsNotification
            // 
            this.LblIsNotification.AutoSize = true;
            this.LblIsNotification.Location = new System.Drawing.Point(49, 750);
            this.LblIsNotification.Name = "LblIsNotification";
            this.LblIsNotification.Size = new System.Drawing.Size(106, 18);
            this.LblIsNotification.TabIndex = 176;
            this.LblIsNotification.Text = "通知ON,OFF";
            // 
            // TxtContractMoney
            // 
            this.TxtContractMoney.Location = new System.Drawing.Point(52, 696);
            this.TxtContractMoney.Name = "TxtContractMoney";
            this.TxtContractMoney.Size = new System.Drawing.Size(636, 25);
            this.TxtContractMoney.TabIndex = 175;
            // 
            // LblContractMoney
            // 
            this.LblContractMoney.AutoSize = true;
            this.LblContractMoney.Location = new System.Drawing.Point(49, 656);
            this.LblContractMoney.Name = "LblContractMoney";
            this.LblContractMoney.Size = new System.Drawing.Size(62, 18);
            this.LblContractMoney.TabIndex = 174;
            this.LblContractMoney.Text = "契約金";
            // 
            // DateContractEndDate
            // 
            this.DateContractEndDate.Location = new System.Drawing.Point(52, 606);
            this.DateContractEndDate.Name = "DateContractEndDate";
            this.DateContractEndDate.Size = new System.Drawing.Size(200, 25);
            this.DateContractEndDate.TabIndex = 173;
            // 
            // LblContractEndDate
            // 
            this.LblContractEndDate.AutoSize = true;
            this.LblContractEndDate.Location = new System.Drawing.Point(50, 562);
            this.LblContractEndDate.Name = "LblContractEndDate";
            this.LblContractEndDate.Size = new System.Drawing.Size(98, 18);
            this.LblContractEndDate.TabIndex = 172;
            this.LblContractEndDate.Text = "契約終了日";
            // 
            // DateContractStartDate
            // 
            this.DateContractStartDate.Location = new System.Drawing.Point(53, 516);
            this.DateContractStartDate.Name = "DateContractStartDate";
            this.DateContractStartDate.Size = new System.Drawing.Size(200, 25);
            this.DateContractStartDate.TabIndex = 171;
            // 
            // LblContractStartDate
            // 
            this.LblContractStartDate.AutoSize = true;
            this.LblContractStartDate.Location = new System.Drawing.Point(50, 476);
            this.LblContractStartDate.Name = "LblContractStartDate";
            this.LblContractStartDate.Size = new System.Drawing.Size(98, 18);
            this.LblContractStartDate.TabIndex = 170;
            this.LblContractStartDate.Text = "契約開始日";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(53, 65);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(636, 25);
            this.TxtTitle.TabIndex = 169;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(50, 14);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(61, 18);
            this.LblTitle.TabIndex = 168;
            this.LblTitle.Text = "タイトル";
            // 
            // TxtDetail
            // 
            this.TxtDetail.Location = new System.Drawing.Point(53, 152);
            this.TxtDetail.Multiline = true;
            this.TxtDetail.Name = "TxtDetail";
            this.TxtDetail.Size = new System.Drawing.Size(636, 299);
            this.TxtDetail.TabIndex = 167;
            // 
            // LblDetail
            // 
            this.LblDetail.AutoSize = true;
            this.LblDetail.Location = new System.Drawing.Point(50, 111);
            this.LblDetail.Name = "LblDetail";
            this.LblDetail.Size = new System.Drawing.Size(44, 18);
            this.LblDetail.TabIndex = 166;
            this.LblDetail.Text = "詳細";
            // 
            // FrmInsertOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1044);
            this.Controls.Add(this.CmbIsNotification);
            this.Controls.Add(this.LblIsNotification);
            this.Controls.Add(this.TxtContractMoney);
            this.Controls.Add(this.LblContractMoney);
            this.Controls.Add(this.DateContractEndDate);
            this.Controls.Add(this.LblContractEndDate);
            this.Controls.Add(this.DateContractStartDate);
            this.Controls.Add(this.LblContractStartDate);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtDetail);
            this.Controls.Add(this.LblDetail);
            this.Controls.Add(this.InsertOrder);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmInsertOrder";
            this.Text = "FrmInsertOrder";
            this.Load += new System.EventHandler(this.FrmInsertOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button InsertOrder;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.ComboBox CmbIsNotification;
        internal System.Windows.Forms.Label LblIsNotification;
        internal System.Windows.Forms.TextBox TxtContractMoney;
        internal System.Windows.Forms.Label LblContractMoney;
        internal System.Windows.Forms.DateTimePicker DateContractEndDate;
        internal System.Windows.Forms.Label LblContractEndDate;
        internal System.Windows.Forms.DateTimePicker DateContractStartDate;
        internal System.Windows.Forms.Label LblContractStartDate;
        internal System.Windows.Forms.TextBox TxtTitle;
        internal System.Windows.Forms.Label LblTitle;
        internal System.Windows.Forms.TextBox TxtDetail;
        internal System.Windows.Forms.Label LblDetail;
    }
}