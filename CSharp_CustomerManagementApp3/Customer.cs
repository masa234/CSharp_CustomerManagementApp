using CSharp_CustomerManagementApp3.Common;
using CSharp_CustomerManagementApp3.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CustomerManagementApp3
{
    public class Customer
    {
        /// <summary>
        /// 顧客情報登録
        /// </summary>
        ///　2023/05/17
        public void InsertCustomer(string customerName,
                                    int age,
                                    string strGender,
                                    string companyName,
                                    string deptName,
                                    string mailAddress,
                                    string remarks)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //性別をint型にする
            int intGender = otherFunc.GenderToInt(strGender);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("CustomerName", customerName),
                new SqlParameter("Age", age),
                new SqlParameter("Gender", intGender),
                new SqlParameter("CompanyName", companyName),
                new SqlParameter("DeptName", deptName),
                new SqlParameter("MailAddress", mailAddress),
                new SqlParameter("Remarks", remarks)
            };

            //SQL取得
            string sql = Constant.INSERT_CUSTOMER_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// 顧客情報一覧取得
        /// </summary>
        ///　2023/05/24
        public List<CustomerData> GetAllCustomerList()
        {
            //SQL取得
            string sql = Constant.GET_CUSTOMERS_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                using (DataTable dt = db.GetDt(sql))
                {
                    //顧客リストに変換
                    List<CustomerData> customerList = this.DtToCustomerList(dt);

                    return customerList;
                }
            }
        }


        /// <summary>
        /// データテーブルを顧客リストに変換
        /// </summary>
        ///　2023/05/24
        public List<CustomerData> DtToCustomerList(DataTable dt)
        {
            //リスト作成
            List<CustomerData> customerList = new List<CustomerData>();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //データテーブルの行数分繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                CustomerData customerData = new CustomerData();

                //設定
                //ID
                int.TryParse(row["Id"].ToString(), out int id);
                customerData.Id = id;
                //顧客氏名
                customerData.CustomerName = row["CustomerName"].ToString();
                //年齢
                int.TryParse(row["Age"].ToString(), out int age);
                customerData.Age = age;
                //性別
                int.TryParse(row["Gender"].ToString(), out int gender);
                customerData.Gender = otherFunc.GenderToString(gender);
                //会社名
                customerData.CompanyName = row["CompanyName"].ToString();
                //部署名
                customerData.DeptName = row["DeptName"].ToString();
                //メールアドレス
                customerData.MailAddress = row["MailAddress"].ToString();
                //備考
                customerData.Remarks = row["Remarks"].ToString();

                //リストに追加
                customerList.Add(customerData);
            }

            return customerList;
        }


        /// <summary>
        /// 顧客情報削除
        /// </summary>
        ///　2023/05/25
        public void DeleteCustomer(long deleteCustomerID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteCustomerID)
            };

            //SQL取得
            string sql = Constant.DELETE_CUSTOMER_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// 顧客情報取得
        /// </summary>
        ///　2023/05/25
        public CustomerData GetCustomer(long customerID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", customerID)
            };

            //SQL取得
            string sql = Constant.GET_CUSTOMER_SQL;

            //インスタンス化
            CustomerData customerData = new CustomerData();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(リーダー)を取
                using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
                {
                    //読み込める間、繰り返す
                    while (reader.Read())
                    {
                        //設定
                        //ID
                        int.TryParse(reader[0].ToString(), out int id);
                        customerData.Id = id;
                        //顧客氏名
                        customerData.CustomerName = reader[1].ToString();
                        //年齢
                        int.TryParse(reader[2].ToString(), out int age);
                        customerData.Age = age;
                        //性別
                        int.TryParse(reader[3].ToString(), out int gender);
                        customerData.Gender = otherFunc.GenderToString(gender);
                        //会社名
                        customerData.CompanyName = reader[4].ToString();
                        //部署名
                        customerData.DeptName = reader[5].ToString();
                        //メールアドレス
                        customerData.MailAddress = reader[6].ToString();
                        //備考
                        customerData.Remarks = reader[7].ToString();

                        return customerData;
                    }
                }
            }

            return customerData;
        }


        /// <summary>
        /// 顧客情報更新
        /// </summary>
        ///　2023/05/25
        public void UpdateCustomer(string customerName,
                                    int age,
                                    string strGender,
                                    string companyName,
                                    string deptName,
                                    string mailAddress,
                                    string remarks,
                                    long updateCustomerID)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //性別をint型にする
            int intGender = otherFunc.GenderToInt(strGender);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("CustomerName", customerName),
                new SqlParameter("Age", age),
                new SqlParameter("Gender", intGender),
                new SqlParameter("CompanyName", companyName),
                new SqlParameter("DeptName", deptName),
                new SqlParameter("MailAddress", mailAddress),
                new SqlParameter("Remarks", remarks),
                new SqlParameter("Id", updateCustomerID)
            };

            //SQL取得
            string sql = Constant.INSERT_CUSTOMER_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //SQL実行
                db.ExecuteNonQuery(sql, paramList);
            }
        }


        /// <summary>
        /// 検索結果(件数)を取得
        /// </summary>
        ///　2023/06/04
        public long GetSearchCount(string searchCustomerName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("CustomerName", searchCustomerName)
            };

            //SQL取得
            string sql = Constant.GET_CUSTOMER_SEARCH_COUNT_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(件数)を取得
                return db.ExecuteScalar(sql, paramList);
            }
        }


        /// <summary>
        /// 検索結果を取得
        /// </summary>
        ///　2023/06/04
        public List<CustomerData> FilterCustomerList(string searchCustomerName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("CustomerName", searchCustomerName)
            };

            //SQL取得
            string sql = Constant.GET_SEARCH_CUSTOMER_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                using (DataTable dt = db.GetDt(sql, paramList))
                {
                    //顧客リストに変換
                    List<CustomerData> customerList = this.DtToCustomerList(dt);

                    return customerList;
                }
            }
        }


        /// <summary>
        /// CSV出力
        /// </summary>
        ///　2023/06/05
        public void OutputCSV(List<CustomerData> customerList,
                                string outputCSVPath)
        {
            //文字列のリストに変換
            List<string> outputList = this.CustomerListToStringList(customerList);

            //区切り文字で区切る
            String.Join(",", outputList);

            //出力
            File.WriteAllLines(outputCSVPath, outputList);
        }


        /// <summary>
        /// 顧客リストを文字列のリストに変換
        /// </summary>
        ///　2023/06/05
        private List<string> CustomerListToStringList(List<CustomerData> customerList)
        {
            //取得
            return customerList
                    .Select(
                        x => x.CustomerName)
                    .ToList();
        }


        /// <summary>
        /// ソート済み顧客リストを取得
        /// </summary>
        ///　2023/06/04
        public List<CustomerData> GetSortedCustomerList()
        {
            //SQL取得
            string sql = Constant.GET_SORTEDCUSTOMERS_SQL;

            //インスタンス化
            using (DB db = new DB())
            {
                //実行結果(データ)を取得
                using (DataTable dt = db.GetDt(sql))
                {
                    //顧客リストに変換
                    List<CustomerData> customerList = this.DtToCustomerList(dt);

                    return customerList;
                }
            }
        }
    }
}
