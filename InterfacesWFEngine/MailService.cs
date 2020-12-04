using System;

namespace InterfacesWFEngine
{
  public class MailService : ITask
  {
    public void Execute()
    {
      Console.WriteLine("Sending an email...");
    }
  }
}
