using SRPDemo;
using SRPDemo.InterfaceSegregationPrinciple;
using SRPDemo.LiskovSubstitutionPrinciple;
using SRPDemo.OpenClosedPrinciple;

public class Program
{
    private static void Main(string[] args)
    {
        // Messages();
        // PhoneMessages();
        //PrintFiles();

        Rectangle rect = new Square(5);
        TestRectangleArea(rect);

        Console.ReadLine();
    }
    static void Messages()
    {
        var voiceMessage = new VoiceMessage();
        voiceMessage.Voice = new byte[] { 5 };
        voiceMessage.FromAddress = "SoftClub";
        voiceMessage.ToAddress = "DCity";
        Console.WriteLine("");
        voiceMessage.Send();

        Console.WriteLine("");
        Console.WriteLine(new string('=', 120));
        Console.WriteLine("");

        var mailMessage = new MailMessage();
        mailMessage.FromAddress = "SoftClub";
        mailMessage.ToAddress = "DCity";
        mailMessage.Text = "Здавствуйте";
        mailMessage.Subject = "Почему сегодня не пришли на заниятия";
        mailMessage.Send();

        Console.WriteLine("");
        Console.WriteLine(new string('=', 120));
        Console.WriteLine("");

        var smsMessage = new SmsMessage();
        smsMessage.FromAddress = "SoftClub";
        smsMessage.ToAddress = "DCity";
        smsMessage.Text = "Здавствуйте";
        smsMessage.Send();

    }
    static void PhoneMessages()
    {
        var photograph = new Photograph();
        var phone = new SRPDemo.InterfaceSegregationPrinciple.Phone();
        Console.WriteLine("");
        photograph.TakePhoto(phone);

        Console.WriteLine("");
        Console.WriteLine(new string('=', 120));
        Console.WriteLine("");

        var camera = new Camera();
        camera.TakePhoto();

        Console.WriteLine("");
        Console.WriteLine(new string('=', 120));
        Console.WriteLine("");


        phone.BrowseInternet();
        phone.Call();
        phone.MakeVideo();
        phone.TakePhoto();
       
    }
    static void PrintFiles()
    {
        var book = new SRPDemo.DependencyInversionPrinciple.Book(new SRPDemo.DependencyInversionPrinciple.Printer());
        book.Print();
    }
    public static void TestRectangleArea(Rectangle rect)
    {
        if (rect is Square)
        {
            rect.Height = 5;
            var res = rect.GetArea();

            if ( res != 25)
                throw new Exception("Неправильная площадь!");
        }
        if (rect is Rectangle)
        {
            rect.Height = 5;
            rect.Width = 10;

            var res = rect.GetArea();

            if (rect.GetArea() != 50)
                throw new Exception("Неправильная площадь!");
        }

    }
}