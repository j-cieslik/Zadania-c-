using System;

namespace InterfacesWFEngine
{
  public class WebServiceCall : ITask
  {
    public void Execute()
    {
      Console.WriteLine("Video is ready to encode...");
    }
  }
}
