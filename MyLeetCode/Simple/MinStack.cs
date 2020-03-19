using System.Collections.Generic;

namespace MyLeetCode.Simple
{
    /// <summary>
    /// 序号：155. 最小栈
    /// 难度：简单
    /// 描述：设计一个支持 push，pop，top 操作，并能在常数时间内检索到最小元素的栈。
    /// </summary>
    public class MinStack
    {
        private readonly Stack<int> _stack = new Stack<int>();
        private readonly Stack<int> _min = new Stack<int>();

        public MinStack() {
        }
    
        public void Push(int x)
        {
            _stack.Push(x);

            if (_min.Count == 0 || _min.Peek() >= x)
            {
                _min.Push(x);
            }
        }
    
        public void Pop()
        {
            var val = _stack.Pop();
            if (_min.Peek() == val)
            {
                _min.Pop();
            }
        }
    
        public int Top()
        {
            return _stack.Peek();
        }
    
        public int GetMin()
        {
            return _min.Peek();
        }
    }
}
