using CSharp_CustomerManagementApp3.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3
{
    public class CommunicationHistory
    {
        /// <summary>
        /// コミュニケーション履歴登録
        /// </summary>
        ///　2023/05/28
        public void InsertCommunicationHistory(string title,
                                                string detail)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Title", title),
                new SqlParameter("Detail", detail)
            };

            //SQL取得
            string sql = Constant.INSERT_COMMUNICATIONHISTORY_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// コミュニケーション履歴一覧取得
        /// </summary>
        /// 2023/05/28
        public DataTable GetAllCommunicationHistories()
        {
            //SQL取得
            string sql = Constant.GET_COMMUNICATIONHISTORIES_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                return db.GetDt(sql);
            }
        }


        /// <summary>
        /// コミュニケーション履歴削除
        /// </summary>
        /// 2023/05/28
        public void DeleteCommunicationHistory(long deleteCommunicationHistoriesID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteCommunicationHistoriesID)
            };

            //SQL取得
            string sql = Constant.DELETE_COMMUNICATIONHISTORY_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }
    }
}
