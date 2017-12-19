
using SuperFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtencionMethodsLesson
{
    public class Util
    {
        public static void CallAll(OperationService service)
        {
            service.Operation1();
            service.Operation2();
            service.Operation3();
        }
    }
}