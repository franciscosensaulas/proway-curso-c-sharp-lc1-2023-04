using MailKit.Net.Smtp;
using MimeKit;

namespace WindowsFormsExemplos.Servicos
{
    internal class EmailServico
    {
        public void EnviarEmail(string destinario, string nomeDestinario, string corpo, string assunto)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add(new MailboxAddress("Sistema ProWay", "franciscosensaulasexemplos@gmail.com"));
            mensagem.To.Add(new MailboxAddress(nomeDestinario, destinario));

            mensagem.Subject = assunto;
            mensagem.Body = new TextPart("plain")
            {
                Text = corpo
            };
            var cliente = new SmtpClient();
            cliente.Connect("smtp.gmail.com", 587, false);
            cliente.Authenticate("franciscosensaulasexemplos@gmail.com", "accjroaraswdlwrz");

            cliente.Send(mensagem);
            cliente.Disconnect(true);
        }
    }
}
