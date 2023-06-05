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
    public partial class FrmInsertCommunicationHistory : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmInsertCommunicationHistory(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID
            this.loginUserID = loginUserID;
        }

        private void InsertCommunicationHistory_Click(object sender, EventArgs e)
        {
            try
            {
                //タイトル
                string title = this.TxtTitle.Text;
                //詳細
                string detail = this.TxtDetail.Text;

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

                //インスタンス化
                CommunicationHistory communicationHistory = new CommunicationHistory();

                //登録
                communicationHistory.InsertCommunicationHistory(title, detail);

                //成功メッセージ
                MessageBox.Show(String.Format(Constant.SUCCESS,
                                              Constant.INSERT_COMMUNICATIONHISTORY),
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
    }
}
