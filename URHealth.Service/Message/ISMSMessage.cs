using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.Message
{
    interface ISMSMessage :IMessage
    {
        string MobileNo { get; set; }
    
    }
}
