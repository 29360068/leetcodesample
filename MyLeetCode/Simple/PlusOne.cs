using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：66. 加一
    /// 难度：简单
    /// 描述：给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
    /// </summary>
    public class PlusOne
    {
        public int[] Excution1(int[] digits)
        {
            return PlusOnePrivate(digits, digits.Length - 1);
        }

        private int [] PlusOnePrivate(int[] digits, int index)
        {
            var sumResult = digits[index] + 1;
            if (sumResult < 10)
            {
                digits[index] = sumResult;
                return digits;
            }
            else
            {
                digits[index] = 0;

                if(index == 0)
                {
                    var newResult = new int[digits.Length + 1];
                    newResult[0] = 1;
                    return newResult;
                }
                else
                {
                    return PlusOnePrivate(digits, --index);
                }
            }
        }
    }
}
