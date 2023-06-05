using CSharp_CustomerManagementApp3.Common;
using CSharp_CustomerManagementApp3.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3
{
    public class Contract
    {
        /// <summary>
        /// 契約情報登録
        /// </summary>
        /// 2023/05/28
        public void InsertContract(string title,
                                    string detail,
                                    DateTime contractStartDate,
                                    DateTime contractEndDate,
                                    int contractMoney,
                                    string strNotification)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //通知をint型にする
            int intNotification = otherFunc.NotificationToInt(strNotification);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Title", title),
                new SqlParameter("Detail", detail),
                new SqlParameter("Contract_StartDate", contractStartDate),
                new SqlParameter("Contract_EndDate", contractEndDate),
                new SqlParameter("Contract＿Money", contractMoney),
                new SqlParameter("Is_Notification", intNotification)
            };

            //SQL取得
            string sql = Constant.INSERT_CONTRACT_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// 契約情報一覧取得
        /// </summary>
        /// 2023/06/01
        public List<ContractData> GetAllContractList()
        {
            //SQL取得
            string sql = Constant.GET_CONTRACTS_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                using (DataTable dt = db.GetDt(sql))
                {
                    //契約リストに変換
                    List<ContractData> contractList = this.DtToContractList(dt);

                    return contractList;
                }
            }
        }


        /// <summary>
        /// データテーブルを契約リストに変換
        /// </summary>
        /// 2023/06/01
        private List<ContractData> DtToContractList(DataTable dt)
        {
            //リスト作成
            List<ContractData> contractList = new List<ContractData>();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //データテーブルの行数分繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                ContractData contractData = new ContractData();

                //設定
                //ID
                int.TryParse(row["Id"].ToString(), out int id);
                contractData.Id = id;
                //タイトル
                contractData.Title = row["Title"].ToString();
                //詳細
                contractData.Detail = row["Detail"].ToString();
                //契約開始日
                DateTime.TryParse(row["Contract_StartDate"].ToString(), out DateTime contractStartDate);
                contractData.ContractStartDate = contractStartDate;
                //契約終了日
                DateTime.TryParse(row["Contract_EndDate"].ToString(), out DateTime contractEndDate);
                contractData.ContractEndDate = contractEndDate;
                //契約金
                int.TryParse(row["Contract_Money"].ToString(), out int contractMoney);
                contractData.ContractMoney = contractMoney;
                //通知
                int.TryParse(row["Is_Notification"].ToString(), out int notification);
                contractData.Notification = otherFunc.NotificationToString(notification);

                //リストに追加
                contractList.Add(contractData);
            }

            return contractList;
        }


        /// <summary>
        /// 契約情報削除
        /// </summary>
        ///　2023/06/01
        public void DeleteContract(long deleteContractID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteContractID)
            };

            //SQL取得
            string sql = Constant.DELETE_CONTRACT_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }
    }
}
