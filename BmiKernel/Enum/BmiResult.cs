using System.ComponentModel;

namespace BmiKernel.Enum
{
    /// <summary>
    /// BMI結果狀態
    /// </summary>
    public enum BmiStatus
    {
        [Description("正常")]
        Normal,

        [Description("太胖")]
        Fat,

        [Description("太瘦")]
        Thin
    }
}
