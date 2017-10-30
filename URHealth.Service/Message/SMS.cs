using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.Message
{
    public class SMS : ISMSMessage
    {

        private string _mobileNo;
        private string _subject;
        private string _msgBody;
       
        public string MobileNo
        {
            get
            {
                return _mobileNo;
            }

            set
            {
                _mobileNo = value;
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
        
        public bool Send()
        {
            return true;
        }
    }
}
