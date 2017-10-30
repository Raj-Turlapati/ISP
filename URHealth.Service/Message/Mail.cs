using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.Message
{
    public class Mail : IEmailMessage
    {
        private string _toAddress;
        private string _ccAddress;
        private string _subject;
        private string _msgBody;
        public string CCAddress
        {
            get
            {
                return _ccAddress;
            }

            set
            {
                _ccAddress = value;
            }
        }
        public string MsgBody
        {
            get
            {
                return _msgBody;
            }

            set
            {
                _msgBody = value;
            }
        }

        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        public string ToAddress
        {
            get
            {
                return _toAddress;
            }

            set
            {
                _toAddress = value;
            }
        }

        public bool Send()
        {
            return true;   
        }
    }
}
