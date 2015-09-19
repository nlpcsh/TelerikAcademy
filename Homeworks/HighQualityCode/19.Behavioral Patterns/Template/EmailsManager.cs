namespace TemplateMethod
{
    using System;

    public static class EmailsManager
    {
        public static void Main()
        {
            EmailSenderBase emailSender =
                new HotmailEmailSender("admin@hotmail.com", "admin@telerik.com", "Wazz'aaa, guys?");
            //// new GoogleEmailSender(...)
            var sendEmailResult = emailSender.SendEmail();
            Console.WriteLine("Result: {0}", sendEmailResult ? "Success" : "Fail");
        }
    }
}
