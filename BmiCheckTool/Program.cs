using System;
using BmiCheckTool.Entity;
using BmiCheckTool.Enum;
using BmiKernel;
using BmiKernel.Enum;

namespace BmiCheckTool
{
    class Program
    {
        static void Main(string[] args)
        {
            #region step 1. 建立BMI檢查對象

            PersonBase person;

            Console.WriteLine("請輸入性別 Male / Female ( M / F )：");
            Gender gender = GetGender(Console.ReadKey().KeyChar);
            person = PersonBase.CreateInstance(gender);

            Console.WriteLine("請輸入身高 （公尺）：");
            person.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("請輸入體重 （公斤）：");
            person.Weight = double.Parse(Console.ReadLine());

            #endregion

            #region step 2. 取得檢查結果

            CheckHelper<PersonBase> helper = new CheckHelper<PersonBase>(person);
            Console.WriteLine("檢查結果： BMI數值： {0:F2}， 狀態： {1}", helper.Value, helper.Result.ToTwString());

            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// 取得性別
        /// </summary>
        /// <param name="c">輸入字元</param>
        /// <returns>性別</returns>
        private static Gender GetGender(char c)
        {
            switch (char.ToLower(c))
            {
                case 'f':
                    return Gender.Female;

                case 'm':
                    return Gender.Male;

                default:
                    return default(Gender);
            }
        }
    }
}
