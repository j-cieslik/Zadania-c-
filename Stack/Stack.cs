using System;
using System.Collections.Generic;

namespace Stack
{
  public class Stack
  {
    private readonly List<object> _stack;
    public Stack()
    {
      _stack = new List<object>();
    }

    public void Push(object obj)
    {
      if(obj != null)
        _stack.Add(obj);
      else
        throw new InvalidOperationException();
    }

    public object Pop()
    {
      if (_stack.Count == 0)
        throw new InvalidOperationException();

      var count = _stack.Count;
      var obj = _stack[count - 1];

      _stack.RemoveAt(count - 1);

      return obj;
    }

    public void Clear()
    {
      _stack.Clear();
    }
  }
}