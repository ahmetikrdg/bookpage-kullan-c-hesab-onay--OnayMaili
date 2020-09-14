using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace bookpage.webui.EMailServices
{
    public class SmptpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _username;
        private string _password;
        public SmptpEmailSender(string host,int port,bool enableSSL,string userName,string password)//host adresi olacak. Port ne üzerinde ngönderiyoruz. bool enableSSL şifreleme true veya falsa. username mail adresi
        {
           _host=host;
           _port=port;
           _enableSSL=enableSSL;
           _username=userName;
           _password=password;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client=new SmtpClient(_host,_port)
            {
                Credentials=new NetworkCredential(_username,_password),
                EnableSsl=_enableSSL
            };
            return client.SendMailAsync(
              new MailMessage(_username,email,subject,htmlMessage){
                  IsBodyHtml=true
              }
            );

        }
    }
}