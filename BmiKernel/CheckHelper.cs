using BmiKernel.Enum;
using BmiKernel.Interface;

namespace BmiKernel
{
    /// <summary>
    /// BMI檢查工具
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CheckHelper<T> where T : class, IBmiCheckable
    {
        /// <summary>
        /// 檢查對象
        /// </summary>
        private T _target;

        /// <summary>
        /// 檢查工具建構子
        /// </summary>
        /// <param name="target">檢查對象</param>
        public CheckHelper(T target)
        {
            _target = target;
        }

        /// <summary>
        /// BMI數值
        /// </summary>
        public double Value
        {
            get
            {
                return _target.GetBmiValue();
            }
        }

        /// <summary>
        /// BMI狀態
        /// </summary>
        public BmiStatus Result
        {
            get
            {
                if (Value > _target.GetNormalUpperLevel())
                {
                    return BmiStatus.Fat;
                }
                else if (Value < _target.GetNormalLowerLevel())
                {
                    return BmiStatus.Thin;
                }
                else
                {
                    return BmiStatus.Normal;
                }
            }
        }
    }
}
