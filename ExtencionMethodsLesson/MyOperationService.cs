
using SuperFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtencionMethodsLesson
{
    public class MyOperationService
    {
        OperationService service;
        public MyOperationService()
        {
           service = new OperationService();
        }
        public void DoAll()
        {
            service.Operation1();
            service.Operation2();
            service.Operation3();
        }
    }
}