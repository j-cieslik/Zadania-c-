using System;

namespace Generics
{

  // where T : IComparable
  // where T : Product <-- T has to be a given type, or subclasses
  // where T : struct <-- T has to be a value type
  // where T : class <-- T has to be a reference type
  // where T : new() <-- for default ctor
  public class Utilitiesv2<T> where T : IComparable, new() //<-- have a constrain to default ctor
  {
    public int Max(int a, int b)
    {
      return a > b ? a : b;
    }

    public void DoSomething(T value)
    {
        var obj = new T();
    }

    public T Max(T a, T b)
    {
      return a.CompareTo(b) > 0 ? a : b;
    }
  }
}