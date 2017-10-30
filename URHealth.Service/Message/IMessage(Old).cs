namespace URHealth.Service.Message
{
    public interface IEmailSMSMessage
    {
        string CCAddress { get; set; }
        string MobileNo { get; set; }
        string MsgBody { get; set; }
        string Subject { get; set; }
        string ToAddress { get; set; }
        bool Send();
    }
}