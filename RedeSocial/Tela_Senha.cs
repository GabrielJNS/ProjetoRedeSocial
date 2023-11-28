
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MimeKit;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeSocial
{
    public partial class Tela_Senha : Form
    {
        public Tela_Senha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EnviarEmail_Click(object sender, EventArgs e)
        {
            string Email = EmailRec.Text;

            {
                Random random = new Random();
                int codigoGerado = random.Next(10000, 100000);
                int codigo = codigoGerado;

                EnviarEmail("CodigoRecFatec@hotmail.com", $"{Email}", "Código Recuperação", $"Seu código é: {codigo}");

                Tela_RecSenha nova = new Tela_RecSenha(codigoGerado);
                nova.Show();

            }

            static void EnviarEmail(string remetente, string destinatario, string assunto, string corpo)

            {
                var mensagem = new MimeMessage();
                mensagem.From.Add(new MailboxAddress("Matheus", remetente));
                mensagem.To.Add(new MailboxAddress("Frois", destinatario));
                mensagem.Subject = assunto;

                var corpoTexto = new TextPart("plain")
                {
                    Text = corpo
                };

                mensagem.Body = corpoTexto;

                using (var clienteSmtp = new SmtpClient())
                {
                    clienteSmtp.Connect("smtp-mail.outlook.com", 587, false);
                    clienteSmtp.Authenticate("CodigoRecFatec@hotmail.com", "156327890M");

                    try
                    {
                        clienteSmtp.Send(mensagem);
                        Console.WriteLine("E-mail enviado com sucesso.");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao enviar e-mail: {ex.Message}");
                    }

                    finally
                    {
                        clienteSmtp.Disconnect(true);
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tela_Senha_Load(object sender, EventArgs e)
        {

        }

    }
}
