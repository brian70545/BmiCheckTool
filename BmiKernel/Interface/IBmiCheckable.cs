namespace BmiKernel.Interface
{
    /// <summary>
    /// BMI檢查介面
    /// </summary>
    public interface IBmiCheckable
    {
        /// <summary>
        /// 取得BMI正常上限值
        /// </summary>
        /// <returns></returns>
        double GetNormalUpperLevel();

        /// <summary>
        /// 取得BMI正常下限值
        /// </summary>
        /// <returns></returns>
        double GetNormalLowerLevel();

        /// <summary>
        /// 取得BMI數值
        /// </summary>
        /// <returns></returns>
        double GetBmiValue();
    }
}
