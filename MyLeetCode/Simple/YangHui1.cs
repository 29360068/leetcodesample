using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：118. 杨辉三角
    /// 难度：简单
    /// 描述：给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。
    /// </summary>
    public class YangHui1
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();

            if (numRows >= 1)
            {
                list.Add(new List<int> {1});
                if (numRows >= 2)
                {
                    list.Add(new List<int> {1, 1});

                    if (numRows >= 3)
                    {
                        for (int i = 3; i <= numRows; i++)
                        {
                            GeneratePrivate(list, i);
                        }
                    }
                }
            }

            return list;
        }

        private void GeneratePrivate(IList<IList<int>> list, int level)
        {
            var levelPre = list[level - 2];
            var levelList = new List<int>(level) {1};

            for (int i = 1; i < level - 1; i++)
            {
                levelList.Add(levelPre[i] + levelPre[i - 1]);
            }

            levelList.Add(1);

            list.Add(levelList);
        }
    }
}
