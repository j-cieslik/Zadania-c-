using System;

namespace InterfacesWFEngine
{
  public class VideoUpload : ITask
  {
    public void Execute()
    {
      Console.WriteLine("Upload a video to a cloud storage");
    }
  }
}
