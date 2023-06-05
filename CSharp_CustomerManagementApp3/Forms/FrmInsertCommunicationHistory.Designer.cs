namespace CSharp_CustomerManagementApp3.Forms
{
    partial class FrmInsertCommunicationHistory
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
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.InsertCommunicationHistory = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtDetail = new System.Windows.Forms.TextBox();
            this.LblDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(34, 78);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(636, 25);
            this.TxtTitle.TabIndex = 100;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(31, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(61, 18);
            this.LblTitle.TabIndex = 99;
            this.LblTitle.Text = "タイトル";
            // 
            // InsertCommunicationHistory
            // 
            this.InsertCommunicationHistory.Location = new System.Drawing.Point(491, 527);
            this.InsertCommunicationHistory.Margin = new System.Windows.Forms.Padding(2);
            this.InsertCommunicationHistory.Name = "InsertCommunicationHistory";
            this.InsertCommunicationHistory.Size = new System.Drawing.Size(179, 52);
            this.InsertCommunicationHistory.TabIndex = 98;
            this.InsertCommunicationHistory.Text = "登録";
            this.InsertCommunicationHistory.UseVisualStyleBackColor = true;
            this.InsertCommunicationHistory.Click += new System.EventHandler(this.InsertCommunicationHistory_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(275, 527);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 52);
            this.BtnBack.TabIndex = 97;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtDetail
            // 
            this.TxtDetail.Location = new System.Drawing.Point(34, 165);
            this.TxtDetail.Multiline = true;
            this.TxtDetail.Name = "TxtDetail";
            this.TxtDetail.Size = new System.Drawing.Size(636, 299);
            this.TxtDetail.TabIndex = 96;
            // 
            // LblDetail
            // 
            this.LblDetail.AutoSize = true;
            this.LblDetail.Location = new System.Drawing.Point(31, 124);
            this.LblDetail.Name = "LblDetail";
            this.LblDetail.Size = new System.Drawing.Size(44, 18);
            this.LblDetail.TabIndex = 95;
            this.LblDetail.Text = "詳細";
            // 
            // FrmInsertCommunicationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.InsertCommunicationHistory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtDetail);
            this.Controls.Add(this.LblDetail);
            this.Name = "FrmInsertCommunicationHistory";
            this.Text = "FrmInsertCommunicationHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtTitle;
        internal System.Windows.Forms.Label LblTitle;
        internal System.Windows.Forms.Button InsertCommunicationHistory;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.TextBox TxtDetail;
        internal System.Windows.Forms.Label LblDetail;
    }
}