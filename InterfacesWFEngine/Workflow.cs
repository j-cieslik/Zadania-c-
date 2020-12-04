using System.Collections.Generic;

namespace InterfacesWFEngine
{
  public class Workflow : IWorkFlow
  {
    private readonly List<ITask> _tasks;
    public Workflow()
    {
      _tasks = new List<ITask>();
    }

    public void Add(ITask task)
    {
      _tasks.Add(task);
    }

    public void Remove(ITask task)
    {
      _tasks.Add(task);
    }

    public IEnumerable<ITask> GetTasks()
    {
      return _tasks;
    }
  }
}

