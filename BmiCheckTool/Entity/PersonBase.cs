using System;
using BmiCheckTool.Enum;
using BmiKernel.Interface;

namespace BmiCheckTool.Entity
{
    /// <summary>
    /// 人類基底
    /// </summary>
    public abstract class PersonBase : IBmiCheckable
    {
        #region Class member
        
        /// <summary>
        /// BMI正常數值上限
        /// </summary>
        protected double _upperLevel = 0;

        /// <summary>
        /// BMI正常數值下限
        /// </summary>
        protected double _lowerLevel = 0;

        #endregion

        #region Property

        /// <summary>
        /// 身高
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// 體重
        /// </summary>
        public double Weight { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// 取得BMI正常上限值
        /// </summary>
        /// <returns></returns>
        public double GetNormalUpperLevel()
        {
            return _upperLevel;
        }

        /// <summary>
        /// 取得BMI正常下限值
        /// </summary>
        /// <returns></returns>
        public double GetNormalLowerLevel()
        {
            return _lowerLevel;
        }

        /// <summary>
        /// 取得BMI數值
        /// </summary>
        /// <returns></returns>
        public virtual double GetBmiValue()
        {
            return Weight / Math.Pow(Height, 2);
        }

        /// <summary>
        /// 建立人類個體
        /// </summary>
        /// <param name="gender">性別</param>
        /// <returns>人類個體</returns>
        public static PersonBase CreateInstance(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:
                    return new MalePerson();

                case Gender.Female:
                    return new FemalePerson();

                default:
                    return default(PersonBase);
            }
        }

        #endregion
    }
}
