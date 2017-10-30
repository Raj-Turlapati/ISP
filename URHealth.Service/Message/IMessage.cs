using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.Message
{
    public interface IMessage
    {
        string MsgBody { get; set; }
        string Subject { get; set; }
        bool Send();
    }

}
