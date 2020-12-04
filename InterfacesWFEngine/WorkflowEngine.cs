using System;
using System.Collections.Generic;

namespace InterfacesWFEngine
{
  public class WorkflowEngine
  {
    public void Run(IWorkFlow workFlow)
    {
      foreach (var task in workFlow.GetTasks())
      {
        try
        {
            task.Execute();
        }
        catch (Exception)
        {
            //Logging
            //Terminate and persist the state workflow
            throw;
        }
      }
        
    }
  }
}
