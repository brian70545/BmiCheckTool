using System.ComponentModel;

namespace BmiKernel.Enum
{
    public static class BmiResultExtension
    {
        /// <summary>
        /// 轉換成BMI狀態的中文表示
        /// </summary>
        /// <param name="result">BMI狀態</param>
        /// <returns>BMI狀態的中文字串</returns>
        public static string ToTwString(this BmiStatus result)
        {
            var attribute = result.GetAttributeOfType<DescriptionAttribute, BmiStatus>();
            return (attribute == default(DescriptionAttribute)) ? result.ToString() : attribute.Description;
        }


        /// <summary>
        /// 取得某類型的特定屬性資訊，如該類型沒有該屬性，則回傳預設值
        /// </summary>
        /// <typeparam name="Tattr">屬性類型</typeparam>
        /// <typeparam name="Uclass">查詢類別</typeparam>
        /// <param name="target">查詢類別的物件</param>
        /// <returns>屬性類型物件</returns>
        private static Tattr GetAttributeOfType<Tattr, Uclass>(this Uclass target) where Tattr : System.Attribute
        {
            var type = target.GetType();
            var memInfo = type.GetMember(target.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(Tattr), false);
            return (attributes.Length > 0) ? (Tattr)attributes[0] : default(Tattr);
        }
    }
}
