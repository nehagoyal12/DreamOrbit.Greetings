using System.Net.Mail;
using System.Net;


string fromMail = "testdreamorbit5@gmail.com";
string fromPassword = "wxrgsxcyecpjzixx";

MailMessage message = new MailMessage();
message.From = new MailAddress(fromMail);
message.Subject = "Test Subject";
message.To.Add(new MailAddress("nehagoyalrke@gmail.com"));
message.Body = "<html><body> Have a wonderful birthday, wish your every day to be filled with lots of love, laughter, happiness and the warmth of sunshine. \r\n\r\n \r\n\r\nDreamOrbit Team wishes you a Very Happy Birthday!!!!  </body></html>";
message.IsBodyHtml = true;

var smtpClient = new SmtpClient("smtp.gmail.com")
{
    Port = 587,
    Credentials = new NetworkCredential(fromMail, fromPassword),
    EnableSsl = true,
};

smtpClient.Send(message);