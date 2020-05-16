using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebAPI.Services
{
	public class SendEmailService
	{
		/// <summary>
		/// Sends the specified message to the specified recipient
		/// </summary>
		/// <param name="message">A MIME message</param>
		/// <param name="clientLogin">Login for authorization on mail sevice</param>
		/// <param name="clientPassword">Password to log in to mail service</param>
		public static void SendMessage(MimeMessage message, string clientLogin, string clientPassword)
		{
			try
			{
				if(message != null && message.From != null && message.To != null &&
					message.To.Count > 0 && message.Subject != null && message.Body != null &&
					clientLogin != "" && message.From.Count > 0 && clientPassword != "")
				{
					using var client = new SmtpClient();
					//now using the Gmail SMTP Protocol, from change this -
					//correct param "smtp.gmail.com" on custom
					client.Connect("smtp.gmail.com", 587, false);

					// Note: only needed if the SMTP server requires authentication
					client.Authenticate(clientLogin, clientPassword);

					client.Send(message);
					client.Disconnect(true);
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch(ArgumentNullException e)
			{
				Console.WriteLine("One argument is null or empty");
				Console.WriteLine($"Message: {e.Message}, Param: {e.ParamName}");
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
				return;
			}
		}

		/// <summary>
		/// Sends the specified message to the specified recipient
		/// </summary>
		/// <param name="FromName">Sender name (by default, clientLogin)</param>
		/// <param name="FromEMail">Sender's email address (by default, clientLogin)</param>
		/// <param name="ToName">Destination name</param>
		/// <param name="ToEMail">Recipient's email address</param>
		/// <param name="Subject">Message header</param>
		/// <param name="Body">Message body</param>
		/// <param name="clientLogin">Login for authorization on mail sevice</param>
		/// <param name="clientPassword">Password to log in to mail service</param>
		public static void SendMessage(string FromName, string FromEMail, 
			string ToName, string ToEMail, string Subject,
			string Body, string clientLogin, string clientPassword)
		{
			try
			{
				if(string.IsNullOrEmpty(FromName))
				{
					FromName = clientLogin;
				}
				if(string.IsNullOrEmpty(FromEMail))
				{
					FromEMail = clientLogin;
				}
				if(string.IsNullOrEmpty(ToName))
				{
					throw new ArgumentException("Argument is null or empty", nameof(ToName));
				}
				if(string.IsNullOrEmpty(ToEMail))
				{
					throw new ArgumentException("Argument is null or empty", nameof(ToEMail));
				}
				if(string.IsNullOrEmpty(Subject))
				{
					throw new ArgumentException("Argument is null or empty", nameof(Subject));
				}
				if(string.IsNullOrEmpty(Body))
				{
					throw new ArgumentException("Argument is null or empty", nameof(Body));
				}
				if(string.IsNullOrEmpty(clientLogin))
				{
					throw new ArgumentException("Argument is null or empty", nameof(clientLogin));
				}
				if(string.IsNullOrEmpty(clientPassword))
				{
					throw new ArgumentException("Argument is null or empty", nameof(clientPassword));
				}

				var message = new MimeMessage();

				message.From.Add(new MailboxAddress(FromName, FromEMail));
				message.To.Add(new MailboxAddress(ToName, ToEMail));
				message.Subject = Subject;

				message.Body = new TextPart("plain")
				{
					Text = Body
				};
				SendMessage(message, clientLogin, clientPassword);
			}
			catch(ArgumentException e)
			{
				Console.WriteLine($"Message: {e.Message}, Param: {e.ParamName}");
				return;
			}
			catch(Exception e)
			{
				Console.WriteLine($"Message: {e.Message}");
				return;
			}
		}
	}
}
