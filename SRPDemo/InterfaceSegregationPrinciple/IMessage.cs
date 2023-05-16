using static System.Net.Mime.MediaTypeNames;

namespace SRPDemo.InterfaceSegregationPrinciple
{
    public interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
    public interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
    public interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
    public interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }
    public class VoiceMessage : IVoiceMessage
    {
        public byte[] Voice { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public void Send()
        {
            Console.WriteLine($"Отправляем голосовое собшения : адрес {ToAddress} , от {FromAddress}, у вас оценка {Voice.FirstOrDefault()} ");
        }
    }
    public class MailMessage : IEmailMessage
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public void Send()
        {
            Console.WriteLine($"Отправляем Email-собшения :  {Text},  адрес {ToAddress} , от {FromAddress},  {Subject}");
        }
    }
    public class SmsMessage : ITextMessage
    {
        public string Text { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public void Send()
        {
            Console.WriteLine($"Отправляем Sms-собшения : {Text},  адрес {ToAddress}, от {FromAddress}");
        }
    }
}
