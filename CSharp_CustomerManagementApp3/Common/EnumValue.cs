using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3.Common
{
    public class EnumValue
    {
        /// <summary>
        /// ロックされているかどうか?
        /// </summary>
        public enum IsLock
        {
            NotLock = 0,
            Locked = 1
        }


        /// <summary>
        /// ユーザ種類
        /// </summary>
        public enum UserType
        {
            Admin = 1,
            Normal = 2
        }


        /// <summary>
        /// 性別
        /// </summary>
        public enum Gender
        {
            Man = 1,
            Woman = 2
        }


        /// <summary>
        /// 通知
        /// </summary>
        public enum Notification
        {
            ON = 1,
            OFF = 2
        }
    }
}
