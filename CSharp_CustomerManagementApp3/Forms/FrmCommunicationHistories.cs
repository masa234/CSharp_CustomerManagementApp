using CSharp_CustomerManagementApp3.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CustomerManagementApp3.Forms
{
    public partial class FrmCommunicationHistories : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmCommunicationHistories(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void DgvCommunicationHistories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //コミュニケーション履歴ID
                long.TryParse(DgvCommunicationHistories.Rows[e.RowIndex].Cells[1].Value.ToString(), out long communicationHistoryID);

                //削除ボタンが押されている場合
                if (DgvCommunicationHistories.Columns[e.ColumnIndex].Name == "BtnDeleteCommunicationHistory")
                {
                    //インスタンス化
                    CommunicationHistory communicationHistory = new CommunicationHistory();

                    //削除
                    communicationHistory.DeleteCommunicationHistory(communicationHistoryID);

                    //データソースの再設定
                    SetDataSource();
                }
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //メイン画面に遷移
                commonFunc.HideAndOpen(this, new FrmMain(this.loginUserID));
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FrmCommunicationHistories_Load(object sender, EventArgs e)
        {
            try
            {
                //フォーム初期化
                InitForm();
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// 2023/05/28
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/05/28
        private void SetDataSource()
        {
            //インスタンス化
            CommunicationHistory communicationHistory = new CommunicationHistory();

            //データソースの設定
            this.DgvCommunicationHistories.DataSource = communicationHistory.GetAllCommunicationHistories();
        }
    }
}
