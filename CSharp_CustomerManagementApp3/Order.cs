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
    public class Order
    {
        /// <summary>
        /// 注文情報登録
        /// </summary>
        ///　2023/06/02
        public void InsertOrder(string title,
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
            string sql = Constant.INSERT_ORDER_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// 注文情報一覧取得
        /// </summary>
        ///　2023/06/03
        public List<OrderData> GetAllOrderList()
        {
            //SQL取得
            string sql = Constant.GET_ORDERS_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                using (DataTable dt = db.GetDt(sql))
                {
                    //注文リストに変換
                    List<OrderData> orderList = this.DtToOrderList(dt);

                    return orderList;
                }
            }
        }


        /// <summary>
        /// データテーブルを注文リストに変換
        /// </summary>
        ///　2023/06/03
        private List<OrderData> DtToOrderList(DataTable dt)
        {
            //リスト作成
            List<OrderData> orderList = new List<OrderData>();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //データテーブルの行数分繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                OrderData orderData = new OrderData();

                //設定
                //ID
                int.TryParse(row["Id"].ToString(), out int id);
                orderData.Id = id;
                //タイトル
                orderData.Title = row["Title"].ToString();
                //詳細
                orderData.Detail = row["Detail"].ToString();
                //契約開始日
                DateTime.TryParse(row["Contract_StartDate"].ToString(), out DateTime contractStartDate);
                orderData.ContractStartDate = contractStartDate;
                //契約終了日
                DateTime.TryParse(row["Contract_EndDate"].ToString(), out DateTime contractEndDate);
                orderData.ContractEndDate = contractEndDate;
                //契約金
                int.TryParse(row["Contract_Money"].ToString(), out int contractMoney);
                orderData.ContractMoney = contractMoney;
                //通知
                int.TryParse(row["Is_Notification"].ToString(), out int notification);
                orderData.Notification = otherFunc.NotificationToString(notification);

                //リストに追加
                orderList.Add(orderData);
            }

            return orderList;
        }


        /// <summary>
        /// 注文情報削除
        /// </summary>
        ///　2023/06/04
        public void DeleteOrder(long deleteOrderID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteOrderID)
            };

            //SQL取得
            string sql = Constant.DELETE_ORDER_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }
    }
}
