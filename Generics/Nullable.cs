namespace Generics
{
  public class Nullable<T> where T : struct   //T has to be a value type
  {
    public Nullable()
    {
    }

    private object _value;
    public Nullable(T value)
    {
        _value = value;
    }

    public bool HasValue
    {
      get {return _value != null; }  // return true or false
    }

    public T GetValueOrDefault()
    {
      if (HasValue)
        return (T)_value;

      return default(T);
    }
  }
}