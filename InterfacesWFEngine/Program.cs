using System;

namespace InterfacesWFEngine
{
  class Program
  {
    static void Main(string[] args)
    {
      var workflow = new Workflow();

      workflow.Add(new VideoUpload());
      workflow.Add(new WebServiceCall());
      workflow.Add(new MailService());
      workflow.Add(new Status());

        var engine = new WorkflowEngine();
        engine.Run(workflow);
    }
  }
}
