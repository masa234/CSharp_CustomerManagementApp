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
    public partial class FrmInsertCustomer : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmInsertCustomer(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmInsertCustomer_Load(object sender, EventArgs e)
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

        private void BtnInsertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //顧客氏名
                string customerName = this.TxtCustomerName.Text;
                //年齢
                int.TryParse(this.TxtAge.Text, out int result);
                int age = result;
                //性別
                string gender = this.CmbGender.Text;
                //会社名
                string companyName = this.TxtCompanyName.Text;
                //部署名
                string deptName = this.TxtDeptName.Text;
                //メールアドレス
                string mailAddress = this.TxtMailAddress.Text;
                //備考
                string remarks = this.TxtRemarks.Text;

                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //文字数チェック(顧客氏名)
                if (! commonFunc.IsFitInText(customerName, Constant.CUSTOMERNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_CUSTOMERNAME,
                                                  Constant.CUSTOMERNAME_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(性別)
                if (String.IsNullOrEmpty(gender))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                                  Constant.ITEM_GENDER),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //コンボボックスの選択肢内かどうか?(性別)
                if (! commonFunc.IsTextInCmb(this.CmbGender, gender))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.MUST_IN_CMB,
                                                  Constant.ITEM_GENDER),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(会社名)
                if (! commonFunc.IsFitInText(companyName, Constant.COMPANYNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_COMPANYNAME,
                                                  Constant.COMPANYNAME_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(部署名)
                if (! commonFunc.IsFitInText(deptName, Constant.DEPTNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_DEPTNAME,
                                                  Constant.DEPTNAME_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(メールアドレス)
                if (! commonFunc.IsFitInText(mailAddress, Constant.MAILADDRESS_MAX_LENGTH))
                {
                    //メールアドレス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_MAILADDRESS,
                                                  Constant.MAILADDRESS_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(備考)
                if (! commonFunc.IsFitInText(remarks, Constant.REMARKS_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                                  Constant.ITEM_REMARKS,
                                                  Constant.REMARKS_MAX_LENGTH),
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                Customer customer = new Customer();

                //登録
                customer.InsertCustomer(customerName,
                                        age,
                                        gender,
                                        companyName,
                                        deptName,
                                        mailAddress,
                                        remarks);

                //成功メッセージ
                MessageBox.Show(String.Format(Constant.SUCCESS,
                                              Constant.INSERT_CUSTOMER),
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


        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// 2023/05/24
        private void InitForm()
        {
            //コンボボックスの設定
            SetCmb();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/05/24
        private void SetCmb()
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //性別のリストを取得
            List<string> genderList = otherFunc.GetGenderList();

            //インスタンス化
            CommonFunc commonFunc = new CommonFunc();

            //コンボボックスに設定
            commonFunc.SetCmb(this.CmbGender, genderList);
        }
    }
}
