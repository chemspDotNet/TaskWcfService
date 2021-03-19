using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TaskWcfService;

namespace MyHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(TaskWcfService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host Started");
                Console.ReadLine();

            }
        }
    }
}
