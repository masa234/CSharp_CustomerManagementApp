namespace CSharp_CustomerManagementApp3.Forms
{
    partial class FrmCommunicationHistories
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
            this.DgvCommunicationHistories = new System.Windows.Forms.DataGridView();
            this.TxtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDeleteCommunicationHistory = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCommunicationHistories)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(539, 365);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 65;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvCommunicationHistories
            // 
            this.DgvCommunicationHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCommunicationHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxtID,
            this.TxtTitle,
            this.TxtDetail,
            this.BtnDeleteCommunicationHistory});
            this.DgvCommunicationHistories.Location = new System.Drawing.Point(67, 41);
            this.DgvCommunicationHistories.Name = "DgvCommunicationHistories";
            this.DgvCommunicationHistories.RowHeadersWidth = 62;
            this.DgvCommunicationHistories.RowTemplate.Height = 27;
            this.DgvCommunicationHistories.Size = new System.Drawing.Size(651, 292);
            this.DgvCommunicationHistories.TabIndex = 64;
            this.DgvCommunicationHistories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCommunicationHistories_CellContentClick);
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
            // BtnDeleteCommunicationHistory
            // 
            this.BtnDeleteCommunicationHistory.HeaderText = "削除";
            this.BtnDeleteCommunicationHistory.MinimumWidth = 8;
            this.BtnDeleteCommunicationHistory.Name = "BtnDeleteCommunicationHistory";
            this.BtnDeleteCommunicationHistory.Width = 150;
            // 
            // FrmCommunicationHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvCommunicationHistories);
            this.Name = "FrmCommunicationHistories";
            this.Text = "FrmCommunicationHistories";
            this.Load += new System.EventHandler(this.FrmCommunicationHistories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCommunicationHistories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvCommunicationHistories;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtTitle;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TxtDetail;
        internal System.Windows.Forms.DataGridViewButtonColumn BtnDeleteCommunicationHistory;
    }
}