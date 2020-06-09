using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using MimeKit;

namespace WebAPI.DTO
{
  public class Message
  {
    public List<MailboxAddress> To { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }

    public IFormFileCollection Attachments { get; set; }

    public Message(IEnumerable<string> to, string subject, string content, IFormFileCollection attachments)
    {
      try
      {
        To = new List<MailboxAddress>();
        To.AddRange(to.Select(x => new MailboxAddress(x)));
        Subject = subject;
        Content = content;
        Attachments = attachments;
      }
      catch
      { }
    }
  }
}
