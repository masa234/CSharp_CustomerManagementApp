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
    public partial class FrmInsertContract : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmInsertContract(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void InsertContract_Click(object sender, EventArgs e)
        {
            try
            {
                //タイトル
                string title = this.TxtTitle.Text;
                //詳細
                string detail = this.TxtDetail.Text;
                //契約開始日
                DateTime contractStartDate = this.DateContractStartDate.Value;
                //契約終了日
                DateTime contractEndDate = this.DateContractEndDate.Value;
                //契約金
                int.TryParse(this.TxtContractMoney.Text, out int result);
                int contractMoney = result;
                //通知ON,OFF
                string notification = this.CmbIsNotification.Text;

                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //文字数チェック(タイトル)
                if (! commonFunc.IsFitInText(title, Constant.TITLE_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_TITLE,
                                                  Constant.TITLE_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(詳細)
                if (! commonFunc.IsFitInText(detail, Constant.DETAIL_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_DETAIL,
                                                  Constant.DETAIL_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(契約開始日)
                if (String.IsNullOrEmpty(contractStartDate.ToString()))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                                  Constant.ITEM_CONTRACT_STARTDATE),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(契約終了日)
                if (String.IsNullOrEmpty(contractEndDate.ToString()))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                                  Constant.ITEM_CONTRACT_ENDDATE),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(通知ON,OFF)
                if (String.IsNullOrEmpty(notification))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                                  Constant.ITEM_NOTIFICATION),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    return;
                }

                //コンボボックスの選択肢内かどうか?(通知ON, OFF)
                if (! commonFunc.IsTextInCmb(this.CmbIsNotification, notification))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.MUST_IN_CMB,
                                                  Constant.ITEM_NOTIFICATION),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                Contract contract = new Contract();

                //登録
                contract.InsertContract(title,
                                        detail,
                                        contractStartDate,
                                        contractEndDate,
                                        contractMoney,
                                        notification);

                //成功メッセージ
                MessageBox.Show(String.Format(Constant.SUCCESS,
                                              Constant.INSERT_CONTRACT),
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

        private void FrmInsertContract_Load(object sender, EventArgs e)
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
            //コンボボックスの設定
            SetCmb();

            //契約開始日
            this.DateContractStartDate.Value = DateTime.Today;

            //契約終了日
            this.DateContractEndDate.Value = DateTime.Today;
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/05/28
        private void SetCmb()
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //通知のリストを取得
            List<string> notificationList = otherFunc.GetNotificationList();

            //インスタンス化
            CommonFunc commonFunc = new CommonFunc();

            //コンボボックスに設定
            commonFunc.SetCmb(this.CmbIsNotification, notificationList);
        }
    }
}
