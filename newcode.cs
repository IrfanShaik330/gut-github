using System;
using System.Net;
using System.Net.Mail;
 

{
    
    {
        try
        {
            string senderEmail = "yourgmail@gmail.com";      // Replace with your Gmail
            string appPassword = "your_app_password";        // Use App Password (NOT regular password)
            string receiverEmail = "recipient@example.com";  // Replace with the recipient
 
            MailMessage message = new MailMessage();
            message.From = new MailAddress(senderEmail);
            message.To.Add(receiverEmail);
            message.Subject = "SMTP Test from .NET App";
            message.Body = "Hi! This is a test email sent via Gmail SMTP using C#.";
 
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            smtp.Credentials = new NetworkCredential(senderEmail, appPassword);
            smtp.EnableSsl = true
 
            smtp.Send(message);
            Console.WriteLine("✅ Email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error sending email: " + ex.Message)
        }
    }
}
 