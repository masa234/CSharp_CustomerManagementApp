using CSharp_CustomerManagementApp3.Common;
using CSharp_CustomerManagementApp3.Entity;
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
    public partial class FrmCustomers : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmCustomers(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void DgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //顧客ID
                long.TryParse(DgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString(), out long customerID);

                //削除ボタンが押されている場合
                if (DgvCustomers.Columns[e.ColumnIndex].Name == "BtnDeleteCustomer")
                {
                    //インスタンス化
                    Customer customer = new Customer();

                    //削除
                    customer.DeleteCustomer(customerID);

                    //データソースの再設定
                    SetDataSource();
                }

                //更新ボタンが押されている場合
                if (DgvCustomers.Columns[e.ColumnIndex].Name == "BtnUpdateCustomer")
                {
                    //インスタンス化
                    CommonFunc commonFunc = new CommonFunc();

                    //顧客更新画面に遷移
                    commonFunc.HideAndOpen(this, new FrmUpdateCustomer(this.loginUserID, customerID));
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

        private void FrmCustomers_Load(object sender, EventArgs e)
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


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //顧客氏名
                string searchCustomerName = this.TxtSearchCustomerName.Text;

                //インスタンス化
                Customer customer = new Customer();

                //検索結果(件数)を取得
                long customerCount = customer.GetSearchCount(searchCustomerName);

                //画面に設定
                this.LblSearchCount.Text = customerCount.ToString() + "件";

                //検索用データソースの設定
                SetSearchDataSource(searchCustomerName);
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



        private void BtnOutputCSV_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                Customer customer = new Customer();

                //顧客リストを取得
                List<CustomerData> customerList = customer.GetAllCustomerList();

                //CSV出力
                //TODO: 不具合あり
                customer.OutputCSV(customerList, Constant.OUTPUT_CSV_PATH);

                //成功メッセージ
                MessageBox.Show(String.Format(Constant.SUCCESS,
                                              Constant.OUTPUT_CSV),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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


        private void BtnSortAge_Click(object sender, EventArgs e)
        {
            try
            {
                //ソート済みデータソースの設定
                SetSortedDataSource();
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
        /// 2023/05/24
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/05/24
        private void SetDataSource()
        {
            //インスタンス化
            Customer customer = new Customer();

            //データソースの設定
            this.DgvCustomers.DataSource = customer.GetAllCustomerList();
        }


        /// <summary>
        /// 検索用データソースの設定
        /// </summary>
        /// 2023/06/01
        private void SetSearchDataSource(string searchCustomerName)
        {
            //インスタンス化
            Customer customer = new Customer();

            //データソースの設定
            this.DgvCustomers.DataSource = customer.FilterCustomerList(searchCustomerName);
        }


        /// <summary>
        /// ソート済みデータソースの設定
        /// </summary>
        /// 2023/06/01
        private void SetSortedDataSource()
        {
            //インスタンス化
            Customer customer = new Customer();

            //データソースの設定
            this.DgvCustomers.DataSource = customer.GetSortedCustomerList();
        }
    }
}
