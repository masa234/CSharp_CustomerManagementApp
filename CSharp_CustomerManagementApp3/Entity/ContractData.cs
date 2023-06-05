using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3.Entity
{
    public class ContractData
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// 詳細
        /// </summary>
        public string Detail { get; set; }


        /// <summary>
        /// 契約開始日
        /// </summary>
        public DateTime ContractStartDate { get; set; }


        /// <summary>
        /// 契約終了日
        /// </summary>
        public DateTime ContractEndDate { get; set; }


        /// <summary>
        /// 契約金
        /// </summary>
        public int ContractMoney { get; set; }


        /// <summary>
        /// 通知
        /// </summary>
        public string Notification { get; set; }
    }
}
