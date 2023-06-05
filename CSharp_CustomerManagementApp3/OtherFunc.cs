using CSharp_CustomerManagementApp3.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CustomerManagementApp3
{
    public class OtherFunc
    {
        /// <summary>
        /// 性別のリストを取得
        /// </summary>
        /// 2023/05/24
        public List<string> GetGenderList()
        {
            //リストを取得
            return new List<string>()
            {
                "男",
                "女"
            };
        }


        /// <summary>
        /// 性別をint型に変換
        /// </summary>
        /// 2023/05/24
        public int GenderToInt(string strGender)
        {
            //値によって分岐
            switch (strGender)
            {
                case "男":
                    return (int)EnumValue.Gender.Man;
                case "女":
                    return (int)EnumValue.Gender.Woman;
            }

            return 0;
        }


        /// <summary>
        /// 性別をString型に変換
        /// </summary>
        /// 2023/05/24
        public string GenderToString(int intGender)
        {
            //値によって分岐
            switch (intGender)
            {
                case (int)EnumValue.Gender.Man:
                    return "男";
                case (int)EnumValue.Gender.Woman:
                    return "女";
            }

            return string.Empty;
        }


        /// <summary>
        /// 通知のリストを取得
        /// </summary>
        /// 2023/05/28
        public List<string> GetNotificationList()
        {
            //リストを取得
            return new List<string>()
            {
                "ON",
                "OFF"
            };
        }


        /// <summary>
        /// 通知をint型に変換
        /// </summary>
        /// 2023/05/28
        public int NotificationToInt(string strNotification)
        {
            //値によって分岐
            switch (strNotification)
            {
                case "ON":
                    return (int)EnumValue.Notification.ON;
                case "OFF":
                    return (int)EnumValue.Notification.OFF;
            }

            return 0;
        }


        /// <summary>
        /// 通知をString型に変換
        /// </summary>
        /// 2023/05/28
        public string NotificationToString(int intNotification)
        {
            //値によって分岐
            switch (intNotification)
            {
                case (int)EnumValue.Notification.ON:
                    return "ON";
                case (int)EnumValue.Notification.OFF:
                    return "OFF";
            }

            return string.Empty;
        }
    }
}
