using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3.Common
{
    public class Constant
    {
        /// <summary>
        /// バリデーションメッセージ
        /// </summary>
        public const string INVALID_LENGTH = "{0}は1～{1}文字で指定してください。";
        public const string MUST_INPUT = "{0}は必須です。";
        public const string MUST_IN_CMB = "{0}はコンボボックスから選択してください。";
        /// <summary>
        /// 失敗メッセージ
        /// </summary>
        public const string FAILED = "{0}に失敗しました。";
        /// <summary>
        /// 成功メッセージ
        /// </summary>
        public const string SUCCESS = "{0}に成功しました。";
        /// <summary>
        /// アイテム
        /// </summary>
        public const string ITEM_USERNAME = "ユーザ名";
        public const string ITEM_PASSWORD = "パスワード";
        public const string ITEM_CUSTOMERNAME = "顧客氏名";
        public const string ITEM_GENDER = "性別";
        public const string ITEM_COMPANYNAME = "会社名";
        public const string ITEM_DEPTNAME = "部署名";
        public const string ITEM_MAILADDRESS = "メールアドレス";
        public const string ITEM_REMARKS = "備考";
        public const string ITEM_TITLE = "タイトル";
        public const string ITEM_DETAIL = "詳細";
        public const string ITEM_CONTRACT_STARTDATE = "契約開始日";
        public const string ITEM_CONTRACT_ENDDATE = "契約終了日";
        public const string ITEM_NOTIFICATION = "通知ON,OFF";
        public const string LOGIN = "ログイン";
        public const string INSERT_CUSTOMER = "顧客情報登録";
        public const string UPDATE_CUSTOMER = "顧客情報更新";
        public const string INSERT_COMMUNICATIONHISTORY = "コミュニケーション履歴登録";
        public const string INSERT_CONTRACT = "契約情報登録";
        public const string INSERT_ORDER = "注文情報登録";
        public const string OUTPUT_CSV = "CSV出力";
        /// <summary>
        /// 最大文字数
        /// </summary>
        public const long USERNAME_MAX_LENGTH = 255;
        public const long PASSWORD_MAX_LENGTH = 255;
        public const long CUSTOMERNAME_MAX_LENGTH = 255;
        public const long COMPANYNAME_MAX_LENGTH = 255;
        public const long DEPTNAME_MAX_LENGTH = 255;
        public const long MAILADDRESS_MAX_LENGTH = 255;
        public const long REMARKS_MAX_LENGTH = 255;
        public const long TITLE_MAX_LENGTH = 255;
        public const long DETAIL_MAX_LENGTH = 255;
        /// <summary>
        /// 接続文字列
        /// </summary>
        public const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDB5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /// <summary>
        /// メッセージタイトル
        /// </summary>
        public const string CONFIRM = "警告";
        /// <summary>
        /// その他
        /// </summary>
        public const int LOCK_COUNT = 3;
        public const string USER_IS_LOCK = "アカウントがロックされました。管理者に問い合わせてください。";
        public const string USER_IS_LOCKED = "アカウントがロックされています。管理者に問い合わせてください。";
        public const string OUTPUT_CSV_PATH = "\"C:\\Users\\bfmt1\\OneDrive\\デスクトップ\"";
        /// <summary>
        /// ユーザ情報SQL
        /// </summary>
        public const string GET_USER_COUNT_SQL = "SELECT " +
                                               "    COUNT(*)" +
                                               "  FROM" +
                                               "    Users " +
                                               "  WHERE " +
                                               "    UserName = @UserName " +
                                               "  AND" +
                                               "    Password = @Password";
        public const string GET_USERID_SQL = "SELECT " +
                                            "   Id " +
                                            " FROM " +
                                            "   Users " +
                                            " WHERE " +
                                            "   UserName = @UserName " +
                                            " AND" +
                                            "   Password = @Password";
        public const string GET_USERNAME_COUNT_SQL = "SELECT " +
                                                    "   COUNT(*) " +
                                                    " FROM " +
                                                    "   Users " +
                                                    " WHERE " +
                                                    "   UserName = @UserName ";
        public const string GET_LOCKFLAG_SQL = "SELECT " +
                                            "     LockFlag " +
                                            "   FROM " +
                                            "     Users " +
                                            "   WHERE " +
                                            "     UserName = @UserName ";
        public const string GET_LOCKED_USERS_SQL = "SELECT " +
                                                "     Id, " +
                                                "     UserName, " +
                                                "     Password " +
                                                "   FROM " +
                                                "     Users " +
                                                "   WHERE " +
                                                "     LockFlag = @LockFlag " +
                                                "   ORDER BY " +
                                                "     Id ASC ";
        public const string GET_ADMIN_SQL = " SELECT " +
                                            "   Admin " +
                                            " FROM " +
                                            "   Users " +
                                            " WHERE " +
                                            "   Id = @Id ";
        public const string UPDATE_LOCKFLAG_SQL = "UPDATE " +
                                                "    Users " +
                                                "  SET " +
                                                "    LockFlag = @LockFlag " +
                                                "  WHERE " +
                                                "    UserName = @UserName";
        /// <summary>
        /// 顧客情報SQL
        /// </summary>
        public const string GET_CUSTOMERS_SQL = "SELECT " +
                                            "      Id, " +
                                            "      CustomerName, " +
                                            "      Age, " +
                                            "      Gender, " +
                                            "      CompanyName, " +
                                            "      DeptName, " +
                                            "      MailAddress, " +
                                            "      Remarks " +
                                            "    FROM " +
                                            "      Customers ";
        public const string GET_CUSTOMER_SQL = "SELECT " +
                                            "     Id, " +
                                            "     CustomerName, " +
                                            "     Age, " +
                                            "     Gender, " +
                                            "     CompanyName, " +
                                            "     DeptName, " +
                                            "     MailAddress, " +
                                            "     Remarks " +
                                            "   FROM " +
                                            "     Customers " +
                                            "   WHERE " +
                                            "     Id = @Id ";
        public const string GET_CUSTOMER_SEARCH_COUNT_SQL = "  SELECT " +
                                                            "    COUNT(*) " +
                                                            "  FROM " +
                                                            "    Customers " +
                                                            "  WHERE " +
                                                            "    CustomerName Like @CustomerName ";
        public const string GET_SEARCH_CUSTOMER_SQL = "   SELECT " +
                                                        "   Id, " +
                                                        "   CustomerName, " +
                                                        "   Age, " +
                                                        "   Gender, " +
                                                        "   CompanyName, " +
                                                        "   DeptName, " +
                                                        "   MailAddress, " +
                                                        "   Remarks " +
                                                        " FROM " +
                                                        "   Customers " +
                                                        " WHERE " +
                                                        "  CustomerName Like @CustomerName ";
        public const string GET_SORTEDCUSTOMERS_SQL = "SELECT " +
                                                "        Id, " +
                                                "        CustomerName, " +
                                                "        Age, " +
                                                "        Gender, " +
                                                "        CompanyName, " +
                                                "        DeptName, " +
                                                "        MailAddress, " +
                                                "        Remarks " +
                                                "      FROM " +
                                                "        Customers " +
                                                "      ORDER BY Age ASC ";
        public const string INSERT_CUSTOMER_SQL = "INSERT " +
                                                "    INTO " +
                                                "  Customers " +
                                                "    (CustomerName, " +
                                                "    Age, " +
                                                "    Gender, " +
                                                "    CompanyName, " +
                                                "    DeptName, " +
                                                "    MailAddress, " +
                                                "    Remarks) " +
                                                "  VALUES" +
                                                "    (@CustomerName, " +
                                                "    @Age, " +
                                                "    @Gender, " +
                                                "    @CompanyName, " +
                                                "    @DeptName, " +
                                                "    @MailAddress, " +
                                                "    @Remarks) ";
        public const string UPDATE_CUSTOMER_SQL = "UPDATE " +
                                                "   Customers " +
                                                " SET " +
                                                "   CustomerName = @CustomerName, " +
                                                "   Age = @Age, " +
                                                "   Gender = @Gender, " +
                                                "   CompanyName = @CompanyName, " +
                                                "   DeptName = @DeptName, " +
                                                "   MailAddress = @MailAddress, " +
                                                "   Remarks = @Remarks " +
                                                " WHERE " +
                                                "   Id = @Id ";
        public const string DELETE_CUSTOMER_SQL = "DELETE " +
                                                 " FROM " +
                                                 "   Customers " +
                                                 " WHERE " +
                                                 "   Id = @Id ";
        /// <summary>
        /// コミュニケーション履歴SQL
        /// </summary>
        public const string GET_COMMUNICATIONHISTORIES_SQL = "SELECT " +
                                                            "   Id, " +
                                                            "   Title, " +
                                                            "   Detail " +
                                                            " FROM " +
                                                            "   CommunicationHistories ";
        public const string INSERT_COMMUNICATIONHISTORY_SQL = "   INSERT " +
                                                                "   INTO " +
                                                                " CommunicationHistories " +
                                                                "   (Title, " +
                                                                "   Detail) " +
                                                                " VALUES" +
                                                                "   (@Title, " +
                                                                "   @Detail) ";
        public const string DELETE_COMMUNICATIONHISTORY_SQL = "DELETE " +
                                                            "  FROM " +
                                                            "    CommunicationHistories " +
                                                            "  WHERE " +
                                                            "    Id = @Id ";
        /// <summary>
        /// 契約情報SQL
        /// </summary>
        public const string GET_CONTRACTS_SQL = "SELECT " +
                                            "      Id, " +
                                            "      Title, " +
                                            "      Detail, " +
                                            "      Contract_StartDate, " +
                                            "      Contract_EndDate, " +
                                            "      Contract＿Money, " +
                                            "      Is_Notification " +
                                            "    FROM " +
                                            "      Contract ";
        public const string INSERT_CONTRACT_SQL = "INSERT " +
                                                "    INTO " +
                                                "  Contract " +
                                                "    (Title, " +
                                                "    Detail , " +
                                                "    Contract_StartDate, " +
                                                "    Contract_EndDate, " +
                                                "    Contract＿Money, " +
                                                "    Is_Notification) " +
                                                "  VALUES" +
                                                "    (@Title, " +
                                                "    @Detail, " +
                                                "    @Contract_StartDate, " +
                                                "    @Contract_EndDate, " +
                                                "    @Contract＿Money, " +
                                                "    @Is_Notification) ";
        public const string DELETE_CONTRACT_SQL = "DELETE " +
                                                "  FROM " +
                                                "    Contract " +
                                                "  WHERE " +
                                                "    Id = @Id ";
        /// <summary>
        /// 注文情報SQL
        /// </summary>
        public const string GET_ORDERS_SQL = "SELECT " +
                                        "      Id, " +
                                        "      Title, " +
                                        "      Detail, " +
                                        "      Contract_StartDate, " +
                                        "      Contract_EndDate, " +
                                        "      Contract＿Money, " +
                                        "      Is_Notification " +
                                        "    FROM " +
                                        "      Orders ";
        public const string INSERT_ORDER_SQL = "INSERT " +
                                            "     INTO " +
                                            "   Orders " +
                                            "     (Title, " +
                                            "     Detail , " +
                                            "     Contract_StartDate, " +
                                            "     Contract_EndDate, " +
                                            "     Contract＿Money, " +
                                            "     Is_Notification) " +
                                            "   VALUES" +
                                            "     (@Title, " +
                                            "     @Detail, " +
                                            "     @Contract_StartDate, " +
                                            "     @Contract_EndDate, " +
                                            "     @Contract＿Money, " +
                                            "     @Is_Notification) ";
        public const string DELETE_ORDER_SQL = "DELETE " +
                                            "   FROM " +
                                            "     Orders " +
                                            "   WHERE " +
                                            "     Id = @Id ";
    }
}
