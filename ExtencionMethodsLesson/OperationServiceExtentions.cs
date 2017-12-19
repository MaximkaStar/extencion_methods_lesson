using SuperFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtencionMethodsLesson
{
    public static class OperationServiceExtentions
    {
        public static void DoAll(this OperationService service)
        {
            service.Operation1();
            service.Operation2();
            service.Operation3();
        }
    }
}