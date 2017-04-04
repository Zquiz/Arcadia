using System;
using System.Net.Mail;
using System.Web.UI;

public partial class Contact : Page
{
    //random value for the message system
    private Random _random;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    ///     Method for the eventhandler on the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSend_Click(object sender, EventArgs e)
    {
        //try catch to make sure it won't do a error when sending the mail. if pop3 is missin on the server
        try
        {
            if (MailValidator.EmailIsValid(txtEmail.Text)) //validate mail
            {
                _random = new Random();

                var randomNumber = _random.Next(0, 2);
                var mailMessage = new MailMessage();
                mailMessage.To.Add(txtEmail.Text);
                mailMessage.From = new MailAddress("noreply@Arcadia.ca");
                //send a mail to the person who wrote instanely with a random respone. 
                //can be changed to a real contact form
                if (randomNumber == 0)
                {
                    //put in a random
                    mailMessage.Subject = txtSubject.Text.Trim();
                    mailMessage.Body = txtMsg.Text.Trim();
                }
                else
                {
                    mailMessage.Subject = txtSubject.Text.Trim();
                    mailMessage.Body = txtMsg.Text.Trim();
                }
                var smtpClient = new SmtpClient("smtp.your-isp.com");
                smtpClient.Send(mailMessage);
                litError.Text = "E-mail sent!";
            }
            else
            {
                litError.Text = "Invalid e-mail adresse";
            }
        }
        catch (Exception)
        {
            litError.Text = "An error happen and the mail wasn't able to get send, please try again later";
        }
    }
}