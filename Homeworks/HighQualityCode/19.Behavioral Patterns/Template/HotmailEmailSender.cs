namespace TemplateMethod
{
    using System;
    using System.Threading;

    public class HotmailEmailSender : EmailSenderBase
    {
        public HotmailEmailSender(string senderEmail, string receiverEmail, string message)
            : base(senderEmail, receiverEmail, message)
        {
        }

        protected override bool CheckEmailAddress()
        {
            return this.SenderEmail.EndsWith("hotmail.com");
        }

        protected override bool ValidateMessage()
        {
            return !this.Message.Contains("Viagra");
        }

        protected override bool SendMail()
        {
            Console.WriteLine("Connecting to hotmail.com on port 25 (SMTP connection)...");
            Thread.Sleep(2000);
            Console.WriteLine("Sending email...");
            Thread.Sleep(2000);
            Console.WriteLine("Done.");
            return true;
        }
    }
}
