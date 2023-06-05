using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CustomerManagementApp3.Common
{
    public class CommonFunc
    {
        /// <summary>
        /// 文字列がおさまっているかどうか?
        /// </summary>
        /// 2023/05/22
        public bool IsFitInText(string str,
                                    long maxLength)
        {
            //空かどうか?
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }

            //制限文字列を超えているかどうか?
            if (maxLength < str.Length)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// 画面遷移
        /// </summary>
        /// 2023/05/22
        public void HideAndOpen(Form openedForm,
                                    Form openForm)
        {
            //既に開いている画面を非表示にする
            openedForm.Hide();

            //画面を表示
            openForm.Show();
        }


        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        /// 2023/05/24
        public void SetCmb(ComboBox cmb,
                            List<string> cmbTxtList)
        {
            //コンボボックスのアイテムをクリア
            cmb.Items.Clear();

            //リストの要素数だけ繰り返す
            foreach (string cmbTxt in cmbTxtList)
            {
                //コンボボックスに値を設定
                cmb.Items.Add(cmbTxt);
            }
        }


        /// <summary>
        /// 文字列がおさまっているかどうか?
        /// </summary>
        /// 2023/05/24
        public bool IsTextInCmb(ComboBox cmb,
                                string str)
        {
            //リスト作成
            List<string> cmbTxtList = new List<string>();

            //コンボボックスの要素数だけ繰り返す
            foreach (string cmbTxt in cmb.Items)
            {
                //リストに追加
                cmbTxtList.Add(cmbTxt);
            }

            //リストに存在するかどうか?
            return cmbTxtList.Contains(str);
        }
    }
}
