using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string email;
            Console.WriteLine("Insira o email para receber a nova senha:");
            email = Console.ReadLine();
            
 // Gera uma senha com 6 caracteres entre numeros e letras
string chars = "abcdefghjkmnpqrstuvwxyz023456789";
string pass = "";
Random random = new Random();
for (int f = 0; f < 6; f++) {
pass = pass + chars.Substring(random.Next(0, chars.Length-1), 1);
Console.WriteLine("A senha gerada é {0}" ,pass);

//cria uma mensagem
System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
MailMessage mail = new MailMessage();

//define os endereços
mail.From = new MailAddress(email);
mail.To.Add(email);

//define o conteúdo
mail.Subject = "Este é um simples ,muito simples email";
mail.Body = "Este é o corpo do email";

//envia a mensagem
SmtpClient smtp = new SmtpClient("smtp.gmail.com");
smtp.Send(mail); 
      },
    }
  }
}