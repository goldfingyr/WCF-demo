using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCF_DemoService" in both code and config file together.
    [ServiceContract]
    public interface IWCF_DemoService
    {
        [OperationContract]
        string GetHeader();

        [OperationContract]
        int CsAdd(int a, int b);
    }
}
