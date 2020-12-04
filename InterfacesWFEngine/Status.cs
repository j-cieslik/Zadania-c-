using System;

namespace InterfacesWFEngine
{
  public class Status : ITask
  {
    public void Execute()
    {
      Console.WriteLine("Status is changed to Processing...");
    }
  }
}
