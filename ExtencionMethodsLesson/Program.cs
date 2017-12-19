using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFramework;

namespace ExtencionMethodsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationService service = new OperationService();
            Util.CallAll(service);
            service.DoAll();

        }
    }
}
