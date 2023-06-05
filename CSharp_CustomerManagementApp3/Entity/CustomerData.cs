using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3.Entity
{
    public class CustomerData
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 顧客氏名
        /// </summary>
        public string CustomerName { get; set; }


        /// <summary>
        /// 年齢
        /// </summary>
        public int Age { get; set; }


        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; set; }


        /// <summary>
        /// 会社名
        /// </summary>
        public string CompanyName { get; set; }


        /// <summary>
        /// 部署名
        /// </summary>
        public string DeptName { get; set; }


        /// <summary>
        /// メールアドレス
        /// </summary>
        public string MailAddress { get; set; }


        /// <summary>
        /// 備考
        /// </summary>
        public string Remarks { get; set; }
    }
}
