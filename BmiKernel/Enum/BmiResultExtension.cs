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
            switch(result)
            {
                case BmiStatus.Normal:
                    return "正常";

                case BmiStatus.Fat:
                    return "太胖";

                case BmiStatus.Thin:
                    return "太瘦";

                default:
                    return string.Empty;
            }
        }
    }
}
