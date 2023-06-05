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
    public partial class FrmContracts : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmContracts(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void DgvContracts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //契約ID
                long.TryParse(DgvContracts.Rows[e.RowIndex].Cells[1].Value.ToString(), out long contractID);

                //削除ボタンが押されている場合
                if (DgvContracts.Columns[e.ColumnIndex].Name == "DeleteContract")
                {
                    //インスタンス化
                    Contract contract = new Contract();

                    //削除
                    contract.DeleteContract(contractID);

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

        private void FrmContracts_Load(object sender, EventArgs e)
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
        /// 2023/06/01
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/06/01
        private void SetDataSource()
        {
            //インスタンス化
            Contract contract = new Contract();

            //データソースの設定
            this.DgvContracts.DataSource = contract.GetAllContractList();
        }
    }
}
