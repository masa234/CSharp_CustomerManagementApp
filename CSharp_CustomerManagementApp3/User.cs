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
    public class User
    {
        /// <summary>
        /// ユーザが存在するかどうか?
        /// </summary>
        ///　2023/05/22
        public bool IsExistsUser(string userName,
                                string password)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password)
            };

            //SQL取得
            string sql = Constant.GET_USER_COUNT_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(件数)を取得
                long userCount = db.ExecuteScalar(sql, paramList);

                //件数が1件以上かどうか?       
                return 1 <= userCount;
            }
        }


        /// <summary>
        /// ユーザが存在するかどうか?
        /// </summary>
        ///　2023/05/22
        public long GetUserID(string userName,
                                string password)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password)
            };

            //SQL取得
            string sql = Constant.GET_USERID_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(リーダー)を取得
                using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
                {
                    //読み込める間、繰り返す
                    while (reader.Read())
                    {
                        //long型に変換 
                        long.TryParse(reader[0].ToString(), out long result);

                        return result;
                    }
                }
            }

            return 0;
        }


        /// <summary>
        /// ユーザ名が存在するかどうか?
        /// </summary>
        /// 2023/05/22
        public bool IsExistsUserName(string userName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName)
            };

            //SQL取得
            string sql = Constant.GET_USERNAME_COUNT_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(件数)を取得
                long userCount =  db.ExecuteScalar(sql, paramList);

                //件数が1件以上かどうか?
                return 1 <= userCount;
            }
        }


        /// <summary>
        /// ロックされているユーザ名かどうか?
        /// </summary>
        /// 2023/05/22
        public bool IsLockedUserName(string userName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName)
            };

            //SQL取得
            string sql = Constant.GET_LOCKFLAG_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(リーダー)を取得
                using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
                {
                    //読み込める間、繰り返す
                    while (reader.Read())
                    {
                        //int型に変換
                        int.TryParse(reader[0].ToString(), out int result);

                        //ロックされているかどうか?
                        if (result == (int)EnumValue.IsLock.Locked)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// ロック状態を更新
        /// </summary>
        /// 2023/05/22
        public void UpdateLock(string userName,
                                long updateIsLock)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("LockFlag", updateIsLock),
                new SqlParameter("UserName", userName)
            };

            //SQL取得
            string sql = Constant.UPDATE_LOCKFLAG_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// 管理者かどうか?
        /// </summary>
        /// 2023/05/22
        public bool IsAdmin(long userID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", userID)
            };

            //SQL取得
            string sql = Constant.GET_ADMIN_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(リーダー)を取得
                using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
                {
                    //読み込める間、繰り返す
                    while (reader.Read())
                    {
                        //int型に変換
                        int.TryParse(reader[0].ToString(), out int result);

                        //管理者かどうか?
                        return result == (int)EnumValue.UserType.Admin;
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// ロックされているユーザ一覧を取得
        /// </summary>
        /// 2023/05/22
        public DataTable GetAllLockedUsers()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("LockFlag", EnumValue.IsLock.Locked)
            };

            //SQL取得
            string sql = Constant.GET_LOCKED_USERS_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                return db.GetDt(sql, paramList);
            }
        }
    }
}
