using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCF_DemoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCF-DemoService.svc or WCF-DemoService.svc.cs at the Solution Explorer and start debugging.
    public class WCF_DemoService : IWCF_DemoService
    {
        public int CsAdd(int a, int b)
        {
            return a + b;
        }

        public string GetHeader()
        {
            return "Calculator Service";
        }
    }
}
