using System.Threading.Tasks;

namespace bookpage.webui.EMailServices
{
    public interface IEmailSender
    {//mail serverları kullanıcaz
         Task SendEmailAsync(string email,string subject,string htmlMessage);

    }
}