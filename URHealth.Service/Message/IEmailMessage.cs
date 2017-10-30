using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.Message
{
    interface IEmailMessage : IMessage
    {
        string ToAddress { get; set; }
        string CCAddress { get; set; }       
                
    }
}
